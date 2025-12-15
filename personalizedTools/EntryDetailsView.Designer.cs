using System.Windows.Forms;
using System.Drawing;
using PasswordManager.additionalClasses;

namespace PasswordManager.personalizedTools
{
    partial class EntryDetailsView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblHeaderUser = new Label();
            btnEdit = new RoundedButton();
            btnDelete = new RoundedButton();
            pbFavorite = new PictureBox();
            pbMainIcon = new PictureBox();
            lblSiteName = new Label();
            lblUserLabel = new Label();
            lblUserValue = new Label();
            pbCopyUser = new PictureBox();
            lblPassLabel = new Label();
            lblPassValue = new Label();
            pbCopyPass = new PictureBox();
            pbEyePass = new PictureBox();
            lblWebLabel = new Label();
            lnkWebsite = new LinkLabel();
            pnlSecurity = new Panel();
            pbSecurityIcon = new PictureBox();
            lblSecurityLevel = new Label();
            lblSecurityMsg = new Label();
            pnlHistory = new Panel();
            pbHistoryArrow = new PictureBox();
            lblHistoryTitle = new Label();
            lblHistoryDate = new Label();
            pnlHistoryList = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbFavorite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMainIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCopyUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCopyPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyePass).BeginInit();
            pnlSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSecurityIcon).BeginInit();
            pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHistoryArrow).BeginInit();
            SuspendLayout();
            // 
            // lblHeaderUser
            // 
            lblHeaderUser.AutoSize = true;
            lblHeaderUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderUser.ForeColor = Color.Gray;
            lblHeaderUser.Location = new Point(30, 40);
            lblHeaderUser.Name = "lblHeaderUser";
            lblHeaderUser.Size = new Size(88, 23);
            lblHeaderUser.TabIndex = 32;
            lblHeaderUser.Text = "Мій сейф";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(123, 84, 195);
            btnEdit.BackgroundColor = Color.FromArgb(123, 84, 195);
            btnEdit.BorderColor = Color.Transparent;
            btnEdit.BorderRadius = 15;
            btnEdit.BorderSize = 0;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F);
            btnEdit.ForeColor = Color.White;
            btnEdit.IconSize = 20;
            btnEdit.Location = new Point(420, 35);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(170, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "  Редагувати";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.TextColor = Color.White;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(240, 240, 240);
            btnDelete.BackgroundColor = Color.FromArgb(240, 240, 240);
            btnDelete.BorderColor = Color.Transparent;
            btnDelete.BorderRadius = 15;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.IconSize = 20;
            btnDelete.Location = new Point(245, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 40);
            btnDelete.TabIndex = 21;
            btnDelete.Text = " Видалити";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.TextColor = Color.Black;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // pbFavorite
            // 
            pbFavorite.Cursor = Cursors.Hand;
            pbFavorite.Location = new Point(120, 38);
            pbFavorite.Name = "pbFavorite";
            pbFavorite.Size = new Size(25, 25);
            pbFavorite.SizeMode = PictureBoxSizeMode.Zoom;
            pbFavorite.TabIndex = 20;
            pbFavorite.TabStop = false;
            // 
            // pbMainIcon
            // 
            pbMainIcon.Location = new Point(30, 90);
            pbMainIcon.Name = "pbMainIcon";
            pbMainIcon.Size = new Size(60, 60);
            pbMainIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbMainIcon.TabIndex = 2;
            pbMainIcon.TabStop = false;
            // 
            // lblSiteName
            // 
            lblSiteName.AutoSize = true;
            lblSiteName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSiteName.Location = new Point(110, 100);
            lblSiteName.Name = "lblSiteName";
            lblSiteName.Size = new Size(149, 37);
            lblSiteName.TabIndex = 31;
            lblSiteName.Text = "Site Name";
            // 
            // lblUserLabel
            // 
            lblUserLabel.AutoSize = true;
            lblUserLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserLabel.ForeColor = Color.FromArgb(123, 92, 214);
            lblUserLabel.Location = new Point(50, 185);
            lblUserLabel.Name = "lblUserLabel";
            lblUserLabel.Size = new Size(227, 20);
            lblUserLabel.TabIndex = 30;
            lblUserLabel.Text = "ІМ'Я КОРИСТУВАЧА / ПОШТА";
            // 
            // lblUserValue
            // 
            lblUserValue.AutoSize = true;
            lblUserValue.Font = new Font("Segoe UI", 12F);
            lblUserValue.Location = new Point(50, 205);
            lblUserValue.Name = "lblUserValue";
            lblUserValue.Size = new Size(48, 28);
            lblUserValue.TabIndex = 29;
            lblUserValue.Text = "user";
            // 
            // pbCopyUser
            // 
            pbCopyUser.Cursor = Cursors.Hand;
            pbCopyUser.Location = new Point(540, 200);
            pbCopyUser.Name = "pbCopyUser";
            pbCopyUser.Size = new Size(20, 20);
            pbCopyUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbCopyUser.TabIndex = 28;
            pbCopyUser.TabStop = false;
            // 
            // lblPassLabel
            // 
            lblPassLabel.AutoSize = true;
            lblPassLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassLabel.ForeColor = Color.FromArgb(123, 92, 214);
            lblPassLabel.Location = new Point(50, 255);
            lblPassLabel.Name = "lblPassLabel";
            lblPassLabel.Size = new Size(71, 20);
            lblPassLabel.TabIndex = 27;
            lblPassLabel.Text = "ПАРОЛЬ";
            // 
            // lblPassValue
            // 
            lblPassValue.AutoSize = true;
            lblPassValue.Font = new Font("Segoe UI", 12F);
            lblPassValue.Location = new Point(50, 275);
            lblPassValue.Name = "lblPassValue";
            lblPassValue.Size = new Size(92, 28);
            lblPassValue.TabIndex = 26;
            lblPassValue.Text = "••••••••••";
            // 
            // pbCopyPass
            // 
            pbCopyPass.Cursor = Cursors.Hand;
            pbCopyPass.Location = new Point(540, 270);
            pbCopyPass.Name = "pbCopyPass";
            pbCopyPass.Size = new Size(20, 20);
            pbCopyPass.SizeMode = PictureBoxSizeMode.Zoom;
            pbCopyPass.TabIndex = 25;
            pbCopyPass.TabStop = false;
            // 
            // pbEyePass
            // 
            pbEyePass.Cursor = Cursors.Hand;
            pbEyePass.Location = new Point(500, 270);
            pbEyePass.Name = "pbEyePass";
            pbEyePass.Size = new Size(20, 20);
            pbEyePass.SizeMode = PictureBoxSizeMode.Zoom;
            pbEyePass.TabIndex = 24;
            pbEyePass.TabStop = false;
            // 
            // lblWebLabel
            // 
            lblWebLabel.AutoSize = true;
            lblWebLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWebLabel.ForeColor = Color.FromArgb(123, 92, 214);
            lblWebLabel.Location = new Point(30, 340);
            lblWebLabel.Name = "lblWebLabel";
            lblWebLabel.Size = new Size(84, 20);
            lblWebLabel.TabIndex = 23;
            lblWebLabel.Text = "ВЕБ-САЙТ";
            // 
            // lnkWebsite
            // 
            lnkWebsite.AutoSize = true;
            lnkWebsite.Font = new Font("Segoe UI", 12F);
            lnkWebsite.LinkColor = Color.FromArgb(33, 145, 245);
            lnkWebsite.Location = new Point(30, 360);
            lnkWebsite.Name = "lnkWebsite";
            lnkWebsite.Size = new Size(192, 28);
            lnkWebsite.TabIndex = 22;
            lnkWebsite.TabStop = true;
            lnkWebsite.Text = "https://example.com";
            // 
            // pnlSecurity
            // 
            pnlSecurity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSecurity.BackColor = Color.Transparent;
            pnlSecurity.Controls.Add(pbSecurityIcon);
            pnlSecurity.Controls.Add(lblSecurityLevel);
            pnlSecurity.Controls.Add(lblSecurityMsg);
            pnlSecurity.Location = new Point(30, 410);
            pnlSecurity.Name = "pnlSecurity";
            pnlSecurity.Size = new Size(560, 60);
            pnlSecurity.TabIndex = 12;
            // 
            // pbSecurityIcon
            // 
            pbSecurityIcon.Location = new Point(15, 15);
            pbSecurityIcon.Name = "pbSecurityIcon";
            pbSecurityIcon.Size = new Size(30, 30);
            pbSecurityIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbSecurityIcon.TabIndex = 0;
            pbSecurityIcon.TabStop = false;
            // 
            // lblSecurityLevel
            // 
            lblSecurityLevel.AutoSize = true;
            lblSecurityLevel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSecurityLevel.Location = new Point(60, 10);
            lblSecurityLevel.Name = "lblSecurityLevel";
            lblSecurityLevel.Size = new Size(73, 25);
            lblSecurityLevel.TabIndex = 1;
            lblSecurityLevel.Text = "Рівень";
            // 
            // lblSecurityMsg
            // 
            lblSecurityMsg.AutoSize = true;
            lblSecurityMsg.Font = new Font("Segoe UI", 9F);
            lblSecurityMsg.ForeColor = Color.Gray;
            lblSecurityMsg.Location = new Point(60, 32);
            lblSecurityMsg.Name = "lblSecurityMsg";
            lblSecurityMsg.Size = new Size(45, 20);
            lblSecurityMsg.TabIndex = 2;
            lblSecurityMsg.Text = "Опис";
            // 
            // pnlHistory
            // 
            pnlHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHistory.Controls.Add(pbHistoryArrow);
            pnlHistory.Controls.Add(lblHistoryTitle);
            pnlHistory.Controls.Add(lblHistoryDate);
            pnlHistory.Controls.Add(pnlHistoryList);
            pnlHistory.Location = new Point(30, 490);
            pnlHistory.Name = "pnlHistory";
            pnlHistory.Size = new Size(560, 200);
            pnlHistory.TabIndex = 13;
            // 
            // pbHistoryArrow
            // 
            pbHistoryArrow.Cursor = Cursors.Hand;
            pbHistoryArrow.Location = new Point(5, 5);
            pbHistoryArrow.Name = "pbHistoryArrow";
            pbHistoryArrow.Size = new Size(15, 15);
            pbHistoryArrow.SizeMode = PictureBoxSizeMode.Zoom;
            pbHistoryArrow.TabIndex = 0;
            pbHistoryArrow.TabStop = false;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHistoryTitle.Location = new Point(30, 3);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(151, 20);
            lblHistoryTitle.TabIndex = 1;
            lblHistoryTitle.Text = "Останнє оновлення";
            // 
            // lblHistoryDate
            // 
            lblHistoryDate.AutoSize = true;
            lblHistoryDate.Font = new Font("Segoe UI", 9F);
            lblHistoryDate.Location = new Point(200, 3);
            lblHistoryDate.Name = "lblHistoryDate";
            lblHistoryDate.Size = new Size(79, 20);
            lblHistoryDate.TabIndex = 2;
            lblHistoryDate.Text = "01.01.2023";
            // 
            // pnlHistoryList
            // 
            pnlHistoryList.Location = new Point(30, 30);
            pnlHistoryList.Name = "pnlHistoryList";
            pnlHistoryList.Size = new Size(500, 100);
            pnlHistoryList.TabIndex = 3;
            pnlHistoryList.Visible = false;
            // 
            // btnRestore (Кнопка відновлення - зелена або синя)
            //
            this.btnRestore = new PasswordManager.additionalClasses.RoundedButton();
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(33, 145, 245); // Синій
            this.btnRestore.BackgroundColor = System.Drawing.Color.FromArgb(33, 145, 245);
            this.btnRestore.BorderColor = System.Drawing.Color.Transparent;
            this.btnRestore.BorderRadius = 15;
            this.btnRestore.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.IconSize = 20;
            this.btnRestore.Location = new System.Drawing.Point(420, 35); // Там же, де btnEdit
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(170, 40);
            this.btnRestore.TabIndex = 25;
            this.btnRestore.Text = "   Відновити";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.TextColor = System.Drawing.Color.White;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Visible = false;
            // 
            // EntryDetailsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnDelete);
            Controls.Add(pbFavorite);
            Controls.Add(pnlHistory);
            Controls.Add(pnlSecurity);
            Controls.Add(lnkWebsite);
            Controls.Add(lblWebLabel);
            Controls.Add(pbEyePass);
            Controls.Add(pbCopyPass);
            Controls.Add(lblPassValue);
            Controls.Add(lblPassLabel);
            Controls.Add(pbCopyUser);
            Controls.Add(lblUserValue);
            Controls.Add(lblUserLabel);
            Controls.Add(lblSiteName);
            Controls.Add(pbMainIcon);
            Controls.Add(btnEdit);
            Controls.Add(lblHeaderUser);
            this.Controls.Add(this.btnRestore);
            Name = "EntryDetailsView";
            Size = new Size(620, 700);
            ((System.ComponentModel.ISupportInitialize)pbFavorite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMainIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCopyUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCopyPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyePass).EndInit();
            pnlSecurity.ResumeLayout(false);
            pnlSecurity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSecurityIcon).EndInit();
            pnlHistory.ResumeLayout(false);
            pnlHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHistoryArrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeaderUser;
        private RoundedButton btnEdit;
        private RoundedButton btnDelete;
        private System.Windows.Forms.PictureBox pbFavorite;

        private System.Windows.Forms.PictureBox pbMainIcon;
        private System.Windows.Forms.Label lblSiteName;
        private System.Windows.Forms.Label lblUserLabel;
        private System.Windows.Forms.Label lblUserValue;
        private System.Windows.Forms.PictureBox pbCopyUser;
        private System.Windows.Forms.Label lblPassLabel;
        private System.Windows.Forms.Label lblPassValue;
        private System.Windows.Forms.PictureBox pbCopyPass;
        private System.Windows.Forms.PictureBox pbEyePass;
        private System.Windows.Forms.Label lblWebLabel;
        private System.Windows.Forms.LinkLabel lnkWebsite;
        private System.Windows.Forms.Panel pnlSecurity;
        private System.Windows.Forms.PictureBox pbSecurityIcon;
        private System.Windows.Forms.Label lblSecurityLevel;
        private System.Windows.Forms.Label lblSecurityMsg;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.PictureBox pbHistoryArrow;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.Label lblHistoryDate;
        private System.Windows.Forms.Panel pnlHistoryList;
        private PasswordManager.additionalClasses.RoundedButton btnRestore;
    }
}