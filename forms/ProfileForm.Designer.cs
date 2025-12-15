using PasswordManager.additionalClasses;
using PasswordManager.personalizedTools;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            tlpMain = new TableLayoutPanel();
            pnlLeft = new GradientPanel();
            pnlUserContainer = new Panel();
            pbUserAvatar = new PictureBox();
            lblUsername = new Label();
            pbDecorationLeft = new PictureBox();
            pnlRight = new Panel();
            pnlContent = new Panel();
            lblHeader = new Label();
            lblEmailTitle = new Label();
            lblEmailValue = new Label();
            pnlDivider1 = new Panel();
            lblCountTitle = new Label();
            lblCountValue = new Label();
            pnlDivider2 = new Panel();
            lblLastUpdateTitle = new Label();
            lblLastUpdateValue = new Label();
            pnlDivider3 = new Panel();
            btnLogout = new RoundedButton();
            pnlTopBar = new Panel();
            pbClose = new PictureBox();
            pbCollapse = new PictureBox();
            pbCollapseIntoWindow = new PictureBox();
            lblBack = new Label();
            tlpMain.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlUserContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDecorationLeft).BeginInit();
            pnlRight.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapseIntoWindow).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpMain.Controls.Add(pnlLeft, 0, 0);
            tlpMain.Controls.Add(pnlRight, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1280, 720);
            tlpMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(pnlUserContainer);
            pnlLeft.Controls.Add(pbDecorationLeft);
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.gradientBottom = Color.FromArgb(123, 84, 195);
            pnlLeft.gradientTop = Color.FromArgb(55, 20, 100);
            pnlLeft.Location = new Point(3, 3);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(570, 714);
            pnlLeft.TabIndex = 0;
            // 
            // pnlUserContainer
            // 
            pnlUserContainer.BackColor = Color.Transparent;
            pnlUserContainer.Controls.Add(pbUserAvatar);
            pnlUserContainer.Controls.Add(lblUsername);
            pnlUserContainer.Location = new Point(50, 200);
            pnlUserContainer.Name = "pnlUserContainer";
            pnlUserContainer.Size = new Size(400, 300);
            pnlUserContainer.TabIndex = 5;
            // 
            // pbUserAvatar
            // 
            pbUserAvatar.BackColor = Color.Transparent;
            pbUserAvatar.Location = new Point(100, 0);
            pbUserAvatar.Name = "pbUserAvatar";
            pbUserAvatar.Size = new Size(200, 200);
            pbUserAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserAvatar.TabIndex = 0;
            pbUserAvatar.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(0, 210);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(400, 60);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbDecorationLeft
            // 
            pbDecorationLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbDecorationLeft.BackColor = Color.Transparent;
            pbDecorationLeft.Location = new Point(370, 0);
            pbDecorationLeft.Name = "pbDecorationLeft";
            pbDecorationLeft.Size = new Size(200, 714);
            pbDecorationLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDecorationLeft.TabIndex = 4;
            pbDecorationLeft.TabStop = false;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(pnlContent);
            pnlRight.Controls.Add(pnlTopBar);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(579, 3);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(698, 714);
            pnlRight.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.None;
            pnlContent.Controls.Add(lblHeader);
            pnlContent.Controls.Add(lblEmailTitle);
            pnlContent.Controls.Add(lblEmailValue);
            pnlContent.Controls.Add(pnlDivider1);
            pnlContent.Controls.Add(lblCountTitle);
            pnlContent.Controls.Add(lblCountValue);
            pnlContent.Controls.Add(pnlDivider2);
            pnlContent.Controls.Add(lblLastUpdateTitle);
            pnlContent.Controls.Add(lblLastUpdateValue);
            pnlContent.Controls.Add(pnlDivider3);
            pnlContent.Controls.Add(btnLogout);
            pnlContent.Location = new Point(124, 77);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(450, 550);
            pnlContent.TabIndex = 1;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(50, 50, 50);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(276, 54);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Мій Профіль";
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmailTitle.ForeColor = Color.Gray;
            lblEmailTitle.Location = new Point(0, 80);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(191, 23);
            lblEmailTitle.TabIndex = 1;
            lblEmailTitle.Text = "ЕЛЕКТРОННА ПОШТА";
            // 
            // lblEmailValue
            // 
            lblEmailValue.AutoSize = true;
            lblEmailValue.Font = new Font("Segoe UI", 14F);
            lblEmailValue.ForeColor = Color.Black;
            lblEmailValue.Location = new Point(0, 110);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(236, 32);
            lblEmailValue.TabIndex = 2;
            lblEmailValue.Text = "email@example.com";
            // 
            // pnlDivider1
            // 
            pnlDivider1.BackColor = Color.FromArgb(240, 240, 240);
            pnlDivider1.Location = new Point(0, 150);
            pnlDivider1.Name = "pnlDivider1";
            pnlDivider1.Size = new Size(450, 2);
            pnlDivider1.TabIndex = 6;
            // 
            // lblCountTitle
            // 
            lblCountTitle.AutoSize = true;
            lblCountTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCountTitle.ForeColor = Color.Gray;
            lblCountTitle.Location = new Point(0, 180);
            lblCountTitle.Name = "lblCountTitle";
            lblCountTitle.Size = new Size(180, 23);
            lblCountTitle.TabIndex = 7;
            lblCountTitle.Text = "ЗБЕРЕЖЕНІ ЗАПИСИ";
            // 
            // lblCountValue
            // 
            lblCountValue.AutoSize = true;
            lblCountValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCountValue.ForeColor = Color.FromArgb(123, 84, 195);
            lblCountValue.Location = new Point(0, 210);
            lblCountValue.Name = "lblCountValue";
            lblCountValue.Size = new Size(42, 32);
            lblCountValue.TabIndex = 8;
            lblCountValue.Text = "42";
            // 
            // pnlDivider2
            // 
            pnlDivider2.BackColor = Color.FromArgb(240, 240, 240);
            pnlDivider2.Location = new Point(0, 250);
            pnlDivider2.Name = "pnlDivider2";
            pnlDivider2.Size = new Size(450, 2);
            pnlDivider2.TabIndex = 7;
            // 
            // lblLastUpdateTitle
            // 
            lblLastUpdateTitle.AutoSize = true;
            lblLastUpdateTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastUpdateTitle.ForeColor = Color.Gray;
            lblLastUpdateTitle.Location = new Point(0, 280);
            lblLastUpdateTitle.Name = "lblLastUpdateTitle";
            lblLastUpdateTitle.Size = new Size(204, 23);
            lblLastUpdateTitle.TabIndex = 9;
            lblLastUpdateTitle.Text = "ОСТАННЯ АКТИВНІСТЬ";
            // 
            // lblLastUpdateValue
            // 
            lblLastUpdateValue.AutoSize = true;
            lblLastUpdateValue.Font = new Font("Segoe UI", 14F);
            lblLastUpdateValue.ForeColor = Color.Black;
            lblLastUpdateValue.Location = new Point(0, 310);
            lblLastUpdateValue.Name = "lblLastUpdateValue";
            lblLastUpdateValue.Size = new Size(192, 32);
            lblLastUpdateValue.TabIndex = 10;
            lblLastUpdateValue.Text = "01.01.2023 12:00";
            // 
            // pnlDivider3
            // 
            pnlDivider3.BackColor = Color.FromArgb(240, 240, 240);
            pnlDivider3.Location = new Point(0, 350);
            pnlDivider3.Name = "pnlDivider3";
            pnlDivider3.Size = new Size(450, 2);
            pnlDivider3.TabIndex = 8;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 235, 238);
            btnLogout.BackgroundColor = Color.FromArgb(255, 235, 238);
            btnLogout.BorderColor = Color.Transparent;
            btnLogout.BorderRadius = 20;
            btnLogout.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.IndianRed;
            btnLogout.IconSize = 30;
            btnLogout.Location = new Point(0, 420);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(450, 50);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "   Вийти з акаунту";
            btnLogout.TextColor = Color.IndianRed;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlTopBar
            // 
            pnlTopBar.Controls.Add(pbCollapse);
            pnlTopBar.Controls.Add(pbCollapseIntoWindow);
            pnlTopBar.Controls.Add(pbClose);
            pnlTopBar.Controls.Add(lblBack);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(698, 60);
            pnlTopBar.TabIndex = 0;
            // 
            // pbClose
            // 
            pbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(661, 12);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(25, 25);
            pbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClose.TabIndex = 2;
            pbClose.TabStop = false;
            // 
            // pbCollapse
            // 
            pbCollapse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbCollapse.Cursor = Cursors.Hand;
            pbCollapse.Image = (Image)resources.GetObject("pbCollapse.Image");
            pbCollapse.Location = new Point(581, 12);
            pbCollapse.Name = "pbCollapse";
            pbCollapse.Size = new Size(25, 25);
            pbCollapse.SizeMode = PictureBoxSizeMode.Zoom;
            pbCollapse.TabIndex = 0;
            pbCollapse.TabStop = false;
            // 
            // pbCollapseIntoWindow
            // 
            pbCollapseIntoWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbCollapseIntoWindow.Cursor = Cursors.Hand;
            pbCollapseIntoWindow.Image = (Image)resources.GetObject("pbCollapseIntoWindow.Image");
            pbCollapseIntoWindow.Location = new Point(621, 12);
            pbCollapseIntoWindow.Name = "pbCollapseIntoWindow";
            pbCollapseIntoWindow.Size = new Size(25, 25);
            pbCollapseIntoWindow.SizeMode = PictureBoxSizeMode.Zoom;
            pbCollapseIntoWindow.TabIndex = 1;
            pbCollapseIntoWindow.TabStop = false;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Cursor = Cursors.Hand;
            lblBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBack.ForeColor = Color.Gray;
            lblBack.Location = new Point(30, 20);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(216, 28);
            lblBack.TabIndex = 3;
            lblBack.Text = "← Назад до головної";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(tlpMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            WindowState = FormWindowState.Maximized;
            tlpMain.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlUserContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUserAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDecorationLeft).EndInit();
            pnlRight.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapseIntoWindow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private PasswordManager.additionalClasses.GradientPanel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlUserContainer;
        private System.Windows.Forms.PictureBox pbUserAvatar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pbDecorationLeft;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbCollapse;
        private System.Windows.Forms.PictureBox pbCollapseIntoWindow;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Panel pnlDivider1;
        private System.Windows.Forms.Label lblCountTitle;
        private System.Windows.Forms.Label lblCountValue;
        private System.Windows.Forms.Panel pnlDivider2;
        private System.Windows.Forms.Label lblLastUpdateTitle;
        private System.Windows.Forms.Label lblLastUpdateValue;
        private System.Windows.Forms.Panel pnlDivider3;
        private PasswordManager.additionalClasses.RoundedButton btnLogout;
    }
}