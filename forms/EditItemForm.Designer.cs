using PasswordManager.additionalClasses;
using PasswordManager.personalizedTools;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    partial class EditItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItemForm));
            tlpMain = new TableLayoutPanel();
            pnlLeftGradient = new GradientPanel();
            pbCloudBackground = new PictureBox();
            pbCodewaveLogo = new PictureBox();
            lblInfoDesc = new Label();
            lblInfoTitle = new Label();
            pbLeftMainImage = new PictureBox();
            pnlRight = new Panel();
            pnlFormContent = new Panel();
            lblMainHeader = new Label();
            pbItemIcon = new PictureBox();
            btnUploadIcon = new RoundedButton();
            pbFavorite = new PictureBox();
            lblFavoriteText = new Label();
            txtTitle = new LoginTextBox();
            dropdownCategory = new ModernDropdown();
            txtUsername = new LoginTextBox();
            txtPassword = new LoginTextBox();
            btnGenerate = new RoundedButton();
            pbEyePass = new PictureBox();
            pbHelpGenerate = new PictureBox();
            txtConfirmPassword = new LoginTextBox();
            btnCopyPass = new RoundedButton();
            pbHelpCopy = new PictureBox();
            txtUrl = new LoginTextBox();
            txtNotes = new LoginTextBox();
            pbHelpNotes = new PictureBox();
            btnSave = new RoundedButton();
            btnCancel = new RoundedButton();
            pnlTopBar = new Panel();
            pbClose = new PictureBox();
            pbCollapse = new PictureBox();
            pbCollapseIntoWindow = new PictureBox();
            lblWindowTitle = new Label();
            tlpMain.SuspendLayout();
            pnlLeftGradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCloudBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCodewaveLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftMainImage).BeginInit();
            pnlRight.SuspendLayout();
            pnlFormContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbItemIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFavorite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyePass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHelpGenerate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHelpCopy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHelpNotes).BeginInit();
            pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapseIntoWindow).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMain.Controls.Add(pnlLeftGradient, 0, 0);
            tlpMain.Controls.Add(pnlRight, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1280, 720);
            tlpMain.TabIndex = 0;
            // 
            // pnlLeftGradient
            // 
            pnlLeftGradient.Controls.Add(pbCloudBackground);
            pnlLeftGradient.Controls.Add(pbCodewaveLogo);
            pnlLeftGradient.Controls.Add(lblInfoDesc);
            pnlLeftGradient.Controls.Add(lblInfoTitle);
            pnlLeftGradient.Controls.Add(pbLeftMainImage);
            pnlLeftGradient.Dock = DockStyle.Fill;
            pnlLeftGradient.gradientBottom = Color.FromArgb(123, 84, 195);
            pnlLeftGradient.gradientTop = Color.FromArgb(55, 20, 100);
            pnlLeftGradient.Location = new Point(3, 3);
            pnlLeftGradient.Name = "pnlLeftGradient";
            pnlLeftGradient.Size = new Size(506, 714);
            pnlLeftGradient.TabIndex = 0;
            // 
            // pbCloudBackground
            // 
            pbCloudBackground.BackColor = Color.Transparent;
            pbCloudBackground.Dock = DockStyle.Right;
            pbCloudBackground.Location = new Point(306, 0);
            pbCloudBackground.Name = "pbCloudBackground";
            pbCloudBackground.Size = new Size(200, 714);
            pbCloudBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCloudBackground.TabIndex = 0;
            pbCloudBackground.TabStop = false;
            // 
            // pbCodewaveLogo
            // 
            pbCodewaveLogo.BackColor = Color.Transparent;
            pbCodewaveLogo.Location = new Point(20, 20);
            pbCodewaveLogo.Name = "pbCodewaveLogo";
            pbCodewaveLogo.Size = new Size(180, 60);
            pbCodewaveLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbCodewaveLogo.TabIndex = 1;
            pbCodewaveLogo.TabStop = false;
            // 
            // lblInfoDesc
            // 
            lblInfoDesc.BackColor = Color.Transparent;
            lblInfoDesc.Font = new Font("Segoe UI", 11F);
            lblInfoDesc.ForeColor = Color.White;
            lblInfoDesc.Location = new Point(150, 550);
            lblInfoDesc.Name = "lblInfoDesc";
            lblInfoDesc.Size = new Size(300, 150);
            lblInfoDesc.TabIndex = 2;
            lblInfoDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblInfoTitle
            // 
            lblInfoTitle.BackColor = Color.Transparent;
            lblInfoTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblInfoTitle.ForeColor = Color.White;
            lblInfoTitle.Location = new Point(161, 496);
            lblInfoTitle.Name = "lblInfoTitle";
            lblInfoTitle.Size = new Size(300, 37);
            lblInfoTitle.TabIndex = 3;
            lblInfoTitle.Text = "РЕДАГУВАННЯ";
            lblInfoTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbLeftMainImage
            // 
            pbLeftMainImage.BackColor = Color.Transparent;
            pbLeftMainImage.Location = new Point(162, 200);
            pbLeftMainImage.Name = "pbLeftMainImage";
            pbLeftMainImage.Size = new Size(300, 250);
            pbLeftMainImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbLeftMainImage.TabIndex = 4;
            pbLeftMainImage.TabStop = false;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(pnlFormContent);
            pnlRight.Controls.Add(pnlTopBar);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(515, 3);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(762, 714);
            pnlRight.TabIndex = 1;
            // 
            // pnlFormContent
            // 
            pnlFormContent.Anchor = AnchorStyles.None;
            pnlFormContent.Controls.Add(lblMainHeader);
            pnlFormContent.Controls.Add(pbItemIcon);
            pnlFormContent.Controls.Add(btnUploadIcon);
            pnlFormContent.Controls.Add(pbFavorite);
            pnlFormContent.Controls.Add(lblFavoriteText);
            pnlFormContent.Controls.Add(txtTitle);
            pnlFormContent.Controls.Add(dropdownCategory);
            pnlFormContent.Controls.Add(txtUsername);
            pnlFormContent.Controls.Add(txtPassword);
            pnlFormContent.Controls.Add(btnGenerate);
            pnlFormContent.Controls.Add(pbEyePass);
            pnlFormContent.Controls.Add(pbHelpGenerate);
            pnlFormContent.Controls.Add(txtConfirmPassword);
            pnlFormContent.Controls.Add(btnCopyPass);
            pnlFormContent.Controls.Add(pbHelpCopy);
            pnlFormContent.Controls.Add(txtUrl);
            pnlFormContent.Controls.Add(txtNotes);
            pnlFormContent.Controls.Add(pbHelpNotes);
            pnlFormContent.Controls.Add(btnSave);
            pnlFormContent.Controls.Add(btnCancel);
            pnlFormContent.Location = new Point(81, 60);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.Size = new Size(660, 740);
            pnlFormContent.TabIndex = 1;
            // 
            // lblMainHeader
            // 
            lblMainHeader.AutoSize = true;
            lblMainHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMainHeader.Location = new Point(0, 0);
            lblMainHeader.Name = "lblMainHeader";
            lblMainHeader.Size = new Size(347, 46);
            lblMainHeader.TabIndex = 0;
            lblMainHeader.Text = "Редагування запису";
            // 
            // pbItemIcon
            // 
            pbItemIcon.Location = new Point(0, 550);
            pbItemIcon.Name = "pbItemIcon";
            pbItemIcon.Size = new Size(60, 60);
            pbItemIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemIcon.TabIndex = 1;
            pbItemIcon.TabStop = false;
            // 
            // btnUploadIcon
            // 
            btnUploadIcon.BackColor = Color.FromArgb(123, 84, 195);
            btnUploadIcon.BackgroundColor = Color.FromArgb(123, 84, 195);
            btnUploadIcon.BorderColor = Color.PaleVioletRed;
            btnUploadIcon.BorderRadius = 15;
            btnUploadIcon.BorderSize = 0;
            btnUploadIcon.FlatStyle = FlatStyle.Flat;
            btnUploadIcon.ForeColor = Color.White;
            btnUploadIcon.IconSize = 30;
            btnUploadIcon.Location = new Point(70, 560);
            btnUploadIcon.Name = "btnUploadIcon";
            btnUploadIcon.Size = new Size(160, 40);
            btnUploadIcon.TabIndex = 2;
            btnUploadIcon.Text = "    Змінити іконку";
            btnUploadIcon.TextColor = Color.White;
            btnUploadIcon.UseVisualStyleBackColor = false;
            // 
            // pbFavorite
            // 
            pbFavorite.Cursor = Cursors.Hand;
            pbFavorite.Location = new Point(200, 620);
            pbFavorite.Name = "pbFavorite";
            pbFavorite.Size = new Size(35, 35);
            pbFavorite.SizeMode = PictureBoxSizeMode.Zoom;
            pbFavorite.TabIndex = 3;
            pbFavorite.TabStop = false;
            // 
            // lblFavoriteText
            // 
            lblFavoriteText.AutoSize = true;
            lblFavoriteText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFavoriteText.ForeColor = Color.Gray;
            lblFavoriteText.Location = new Point(0, 625);
            lblFavoriteText.Name = "lblFavoriteText";
            lblFavoriteText.Size = new Size(203, 25);
            lblFavoriteText.TabIndex = 4;
            lblFavoriteText.Text = "Додати в улюблене?";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(33, 45, 245);
            txtTitle.isPassword = false;
            txtTitle.label = "Назва сайту";
            txtTitle.Location = new Point(0, 60);
            txtTitle.Name = "txtTitle";
            txtTitle.Padding = new Padding(0, 0, 0, 1);
            txtTitle.Size = new Size(600, 55);
            txtTitle.TabIndex = 5;
            // 
            // dropdownCategory
            // 
            dropdownCategory.ArrowIcon = null;
            dropdownCategory.BackColor = Color.White;
            dropdownCategory.Location = new Point(0, 130);
            dropdownCategory.MainIcon = null;
            dropdownCategory.Name = "dropdownCategory";
            dropdownCategory.SelectedText = "   Select...";
            dropdownCategory.Size = new Size(600, 40);
            dropdownCategory.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(33, 45, 245);
            txtUsername.isPassword = false;
            txtUsername.label = "Ім'я користувача / Пошта";
            txtUsername.Location = new Point(0, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(0, 0, 0, 1);
            txtUsername.Size = new Size(600, 55);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(33, 45, 245);
            txtPassword.isPassword = true;
            txtPassword.label = "Пароль";
            txtPassword.Location = new Point(0, 270);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(0, 0, 0, 1);
            txtPassword.Size = new Size(370, 55);
            txtPassword.TabIndex = 8;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(123, 84, 195);
            btnGenerate.BackgroundColor = Color.FromArgb(123, 84, 195);
            btnGenerate.BorderColor = Color.PaleVioletRed;
            btnGenerate.BorderRadius = 15;
            btnGenerate.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.ForeColor = Color.White;
            btnGenerate.IconSize = 30;
            btnGenerate.Location = new Point(380, 280);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(120, 40);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "  Генерувати";
            btnGenerate.TextColor = Color.White;
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // pbEyePass
            // 
            pbEyePass.Cursor = Cursors.Hand;
            pbEyePass.Location = new Point(510, 285);
            pbEyePass.Name = "pbEyePass";
            pbEyePass.Size = new Size(25, 25);
            pbEyePass.SizeMode = PictureBoxSizeMode.Zoom;
            pbEyePass.TabIndex = 10;
            pbEyePass.TabStop = false;
            // 
            // pbHelpGenerate
            // 
            pbHelpGenerate.Cursor = Cursors.Hand;
            pbHelpGenerate.Location = new Point(550, 285);
            pbHelpGenerate.Name = "pbHelpGenerate";
            pbHelpGenerate.Size = new Size(25, 25);
            pbHelpGenerate.SizeMode = PictureBoxSizeMode.Zoom;
            pbHelpGenerate.TabIndex = 11;
            pbHelpGenerate.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(33, 45, 245);
            txtConfirmPassword.isPassword = true;
            txtConfirmPassword.label = "Підтвердження паролю";
            txtConfirmPassword.Location = new Point(0, 340);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Padding = new Padding(0, 0, 0, 1);
            txtConfirmPassword.Size = new Size(370, 55);
            txtConfirmPassword.TabIndex = 12;
            // 
            // btnCopyPass
            // 
            btnCopyPass.BackColor = Color.FromArgb(123, 84, 195);
            btnCopyPass.BackgroundColor = Color.FromArgb(123, 84, 195);
            btnCopyPass.BorderColor = Color.PaleVioletRed;
            btnCopyPass.BorderRadius = 15;
            btnCopyPass.BorderSize = 0;
            btnCopyPass.FlatStyle = FlatStyle.Flat;
            btnCopyPass.ForeColor = Color.White;
            btnCopyPass.IconSize = 30;
            btnCopyPass.Location = new Point(380, 350);
            btnCopyPass.Name = "btnCopyPass";
            btnCopyPass.Size = new Size(154, 40);
            btnCopyPass.TabIndex = 13;
            btnCopyPass.Text = "       Копіювати";
            btnCopyPass.TextColor = Color.White;
            btnCopyPass.UseVisualStyleBackColor = false;
            // 
            // pbHelpCopy
            // 
            pbHelpCopy.Cursor = Cursors.Hand;
            pbHelpCopy.Location = new Point(550, 355);
            pbHelpCopy.Name = "pbHelpCopy";
            pbHelpCopy.Size = new Size(25, 25);
            pbHelpCopy.SizeMode = PictureBoxSizeMode.Zoom;
            pbHelpCopy.TabIndex = 14;
            pbHelpCopy.TabStop = false;
            // 
            // txtUrl
            // 
            txtUrl.BackColor = Color.FromArgb(33, 45, 245);
            txtUrl.isPassword = false;
            txtUrl.label = "Веб-сайт (URL)";
            txtUrl.Location = new Point(0, 410);
            txtUrl.Name = "txtUrl";
            txtUrl.Padding = new Padding(0, 0, 0, 1);
            txtUrl.Size = new Size(600, 55);
            txtUrl.TabIndex = 15;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(33, 45, 245);
            txtNotes.isPassword = false;
            txtNotes.label = "Нотатки";
            txtNotes.Location = new Point(0, 480);
            txtNotes.Name = "txtNotes";
            txtNotes.Padding = new Padding(0, 0, 0, 1);
            txtNotes.Size = new Size(534, 55);
            txtNotes.TabIndex = 16;
            // 
            // pbHelpNotes
            // 
            pbHelpNotes.Cursor = Cursors.Hand;
            pbHelpNotes.Location = new Point(540, 495);
            pbHelpNotes.Name = "pbHelpNotes";
            pbHelpNotes.Size = new Size(25, 25);
            pbHelpNotes.SizeMode = PictureBoxSizeMode.Zoom;
            pbHelpNotes.TabIndex = 17;
            pbHelpNotes.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(123, 84, 195);
            btnSave.BackgroundColor = Color.FromArgb(123, 84, 195);
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 20;
            btnSave.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.IconSize = 30;
            btnSave.Location = new Point(0, 680);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(290, 50);
            btnSave.TabIndex = 18;
            btnSave.Text = "         Зберегти зміни";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(240, 240, 240);
            btnCancel.BackgroundColor = Color.FromArgb(240, 240, 240);
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 20;
            btnCancel.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Black;
            btnCancel.IconSize = 30;
            btnCancel.Location = new Point(310, 680);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(290, 50);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "              Скасувати";
            btnCancel.TextColor = Color.Black;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnlTopBar
            // 
            pnlTopBar.Controls.Add(pbClose);
            pnlTopBar.Controls.Add(pbCollapse);
            pnlTopBar.Controls.Add(pbCollapseIntoWindow);
            pnlTopBar.Controls.Add(lblWindowTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(762, 50);
            pnlTopBar.TabIndex = 1;
            // 
            // pbClose
            // 
            pbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(710, 12);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(25, 25);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 0;
            pbClose.TabStop = false;
            // 
            // pbCollapse
            // 
            pbCollapse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbCollapse.Image = (Image)resources.GetObject("pbCollapse.Image");
            pbCollapse.Location = new Point(630, 12);
            pbCollapse.Name = "pbCollapse";
            pbCollapse.Size = new Size(25, 25);
            pbCollapse.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCollapse.TabIndex = 1;
            pbCollapse.TabStop = false;
            // 
            // pbCollapseIntoWindow
            // 
            pbCollapseIntoWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbCollapseIntoWindow.Image = (Image)resources.GetObject("pbCollapseIntoWindow.Image");
            pbCollapseIntoWindow.Location = new Point(670, 12);
            pbCollapseIntoWindow.Name = "pbCollapseIntoWindow";
            pbCollapseIntoWindow.Size = new Size(25, 25);
            pbCollapseIntoWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCollapseIntoWindow.TabIndex = 2;
            pbCollapseIntoWindow.TabStop = false;
            // 
            // lblWindowTitle
            // 
            lblWindowTitle.AutoSize = true;
            lblWindowTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWindowTitle.ForeColor = Color.Gray;
            lblWindowTitle.Location = new Point(20, 15);
            lblWindowTitle.Name = "lblWindowTitle";
            lblWindowTitle.Size = new Size(173, 23);
            lblWindowTitle.TabIndex = 3;
            lblWindowTitle.Text = "Редагування запису";
            // 
            // EditItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(tlpMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditItemForm";
            Text = "Edit Item";
            WindowState = FormWindowState.Maximized;
            tlpMain.ResumeLayout(false);
            pnlLeftGradient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCloudBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCodewaveLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftMainImage).EndInit();
            pnlRight.ResumeLayout(false);
            pnlFormContent.ResumeLayout(false);
            pnlFormContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbItemIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFavorite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyePass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHelpGenerate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHelpCopy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHelpNotes).EndInit();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapseIntoWindow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private PasswordManager.additionalClasses.GradientPanel pnlLeftGradient;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlFormContent;
        private System.Windows.Forms.PictureBox pbCodewaveLogo;
        private System.Windows.Forms.PictureBox pbLeftMainImage;
        private System.Windows.Forms.PictureBox pbCloudBackground;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblInfoDesc;
        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbCollapse;
        private System.Windows.Forms.PictureBox pbCollapseIntoWindow;
        private System.Windows.Forms.Label lblMainHeader;
        private PasswordManager.personalizedTools.LoginTextBox txtTitle;
        private PasswordManager.personalizedTools.ModernDropdown dropdownCategory;
        private PasswordManager.personalizedTools.LoginTextBox txtUsername;
        private PasswordManager.personalizedTools.LoginTextBox txtPassword;
        private PasswordManager.personalizedTools.LoginTextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pbEyePass;
        private PasswordManager.additionalClasses.RoundedButton btnGenerate;
        private PasswordManager.additionalClasses.RoundedButton btnCopyPass;
        private PasswordManager.personalizedTools.LoginTextBox txtUrl;
        private PasswordManager.personalizedTools.LoginTextBox txtNotes;
        private PasswordManager.additionalClasses.RoundedButton btnSave;
        private PasswordManager.additionalClasses.RoundedButton btnCancel;
        private System.Windows.Forms.PictureBox pbHelpGenerate;
        private System.Windows.Forms.PictureBox pbHelpCopy;
        private System.Windows.Forms.PictureBox pbHelpNotes;
        private System.Windows.Forms.PictureBox pbItemIcon;
        private PasswordManager.additionalClasses.RoundedButton btnUploadIcon;
        private System.Windows.Forms.Label lblFavoriteText;
        private System.Windows.Forms.PictureBox pbFavorite;
    }
}