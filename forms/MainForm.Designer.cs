namespace PasswordManager.forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pbCollapseIntoWindow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCollapseIntoWindow).BeginInit();
            SuspendLayout();
            // 
            // pbCollapseIntoWindow
            // 
            pbCollapseIntoWindow.BackColor = Color.Transparent;
            pbCollapseIntoWindow.Image = (Image)resources.GetObject("pbCollapseIntoWindow.Image");
            pbCollapseIntoWindow.Location = new Point(731, 12);
            pbCollapseIntoWindow.Name = "pbCollapseIntoWindow";
            pbCollapseIntoWindow.Size = new Size(30, 30);
            pbCollapseIntoWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCollapseIntoWindow.TabIndex = 2;
            pbCollapseIntoWindow.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbCollapseIntoWindow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pbCollapseIntoWindow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbCollapseIntoWindow;
    }
}