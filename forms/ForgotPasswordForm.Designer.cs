using PasswordManager.additionalClasses;

namespace PasswordManager.Forms
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            gradientPanel1 = new GradientPanel();
            lblAbout = new Label();
            lblPasswordManager = new Label();
            pbCodewaveLogo = new PictureBox();
            lblWelcomeTo = new Label();
            pbClouds = new PictureBox();
            lblTitle = new Label();
            lblDescription = new Label();
            LTxtEmail = new PasswordManager.personalizedTools.LoginTextBox();
            btnSend = new RoundedButton();
            lblBackToLogin = new Label();
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
            gradientPanel1.Controls.Add(lblAbout);
            gradientPanel1.Controls.Add(lblPasswordManager);
            gradientPanel1.Controls.Add(pbCodewaveLogo);
            gradientPanel1.Controls.Add(lblWelcomeTo);
            gradientPanel1.Controls.Add(pbClouds);
            gradientPanel1.gradientBottom = Color.FromArgb(123, 84, 195);
            gradientPanel1.gradientTop = Color.FromArgb(55, 20, 100);
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(400, 454);
            gradientPanel1.TabIndex = 0;
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.BackColor = Color.Transparent;
            lblAbout.Font = new Font("Segoe UI", 10F);
            lblAbout.ForeColor = Color.White;
            lblAbout.Location = new Point(12, 240);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(298, 69);
            lblAbout.TabIndex = 3;
            lblAbout.Text = "Забули пароль? Не хвилюйтеся.\r\nВведіть свою пошту, і ми надішлемо\r\nвам інструкції.";
            lblAbout.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPasswordManager
            // 
            lblPasswordManager.AutoSize = true;
            lblPasswordManager.BackColor = Color.Transparent;
            lblPasswordManager.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPasswordManager.ForeColor = Color.White;
            lblPasswordManager.Location = new Point(113, 164);
            lblPasswordManager.Name = "lblPasswordManager";
            lblPasswordManager.Size = new Size(89, 28);
            lblPasswordManager.TabIndex = 2;
            lblPasswordManager.Text = "Доступу";
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
            // lblWelcomeTo
            // 
            lblWelcomeTo.AutoSize = true;
            lblWelcomeTo.BackColor = Color.Transparent;
            lblWelcomeTo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWelcomeTo.ForeColor = Color.White;
            lblWelcomeTo.Location = new Point(72, 133);
            lblWelcomeTo.Name = "lblWelcomeTo";
            lblWelcomeTo.Size = new Size(176, 31);
            lblWelcomeTo.TabIndex = 1;
            lblWelcomeTo.Text = "ВІДНОВЛЕННЯ";
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
            lblTitle.Size = new Size(216, 31);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Скидання паролю";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            lblDescription.Text = "Введіть адресу електронної пошти,\r\nпов'язану з вашим акаунтом.";
            // 
            // LTxtEmail
            // 
            LTxtEmail.BackColor = Color.FromArgb(33, 45, 245);
            LTxtEmail.isPassword = false;
            LTxtEmail.label = "Електронна пошта";
            LTxtEmail.Location = new Point(435, 170);
            LTxtEmail.Name = "LTxtEmail";
            LTxtEmail.Padding = new Padding(0, 0, 0, 1);
            LTxtEmail.Size = new Size(274, 53);
            LTxtEmail.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(123, 84, 195);
            btnSend.BackgroundColor = Color.FromArgb(123, 84, 195);
            btnSend.BorderColor = Color.PaleVioletRed;
            btnSend.BorderRadius = 20;
            btnSend.BorderSize = 0;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.ForeColor = Color.White;
            btnSend.IconSize = 30;
            btnSend.Location = new Point(435, 260);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(274, 43);
            btnSend.TabIndex = 6;
            btnSend.Text = "Відправити";
            btnSend.TextColor = Color.White;
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblBackToLogin
            // 
            lblBackToLogin.AutoSize = true;
            lblBackToLogin.Cursor = Cursors.Hand;
            lblBackToLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBackToLogin.ForeColor = Color.FromArgb(123, 84, 195);
            lblBackToLogin.Location = new Point(500, 330);
            lblBackToLogin.Name = "lblBackToLogin";
            lblBackToLogin.Size = new Size(138, 20);
            lblBackToLogin.TabIndex = 7;
            lblBackToLogin.Text = "← Назад до входу";
            lblBackToLogin.Click += lblBackToLogin_Click;
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
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 453);
            Controls.Add(pbClose);
            Controls.Add(pbCollapse);
            Controls.Add(lblBackToLogin);
            Controls.Add(btnSend);
            Controls.Add(LTxtEmail);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
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
        private PasswordManager.personalizedTools.LoginTextBox LTxtEmail;
        private PasswordManager.additionalClasses.RoundedButton btnSend;
        private System.Windows.Forms.Label lblBackToLogin;
        private System.Windows.Forms.PictureBox pbCollapse;
        private System.Windows.Forms.PictureBox pbClose;
    }
}