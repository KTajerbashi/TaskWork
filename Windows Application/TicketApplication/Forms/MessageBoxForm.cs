using BusinessLogic.Library;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TicketApplication.Forms
{
    public partial class MessageBoxForm : Form
    {
        private readonly TaskWorkService _service;
        #region Code

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
        public MessageBoxForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _service = new TaskWorkService();
        }

        private void NewTaskForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            var tag = (sender as Button).Tag;
            var Name = this.Name;
            switch (Name)
            {
                case "DeliverTask":
                    {
                        var model = _service.GetById(tag);
                        model.IsDeliver = true;
                        _service.Update(model);
                        break;
                    }
                case "PassTask":
                    {
                        var model = _service.GetById(tag);
                        model.IsPassed = true;
                        _service.Update(model);
                        break;
                    }
                default:
                    {
                        this.Close();
                        break;
                    }
            }

            _service.Save();
            this.Close();
        }
    }
}
