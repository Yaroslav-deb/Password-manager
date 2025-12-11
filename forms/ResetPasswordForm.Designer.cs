using PasswordManager.additionalClasses;

namespace PasswordManager.Forms
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            gradientPanel1 = new GradientPanel();
            lblAbout = new Label();
            lblPasswordManager = new Label();
            pbCodewaveLogo = new PictureBox();
            lblWelcomeTo = new Label();
            pbClouds = new PictureBox();
            lblTitle = new Label();
            lblDescription = new Label();
            LTxtPassword = new PasswordManager.personalizedTools.LoginTextBox();
            LTxtConfirm = new PasswordManager.personalizedTools.LoginTextBox();
            btnSave = new RoundedButton();
            pbCollapse = new PictureBox();
            pbClose = new PictureBox();
            pbEyePass = new PictureBox();
            pbEyeConfirm = new PictureBox();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCodewaveLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClouds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyePass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeConfirm).BeginInit();
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
            lblAbout.Location = new Point(42, 244);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(229, 46);
            lblAbout.TabIndex = 3;
            lblAbout.Text = "Захистіть свій акаунт новим\r\nнадійним паролем.";
            lblAbout.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPasswordManager
            // 
            lblPasswordManager.AutoSize = true;
            lblPasswordManager.BackColor = Color.Transparent;
            lblPasswordManager.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPasswordManager.ForeColor = Color.White;
            lblPasswordManager.Location = new Point(88, 180);
            lblPasswordManager.Name = "lblPasswordManager";
            lblPasswordManager.Size = new Size(127, 28);
            lblPasswordManager.TabIndex = 2;
            lblPasswordManager.Text = "Для акаунта";
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
            lblWelcomeTo.Location = new Point(57, 148);
            lblWelcomeTo.Name = "lblWelcomeTo";
            lblWelcomeTo.Size = new Size(196, 31);
            lblWelcomeTo.TabIndex = 1;
            lblWelcomeTo.Text = "НОВИЙ ПАРОЛЬ";
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
            lblTitle.Location = new Point(432, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(257, 31);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Встановлення пароля";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.ForeColor = Color.Gray;
            lblDescription.Location = new Point(435, 90);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(198, 40);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Придумайте новий пароль\r\nта підтвердіть його.";
            // 
            // LTxtPassword
            // 
            LTxtPassword.BackColor = Color.FromArgb(33, 45, 245);
            LTxtPassword.isPassword = true;
            LTxtPassword.label = "Новий пароль";
            LTxtPassword.Location = new Point(435, 150);
            LTxtPassword.Name = "LTxtPassword";
            LTxtPassword.Padding = new Padding(0, 0, 0, 1);
            LTxtPassword.Size = new Size(274, 53);
            LTxtPassword.TabIndex = 5;
            // 
            // LTxtConfirm
            // 
            LTxtConfirm.BackColor = Color.FromArgb(33, 45, 245);
            LTxtConfirm.isPassword = true;
            LTxtConfirm.label = "Підтвердження";
            LTxtConfirm.Location = new Point(435, 220);
            LTxtConfirm.Name = "LTxtConfirm";
            LTxtConfirm.Padding = new Padding(0, 0, 0, 1);
            LTxtConfirm.Size = new Size(274, 53);
            LTxtConfirm.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(123, 84, 195);
            btnSave.BackgroundColor = Color.FromArgb(123, 84, 195);
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 20;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.IconSize = 30;
            btnSave.Location = new Point(435, 310);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(274, 43);
            btnSave.TabIndex = 7;
            btnSave.Text = "Зберегти";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            // pbEyePass
            // 
            pbEyePass.BackColor = Color.Transparent;
            pbEyePass.Cursor = Cursors.Hand;
            pbEyePass.Image = (Image)resources.GetObject("pbEyePass.Image");
            pbEyePass.Location = new Point(670, 165);
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
            pbEyeConfirm.Location = new Point(670, 235);
            pbEyeConfirm.Name = "pbEyeConfirm";
            pbEyeConfirm.Size = new Size(25, 25);
            pbEyeConfirm.SizeMode = PictureBoxSizeMode.Zoom;
            pbEyeConfirm.TabIndex = 21;
            pbEyeConfirm.TabStop = false;
            pbEyeConfirm.Click += pbEyeConfirm_Click;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 453);
            Controls.Add(pbEyeConfirm);
            Controls.Add(pbEyePass);
            Controls.Add(pbClose);
            Controls.Add(pbCollapse);
            Controls.Add(btnSave);
            Controls.Add(LTxtConfirm);
            Controls.Add(LTxtPassword);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCodewaveLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClouds).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyePass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeConfirm).EndInit();
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
        private PasswordManager.personalizedTools.LoginTextBox LTxtPassword;
        private PasswordManager.personalizedTools.LoginTextBox LTxtConfirm;
        private PasswordManager.additionalClasses.RoundedButton btnSave;
        private System.Windows.Forms.PictureBox pbCollapse;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbEyePass;
        private System.Windows.Forms.PictureBox pbEyeConfirm;
    }
}