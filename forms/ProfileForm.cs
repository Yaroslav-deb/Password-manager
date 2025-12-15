using PasswordManager.additionalClasses;
using PasswordManager.database;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class ProfileForm : Form
    {
        private int currentUserId;
        private string photosPath;

        public ProfileForm(int userId)
        {
            this.currentUserId = userId;
            InitializeComponent();
            this.DoubleBuffered = true;

            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            photosPath = Path.Combine(projectDir, "photos");

            InitializeLogic();
            LoadUserData();
            LoadImages();

            CenterUserPanel();
            this.Resize += (s, e) => CenterUserPanel();
        }

        private void CenterUserPanel()
        {
            if (pnlLeft != null && pnlUserContainer != null)
            {
                int x = (pnlLeft.Width - pnlUserContainer.Width) / 2;
                int y = (pnlLeft.Height - pnlUserContainer.Height) / 2;
                pnlUserContainer.Location = new Point(x, y);
            }
        }

        private void InitializeLogic()
        {
            pbClose.Click += (s, e) => Application.Exit();
            pbCollapse.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            pbCollapseIntoWindow.Click += (s, e) => {
                this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
            };

            lblBack.MouseEnter += (s, e) => { lblBack.ForeColor = Color.Black; };
            lblBack.MouseLeave += (s, e) => { lblBack.ForeColor = Color.Gray; };
            lblBack.Click += (s, e) => this.Close();

            pnlTopBar.MouseDown += (s, e) => {
                if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, 0xA1, 0x2, 0); }
            };

            pbUserAvatar.Paint += (s, e) => {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, pbUserAvatar.Width - 1, pbUserAvatar.Height - 1);
                pbUserAvatar.Region = new Region(path);
            };

            btnLogout.Click += (s, e) =>
            {
                if (MessageBox.Show("Ви впевнені, що хочете вийти?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
            };
        }

        private void LoadUserData()
        {
            lblUsername.Text = DatabaseHelper.GetUsernameById(currentUserId);

            lblEmailValue.Text = DatabaseHelper.GetUserEmail(currentUserId);

            int count = DatabaseHelper.GetTotalEntriesCount(currentUserId);
            lblCountValue.Text = count.ToString();

            lblLastUpdateValue.Text = DatabaseHelper.GetLastActivityDate(currentUserId);
        }

        private void LoadImages()
        {
            pbUserAvatar.Image = LoadImage("profile_big.png") ?? LoadImage("profile.png");

            Image cloudImg = LoadImage("clouds.png");
            if (cloudImg != null)
            {
                pbDecorationLeft.Image = cloudImg;
            }

            pbClose.Image = LoadImage("close_icon.png") ?? LoadImage("close.png");
            pbCollapse.Image = LoadImage("minimize.png");
            pbCollapseIntoWindow.Image = LoadImage("maximize.png");

            Image outImg = LoadImage("logout.png");
            if (outImg != null)
            {
                btnLogout.Image = outImg;
                btnLogout.Padding = new Padding(20, 0, 0, 0);
            }
        }

        private Image LoadImage(string name)
        {
            string path = Path.Combine(photosPath, name);
            return File.Exists(path) ? Image.FromFile(path) : null;
        }

        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] public static extern bool ReleaseCapture();
    }
}