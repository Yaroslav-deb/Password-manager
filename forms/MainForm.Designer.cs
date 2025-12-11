using PasswordManager.additionalClasses;
using PasswordManager.personalizedTools;

namespace PasswordManager.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tlpMain = new TableLayoutPanel();
            pnlLeft = new Panel();
            flpCategories = new FlowLayoutPanel();
            pnlSidebarBottom = new Panel();
            lblToolsHeader = new Label();
            btnAudit = new RoundedButton();
            btnGenerator = new RoundedButton();
            btnTrash = new RoundedButton();
            btnSettings = new RoundedButton();
            pnlSidebarTop = new Panel();
            lblUsername = new Label();
            btnProfile = new RoundedButton();
            btnAllItems = new RoundedButton();
            btnFavorites = new RoundedButton();
            pbCatArrow = new PictureBox();
            lblCatHeader = new Label();
            pnlRight = new Panel();
            tlpContent = new TableLayoutPanel();
            pnlListArea = new Panel();
            flpPasswordList = new FlowLayoutPanel();
            pnlListHeader = new Panel();
            lblHeaderAllItems = new Label();
            dropdownCategory = new ModernDropdown();
            dropdownSort = new ModernDropdown();
            pnlDetailsArea = new Panel();
            pnlTopBar = new Panel();
            btnAddItem = new RoundedButton();
            searchBar = new ModernSearchBar();
            pbCollapseIntoWindow = new PictureBox();
            pbCollapse = new PictureBox();
            pbClose = new PictureBox();
            tlpMain.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlSidebarBottom.SuspendLayout();
            pnlSidebarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCatArrow).BeginInit();
            pnlRight.SuspendLayout();
            tlpContent.SuspendLayout();
            pnlListArea.SuspendLayout();
            pnlListHeader.SuspendLayout();
            pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCollapseIntoWindow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlLeft, 0, 0);
            tlpMain.Controls.Add(pnlRight, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1280, 720);
            tlpMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(242, 242, 247);
            pnlLeft.Controls.Add(flpCategories);
            pnlLeft.Controls.Add(pnlSidebarBottom);
            pnlLeft.Controls.Add(pnlSidebarTop);
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(0, 0, 1, 0);
            pnlLeft.Size = new Size(260, 720);
            pnlLeft.TabIndex = 0;
            // 
            // flpCategories
            // 
            flpCategories.AutoScroll = true;
            flpCategories.Dock = DockStyle.Fill;
            flpCategories.FlowDirection = FlowDirection.TopDown;
            flpCategories.Location = new Point(0, 310);
            flpCategories.Name = "flpCategories";
            flpCategories.Padding = new Padding(15, 5, 0, 0);
            flpCategories.Size = new Size(259, 190);
            flpCategories.TabIndex = 2;
            flpCategories.WrapContents = false;
            // 
            // pnlSidebarBottom
            // 
            pnlSidebarBottom.BackColor = Color.Transparent;
            pnlSidebarBottom.Controls.Add(lblToolsHeader);
            pnlSidebarBottom.Controls.Add(btnAudit);
            pnlSidebarBottom.Controls.Add(btnGenerator);
            pnlSidebarBottom.Controls.Add(btnTrash);
            pnlSidebarBottom.Controls.Add(btnSettings);
            pnlSidebarBottom.Dock = DockStyle.Bottom;
            pnlSidebarBottom.Location = new Point(0, 500);
            pnlSidebarBottom.Name = "pnlSidebarBottom";
            pnlSidebarBottom.Size = new Size(259, 220);
            pnlSidebarBottom.TabIndex = 1;
            // 
            // lblToolsHeader
            // 
            lblToolsHeader.AutoSize = true;
            lblToolsHeader.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblToolsHeader.ForeColor = Color.Gray;
            lblToolsHeader.Location = new Point(20, 10);
            lblToolsHeader.Name = "lblToolsHeader";
            lblToolsHeader.Size = new Size(109, 19);
            lblToolsHeader.TabIndex = 0;
            lblToolsHeader.Text = "ІНСТРУМЕНТИ";
            // 
            // btnAudit
            // 
            btnAudit.BackColor = Color.Transparent;
            btnAudit.BackgroundColor = Color.Transparent;
            btnAudit.BorderColor = Color.PaleVioletRed;
            btnAudit.BorderRadius = 15;
            btnAudit.BorderSize = 0;
            btnAudit.FlatAppearance.BorderSize = 0;
            btnAudit.FlatStyle = FlatStyle.Flat;
            btnAudit.Font = new Font("Segoe UI Semibold", 10F);
            btnAudit.ForeColor = Color.Black;
            btnAudit.IconSize = 30;
            btnAudit.Location = new Point(12, 40);
            btnAudit.Name = "btnAudit";
            btnAudit.Size = new Size(236, 40);
            btnAudit.TabIndex = 1;
            btnAudit.Text = "   Аудит безпеки";
            btnAudit.TextAlign = ContentAlignment.MiddleLeft;
            btnAudit.TextColor = Color.Black;
            btnAudit.UseVisualStyleBackColor = false;
            // 
            // btnGenerator
            // 
            btnGenerator.BackColor = Color.Transparent;
            btnGenerator.BackgroundColor = Color.Transparent;
            btnGenerator.BorderColor = Color.PaleVioletRed;
            btnGenerator.BorderRadius = 15;
            btnGenerator.BorderSize = 0;
            btnGenerator.FlatAppearance.BorderSize = 0;
            btnGenerator.FlatStyle = FlatStyle.Flat;
            btnGenerator.Font = new Font("Segoe UI Semibold", 10F);
            btnGenerator.ForeColor = Color.Black;
            btnGenerator.IconSize = 30;
            btnGenerator.Location = new Point(12, 85);
            btnGenerator.Name = "btnGenerator";
            btnGenerator.Size = new Size(236, 40);
            btnGenerator.TabIndex = 2;
            btnGenerator.Text = "   Генератор";
            btnGenerator.TextAlign = ContentAlignment.MiddleLeft;
            btnGenerator.TextColor = Color.Black;
            btnGenerator.UseVisualStyleBackColor = false;
            // 
            // btnTrash
            // 
            btnTrash.BackColor = Color.Transparent;
            btnTrash.BackgroundColor = Color.Transparent;
            btnTrash.BorderColor = Color.PaleVioletRed;
            btnTrash.BorderRadius = 15;
            btnTrash.BorderSize = 0;
            btnTrash.FlatAppearance.BorderSize = 0;
            btnTrash.FlatStyle = FlatStyle.Flat;
            btnTrash.Font = new Font("Segoe UI Semibold", 10F);
            btnTrash.ForeColor = Color.Black;
            btnTrash.IconSize = 30;
            btnTrash.Location = new Point(12, 130);
            btnTrash.Name = "btnTrash";
            btnTrash.Size = new Size(236, 40);
            btnTrash.TabIndex = 3;
            btnTrash.Text = "   Кошик";
            btnTrash.TextAlign = ContentAlignment.MiddleLeft;
            btnTrash.TextColor = Color.Black;
            btnTrash.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.BackgroundColor = Color.Transparent;
            btnSettings.BorderColor = Color.PaleVioletRed;
            btnSettings.BorderRadius = 15;
            btnSettings.BorderSize = 0;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 10F);
            btnSettings.ForeColor = Color.Black;
            btnSettings.IconSize = 30;
            btnSettings.Location = new Point(12, 175);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(236, 40);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "   Налаштування";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextColor = Color.Black;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // pnlSidebarTop
            // 
            pnlSidebarTop.BackColor = Color.Transparent;
            pnlSidebarTop.Controls.Add(lblUsername);
            pnlSidebarTop.Controls.Add(btnProfile);
            pnlSidebarTop.Controls.Add(btnAllItems);
            pnlSidebarTop.Controls.Add(btnFavorites);
            pnlSidebarTop.Controls.Add(pbCatArrow);
            pnlSidebarTop.Controls.Add(lblCatHeader);
            pnlSidebarTop.Dock = DockStyle.Top;
            pnlSidebarTop.Location = new Point(0, 0);
            pnlSidebarTop.Name = "pnlSidebarTop";
            pnlSidebarTop.Size = new Size(259, 310);
            pnlSidebarTop.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblUsername.Location = new Point(20, 25);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(128, 32);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.BackgroundColor = Color.Transparent;
            btnProfile.BorderColor = Color.PaleVioletRed;
            btnProfile.BorderRadius = 15;
            btnProfile.BorderSize = 0;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI Semibold", 10F);
            btnProfile.ForeColor = Color.Black;
            btnProfile.IconSize = 30;
            btnProfile.Location = new Point(12, 80);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(236, 45);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "   Профіль";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.TextColor = Color.Black;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnAllItems
            // 
            btnAllItems.BackColor = Color.Transparent;
            btnAllItems.BackgroundColor = Color.Transparent;
            btnAllItems.BorderColor = Color.PaleVioletRed;
            btnAllItems.BorderRadius = 15;
            btnAllItems.BorderSize = 0;
            btnAllItems.FlatAppearance.BorderSize = 0;
            btnAllItems.FlatStyle = FlatStyle.Flat;
            btnAllItems.Font = new Font("Segoe UI Semibold", 10F);
            btnAllItems.ForeColor = Color.Black;
            btnAllItems.IconSize = 30;
            btnAllItems.Location = new Point(12, 145);
            btnAllItems.Name = "btnAllItems";
            btnAllItems.Size = new Size(236, 45);
            btnAllItems.TabIndex = 3;
            btnAllItems.Text = "   Всі записи";
            btnAllItems.TextAlign = ContentAlignment.MiddleLeft;
            btnAllItems.TextColor = Color.Black;
            btnAllItems.UseVisualStyleBackColor = false;
            // 
            // btnFavorites
            // 
            btnFavorites.BackColor = Color.Transparent;
            btnFavorites.BackgroundColor = Color.Transparent;
            btnFavorites.BorderColor = Color.PaleVioletRed;
            btnFavorites.BorderRadius = 15;
            btnFavorites.BorderSize = 0;
            btnFavorites.FlatAppearance.BorderSize = 0;
            btnFavorites.FlatStyle = FlatStyle.Flat;
            btnFavorites.Font = new Font("Segoe UI Semibold", 10F);
            btnFavorites.ForeColor = Color.Black;
            btnFavorites.IconSize = 30;
            btnFavorites.Location = new Point(12, 196);
            btnFavorites.Name = "btnFavorites";
            btnFavorites.Size = new Size(236, 45);
            btnFavorites.TabIndex = 5;
            btnFavorites.Text = "   Улюблене";
            btnFavorites.TextAlign = ContentAlignment.MiddleLeft;
            btnFavorites.TextColor = Color.Black;
            btnFavorites.UseVisualStyleBackColor = false;
            // 
            // pbCatArrow
            // 
            pbCatArrow.Cursor = Cursors.Hand;
            pbCatArrow.Image = (Image)resources.GetObject("pbCatArrow.Image");
            pbCatArrow.Location = new Point(110, 276);
            pbCatArrow.Name = "pbCatArrow";
            pbCatArrow.Size = new Size(20, 20);
            pbCatArrow.SizeMode = PictureBoxSizeMode.Zoom;
            pbCatArrow.TabIndex = 8;
            pbCatArrow.TabStop = false;
            // 
            // lblCatHeader
            // 
            lblCatHeader.AutoSize = true;
            lblCatHeader.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCatHeader.ForeColor = Color.Gray;
            lblCatHeader.Location = new Point(20, 276);
            lblCatHeader.Name = "lblCatHeader";
            lblCatHeader.Size = new Size(77, 19);
            lblCatHeader.TabIndex = 7;
            lblCatHeader.Text = "КАТЕГОРІЇ";
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(tlpContent);
            pnlRight.Controls.Add(pnlTopBar);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(260, 0);
            pnlRight.Margin = new Padding(0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(1020, 720);
            pnlRight.TabIndex = 1;
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 2;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 450F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContent.Controls.Add(pnlListArea, 0, 0);
            tlpContent.Controls.Add(pnlDetailsArea, 1, 0);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(0, 70);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 1;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1020, 650);
            tlpContent.TabIndex = 2;
            // 
            // pnlListArea
            // 
            pnlListArea.BackColor = Color.White;
            pnlListArea.Controls.Add(flpPasswordList);
            pnlListArea.Controls.Add(pnlListHeader);
            pnlListArea.Dock = DockStyle.Fill;
            pnlListArea.Location = new Point(0, 0);
            pnlListArea.Margin = new Padding(0);
            pnlListArea.Name = "pnlListArea";
            pnlListArea.Padding = new Padding(0, 0, 1, 0);
            pnlListArea.Size = new Size(450, 650);
            pnlListArea.TabIndex = 0;
            // 
            // flpPasswordList
            // 
            flpPasswordList.AutoScroll = true;
            flpPasswordList.Dock = DockStyle.Fill;
            flpPasswordList.FlowDirection = FlowDirection.TopDown;
            flpPasswordList.Location = new Point(0, 90);
            flpPasswordList.Name = "flpPasswordList";
            flpPasswordList.Size = new Size(449, 560);
            flpPasswordList.TabIndex = 1;
            flpPasswordList.WrapContents = false;
            // 
            // pnlListHeader
            // 
            pnlListHeader.BackColor = Color.White;
            pnlListHeader.Controls.Add(lblHeaderAllItems);
            pnlListHeader.Controls.Add(dropdownCategory);
            pnlListHeader.Controls.Add(dropdownSort);
            pnlListHeader.Dock = DockStyle.Top;
            pnlListHeader.Location = new Point(0, 0);
            pnlListHeader.Name = "pnlListHeader";
            pnlListHeader.Size = new Size(449, 90);
            pnlListHeader.TabIndex = 0;
            // 
            // lblHeaderAllItems
            // 
            lblHeaderAllItems.AutoSize = true;
            lblHeaderAllItems.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderAllItems.Location = new Point(15, 10);
            lblHeaderAllItems.Name = "lblHeaderAllItems";
            lblHeaderAllItems.Size = new Size(137, 32);
            lblHeaderAllItems.TabIndex = 0;
            lblHeaderAllItems.Text = "Всі записи";
            // 
            // dropdownCategory
            // 
            dropdownCategory.ArrowIcon = null;
            dropdownCategory.BackColor = Color.White;
            dropdownCategory.Cursor = Cursors.Hand;
            dropdownCategory.Location = new Point(15, 50);
            dropdownCategory.MainIcon = null;
            dropdownCategory.Name = "dropdownCategory";
            dropdownCategory.SelectedText = "Категорія";
            dropdownCategory.Size = new Size(240, 32);
            dropdownCategory.TabIndex = 1;
            // 
            // dropdownSort
            // 
            dropdownSort.ArrowIcon = null;
            dropdownSort.BackColor = Color.White;
            dropdownSort.Cursor = Cursors.Hand;
            dropdownSort.Location = new Point(265, 50);
            dropdownSort.MainIcon = null;
            dropdownSort.Name = "dropdownSort";
            dropdownSort.SelectedText = "Сортування";
            dropdownSort.Size = new Size(170, 32);
            dropdownSort.TabIndex = 2;
            // 
            // pnlDetailsArea
            // 
            pnlDetailsArea.BackColor = Color.FromArgb(250, 250, 252);
            pnlDetailsArea.Dock = DockStyle.Fill;
            pnlDetailsArea.Location = new Point(453, 3);
            pnlDetailsArea.Name = "pnlDetailsArea";
            pnlDetailsArea.Size = new Size(564, 644);
            pnlDetailsArea.TabIndex = 1;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(btnAddItem);
            pnlTopBar.Controls.Add(searchBar);
            pnlTopBar.Controls.Add(pbCollapseIntoWindow);
            pnlTopBar.Controls.Add(pbCollapse);
            pnlTopBar.Controls.Add(pbClose);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1020, 70);
            pnlTopBar.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(33, 145, 245);
            btnAddItem.BackgroundColor = Color.FromArgb(33, 145, 245);
            btnAddItem.BorderColor = Color.Transparent;
            btnAddItem.BorderRadius = 20;
            btnAddItem.BorderSize = 0;
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.IconSize = 25;
            btnAddItem.Location = new Point(630, 15);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Padding = new Padding(15, 0, 0, 0);
            btnAddItem.Size = new Size(224, 40);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "   Новий запис";
            btnAddItem.TextAlign = ContentAlignment.MiddleLeft;
            btnAddItem.TextColor = Color.White;
            btnAddItem.UseVisualStyleBackColor = false;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.White;
            searchBar.Icon = null;
            searchBar.Location = new Point(30, 15);
            searchBar.Name = "searchBar";
            searchBar.Padding = new Padding(10, 5, 10, 5);
            searchBar.SearchText = "";
            searchBar.Size = new Size(580, 40);
            searchBar.TabIndex = 3;
            // 
            // pbCollapseIntoWindow
            // 
            pbCollapseIntoWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbCollapseIntoWindow.Cursor = Cursors.Hand;
            pbCollapseIntoWindow.Image = (Image)resources.GetObject("pbCollapseIntoWindow.Image");
            pbCollapseIntoWindow.Location = new Point(930, 20);
            pbCollapseIntoWindow.Name = "pbCollapseIntoWindow";
            pbCollapseIntoWindow.Size = new Size(30, 30);
            pbCollapseIntoWindow.SizeMode = PictureBoxSizeMode.Zoom;
            pbCollapseIntoWindow.TabIndex = 2;
            pbCollapseIntoWindow.TabStop = false;
            // 
            // pbCollapse
            // 
            pbCollapse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbCollapse.Cursor = Cursors.Hand;
            pbCollapse.Image = (Image)resources.GetObject("pbCollapse.Image");
            pbCollapse.Location = new Point(890, 20);
            pbCollapse.Name = "pbCollapse";
            pbCollapse.Size = new Size(30, 30);
            pbCollapse.SizeMode = PictureBoxSizeMode.Zoom;
            pbCollapse.TabIndex = 1;
            pbCollapse.TabStop = false;
            // 
            // pbClose
            // 
            pbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(970, 20);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(30, 30);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 0;
            pbClose.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(tlpMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Manager";
            WindowState = FormWindowState.Maximized;
            tlpMain.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlSidebarBottom.ResumeLayout(false);
            pnlSidebarBottom.PerformLayout();
            pnlSidebarTop.ResumeLayout(false);
            pnlSidebarTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCatArrow).EndInit();
            pnlRight.ResumeLayout(false);
            tlpContent.ResumeLayout(false);
            pnlListArea.ResumeLayout(false);
            pnlListHeader.ResumeLayout(false);
            pnlListHeader.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCollapseIntoWindow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCollapse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSidebarTop;
        private System.Windows.Forms.Panel pnlSidebarBottom;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private System.Windows.Forms.Label lblUsername;
        private RoundedButton btnProfile;
        private RoundedButton btnAllItems;
        private RoundedButton btnFavorites;
        private System.Windows.Forms.Label lblCatHeader;
        private System.Windows.Forms.PictureBox pbCatArrow;
        private System.Windows.Forms.Label lblToolsHeader;
        private RoundedButton btnAudit;
        private RoundedButton btnGenerator;
        private RoundedButton btnTrash;
        private RoundedButton btnSettings;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbCollapse;
        private System.Windows.Forms.PictureBox pbCollapseIntoWindow;
        private ModernSearchBar searchBar;
        private RoundedButton btnAddItem;
        private TableLayoutPanel tlpContent;
        private Panel pnlListArea;
        private Panel pnlListHeader;
        private Label lblHeaderAllItems;
        private Panel pnlDetailsArea;
        private ModernDropdown dropdownCategory;
        private ModernDropdown dropdownSort;
        private FlowLayoutPanel flpPasswordList;
    }
}