using PasswordManager.additionalClasses;

namespace PasswordManager.Forms
{
    partial class VerificationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationForm));
            gradientPanel1 = new GradientPanel();
            pbCodewaveLogo = new PictureBox();
            lblAbout = new Label();
            lblPasswordManager = new Label();
            lblWelcomeTo = new Label();
            pbClouds = new PictureBox();
            lblTitle = new Label();
            lblDescription = new Label();
            LTxtCode = new PasswordManager.personalizedTools.LoginTextBox();
            btnVerify = new RoundedButton();
            pbCollapse = new PictureBox();
            pbClose = new PictureBox();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCodewaveLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClouds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(pbCodewaveLogo);
            gradientPanel1.Controls.Add(lblAbout);
            gradientPanel1.Controls.Add(lblPasswordManager);
            gradientPanel1.Controls.Add(lblWelcomeTo);
            gradientPanel1.Controls.Add(pbClouds);
            gradientPanel1.gradientBottom = Color.FromArgb(123, 84, 195);
            gradientPanel1.gradientTop = Color.FromArgb(55, 20, 100);
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(400, 454);
            gradientPanel1.TabIndex = 0;
            // 
            // pbCodewaveLogo
            // 
            pbCodewaveLogo.BackColor = Color.Transparent;
            pbCodewaveLogo.Image = (Image)resources.GetObject("pbCodewaveLogo.Image");
            pbCodewaveLogo.Location = new Point(12, 23);
            pbCodewaveLogo.Name = "pbCodewaveLogo";
            pbCodewaveLogo.Size = new Size(190, 62);
            pbCodewaveLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCodewaveLogo.TabIndex = 2;
            pbCodewaveLogo.TabStop = false;
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.BackColor = Color.Transparent;
            lblAbout.Font = new Font("Segoe UI", 10F);
            lblAbout.ForeColor = Color.White;
            lblAbout.Location = new Point(12, 240);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(306, 46);
            lblAbout.TabIndex = 3;
            lblAbout.Text = "Ми надіслали 6-значний код на вашу\r\nелектронну пошту.";
            lblAbout.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPasswordManager
            // 
            lblPasswordManager.AutoSize = true;
            lblPasswordManager.BackColor = Color.Transparent;
            lblPasswordManager.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPasswordManager.ForeColor = Color.White;
            lblPasswordManager.Location = new Point(72, 180);
            lblPasswordManager.Name = "lblPasswordManager";
            lblPasswordManager.Size = new Size(178, 28);
            lblPasswordManager.TabIndex = 2;
            lblPasswordManager.Text = "Перевірка пошти";
            // 
            // lblWelcomeTo
            // 
            lblWelcomeTo.AutoSize = true;
            lblWelcomeTo.BackColor = Color.Transparent;
            lblWelcomeTo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWelcomeTo.ForeColor = Color.White;
            lblWelcomeTo.Location = new Point(81, 145);
            lblWelcomeTo.Name = "lblWelcomeTo";
            lblWelcomeTo.Size = new Size(164, 31);
            lblWelcomeTo.TabIndex = 1;
            lblWelcomeTo.Text = "ВЕРИФІКАЦІЯ";
            // 
            // pbClouds
            // 
            pbClouds.BackColor = Color.Transparent;
            pbClouds.Image = (Image)resources.GetObject("pbClouds.Image");
            pbClouds.Location = new Point(304, 0);
            pbClouds.Name = "pbClouds";
            pbClouds.Size = new Size(96, 454);
            pbClouds.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClouds.TabIndex = 0;
            pbClouds.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(432, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(145, 31);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Введіть код";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.ForeColor = Color.Gray;
            lblDescription.Location = new Point(435, 110);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(253, 40);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Введіть код підтвердження, який\r\nви отримали у вікні повідомлення.";
            // 
            // LTxtCode
            // 
            LTxtCode.BackColor = Color.FromArgb(33, 45, 245);
            LTxtCode.isPassword = false;
            LTxtCode.label = "Код підтвердження";
            LTxtCode.Location = new Point(435, 170);
            LTxtCode.Name = "LTxtCode";
            LTxtCode.Padding = new Padding(0, 0, 0, 1);
            LTxtCode.Size = new Size(274, 53);
            LTxtCode.TabIndex = 5;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.FromArgb(123, 84, 195);
            btnVerify.BackgroundColor = Color.FromArgb(123, 84, 195);
            btnVerify.BorderColor = Color.PaleVioletRed;
            btnVerify.BorderRadius = 20;
            btnVerify.BorderSize = 0;
            btnVerify.FlatAppearance.BorderSize = 0;
            btnVerify.FlatStyle = FlatStyle.Flat;
            btnVerify.ForeColor = Color.White;
            btnVerify.IconSize = 30;
            btnVerify.Location = new Point(435, 260);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(274, 43);
            btnVerify.TabIndex = 6;
            btnVerify.Text = "Перевірити";
            btnVerify.TextColor = Color.White;
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // pbCollapse
            // 
            pbCollapse.BackColor = Color.Transparent;
            pbCollapse.Image = (Image)resources.GetObject("pbCollapse.Image");
            pbCollapse.Location = new Point(663, 6);
            pbCollapse.Name = "pbCollapse";
            pbCollapse.Size = new Size(30, 30);
            pbCollapse.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCollapse.TabIndex = 8;
            pbCollapse.TabStop = false;
            // 
            // pbClose
            // 
            pbClose.BackColor = Color.Transparent;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(699, 6);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(30, 30);
            pbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClose.TabIndex = 9;
            pbClose.TabStop = false;
            // 
            // VerificationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 453);
            Controls.Add(pbClose);
            Controls.Add(pbCollapse);
            Controls.Add(btnVerify);
            Controls.Add(LTxtCode);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerificationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verification";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCodewaveLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClouds).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PasswordManager.additionalClasses.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblPasswordManager;
        private System.Windows.Forms.PictureBox pbCodewaveLogo;
        private System.Windows.Forms.Label lblWelcomeTo;
        private System.Windows.Forms.PictureBox pbClouds;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private PasswordManager.personalizedTools.LoginTextBox LTxtCode;
        private PasswordManager.additionalClasses.RoundedButton btnVerify;
        private System.Windows.Forms.PictureBox pbCollapse;
        private System.Windows.Forms.PictureBox pbClose;
    }
}