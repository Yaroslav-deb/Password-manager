using System.Windows.Forms;
using System.Drawing;

namespace PasswordManager.personalizedTools
{
    partial class ModernDropdown
    {
        private System.ComponentModel.IContainer components = null;

        // Объявляем элементы
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pbIconLeft;
        private System.Windows.Forms.PictureBox pbArrow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            lblText = new Label();
            pbIconLeft = new PictureBox();
            pbArrow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbIconLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow).BeginInit();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Segoe UI Semibold", 9F);
            lblText.Location = new Point(10, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(120, 35);
            lblText.TabIndex = 2;
            lblText.Text = "   Select...";
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbIconLeft
            // 
            pbIconLeft.BackColor = Color.Transparent;
            pbIconLeft.Location = new Point(10, 7);
            pbIconLeft.Name = "pbIconLeft";
            pbIconLeft.Size = new Size(20, 20);
            pbIconLeft.SizeMode = PictureBoxSizeMode.Zoom;
            pbIconLeft.TabIndex = 0;
            pbIconLeft.TabStop = false;
            pbIconLeft.Visible = false;
            // 
            // pbArrow
            // 
            pbArrow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbArrow.BackColor = Color.Transparent;
            pbArrow.Location = new Point(135, 10);
            pbArrow.Name = "pbArrow";
            pbArrow.Size = new Size(15, 15);
            pbArrow.SizeMode = PictureBoxSizeMode.Zoom;
            pbArrow.TabIndex = 1;
            pbArrow.TabStop = false;
            // 
            // ModernDropdown
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pbArrow);
            Controls.Add(pbIconLeft);
            Controls.Add(lblText);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Name = "ModernDropdown";
            Size = new Size(160, 35);
            ((System.ComponentModel.ISupportInitialize)pbIconLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}