using PasswordManager.database;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace PasswordManager.personalizedTools
{
    public partial class PasswordListItem : UserControl
    {
        private PasswordEntry _entry;
        private bool _isSelected;
        private bool _isHovered;
        private string photosPath;

        // Події
        public event EventHandler ItemClick;
        public event EventHandler EditClick;
        public event EventHandler DeleteClick;

        // Цвета
        private Color colorNormalBg = Color.White;
        private Color colorSelectedBg = Color.FromArgb(33, 145, 245);
        private Color colorTextTitleNormal = Color.Black;
        private Color colorTextSubNormal = Color.Gray;
        private Color colorTextSelected = Color.White;

        public PasswordEntry EntryData => _entry;

        public PasswordListItem(PasswordEntry entry)
        {
            InitializeComponent();
            _entry = entry;

            // Шлях до іконок
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            photosPath = Path.Combine(projectDir, "photos");

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.Size = new Size(320, 70);
            this.Margin = new Padding(0);
            this.BackColor = colorNormalBg;
            this.Cursor = Cursors.Hand;

            PopulateData();
            LoadActionIcons();

            lblTitle.BackColor = Color.Transparent;
            lblSubtitle.BackColor = Color.Transparent;
            pbIcon.BackColor = Color.Transparent;

            AttachMouseEvents(this);
            AttachMouseEvents(pbIcon);
            AttachMouseEvents(lblTitle);
            AttachMouseEvents(lblSubtitle);

            this.Resize += (s, e) => AdjustButtonsPosition();
            AdjustButtonsPosition();
        }

        private void LoadActionIcons()
        {

            string editPath = Path.Combine(photosPath, "edit_white.png");
            if (!File.Exists(editPath)) editPath = Path.Combine(photosPath, "edit.png");

            string delPath = Path.Combine(photosPath, "bin_white.png");
            if (!File.Exists(delPath)) delPath = Path.Combine(photosPath, "bin.png");

            if (File.Exists(editPath)) pbEdit.Image = Image.FromFile(editPath);
            if (File.Exists(delPath)) pbDelete.Image = Image.FromFile(delPath);

            pbEdit.Click += (s, e) => EditClick?.Invoke(this, EventArgs.Empty);
            pbDelete.Click += (s, e) => DeleteClick?.Invoke(this, EventArgs.Empty);
        }

        private void AdjustButtonsPosition()
        {
            int rightMargin = 20;
            pbDelete.Location = new Point(this.Width - pbDelete.Width - rightMargin, (this.Height - pbDelete.Height) / 2);
            pbEdit.Location = new Point(pbDelete.Location.X - pbEdit.Width - 10, (this.Height - pbEdit.Height) / 2);
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                if (!_isSelected) _isHovered = false;
                UpdateVisualState();
            }
        }

        private void UpdateVisualState()
        {
            bool active = _isSelected || _isHovered;

            if (active)
            {
                lblTitle.ForeColor = colorTextSelected;
                lblSubtitle.ForeColor = colorTextSelected;
                // Показуємо кнопки тільки коли активно
                pbEdit.Visible = true;
                pbDelete.Visible = true;
            }
            else
            {
                lblTitle.ForeColor = colorTextTitleNormal;
                lblSubtitle.ForeColor = colorTextSubNormal;
                // Ховаємо кнопки
                pbEdit.Visible = false;
                pbDelete.Visible = false;
            }
            Invalidate(); // Перемалювати фон
        }

        private void AttachMouseEvents(Control c)
        {
            c.Click += (s, e) => ItemClick?.Invoke(this, EventArgs.Empty);

            c.MouseEnter += (s, e) =>
            {
                if (!_isSelected)
                {
                    _isHovered = true;
                    UpdateVisualState();
                }
            };

            c.MouseLeave += (s, e) =>
            {
                Point p = this.PointToClient(Cursor.Position);
                if (!this.ClientRectangle.Contains(p) && !_isSelected)
                {
                    _isHovered = false;
                    UpdateVisualState();
                }
            };
        }

        private void PopulateData()
        {
            lblTitle.Text = _entry.Title;
            lblSubtitle.Text = !string.IsNullOrEmpty(_entry.Username) ? _entry.Username : _entry.WebsiteUrl;

            if (!string.IsNullOrEmpty(_entry.IconBase64))
            {
                pbIcon.Image = DatabaseHelper.Base64ToImage(_entry.IconBase64); MakeCircular(pbIcon);
            }
            else
            {
                pbIcon.Image = GeneratePlaceholderImage(_entry.Title);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (_isSelected || _isHovered)
            {
                Rectangle rect = new Rectangle(10, 5, this.Width - 20, this.Height - 10);
                using (GraphicsPath path = GetFigurePath(rect, 15))
                using (Brush brush = new SolidBrush(colorSelectedBg))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
            else
            {
                using (Pen p = new Pen(Color.FromArgb(240, 240, 240), 1))
                {
                    e.Graphics.DrawLine(p, 20, this.Height - 1, this.Width - 20, this.Height - 1);
                }
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath(); float d = radius * 2F;
            path.StartFigure(); path.AddArc(rect.X, rect.Y, d, d, 180, 90); path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90); path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90); path.CloseFigure(); return path;
        }

        private void MakeCircular(PictureBox pb) { GraphicsPath path = new GraphicsPath(); path.AddEllipse(0, 0, pb.Width, pb.Height); pb.Region = new Region(path); }

        private Image GeneratePlaceholderImage(string title)
        {
            Bitmap bmp = new Bitmap(45, 45);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                int hash = title.GetHashCode(); Random rnd = new Random(hash);
                Color randomColor = Color.FromArgb(rnd.Next(80, 200), rnd.Next(80, 200), rnd.Next(80, 200));
                using (Brush brush = new SolidBrush(randomColor)) g.FillEllipse(brush, 0, 0, 40, 40);
                string initials = title.Length >= 2 ? title.Substring(0, 2).ToUpper() : (title.Length > 0 ? title.Substring(0, 1).ToUpper() : "?");
                using (Font font = new Font("Segoe UI", 12, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(initials, font); g.DrawString(initials, font, Brushes.White, (40 - textSize.Width) / 2, (40 - textSize.Height) / 2 + 1);
                }
            }
            return bmp;
        }
    }
}