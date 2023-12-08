using MD.PersianDateTime;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TicketApplication.Authentication;
using TicketApplication.Forms;
using TicketApplication.UserControls;

namespace TicketApplication
{
    public partial class Main : Form
    {
        #region Code
        LoginForm loginForm;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Main()
        {
            loginForm = new LoginForm();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
        }

        #endregion
        private void ReportBtn_Click(object sender, EventArgs e)
        {
            ReportList reportList = new ReportList();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(reportList);

        }

        private void AsidePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loginForm.ShowDialog();
            CartablePanel cartablePanel = new CartablePanel();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(cartablePanel);
            UsernameLBL.Text = AppUser.DisplayName;

        }

        private void TasksListBtn_Click(object sender, EventArgs e)
        {
            TaskList taskList = new TaskList();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(taskList);
        }

        private void NewTaskBtn_Click(object sender, EventArgs e)
        {
            NewTaskForm newTaskForm = new NewTaskForm();
            newTaskForm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PersianDateTime persianDateTime = new PersianDateTime(DateTime.Now);
            DateTimeLBL.Text = persianDateTime.ToString();
        }

        private void SaamanehBtn_Click(object sender, EventArgs e)
        {
            SaamanehPanel saamanehPanel = new SaamanehPanel(); 
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(saamanehPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CartablePanel cartablePanel = new CartablePanel();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(cartablePanel);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            RoadMapPanel panel = new RoadMapPanel();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LockScreenBtn_Click(object sender, EventArgs e)
        {
            loginForm.Location = new Point(535, 0);
            loginForm.UsernameTxt.Text = "";
            loginForm.PasswordTxt.Text = "";
            loginForm.LoginMsg.Text = "";
            loginForm.ShowDialog();
        }

        private void DbBackupBtn_Click(object sender, EventArgs e)
        {
            //BackupPanel backupPanel = new BackupPanel();
            //if (MainPanel.Controls.Count > 0)
            //{
            //    MainPanel.Controls[0].Dispose();
            //}
            //MainPanel.Controls.Add(backupPanel);
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            SettingPanel panel = new SettingPanel();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);
        }
    }
}
