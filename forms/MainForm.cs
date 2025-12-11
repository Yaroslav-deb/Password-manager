using PasswordManager.additionalClasses;
using PasswordManager.database;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PasswordManager.personalizedTools;
using System.Collections.Generic;
using System.Linq;

namespace PasswordManager.Forms
{
    public partial class MainForm : Form
    {
        private int currentUserId;
        private bool isCategoriesExpanded = true;
        private string photosPath;
        private List<PasswordEntry> allEntries = new List<PasswordEntry>();
        private string currentCategoryFilter = "Всі";
        private int currentSortMode = 1;
        private PasswordListItem _currentSelectedItem = null;

        private Image imgSearch, imgPlus;
        private Image imgArrowRight, imgArrowDown;
        private Image imgProfileIco, imgAllItemsIco, imgFavIco;
        private Image imgAudit, imgGenerator, imgTrash, imgSettings;

        public MainForm(int userId)
        {
            this.currentUserId = userId;
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            photosPath = Path.Combine(projectDir, "photos");

            LoadStaticIcons();
            LoadUserData();
            InitializeCustomEvents();
            InitializeWindowControls();
            LoadCategories();
            InitializeTopBar();
            InitializeListHeader();
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 0x1;
            const int HTCAPTION = 0x2;
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        private void InitializeWindowControls()
        {
            pbClose.Click += (s, e) => Application.Exit();
            pbCollapse.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            pbCollapseIntoWindow.Click += (s, e) => {
                this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
            };
        }

        private Image LoadImage(string fileName)
        {
            string path = Path.Combine(photosPath, fileName);
            return File.Exists(path) ? Image.FromFile(path) : null;
        }

        private void LoadStaticIcons()
        {
            try
            {
                imgArrowRight = LoadImage("right_arrow.png"); imgArrowDown = LoadImage("down_arrow.png"); pbCatArrow.Image = imgArrowDown;
                imgProfileIco = LoadImage("profile.png"); imgAllItemsIco = LoadImage("all_items.png"); imgFavIco = LoadImage("star.png");
                imgAudit = LoadImage("watchover.png"); imgGenerator = LoadImage("generator.png"); imgTrash = LoadImage("bin.png"); imgSettings = LoadImage("settings.png");
                imgSearch = LoadImage("search_icon.png"); imgPlus = LoadImage("plus_icon.png");

                AssignIconToButton(btnProfile, imgProfileIco); AssignIconToButton(btnAllItems, imgAllItemsIco); AssignIconToButton(btnFavorites, imgFavIco);
                AssignIconToButton(btnAudit, imgAudit); AssignIconToButton(btnGenerator, imgGenerator); AssignIconToButton(btnTrash, imgTrash); AssignIconToButton(btnSettings, imgSettings);

                if (imgSearch != null) searchBar.Icon = imgSearch;
                if (imgPlus != null) { btnAddItem.Image = imgPlus; btnAddItem.Padding = new Padding(15, 0, 0, 0); btnAddItem.TextAlign = ContentAlignment.MiddleLeft; }
            }
            catch { }
        }

        private void AssignIconToButton(RoundedButton btn, Image img) { if (img == null) return; btn.Image = img; btn.IconSize = 30; btn.Padding = new Padding(12, 0, 0, 0); }

        private void InitializeTopBar()
        {
            var suggestions = DatabaseHelper.GetAutoSuggestionList();
            searchBar.AutoCompleteCustomSource = suggestions;
            searchBar.TextChangedEvent += (s, e) => RefreshList();
            btnAddItem.Click += (s, e) =>
            {
                this.Hide();

                AddItemForm addForm = new AddItemForm(currentUserId);

                DialogResult result = addForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadEntriesFromDb();
                }

                this.Show();
            };
            btnAddItem.BorderRadius = 20;
            pnlTopBar.Paint += (s, e) => { using (Pen p = new Pen(Color.FromArgb(220, 220, 220), 1)) e.Graphics.DrawLine(p, 0, pnlTopBar.Height - 1, pnlTopBar.Width, pnlTopBar.Height - 1); };

            pnlListArea.Paint += (s, e) => {
                using (Pen p = new Pen(Color.Silver, 1))
                    e.Graphics.DrawLine(p, pnlListArea.Width - 1, 0, pnlListArea.Width - 1, pnlListArea.Height);
            };

            LoadEntriesFromDb();
        }

        private void InitializeListHeader()
        {
            Image arrowImg = LoadImage("down_arrow.png");
            if (arrowImg != null)
            {
                dropdownCategory.ArrowIcon = arrowImg;
                dropdownSort.ArrowIcon = arrowImg;
            }

            Image defaultCatIcon = LoadImage("categories.png") ?? LoadImage("others.png");
            dropdownCategory.MainIcon = defaultCatIcon;
            dropdownCategory.SelectedText = "      Всі категорії";
            dropdownCategory.AddItem("Всі категорії", defaultCatIcon);

            string[] cats = { "Робота", "Розваги", "Соціальні мережі", "Фінанси", "Навчання", "Покупки", "Документи", "Пошта", "Інше" };
            foreach (var cat in cats)
            {
                string iconName = GetIconNameForCategory(cat);
                Image ico = LoadImage(iconName);
                dropdownCategory.AddItem(cat, ico);
            }

            dropdownCategory.ItemSelected += (s, e) => {
                currentCategoryFilter = (e.Index == 0) ? "Всі" : e.SelectedItem;
                RefreshList();
            };

            dropdownSort.MainIcon = null;
            dropdownSort.SelectedText = "Нові (за датою)";
            dropdownSort.AddItem("По імені (А-Я)");
            dropdownSort.AddItem("Нові (за датою)");
            dropdownSort.AddItem("Старі (за датою)");

            dropdownSort.ItemSelected += (s, e) => {
                currentSortMode = e.Index;
                RefreshList();
            };
        }

        private void LoadEntriesFromDb()
        {
            allEntries = DatabaseHelper.GetEntries(currentUserId);
            RefreshList();
        }

        private void RefreshList()
        {
            flpPasswordList.SuspendLayout();
            flpPasswordList.Controls.Clear();

            _currentSelectedItem = null;

            IEnumerable<PasswordEntry> result = allEntries;

            if (currentCategoryFilter != "Всі") result = result.Where(x => x.Category == currentCategoryFilter);

            string searchQuery = searchBar.SearchText?.ToLower();
            if (!string.IsNullOrEmpty(searchQuery))
                result = result.Where(x => x.Title.ToLower().Contains(searchQuery) || (x.WebsiteUrl != null && x.WebsiteUrl.ToLower().Contains(searchQuery)));

            switch (currentSortMode)
            {
                case 0: result = result.OrderBy(x => x.Title); break;
                case 1: result = result.OrderByDescending(x => x.UpdatedAt); break;
                case 2: result = result.OrderBy(x => x.UpdatedAt); break;
            }

            foreach (var entry in result)
            {
                var item = new PasswordListItem(entry);
                item.TabStop = false;

                item.ItemClick += (s, e) =>
                {
                    if (_currentSelectedItem != null && _currentSelectedItem != item) _currentSelectedItem.IsSelected = false;
                    item.IsSelected = true;
                    _currentSelectedItem = item;
                    ShowDetails(entry);
                };

                item.EditClick += (s, e) =>
                {
                    this.Hide();

                    EditItemForm editForm = new EditItemForm(currentUserId, entry);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadEntriesFromDb();
                    }

                    this.Show();
                };

                item.DeleteClick += (s, e) =>
                {
                    DialogResult res = MessageBox.Show(
                        $"Видалити запис \"{entry.Title}\" у кошик?",
                        "Підтвердження",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        bool success = DatabaseHelper.MoveToTrash(entry.Id);
                        if (success)
                        {
                            LoadEntriesFromDb();
                            pnlDetailsArea.Controls.Clear();
                        }
                    }
                };

                flpPasswordList.Controls.Add(item);
            }
        }

        private void ShowDetails(PasswordEntry entry)
        {
            pnlDetailsArea.Controls.Clear();

            var detailsView = new EntryDetailsView(entry, currentUserId);
            detailsView.Dock = DockStyle.Fill;

            detailsView.EntryDeleted += (s, e) =>
            {
                pnlDetailsArea.Controls.Clear();
                LoadEntriesFromDb();
            };

            pnlDetailsArea.Controls.Add(detailsView);
        }


        private void LoadUserData() { lblUsername.Text = DatabaseHelper.GetUsernameById(currentUserId); }

        private void InitializeCustomEvents()
        {
            pnlLeft.Paint += pnlLeft_Paint;
            pbCatArrow.Click += (s, e) => ToggleCategories();

            flpPasswordList.Resize += (s, e) => {
                foreach (Control c in flpPasswordList.Controls) c.Width = flpPasswordList.Width - 25;
            };

            AttachHoverEffect(btnProfile); AttachHoverEffect(btnAllItems); AttachHoverEffect(btnFavorites);
            AttachHoverEffect(btnSettings); AttachHoverEffect(btnTrash); AttachHoverEffect(btnGenerator); AttachHoverEffect(btnAudit);
            pnlTopBar.MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, 0xA1, 0x2, 0); } };
        }

        private void AttachHoverEffect(RoundedButton btn)
        {
            btn.ForeColor = Color.Black; Color normalColor = Color.Transparent; Color hoverColor = Color.FromArgb(33, 145, 245);
            Color textNormal = Color.Black; Color textHover = Color.White;
            btn.MouseEnter += (s, e) => { btn.BackColor = hoverColor; btn.ForeColor = textHover; btn.Cursor = Cursors.Hand; };
            btn.MouseLeave += (s, e) => { btn.BackColor = normalColor; btn.ForeColor = textNormal; };
        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e) { using (Pen p = new Pen(Color.FromArgb(200, 200, 200), 1)) e.Graphics.DrawLine(p, pnlLeft.Width - 1, 0, pnlLeft.Width - 1, pnlLeft.Height); }

        private void ToggleCategories() { isCategoriesExpanded = !isCategoriesExpanded; pbCatArrow.Image = isCategoriesExpanded ? imgArrowDown : imgArrowRight; flpCategories.Visible = isCategoriesExpanded; }

        private void LoadCategories()
        {
            flpCategories.Controls.Clear();
            string[] cats = { "Робота", "Розваги", "Соціальні мережі", "Фінанси", "Навчання", "Покупки", "Документи", "Пошта", "Інше" };
            foreach (var categoryName in cats)
            {
                RoundedButton btn = new RoundedButton();
                btn.Text = "   " + categoryName;
                btn.Size = new Size(236, 40);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Font = new Font("Segoe UI Semibold", 9F);
                btn.BackColor = Color.Transparent; btn.BackgroundColor = Color.Transparent;
                btn.BorderColor = Color.Transparent; btn.BorderSize = 0; btn.BorderRadius = 15; btn.IconSize = 30;
                string iconFile = GetIconNameForCategory(categoryName);
                Image catImage = LoadImage(iconFile);
                if (catImage != null) { btn.Image = catImage; btn.Padding = new Padding(15, 0, 0, 0); }
                AttachHoverEffect(btn);
                btn.Click += (s, e) => { currentCategoryFilter = categoryName; dropdownCategory.SelectedText = categoryName; RefreshList(); };
                flpCategories.Controls.Add(btn);
            }
        }

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
    }
}