using PasswordManager.additionalClasses;
using PasswordManager.personalizedTools;
using System.Drawing;
using System.Windows.Forms;

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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSidebarBottom = new System.Windows.Forms.Panel();
            this.lblToolsHeader = new System.Windows.Forms.Label();
            this.btnAudit = new PasswordManager.additionalClasses.RoundedButton();
            this.btnGenerator = new PasswordManager.additionalClasses.RoundedButton();
            this.btnTrash = new PasswordManager.additionalClasses.RoundedButton();
            this.btnSettings = new PasswordManager.additionalClasses.RoundedButton();
            this.pnlSidebarTop = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnProfile = new PasswordManager.additionalClasses.RoundedButton();
            this.btnAllItems = new PasswordManager.additionalClasses.RoundedButton();
            this.btnFavorites = new PasswordManager.additionalClasses.RoundedButton();
            this.pbCatArrow = new System.Windows.Forms.PictureBox();
            this.lblCatHeader = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlListArea = new System.Windows.Forms.Panel();
            this.flpPasswordList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlListHeader = new System.Windows.Forms.Panel();
            this.lblCategorySubtitle = new System.Windows.Forms.Label();
            this.lblHeaderAllItems = new System.Windows.Forms.Label();
            this.dropdownCategory = new PasswordManager.personalizedTools.ModernDropdown();
            this.dropdownSort = new PasswordManager.personalizedTools.ModernDropdown();
            this.pnlDetailsArea = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnAddItem = new PasswordManager.additionalClasses.RoundedButton();
            this.searchBar = new PasswordManager.personalizedTools.ModernSearchBar();
            this.pbCollapseIntoWindow = new System.Windows.Forms.PictureBox();
            this.pbCollapse = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.tlpMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlSidebarBottom.SuspendLayout();
            this.pnlSidebarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCatArrow)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pnlListArea.SuspendLayout();
            this.pnlListHeader.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollapseIntoWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlLeft, 0, 0);
            this.tlpMain.Controls.Add(this.pnlRight, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1280, 720);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.pnlLeft.Controls.Add(this.flpCategories);
            this.pnlLeft.Controls.Add(this.pnlSidebarBottom);
            this.pnlLeft.Controls.Add(this.pnlSidebarTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pnlLeft.Size = new System.Drawing.Size(260, 720);
            this.pnlLeft.TabIndex = 0;
            // 
            // flpCategories
            // 
            this.flpCategories.AutoScroll = true;
            this.flpCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCategories.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCategories.Location = new System.Drawing.Point(0, 310);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.flpCategories.Size = new System.Drawing.Size(259, 190);
            this.flpCategories.TabIndex = 2;
            this.flpCategories.WrapContents = false;
            // 
            // pnlSidebarBottom
            // 
            this.pnlSidebarBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlSidebarBottom.Controls.Add(this.lblToolsHeader);
            this.pnlSidebarBottom.Controls.Add(this.btnAudit);
            this.pnlSidebarBottom.Controls.Add(this.btnGenerator);
            this.pnlSidebarBottom.Controls.Add(this.btnTrash);
            this.pnlSidebarBottom.Controls.Add(this.btnSettings);
            this.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarBottom.Location = new System.Drawing.Point(0, 500);
            this.pnlSidebarBottom.Name = "pnlSidebarBottom";
            this.pnlSidebarBottom.Size = new System.Drawing.Size(259, 220);
            this.pnlSidebarBottom.TabIndex = 1;
            // 
            // lblToolsHeader
            // 
            this.lblToolsHeader.AutoSize = true;
            this.lblToolsHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblToolsHeader.ForeColor = System.Drawing.Color.Gray;
            this.lblToolsHeader.Location = new System.Drawing.Point(20, 10);
            this.lblToolsHeader.Name = "lblToolsHeader";
            this.lblToolsHeader.Size = new System.Drawing.Size(109, 19);
            this.lblToolsHeader.TabIndex = 0;
            this.lblToolsHeader.Text = "ІНСТРУМЕНТИ";
            // 
            // btnAudit
            // 
            this.btnAudit.BackColor = System.Drawing.Color.Transparent;
            this.btnAudit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAudit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAudit.BorderRadius = 15;
            this.btnAudit.BorderSize = 0;
            this.btnAudit.FlatAppearance.BorderSize = 0;
            this.btnAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAudit.ForeColor = System.Drawing.Color.Black;
            this.btnAudit.IconSize = 30;
            this.btnAudit.Location = new System.Drawing.Point(12, 40);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(236, 40);
            this.btnAudit.TabIndex = 1;
            this.btnAudit.Text = "   Аудит безпеки";
            this.btnAudit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAudit.TextColor = System.Drawing.Color.Black;
            this.btnAudit.UseVisualStyleBackColor = false;
            // 
            // btnGenerator
            // 
            this.btnGenerator.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerator.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnGenerator.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGenerator.BorderRadius = 15;
            this.btnGenerator.BorderSize = 0;
            this.btnGenerator.FlatAppearance.BorderSize = 0;
            this.btnGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerator.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnGenerator.ForeColor = System.Drawing.Color.Black;
            this.btnGenerator.IconSize = 30;
            this.btnGenerator.Location = new System.Drawing.Point(12, 85);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(236, 40);
            this.btnGenerator.TabIndex = 2;
            this.btnGenerator.Text = "   Генератор";
            this.btnGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerator.TextColor = System.Drawing.Color.Black;
            this.btnGenerator.UseVisualStyleBackColor = false;
            // 
            // btnTrash
            // 
            this.btnTrash.BackColor = System.Drawing.Color.Transparent;
            this.btnTrash.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTrash.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTrash.BorderRadius = 15;
            this.btnTrash.BorderSize = 0;
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnTrash.ForeColor = System.Drawing.Color.Black;
            this.btnTrash.IconSize = 30;
            this.btnTrash.Location = new System.Drawing.Point(12, 130);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(236, 40);
            this.btnTrash.TabIndex = 3;
            this.btnTrash.Text = "   Кошик";
            this.btnTrash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrash.TextColor = System.Drawing.Color.Black;
            this.btnTrash.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSettings.BorderRadius = 15;
            this.btnSettings.BorderSize = 0;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.IconSize = 30;
            this.btnSettings.Location = new System.Drawing.Point(12, 175);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(236, 40);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "   Налаштування";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextColor = System.Drawing.Color.Black;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // pnlSidebarTop
            // 
            this.pnlSidebarTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlSidebarTop.Controls.Add(this.lblUsername);
            this.pnlSidebarTop.Controls.Add(this.btnProfile);
            this.pnlSidebarTop.Controls.Add(this.btnAllItems);
            this.pnlSidebarTop.Controls.Add(this.btnFavorites);
            this.pnlSidebarTop.Controls.Add(this.pbCatArrow);
            this.pnlSidebarTop.Controls.Add(this.lblCatHeader);
            this.pnlSidebarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarTop.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarTop.Name = "pnlSidebarTop";
            this.pnlSidebarTop.Size = new System.Drawing.Size(259, 310);
            this.pnlSidebarTop.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(20, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(128, 32);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnProfile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnProfile.BorderRadius = 15;
            this.btnProfile.BorderSize = 0;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.IconSize = 30;
            this.btnProfile.Location = new System.Drawing.Point(12, 80);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(236, 45);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "   Профіль";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextColor = System.Drawing.Color.Black;
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnAllItems
            // 
            this.btnAllItems.BackColor = System.Drawing.Color.Transparent;
            this.btnAllItems.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAllItems.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAllItems.BorderRadius = 15;
            this.btnAllItems.BorderSize = 0;
            this.btnAllItems.FlatAppearance.BorderSize = 0;
            this.btnAllItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllItems.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAllItems.ForeColor = System.Drawing.Color.Black;
            this.btnAllItems.IconSize = 30;
            this.btnAllItems.Location = new System.Drawing.Point(12, 145);
            this.btnAllItems.Name = "btnAllItems";
            this.btnAllItems.Size = new System.Drawing.Size(236, 45);
            this.btnAllItems.TabIndex = 3;
            this.btnAllItems.Text = "   Всі записи";
            this.btnAllItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllItems.TextColor = System.Drawing.Color.Black;
            this.btnAllItems.UseVisualStyleBackColor = false;
            // 
            // btnFavorites
            // 
            this.btnFavorites.BackColor = System.Drawing.Color.Transparent;
            this.btnFavorites.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnFavorites.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFavorites.BorderRadius = 15;
            this.btnFavorites.BorderSize = 0;
            this.btnFavorites.FlatAppearance.BorderSize = 0;
            this.btnFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorites.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnFavorites.ForeColor = System.Drawing.Color.Black;
            this.btnFavorites.IconSize = 30;
            this.btnFavorites.Location = new System.Drawing.Point(12, 196);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(236, 45);
            this.btnFavorites.TabIndex = 5;
            this.btnFavorites.Text = "   Улюблене";
            this.btnFavorites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorites.TextColor = System.Drawing.Color.Black;
            this.btnFavorites.UseVisualStyleBackColor = false;
            // 
            // pbCatArrow
            // 
            this.pbCatArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCatArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbCatArrow.Image")));
            this.pbCatArrow.Location = new System.Drawing.Point(110, 276);
            this.pbCatArrow.Name = "pbCatArrow";
            this.pbCatArrow.Size = new System.Drawing.Size(20, 20);
            this.pbCatArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCatArrow.TabIndex = 8;
            this.pbCatArrow.TabStop = false;
            // 
            // lblCatHeader
            // 
            this.lblCatHeader.AutoSize = true;
            this.lblCatHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCatHeader.ForeColor = System.Drawing.Color.Gray;
            this.lblCatHeader.Location = new System.Drawing.Point(20, 276);
            this.lblCatHeader.Name = "lblCatHeader";
            this.lblCatHeader.Size = new System.Drawing.Size(77, 19);
            this.lblCatHeader.TabIndex = 7;
            this.lblCatHeader.Text = "КАТЕГОРІЇ";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.tlpContent);
            this.pnlRight.Controls.Add(this.pnlTopBar);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(260, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1020, 720);
            this.pnlRight.TabIndex = 1;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Controls.Add(this.pnlListArea, 0, 0);
            this.tlpContent.Controls.Add(this.pnlDetailsArea, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 70);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1020, 650);
            this.tlpContent.TabIndex = 2;
            // 
            // pnlListArea
            // 
            this.pnlListArea.BackColor = System.Drawing.Color.White;
            this.pnlListArea.Controls.Add(this.flpPasswordList);
            this.pnlListArea.Controls.Add(this.pnlListHeader);
            this.pnlListArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListArea.Location = new System.Drawing.Point(0, 0);
            this.pnlListArea.Margin = new System.Windows.Forms.Padding(0);
            this.pnlListArea.Name = "pnlListArea";
            this.pnlListArea.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pnlListArea.Size = new System.Drawing.Size(450, 650);
            this.pnlListArea.TabIndex = 0;
            // 
            // flpPasswordList
            // 
            this.flpPasswordList.AutoScroll = true;
            this.flpPasswordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPasswordList.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpPasswordList.Location = new System.Drawing.Point(0, 90);
            this.flpPasswordList.Name = "flpPasswordList";
            this.flpPasswordList.Padding = new System.Windows.Forms.Padding(0);
            this.flpPasswordList.Size = new System.Drawing.Size(449, 560);
            this.flpPasswordList.TabIndex = 1;
            this.flpPasswordList.WrapContents = true;
            // 
            // pnlListHeader
            // 
            this.pnlListHeader.BackColor = System.Drawing.Color.White;
            this.pnlListHeader.Controls.Add(this.lblCategorySubtitle);
            this.pnlListHeader.Controls.Add(this.lblHeaderAllItems);
            this.pnlListHeader.Controls.Add(this.dropdownCategory);
            this.pnlListHeader.Controls.Add(this.dropdownSort);
            this.pnlListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlListHeader.Name = "pnlListHeader";
            this.pnlListHeader.Size = new System.Drawing.Size(449, 90);
            this.pnlListHeader.TabIndex = 0;
            // 
            // lblCategorySubtitle
            // 
            this.lblCategorySubtitle.AutoSize = true;
            this.lblCategorySubtitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCategorySubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.lblCategorySubtitle.Location = new System.Drawing.Point(15, 50);
            this.lblCategorySubtitle.Name = "lblCategorySubtitle";
            this.lblCategorySubtitle.Size = new System.Drawing.Size(100, 32);
            this.lblCategorySubtitle.TabIndex = 3;
            this.lblCategorySubtitle.Text = "\"Робота\"";
            this.lblCategorySubtitle.Visible = false;
            // 
            // lblHeaderAllItems
            // 
            this.lblHeaderAllItems.AutoSize = true;
            this.lblHeaderAllItems.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeaderAllItems.Location = new System.Drawing.Point(15, 10);
            this.lblHeaderAllItems.Name = "lblHeaderAllItems";
            this.lblHeaderAllItems.Size = new System.Drawing.Size(137, 32);
            this.lblHeaderAllItems.TabIndex = 0;
            this.lblHeaderAllItems.Text = "Всі записи";
            // 
            // dropdownCategory
            // 
            this.dropdownCategory.ArrowIcon = null;
            this.dropdownCategory.BackColor = System.Drawing.Color.White;
            this.dropdownCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropdownCategory.Location = new System.Drawing.Point(15, 50);
            this.dropdownCategory.MainIcon = null;
            this.dropdownCategory.Name = "dropdownCategory";
            this.dropdownCategory.SelectedText = "Категорія";
            this.dropdownCategory.Size = new System.Drawing.Size(240, 32);
            this.dropdownCategory.TabIndex = 1;
            // 
            // dropdownSort
            // 
            this.dropdownSort.ArrowIcon = null;
            this.dropdownSort.BackColor = System.Drawing.Color.White;
            this.dropdownSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropdownSort.Location = new System.Drawing.Point(265, 50);
            this.dropdownSort.MainIcon = null;
            this.dropdownSort.Name = "dropdownSort";
            this.dropdownSort.SelectedText = "Сортування";
            this.dropdownSort.Size = new System.Drawing.Size(170, 32);
            this.dropdownSort.TabIndex = 2;
            // 
            // pnlDetailsArea
            // 
            this.pnlDetailsArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlDetailsArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailsArea.Location = new System.Drawing.Point(453, 3);
            this.pnlDetailsArea.Name = "pnlDetailsArea";
            this.pnlDetailsArea.Size = new System.Drawing.Size(564, 644);
            this.pnlDetailsArea.TabIndex = 1;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.btnAddItem);
            this.pnlTopBar.Controls.Add(this.searchBar);
            this.pnlTopBar.Controls.Add(this.pbCollapseIntoWindow);
            this.pnlTopBar.Controls.Add(this.pbCollapse);
            this.pnlTopBar.Controls.Add(this.pbClose);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1020, 70);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.btnAddItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(145)))), ((int)(((byte)(245)))));
            this.btnAddItem.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddItem.BorderRadius = 20;
            this.btnAddItem.BorderSize = 0;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.IconSize = 25;
            this.btnAddItem.Location = new System.Drawing.Point(630, 15);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAddItem.Size = new System.Drawing.Size(224, 40);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "   Новий запис";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.TextColor = System.Drawing.Color.White;
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // searchBar
            // 
            this.searchBar.AutoCompleteCustomSource = null;
            this.searchBar.BackColor = System.Drawing.Color.White;
            this.searchBar.Icon = null;
            this.searchBar.Location = new System.Drawing.Point(30, 15);
            this.searchBar.Name = "searchBar";
            this.searchBar.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.searchBar.SearchText = "";
            this.searchBar.Size = new System.Drawing.Size(580, 40);
            this.searchBar.TabIndex = 3;
            // 
            // pbCollapseIntoWindow
            // 
            this.pbCollapseIntoWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCollapseIntoWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCollapseIntoWindow.Image = ((System.Drawing.Image)(resources.GetObject("pbCollapseIntoWindow.Image")));
            this.pbCollapseIntoWindow.Location = new System.Drawing.Point(930, 20);
            this.pbCollapseIntoWindow.Name = "pbCollapseIntoWindow";
            this.pbCollapseIntoWindow.Size = new System.Drawing.Size(30, 30);
            this.pbCollapseIntoWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCollapseIntoWindow.TabIndex = 2;
            this.pbCollapseIntoWindow.TabStop = false;
            // 
            // pbCollapse
            // 
            this.pbCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCollapse.Image = ((System.Drawing.Image)(resources.GetObject("pbCollapse.Image")));
            this.pbCollapse.Location = new System.Drawing.Point(890, 20);
            this.pbCollapse.Name = "pbCollapse";
            this.pbCollapse.Size = new System.Drawing.Size(30, 30);
            this.pbCollapse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCollapse.TabIndex = 1;
            this.pbCollapse.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(970, 20);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlSidebarBottom.ResumeLayout(false);
            this.pnlSidebarBottom.PerformLayout();
            this.pnlSidebarTop.ResumeLayout(false);
            this.pnlSidebarTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCatArrow)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.pnlListArea.ResumeLayout(false);
            this.pnlListHeader.ResumeLayout(false);
            this.pnlListHeader.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCollapseIntoWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Panel pnlListArea;
        private System.Windows.Forms.Panel pnlListHeader;
        private System.Windows.Forms.Label lblHeaderAllItems;
        private System.Windows.Forms.Panel pnlDetailsArea;
        private ModernDropdown dropdownCategory;
        private ModernDropdown dropdownSort;
        private System.Windows.Forms.FlowLayoutPanel flpPasswordList;
        private System.Windows.Forms.Label lblCategorySubtitle;
    }
}