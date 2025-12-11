using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace PasswordManager.additionalClasses
{
    public class RoundedButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        private int iconSize = 30;

        [Category("Codewave UI")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }

        [Category("Codewave UI")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        [Category("Codewave UI")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        [Category("Codewave UI")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Codewave UI")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        [Category("Codewave UI")]
        public int IconSize
        {
            get { return iconSize; }
            set { iconSize = value; Invalidate(); }
        }

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 50);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += (s, e) => { if (borderRadius > this.Height) borderRadius = this.Height; };

            SetStyle(ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer, true);
        }

        private Color GetVisibleBackColor()
        {
            Control current = this.Parent;
            while (current != null)
            {
                if (current.BackColor != Color.Transparent && current.BackColor.A == 255)
                {
                    return current.BackColor;
                }
                current = current.Parent;
            }
            return SystemColors.Control;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;

            Color parentColor = GetVisibleBackColor();

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(parentColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    graphics.Clear(parentColor);

                    if (this.BackColor != Color.Transparent)
                    {
                        using (Brush brushBg = new SolidBrush(this.BackColor))
                        {
                            graphics.FillPath(brushBg, pathSurface);
                        }
                    }

                    if (borderSize >= 1)
                        graphics.DrawPath(penBorder, pathBorder);

                    graphics.DrawPath(penSurface, pathSurface);
                }
            }
            else
            {
                graphics.Clear(parentColor);

                if (this.BackColor != Color.Transparent)
                {
                    using (Brush brushBg = new SolidBrush(this.BackColor))
                    {
                        graphics.FillRectangle(brushBg, rectSurface);
                    }
                }

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            DrawImageAndText(graphics);
        }

        private void DrawImageAndText(Graphics g)
        {
            int currentIconSize = this.IconSize;
            int imgX = 15;

            if (this.Padding.Left > 0) imgX = this.Padding.Left;

            if (this.Image != null)
            {
                int imgY = (this.Height - currentIconSize) / 2;
                g.DrawImage(this.Image, new Rectangle(imgX, imgY, currentIconSize, currentIconSize));
            }

            if (!string.IsNullOrEmpty(this.Text))
            {
                int textX = (this.Image != null) ? (imgX + currentIconSize + 10) : 10;

                if (this.Padding.Left > textX) textX = this.Padding.Left + 5;

                TextRenderer.DrawText(g, this.Text, this.Font,
                    new Rectangle(textX, 0, this.Width - textX, this.Height),
                    this.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis);
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

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.Parent != null)
                this.Parent.BackColorChanged += (s, args) => { if (this.DesignMode) Invalidate(); };
        }
    }
}