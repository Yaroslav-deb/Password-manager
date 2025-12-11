using PasswordManager.additionalClasses; // Для EncryptionHelper
using PasswordManager.database;
using PasswordManager.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace PasswordManager.personalizedTools
{
    public partial class EntryDetailsView : UserControl
    {
        private PasswordEntry _entry;
        private bool isPasswordVisible = false;
        private string photosPath;
        private int historyState = 0;
        private int currentUserId;

        public event EventHandler EntryDeleted;

        private int boxY = 190;
        private int boxHeight = 160;
        private int boxMarginX = 30;

        public EntryDetailsView(PasswordEntry entry, int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this._entry = entry;

            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            photosPath = Path.Combine(projectDir, "photos");

            LoadIcons();
            PopulateData();
            SetupEvents();

            pnlSecurity.Paint += PnlSecurity_Paint;
            AdjustLayout();
            this.Resize += (s, e) => AdjustLayout();
        }

        private void PopulateData()
        {
            lblHeaderUser.Text = "Мій сейф";
            lblSiteName.Text = _entry.Title;

            if (!string.IsNullOrEmpty(_entry.IconBase64))
            {
                pbMainIcon.Image = DatabaseHelper.Base64ToImage(_entry.IconBase64);
                MakeCircular(pbMainIcon);
            }
            else
            {
                pbMainIcon.Image = GeneratePlaceholderImage(_entry.Title);
            }

            lblUserValue.Text = !string.IsNullOrEmpty(_entry.Username) ? _entry.Username : "Не вказано";

            string realPassword = "";
            try
            {
                realPassword = EncryptionHelper.Decrypt(_entry.EncryptedPassword, _entry.EncryptionIV);
            }
            catch
            {
                realPassword = "Error Decrypting";
            }

            lblPassValue.Tag = realPassword;
            UpdatePasswordText();

            if (!string.IsNullOrEmpty(_entry.WebsiteUrl))
            {
                lnkWebsite.Text = _entry.WebsiteUrl; lnkWebsite.Enabled = true;
            }
            else
            {
                lnkWebsite.Text = "Не вказано"; lnkWebsite.Enabled = false; lnkWebsite.LinkColor = Color.Gray;
            }

            var security = DatabaseHelper.EvaluatePasswordStrength(realPassword);
            lblSecurityLevel.Text = security.Level;
            lblSecurityLevel.ForeColor = security.Color;
            lblSecurityMsg.Text = security.Message;
            pbSecurityIcon.Image = GenerateSolidCircle(security.Color);

            SetupHistorySection();
        }

        private Image GeneratePlaceholderImage(string title)
        {
            Bitmap bmp = new Bitmap(60, 60);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                int hash = title.GetHashCode();
                Random rnd = new Random(hash);
                Color randomColor = Color.FromArgb(rnd.Next(80, 200), rnd.Next(80, 200), rnd.Next(80, 200));

                using (Brush brush = new SolidBrush(randomColor))
                    g.FillEllipse(brush, 0, 0, 60, 60);
                string initials = title.Length >= 2 ? title.Substring(0, 2).ToUpper() : (title.Length > 0 ? title.Substring(0, 1).ToUpper() : "?");

                using (Font font = new Font("Segoe UI", 20, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(initials, font);
                    g.DrawString(initials, font, Brushes.White,
                        (60 - textSize.Width) / 2,
                        (60 - textSize.Height) / 2 + 2);
                }
            }
            return bmp;
        }

        private void AdjustLayout()
        {
            int contentWidth = this.Width - (boxMarginX * 2);
            int rightEdge = boxMarginX + contentWidth;

            btnEdit.Location = new Point(rightEdge - btnEdit.Width, btnEdit.Location.Y);
            btnDelete.Location = new Point(btnEdit.Location.X - btnDelete.Width - 10, btnEdit.Location.Y);
            pbFavorite.Location = new Point(lblHeaderUser.Right + 10, lblHeaderUser.Location.Y - 2);

            int contentStartX = boxMarginX + 35;
            int iconsRightX = rightEdge - 45;

            lblUserLabel.Location = new Point(contentStartX, boxY + 20);
            lblUserValue.Location = new Point(contentStartX, boxY + 45);
            pbCopyUser.Location = new Point(iconsRightX, boxY + 45);

            int secondRowY = boxY + (boxHeight / 2) + 20;
            lblPassLabel.Location = new Point(contentStartX, secondRowY);
            lblPassValue.Location = new Point(contentStartX, secondRowY + 25);
            pbCopyPass.Location = new Point(iconsRightX, secondRowY + 20);
            pbEyePass.Location = new Point(iconsRightX - 35, secondRowY + 20);

            int webY = boxY + boxHeight + 40;
            lblWebLabel.Location = new Point(boxMarginX, webY);
            lnkWebsite.Location = new Point(boxMarginX, webY + 25);

            int securityY = webY + 100;
            pnlSecurity.Location = new Point(boxMarginX, securityY);
            pnlSecurity.Width = contentWidth;

            int historyY = securityY + 60 + 40;
            pnlHistory.Location = new Point(boxMarginX, historyY);
            pnlHistory.Width = contentWidth;
        }

        private void LoadIcons()
        {
            pbCopyUser.Image = LoadImage("copy.png");
            pbCopyPass.Image = LoadImage("copy.png");
            Image editImg = LoadImage("edit.png");
            if (editImg != null) { btnEdit.Image = editImg; btnEdit.Padding = new Padding(15, 0, 0, 0); }
            Image delImg = LoadImage("bin.png");
            if (delImg != null) { btnDelete.Image = delImg; btnDelete.Padding = new Padding(15, 0, 0, 0); }

            UpdateEyeIcon();
            UpdateFavoriteIcon();
        }

        private void UpdateFavoriteIcon() { pbFavorite.Image = _entry.Favorite ? LoadImage("star_filled.png") : LoadImage("star_empty.png"); }
        private void UpdateEyeIcon() { pbEyePass.Image = isPasswordVisible ? LoadImage("eye_show.png") : LoadImage("eye_hide.png"); }

        private void SetupEvents()
        {
            pbCopyUser.Click += (s, e) => { if (lblUserValue.Text != "Не вказано") Clipboard.SetText(lblUserValue.Text); };
            pbCopyPass.Click += (s, e) => { Clipboard.SetText(lblPassValue.Tag.ToString()); };
            pbEyePass.Click += (s, e) => { isPasswordVisible = !isPasswordVisible; UpdateEyeIcon(); UpdatePasswordText(); };
            lnkWebsite.LinkClicked += (s, e) => { try { Process.Start(new ProcessStartInfo(lnkWebsite.Text) { UseShellExecute = true }); } catch { } };
            pbHistoryArrow.Click += (s, e) => ToggleHistory();
            lblHistoryTitle.Click += (s, e) => ToggleHistory();

            pbFavorite.Click += (s, e) => {
                _entry.Favorite = !_entry.Favorite;
                UpdateFavoriteIcon();
                DatabaseHelper.UpdateEntryFavorite(_entry.Id, _entry.Favorite);
            };

            btnEdit.Click += (s, e) =>
            {
                Form mainForm = this.FindForm();
                mainForm.Hide();

                EditItemForm editForm = new EditItemForm(currentUserId, _entry);

                DialogResult result = editForm.ShowDialog();

                mainForm.Show();

                if (result == DialogResult.OK)
                {
                    EntryDeleted?.Invoke(this, EventArgs.Empty);
                }
            };

            btnDelete.Click += (s, e) => {
                if (MessageBox.Show($"Видалити \"{_entry.Title}\"?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (DatabaseHelper.MoveToTrash(_entry.Id)) EntryDeleted?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        private void SetupHistorySection()
        {
            historyState = 3; pbHistoryArrow.Image = null; lblHistoryTitle.Text = "Створено"; lblHistoryDate.Text = _entry.UpdatedAt.ToShortDateString();
        }
        private void ToggleHistory() { /* Заглушка */ }

        private void UpdatePasswordText() { if (isPasswordVisible) lblPassValue.Text = lblPassValue.Tag.ToString(); else lblPassValue.Text = "••••••••••"; }
        private Image LoadImage(string name) { string path = Path.Combine(photosPath, name); return File.Exists(path) ? Image.FromFile(path) : null; }
        private void MakeCircular(PictureBox pb) { GraphicsPath path = new GraphicsPath(); path.AddEllipse(0, 0, pb.Width, pb.Height); pb.Region = new Region(path); }

        private Image GenerateSolidCircle(Color color)
        {
            Bitmap bmp = new Bitmap(30, 30); using (Graphics g = Graphics.FromImage(bmp)) { g.SmoothingMode = SmoothingMode.AntiAlias; using (Brush brush = new SolidBrush(color)) g.FillEllipse(brush, 1, 1, 28, 28); }
            return bmp;
        }

        private void PnlSecurity_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; Rectangle r = new Rectangle(0, 0, pnlSecurity.Width - 1, pnlSecurity.Height - 1);
            using (GraphicsPath path = GetRoundedPath(r, 15)) using (Brush brush = new SolidBrush(Color.FromArgb(245, 248, 255))) e.Graphics.FillPath(brush, path);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); Graphics g = e.Graphics; g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(boxMarginX, boxY, this.Width - (boxMarginX * 2), boxHeight);
            using (Pen pen = new Pen(Color.FromArgb(220, 220, 220), 1.5f)) using (GraphicsPath path = GetRoundedPath(rect, 15)) g.DrawPath(pen, path);
            using (Pen pen = new Pen(Color.FromArgb(240, 240, 240), 1)) { int mid = boxY + (boxHeight / 2); g.DrawLine(pen, boxMarginX + 1, mid, this.Width - boxMarginX - 1, mid); }
        }
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath(); float d = radius * 2F;
            path.StartFigure(); path.AddArc(rect.X, rect.Y, d, d, 180, 90); path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90); path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90); path.CloseFigure(); return path;
        }
    }
}