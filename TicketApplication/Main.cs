using Domain.Model;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TicketApplication.Forms;
using TicketApplication.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketApplication
{
    public partial class Main : Form
    {

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
        TaskList taskList;
        ReportList reportList;
        Timer timer = new Timer();

        public Main()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            reportList = new ReportList();
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
            taskList = new TaskList();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(taskList);
        }

        private void TasksListBtn_Click(object sender, EventArgs e)
        {
            taskList = new TaskList();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(taskList);
        }

        private void NewTaskBtn_Click(object sender, EventArgs e)
        {
            NewTaskForm form = new NewTaskForm();
            form.ShowDialog();
        }

    }
}
