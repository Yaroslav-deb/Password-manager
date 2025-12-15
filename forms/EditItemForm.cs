using PasswordManager.additionalClasses;
using PasswordManager.database;
using PasswordManager.personalizedTools;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class EditItemForm : Form
    {
        private int currentUserId;
        private PasswordEntry _originalEntry;
        private string photosPath;
        private string selectedCategory = "";

        private bool isPasswordGenerated = false;
        private bool isPasswordVisible = false;
        private bool isFavorite = false;
        private string currentIconBase64 = null;

        public EditItemForm(int userId, PasswordEntry entry)
        {
            this.currentUserId = userId;
            this._originalEntry = entry;
            InitializeComponent();
            this.DoubleBuffered = true;

            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            photosPath = Path.Combine(projectDir, "photos");

            InitializeWindowLogic();
            LoadCategories();
            LoadImages();
            PopulateFields();

            pbItemIcon.Paint += (s, e) => {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, pbItemIcon.Width - 1, pbItemIcon.Height - 1);
                pbItemIcon.Region = new Region(path);
            };

            pnlFormContent.Anchor = AnchorStyles.None;

            this.Load += (s, e) => CenterContentPanel();

            this.SizeChanged += (s, e) => CenterContentPanel();
        }

        private void CenterContentPanel()
        {
            if (pnlRight == null || pnlFormContent == null) return;

            int x = (pnlRight.Width - pnlFormContent.Width) / 2;
            int y = (pnlRight.Height - pnlFormContent.Height) / 2;

            if (y < 60) y = 60;

            pnlFormContent.Location = new Point(x, y);
        }

        private void PopulateFields()
        {
            txtTitle.Text = _originalEntry.Title;
            txtUsername.Text = _originalEntry.Username;
            txtUrl.Text = _originalEntry.WebsiteUrl;

            string decryptedPass = EncryptionHelper.Decrypt(_originalEntry.EncryptedPassword, _originalEntry.EncryptionIV);
            txtPassword.Text = decryptedPass;
            txtConfirmPassword.Text = decryptedPass;

            string decryptedNotes = "";
            if (_originalEntry.EncryptedNotes != null)
                decryptedNotes = EncryptionHelper.Decrypt(_originalEntry.EncryptedNotes, _originalEntry.EncryptionIV);
            txtNotes.Text = decryptedNotes;

            selectedCategory = _originalEntry.Category;
            dropdownCategory.SelectedText = selectedCategory;

            isFavorite = _originalEntry.Favorite;
            UpdateFavoriteIcon();

            if (!string.IsNullOrEmpty(_originalEntry.IconBase64))
            {
                currentIconBase64 = _originalEntry.IconBase64;
                pbItemIcon.Image = DatabaseHelper.Base64ToImage(currentIconBase64);
            }
            else
            {
                pbItemIcon.Image = LoadImage("default_entry.png") ?? LoadImage("others.png");
            }
        }

        private void LoadImages()
        {
            pbCodewaveLogo.Image = LoadImage("CodeWaveLogo.png");
            pbCloudBackground.Image = LoadImage("clouds.png");
            pbLeftMainImage.Image = LoadImage("secure_illustration.png");
            UpdateEyeIcon();

            Image questionImg = LoadImage("question.png");
            if (questionImg != null)
            {
                pbHelpGenerate.Image = questionImg;
                pbHelpCopy.Image = questionImg;
                pbHelpNotes.Image = questionImg;
            }
        }

        private void InitializeWindowLogic()
        {
            pbClose.Click += (s, e) => Application.Exit();
            pbCollapse.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            pbCollapseIntoWindow.Click += (s, e) => {
                this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
            };

            pnlTopBar.MouseDown += (s, e) => {
                if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, 0xA1, 0x2, 0); }
            };

            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            btnSave.Click += BtnSave_Click;

            btnGenerate.Click += (s, e) => {
                string newPass = GenerateRandomPassword();
                txtPassword.Text = newPass;
                txtConfirmPassword.Text = "";
                isPasswordGenerated = true;
                UpdateCopyIconState();
            };

            btnCopyPass.Click += (s, e) => {
                if (isPasswordGenerated) txtConfirmPassword.Text = txtPassword.Text;
            };

            txtPassword.TextChanged += (s, e) => {
                if (txtPassword.ContainsFocus) { isPasswordGenerated = false; UpdateCopyIconState(); }
            };

            pbEyePass.Click += (s, e) => {
                isPasswordVisible = !isPasswordVisible;
                txtPassword.isPassword = !isPasswordVisible;
                UpdateEyeIcon();
            };

            pbFavorite.Click += (s, e) => { isFavorite = !isFavorite; UpdateFavoriteIcon(); };

            btnUploadIcon.Click += (s, e) => {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Image original = Image.FromFile(ofd.FileName);
                            Image resized = ResizeImage(original, 128, 128);
                            pbItemIcon.Image = resized;
                            currentIconBase64 = DatabaseHelper.ImageToBase64(resized, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
                    }
                }
            };

            pbHelpGenerate.Click += (s, e) => UpdateLeftPanel("ГЕНЕРАЦІЯ", "Створення надійного пароля.", "generator.png");
            pbHelpCopy.Click += (s, e) => UpdateLeftPanel("ДУБЛЮВАННЯ", "Копіювання пароля в поле підтвердження.", "copy.png");
            pbHelpNotes.Click += (s, e) => UpdateLeftPanel("НОТАТКИ", "Секретна інформація.", "notes.png");

            UpdateCopyIconState();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text?.Trim();
            string username = txtUsername.Text?.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;
            string url = txtUrl.Text?.Trim();
            string notes = txtNotes.Text?.Trim();

            if (string.IsNullOrEmpty(selectedCategory) || selectedCategory == "Оберіть категорію")
            {
                MessageBox.Show("Оберіть категорію!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (string.IsNullOrEmpty(title) && string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Вкажіть назву або URL.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(url)) { title = ExtractNameFromUrl(url); txtTitle.Text = title; }
            if (!string.IsNullOrEmpty(title) && string.IsNullOrEmpty(url)) { url = GenerateUrlFromName(title); txtUrl.Text = url; }

            if (string.IsNullOrEmpty(username)) { MessageBox.Show("Введіть логін.", "Увага"); return; }
            if (selectedCategory == "Пошта" && !IsValidEmail(username)) { MessageBox.Show("Невірний Email!", "Помилка"); return; }
            if (string.IsNullOrEmpty(password)) { MessageBox.Show("Введіть пароль.", "Увага"); return; }
            if (password != confirm) { MessageBox.Show("Паролі не співпадають!", "Помилка"); return; }

            bool success = DatabaseHelper.UpdateEntry(
                _originalEntry.Id,
                currentUserId,
                selectedCategory,
                title,
                username,
                password,
                url,
                notes,
                currentIconBase64,
                isFavorite
            );

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void UpdateLeftPanel(string title, string desc, string imgName)
        {
            lblInfoTitle.Text = title;
            lblInfoDesc.Text = desc;
            Image newImg = LoadImage(imgName);
            if (newImg != null) pbLeftMainImage.Image = newImg;
        }

        private void UpdateCopyIconState()
        {
            if (isPasswordGenerated)
            {
                btnCopyPass.BackColor = Color.FromArgb(123, 84, 195); btnCopyPass.Enabled = true; btnCopyPass.Cursor = Cursors.Hand;
            }
            else
            {
                btnCopyPass.BackColor = Color.FromArgb(200, 200, 200); btnCopyPass.Enabled = false; btnCopyPass.Cursor = Cursors.Default;
            }
        }

        private void UpdateFavoriteIcon()
        {
            pbFavorite.Image = isFavorite ? LoadImage("star_filled.png") : LoadImage("star_empty.png");
        }

        private void UpdateEyeIcon() { pbEyePass.Image = isPasswordVisible ? LoadImage("eye_show.png") : LoadImage("eye_hide.png"); }

        private void LoadCategories()
        {
            string[] cats = { "Робота", "Розваги", "Соціальні мережі", "Фінанси", "Навчання", "Покупки", "Документи", "Пошта", "Інше" };
            Image arrowImg = LoadImage("down_arrow.png");
            if (arrowImg != null) dropdownCategory.ArrowIcon = arrowImg;
            foreach (var cat in cats) dropdownCategory.AddItem(cat, LoadImage(GetIconNameForCategory(cat)));
            dropdownCategory.ItemSelected += (s, e) => selectedCategory = e.SelectedItem;
        }

        private string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            var random = new Random(); char[] stringChars = new char[16];
            for (int i = 0; i < stringChars.Length; i++) stringChars[i] = chars[random.Next(chars.Length)];
            return new string(stringChars);
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        private bool IsValidEmail(string email) { try { return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); } catch { return false; } }

        private string ExtractNameFromUrl(string url)
        {
            try { if (!url.StartsWith("http")) url = "https://" + url; Uri uri = new Uri(url); string host = uri.Host; if (host.StartsWith("www.")) host = host.Substring(4); int dotIndex = host.IndexOf('.'); if (dotIndex > 0) return char.ToUpper(host[0]) + host.Substring(1, dotIndex - 1); return host; } catch { return url; }
        }

        private string GenerateUrlFromName(string name) { string cleanName = name.Replace(" ", "").ToLower(); return $"https://{cleanName}.com"; }

        private Image LoadImage(string fileName) { string path = Path.Combine(photosPath, fileName); return File.Exists(path) ? Image.FromFile(path) : null; }

        private string GetIconNameForCategory(string category)
        {
            switch (category)
            {
                case "Робота": return "work.png";
                case "Розваги": return "entertaint.png";
                case "Соціальні мережі": return "social_media.png";
                case "Фінанси": return "finance.png";
                case "Навчання": return "study.png";
                case "Покупки": return "purchases.png";
                case "Документи": return "documents.png";
                case "Пошта": return "mail.png";
                default: return "others.png";
            }
        }

        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] public static extern bool ReleaseCapture();
    }
}