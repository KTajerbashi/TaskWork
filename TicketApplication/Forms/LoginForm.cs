using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketApplication.Forms
{
    public partial class LoginForm : Form
    {
        #region CodeRound
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
        #endregion
        List<String> users= new List<String>();

        Timer T1 = new Timer();
        Timer T2 = new Timer();

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            T1.Enabled = true;
            T1.Interval = 10;
            T1.Tick += Timer_Tick1;
            T1.Start();
        }
        int y = 500;
        private void Timer_Tick1(object sender, EventArgs e)
        {
            CheckLocationLBL.Text = $"X : {SignInTitle.Location.X}\nY : {SignInTitle.Location.Y} \ny : {y}";
            if (SignInTitle.Location.Y > 0)
            {
                y = y - 10;
                SignInTitle.Location = new Point(4, y);
                //this.Controls["MainPanel"].Location = new Point(411, y2);
            }
            else
            {
                T1.Stop();
            }
        }
        private void Timer_Tick2(object sender, EventArgs e)
        {
            CheckLocationLBL.Text = $"X : {SignInPanel.Location.X}\nY : {SignInPanel.Location.Y} \ny : {y}";
            if (SignInPanel.Location.Y > 0)
            {
                y = y - 10;
                SignInPanel.Location = new Point(535, y);
                //this.Controls["MainPanel"].Location = new Point(411, y2);
            }
            else
            {
                T1.Stop();
            }
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            T1.Enabled = true;
            T1.Interval = 10;
            T1.Tick += Timer_Tick2;
            T1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
