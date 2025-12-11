using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PasswordManager.personalizedTools
{
    public partial class ModernSearchBar : UserControl
    {
        private int borderRadius = 20;
        private Color borderColor = Color.LightGray;

        private string placeholderText = "Пошук...";
        private Color placeholderColor = Color.Gray;
        private Color textColor = Color.Black;
        private bool isPlaceholderActive = true;

        public event EventHandler TextChangedEvent;

        public ModernSearchBar()
        {
            InitializeComponent();
            InitializeCustomLogic();
        }

        private void InitializeCustomLogic()
        {
            SetPlaceholder();

            txtSearch.GotFocus += RemovePlaceholder;
            txtSearch.LostFocus += SetPlaceholder;

            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtSearch.TextChanged += (s, e) =>
            {
                if (!isPlaceholderActive)
                    TextChangedEvent?.Invoke(this, e);
            };

            this.Resize += (s, e) => {
                txtSearch.Location = new Point(40, (this.Height - txtSearch.Height) / 2);
                txtSearch.Width = this.Width - 50;
            };

            txtSearch.Location = new Point(40, (this.Height - txtSearch.Height) / 2);
            txtSearch.Width = this.Width - 50;
        }

        private void SetPlaceholder(object sender = null, EventArgs e = null)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                isPlaceholderActive = true;
                txtSearch.Text = placeholderText;
                txtSearch.ForeColor = placeholderColor;
            }
        }

        private void RemovePlaceholder(object sender = null, EventArgs e = null)
        {
            if (isPlaceholderActive)
            {
                isPlaceholderActive = false;
                txtSearch.Text = "";
                txtSearch.ForeColor = textColor;
            }
        }

        public string SearchText
        {
            get { return isPlaceholderActive ? "" : txtSearch.Text; }
            set
            {
                txtSearch.Text = value;
                RemovePlaceholder();
            }
        }

        public Image Icon
        {
            get { return pbIcon.Image; }
            set { pbIcon.Image = value; }
        }

        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return txtSearch.AutoCompleteCustomSource; }
            set { txtSearch.AutoCompleteCustomSource = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath path = GetFigurePath(rect, borderRadius))
            using (Pen pen = new Pen(borderColor, 1.5f))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}