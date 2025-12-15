using PasswordManager.additionalClasses;

namespace PasswordManager.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pbClouds = new PictureBox();
            lblWelcomeTo = new Label();
            gradientPanel1 = new GradientPanel();
            lblAbout = new Label();
            lblPasswordManager = new Label();
            pbCodewaveLogo = new PictureBox();
            lblTitle = new Label();
            LTxtUsername = new PasswordManager.personalizedTools.LoginTextBox();
            LTxtPassword = new PasswordManager.personalizedTools.LoginTextBox();
            lblForgotPassword = new Label();
            lblSignUp = new Label();
            lblDHACquestion = new Label();
            pbCollapse = new PictureBox();
            pbClose = new PictureBox();
            rbLogin = new RoundedButton();
            pbEyePass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbClouds).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCodewaveLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyePass).BeginInit();
            SuspendLayout();
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
            // lblWelcomeTo
            // 
            lblWelcomeTo.AutoSize = true;
            lblWelcomeTo.BackColor = Color.Transparent;
            lblWelcomeTo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblWelcomeTo.ForeColor = Color.White;
            lblWelcomeTo.Location = new Point(24, 122);
            lblWelcomeTo.Name = "lblWelcomeTo";
            lblWelcomeTo.Size = new Size(291, 31);
            lblWelcomeTo.TabIndex = 1;
            lblWelcomeTo.Text = "ЛАСКАВО ПРОСИМО ДО";
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
            gradientPanel1.Size = new Size(400, 454);
            gradientPanel1.TabIndex = 0;
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.BackColor = Color.Transparent;
            lblAbout.Font = new Font("Segoe UI", 10.2F);
            lblAbout.ForeColor = Color.White;
            lblAbout.Location = new Point(11, 245);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(335, 92);
            lblAbout.TabIndex = 3;
            lblAbout.Text = "Надійно зберігайте паролі, захищайте \r\nособисті дані та керуйте доступом до \r\nоблікових записів в одному безпечному \r\nмісці.";
            lblAbout.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPasswordManager
            // 
            lblPasswordManager.AutoSize = true;
            lblPasswordManager.BackColor = Color.Transparent;
            lblPasswordManager.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPasswordManager.ForeColor = Color.White;
            lblPasswordManager.Location = new Point(70, 162);
            lblPasswordManager.Name = "lblPasswordManager";
            lblPasswordManager.Size = new Size(204, 28);
            lblPasswordManager.TabIndex = 2;
            lblPasswordManager.Text = "Менеджера паролів";
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
            lblTitle.Location = new Point(432, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(277, 62);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Увійдіть до облікового \r\nзапису";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LTxtUsername
            // 
            LTxtUsername.BackColor = Color.FromArgb(33, 45, 245);
            LTxtUsername.isPassword = false;
            LTxtUsername.label = "Ім'я користувача";
            LTxtUsername.Location = new Point(435, 132);
            LTxtUsername.Name = "LTxtUsername";
            LTxtUsername.Padding = new Padding(0, 0, 0, 1);
            LTxtUsername.Size = new Size(274, 53);
            LTxtUsername.TabIndex = 4;
            // 
            // LTxtPassword
            // 
            LTxtPassword.BackColor = Color.FromArgb(33, 45, 245);
            LTxtPassword.isPassword = true;
            LTxtPassword.label = "Пароль";
            LTxtPassword.Location = new Point(435, 204);
            LTxtPassword.Name = "LTxtPassword";
            LTxtPassword.Padding = new Padding(0, 0, 0, 1);
            LTxtPassword.Size = new Size(274, 53);
            LTxtPassword.TabIndex = 5;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.BackColor = Color.Transparent;
            lblForgotPassword.Font = new Font("Segoe UI", 8F);
            lblForgotPassword.ForeColor = Color.FromArgb(123, 84, 195);
            lblForgotPassword.Location = new Point(605, 263);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(109, 19);
            lblForgotPassword.TabIndex = 7;
            lblForgotPassword.Text = "Забули пароль?";
            lblForgotPassword.Click += lblForgotPassword_Click;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.BackColor = Color.Transparent;
            lblSignUp.Font = new Font("Segoe UI", 8F);
            lblSignUp.ForeColor = Color.FromArgb(33, 45, 245);
            lblSignUp.Location = new Point(589, 408);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(113, 19);
            lblSignUp.TabIndex = 8;
            lblSignUp.Text = "Зареєструватися";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // lblDHACquestion
            // 
            lblDHACquestion.AutoSize = true;
            lblDHACquestion.BackColor = Color.Transparent;
            lblDHACquestion.Font = new Font("Segoe UI", 8F);
            lblDHACquestion.ForeColor = Color.Black;
            lblDHACquestion.Location = new Point(489, 408);
            lblDHACquestion.Name = "lblDHACquestion";
            lblDHACquestion.Size = new Size(102, 19);
            lblDHACquestion.TabIndex = 9;
            lblDHACquestion.Text = "Нема акаунта?";
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
            // rbLogin
            // 
            rbLogin.BackColor = Color.FromArgb(33, 145, 245);
            rbLogin.BackgroundColor = Color.FromArgb(33, 145, 245);
            rbLogin.BorderColor = Color.PaleVioletRed;
            rbLogin.BorderRadius = 20;
            rbLogin.BorderSize = 0;
            rbLogin.FlatAppearance.BorderSize = 0;
            rbLogin.FlatStyle = FlatStyle.Flat;
            rbLogin.ForeColor = Color.White;
            rbLogin.IconSize = 30;
            rbLogin.Location = new Point(435, 315);
            rbLogin.Name = "rbLogin";
            rbLogin.Size = new Size(274, 43);
            rbLogin.TabIndex = 10;
            rbLogin.Text = "                         Увійти";
            rbLogin.TextColor = Color.White;
            rbLogin.UseVisualStyleBackColor = false;
            rbLogin.Click += rbLogin_Click;
            // 
            // pbEyePass
            // 
            pbEyePass.BackColor = Color.Transparent;
            pbEyePass.Cursor = Cursors.Hand;
            pbEyePass.Image = (Image)resources.GetObject("pbEyePass.Image");
            pbEyePass.Location = new Point(675, 222);
            pbEyePass.Name = "pbEyePass";
            pbEyePass.Size = new Size(25, 25);
            pbEyePass.SizeMode = PictureBoxSizeMode.Zoom;
            pbEyePass.TabIndex = 20;
            pbEyePass.TabStop = false;
            pbEyePass.Click += pbEyePass_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 453);
            Controls.Add(rbLogin);
            Controls.Add(pbEyePass);
            Controls.Add(pbCollapse);
            Controls.Add(lblDHACquestion);
            Controls.Add(pbClose);
            Controls.Add(lblSignUp);
            Controls.Add(lblForgotPassword);
            Controls.Add(LTxtPassword);
            Controls.Add(LTxtUsername);
            Controls.Add(gradientPanel1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pbClouds).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCodewaveLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyePass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbClouds;
        private Label lblWelcomeTo;
        private GradientPanel gradientPanel1;
        private PictureBox pbCodewaveLogo;
        private Label lblPasswordManager;
        private Label lblTitle;
        private Label lblAbout;
        private personalizedTools.LoginTextBox LTxtUsername;
        private personalizedTools.LoginTextBox LTxtPassword;
        private Label lblForgotPassword;
        private Label lblSignUp;
        private Label lblDHACquestion;
        private PictureBox pbCollapse;
        private PictureBox pbClose;
        private RoundedButton rbLogin;
        private System.Windows.Forms.PictureBox pbEyePass;
    }
}