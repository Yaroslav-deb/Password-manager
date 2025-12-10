using PasswordManager.additionalClasses;

namespace PasswordManager.Forms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            pbClouds = new PictureBox();
            lblWelcomeTo = new Label();
            gradientPanel1 = new GradientPanel();
            lblAbout = new Label();
            lblPasswordManager = new Label();
            pbCodewaveLogo = new PictureBox();
            lblTitle = new Label();
            LTxtUsername = new PasswordManager.personalizedTools.LoginTextBox();
            LTxtEmail = new PasswordManager.personalizedTools.LoginTextBox();
            LTxtPassword = new PasswordManager.personalizedTools.LoginTextBox();
            LTxtConfirmPass = new PasswordManager.personalizedTools.LoginTextBox();
            lblLogin = new Label();
            lblQuestion = new Label();
            pbCollapse = new PictureBox();
            pbClose = new PictureBox();
            rbRegister = new RoundedButton();
            pbEyePass = new PictureBox();
            pbEyeConfirm = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbClouds).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCodewaveLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyePass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeConfirm).BeginInit();
            SuspendLayout();
            // 
            // pbClouds
            // 
            pbClouds.BackColor = Color.Transparent;
            pbClouds.Image = (Image)resources.GetObject("pbClouds.Image");
            pbClouds.Location = new Point(304, 0);
            pbClouds.Name = "pbClouds";
            pbClouds.Size = new Size(96, 550);
            pbClouds.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClouds.TabIndex = 0;
            pbClouds.TabStop = false;
            // 
            // lblWelcomeTo
            // 
            lblWelcomeTo.AutoSize = true;
            lblWelcomeTo.BackColor = Color.Transparent;
            lblWelcomeTo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblWelcomeTo.ForeColor = Color.White;
            lblWelcomeTo.Location = new Point(49, 160);
            lblWelcomeTo.Name = "lblWelcomeTo";
            lblWelcomeTo.Size = new Size(239, 31);
            lblWelcomeTo.TabIndex = 1;
            lblWelcomeTo.Text = "СТВОРІТЬ АКАУНТ У";
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(lblAbout);
            gradientPanel1.Controls.Add(lblPasswordManager);
            gradientPanel1.Controls.Add(pbCodewaveLogo);
            gradientPanel1.Controls.Add(lblWelcomeTo);
            gradientPanel1.Controls.Add(pbClouds);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(400, 550);
            gradientPanel1.TabIndex = 0;
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.BackColor = Color.Transparent;
            lblAbout.Font = new Font("Segoe UI", 10.2F);
            lblAbout.ForeColor = Color.White;
            lblAbout.Location = new Point(12, 300);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(310, 69);
            lblAbout.TabIndex = 3;
            lblAbout.Text = "Приєднуйтесь до нас та почніть\r\nконтролювати свою цифрову безпеку\r\nвже сьогодні.";
            lblAbout.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPasswordManager
            // 
            lblPasswordManager.AutoSize = true;
            lblPasswordManager.BackColor = Color.Transparent;
            lblPasswordManager.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPasswordManager.ForeColor = Color.White;
            lblPasswordManager.Location = new Point(68, 204);
            lblPasswordManager.Name = "lblPasswordManager";
            lblPasswordManager.Size = new Size(199, 28);
            lblPasswordManager.TabIndex = 2;
            lblPasswordManager.Text = "Менеджері паролів";
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(432, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 31);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Реєстрація";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LTxtUsername
            // 
            LTxtUsername.BackColor = Color.FromArgb(33, 45, 245);
            LTxtUsername.isPassword = false;
            LTxtUsername.label = "Ім'я користувача";
            LTxtUsername.Location = new Point(435, 90);
            LTxtUsername.Name = "LTxtUsername";
            LTxtUsername.Padding = new Padding(0, 0, 0, 1);
            LTxtUsername.Size = new Size(274, 53);
            LTxtUsername.TabIndex = 4;
            // 
            // LTxtEmail
            // 
            LTxtEmail.BackColor = Color.FromArgb(33, 45, 245);
            LTxtEmail.isPassword = false;
            LTxtEmail.label = "Електронна пошта";
            LTxtEmail.Location = new Point(435, 160);
            LTxtEmail.Name = "LTxtEmail";
            LTxtEmail.Padding = new Padding(0, 0, 0, 1);
            LTxtEmail.Size = new Size(274, 53);
            LTxtEmail.TabIndex = 5;
            // 
            // LTxtPassword
            // 
            LTxtPassword.BackColor = Color.FromArgb(33, 45, 245);
            LTxtPassword.isPassword = true;
            LTxtPassword.label = "Пароль";
            LTxtPassword.Location = new Point(435, 230);
            LTxtPassword.Name = "LTxtPassword";
            LTxtPassword.Padding = new Padding(0, 0, 0, 1);
            LTxtPassword.Size = new Size(274, 53);
            LTxtPassword.TabIndex = 6;
            // 
            // LTxtConfirmPass
            // 
            LTxtConfirmPass.BackColor = Color.FromArgb(33, 45, 245);
            LTxtConfirmPass.isPassword = true;
            LTxtConfirmPass.label = "Підтвердження паролю";
            LTxtConfirmPass.Location = new Point(435, 300);
            LTxtConfirmPass.Name = "LTxtConfirmPass";
            LTxtConfirmPass.Padding = new Padding(0, 0, 0, 1);
            LTxtConfirmPass.Size = new Size(274, 53);
            LTxtConfirmPass.TabIndex = 7;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 8F);
            lblLogin.ForeColor = Color.FromArgb(33, 45, 245);
            lblLogin.Location = new Point(620, 480);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 19);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Увійти";
            lblLogin.Click += lblLogin_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.Font = new Font("Segoe UI", 8F);
            lblQuestion.ForeColor = Color.Black;
            lblQuestion.Location = new Point(480, 480);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(96, 19);
            lblQuestion.TabIndex = 9;
            lblQuestion.Text = "Вже є акаунт?";
            // 
            // pbCollapse
            // 
            pbCollapse.BackColor = Color.Transparent;
            pbCollapse.Image = (Image)resources.GetObject("pbCollapse.Image");
            pbCollapse.Location = new Point(663, 6);
            pbCollapse.Name = "pbCollapse";
            pbCollapse.Size = new Size(30, 30);
            pbCollapse.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCollapse.TabIndex = 2;
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
            pbClose.TabIndex = 0;
            pbClose.TabStop = false;
            // 
            // rbRegister
            // 
            rbRegister.BackColor = Color.FromArgb(33, 145, 245);
            rbRegister.BackgroundColor = Color.FromArgb(33, 145, 245);
            rbRegister.BorderColor = Color.PaleVioletRed;
            rbRegister.BorderRadius = 20;
            rbRegister.BorderSize = 0;
            rbRegister.FlatAppearance.BorderSize = 0;
            rbRegister.FlatStyle = FlatStyle.Flat;
            rbRegister.ForeColor = Color.White;
            rbRegister.Location = new Point(435, 400);
            rbRegister.Name = "rbRegister";
            rbRegister.Size = new Size(274, 43);
            rbRegister.TabIndex = 10;
            rbRegister.Text = "Зареєструватися";
            rbRegister.TextColor = Color.White;
            rbRegister.UseVisualStyleBackColor = false;
            rbRegister.Click += rbRegister_Click;
            // 
            // pbEyePass
            // 
            pbEyePass.BackColor = Color.Transparent;
            pbEyePass.Cursor = Cursors.Hand;
            pbEyePass.Image = (Image)resources.GetObject("pbEyePass.Image");
            pbEyePass.Location = new Point(675, 249);
            pbEyePass.Name = "pbEyePass";
            pbEyePass.Size = new Size(25, 25);
            pbEyePass.SizeMode = PictureBoxSizeMode.Zoom;
            pbEyePass.TabIndex = 20;
            pbEyePass.TabStop = false;
            pbEyePass.Click += pbEyePass_Click;
            // 
            // pbEyeConfirm
            // 
            pbEyeConfirm.BackColor = Color.Transparent;
            pbEyeConfirm.Cursor = Cursors.Hand;
            pbEyeConfirm.Image = (Image)resources.GetObject("pbEyeConfirm.Image");
            pbEyeConfirm.Location = new Point(675, 319);
            pbEyeConfirm.Name = "pbEyeConfirm";
            pbEyeConfirm.Size = new Size(25, 25);
            pbEyeConfirm.SizeMode = PictureBoxSizeMode.Zoom;
            pbEyeConfirm.TabIndex = 21;
            pbEyeConfirm.TabStop = false;
            pbEyeConfirm.Click += pbEyeConfirm_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 550);
            Controls.Add(rbRegister);
            Controls.Add(pbCollapse);
            Controls.Add(lblQuestion);
            Controls.Add(pbClose);
            Controls.Add(lblLogin);
            Controls.Add(LTxtConfirmPass);
            Controls.Add(LTxtPassword);
            Controls.Add(LTxtEmail);
            Controls.Add(LTxtUsername);
            Controls.Add(gradientPanel1);
            Controls.Add(lblTitle);
            Controls.Add(pbEyePass);
            Controls.Add(pbEyeConfirm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)pbClouds).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCodewaveLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyePass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeConfirm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbClouds;
        private System.Windows.Forms.Label lblWelcomeTo;
        private PasswordManager.additionalClasses.GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pbCodewaveLogo;
        private System.Windows.Forms.Label lblPasswordManager;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAbout;
        private PasswordManager.personalizedTools.LoginTextBox LTxtUsername;
        private PasswordManager.personalizedTools.LoginTextBox LTxtEmail;
        private PasswordManager.personalizedTools.LoginTextBox LTxtPassword;
        private PasswordManager.personalizedTools.LoginTextBox LTxtConfirmPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox pbCollapse;
        private System.Windows.Forms.PictureBox pbClose;
        private PasswordManager.additionalClasses.RoundedButton rbRegister;
        private PictureBox pbEyePass;
        private PictureBox pbEyeConfirm;
    }
}