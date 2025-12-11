using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PasswordManager.personalizedTools
{
    public class DropdownItemSelectedEventArgs : EventArgs
    {
        public string SelectedItem { get; set; }
        public int Index { get; set; }
    }

    public partial class ModernDropdown : UserControl
    {
        private ContextMenuStrip dropdownMenu;
        private List<string> _items = new List<string>();
        private int _selectedIndex = -1;

        public event EventHandler<DropdownItemSelectedEventArgs> ItemSelected;

        public ModernDropdown()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                InitializeCustomLogic();
            }
        }

        private void InitializeCustomLogic()
        {
            this.BackColor = Color.White;

            dropdownMenu = new ContextMenuStrip();
            dropdownMenu.Renderer = new ModernMenuRenderer();
            dropdownMenu.ShowImageMargin = true;

            dropdownMenu.BackColor = Color.FromArgb(242, 242, 242);
            dropdownMenu.Font = new Font("Segoe UI", 10F);

            lblText.Anchor = AnchorStyles.None;

            this.Click += ToggleMenu;
            lblText.Click += ToggleMenu;
            pbIconLeft.Click += ToggleMenu;
            pbArrow.Click += ToggleMenu;

            this.Resize += (s, e) => {
                pbArrow.Location = new Point(this.Width - 25, (this.Height - 15) / 2);
                UpdateTextPosition();
            };
        }

        public Image MainIcon
        {
            get { return pbIconLeft.Image; }
            set
            {
                pbIconLeft.Image = value;
                pbIconLeft.Visible = (value != null);
                UpdateTextPosition();
            }
        }

        public Image ArrowIcon
        {
            get { return pbArrow.Image; }
            set { pbArrow.Image = value; }
        }

        public string SelectedText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        public int SelectedIndex => _selectedIndex;

        private void UpdateTextPosition()
        {
            if (pbIconLeft.Visible)
            {
                lblText.Location = new Point(34, 0);
                lblText.Width = this.Width - 64;
            }
            else
            {
                lblText.Location = new Point(10, 0);
                lblText.Width = this.Width - 40;
            }
        }

        public void AddItem(string text, Image icon = null)
        {
            _items.Add(text);
            var menuItem = new ToolStripMenuItem(text);
            if (icon != null) menuItem.Image = icon;

            menuItem.Click += (s, e) =>
            {
                _selectedIndex = _items.IndexOf(text);
                lblText.Text = text;

                if (icon != null) MainIcon = icon;
                else MainIcon = null;

                ItemSelected?.Invoke(this, new DropdownItemSelectedEventArgs { SelectedItem = text, Index = _selectedIndex });
            };

            dropdownMenu.Items.Add(menuItem);
        }

        private void ToggleMenu(object sender, EventArgs e)
        {
            dropdownMenu.Show(this, 0, this.Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.Silver, 1.5f))
            {
                Rectangle r = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                GraphicsPath path = GetRoundedPath(r, 15);
                e.Graphics.DrawPath(p, path);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float d = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private class ModernMenuRenderer : ToolStripProfessionalRenderer
        {
            public ModernMenuRenderer() : base(new ModernColorTable()) { }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
        }

        private class ModernColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground => Color.FromArgb(242, 242, 242);
            public override Color ImageMarginGradientBegin => Color.FromArgb(242, 242, 242);
            public override Color ImageMarginGradientMiddle => Color.FromArgb(242, 242, 242);
            public override Color ImageMarginGradientEnd => Color.FromArgb(242, 242, 242);
            public override Color MenuItemSelected => Color.FromArgb(225, 225, 225);
            public override Color MenuItemBorder => Color.FromArgb(200, 200, 200);
            public override Color MenuItemPressedGradientBegin => Color.FromArgb(210, 210, 210);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(210, 210, 210);
        }
    }
}