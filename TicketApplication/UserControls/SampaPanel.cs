using BusinessLogic.Library;
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
using TicketApplication.Common;

namespace TicketApplication.UserControls
{
    public partial class SampaPanel : UserControl
    {
        private readonly IBaseDatabaseRepository _baseDatabase;
        private TaskWorkService _taskWork;
        private Paging Paging;
        private int tab;
        private readonly TaskWorkShowGird Show;

        #region Code
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,          // x-coordinate of upper-left corner
            int nTopRect,           // y-coordinate of upper-left corner
            int nRightRect,         // x-coordinate of lower-right corner
            int nBottomRect,        // y-coordinate of lower-right corner
            int nWidthEllipse,      // width of ellipse
            int nHeightEllipse      // height of ellipse
        );
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public SampaPanel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Paging = new Paging();
            _baseDatabase = new BaseDatabaseRepository();
            Show = new TaskWorkShowGird();
        }
        #endregion
        private void ShowDataGridView(int type)
        {
            _taskWork = new TaskWorkService();
            string QUERY;
            switch (type)
            {
                case 0: // الفبا
                    {
                        QUERY = Show.ShowAlphabet(Paging.Order(Paging.Page));
                        break;
                    }
                case 1: // تمام شده
                    {
                        QUERY = Show.ShowPassed(Paging.Order(Paging.Page));
                        break;
                    }
                case 2: // تمام نشده
                    {
                        QUERY = Show.ShowNotPassed(Paging.Order(Paging.Page));
                        break;
                    }
                case 3: // جستجو
                    {
                        QUERY = Show.ShowSearchDate(SearchTxt.Text);
                        break;
                    }
                case 4: // تحویل شده
                    {
                        QUERY = Show.ShowDeliver(Paging.Order(Paging.Page));
                        break;
                    }
                case 5: // به ترتیب الویت
                    {
                        QUERY = Show.ShowImportant(Paging.Order(Paging.Page));
                        break;
                    }
                case 6: // تحویل شده
                    {
                        QUERY = Show.ShowNotDeliver(Paging.Order(Paging.Page));
                        break;
                    }
                default: // جدید ترین
                    {
                        QUERY = Show.ShowAll(Paging.Order(Paging.Page));
                        break;
                    }
            }
            ListTasks.DataSource = null;
            ListTasks.DataSource = _baseDatabase.Execute(QUERY);
            CountLBL.Text = ListTasks.Rows.Count.ToString();
        }

        private void SampaPanel_Load(object sender, EventArgs e)
        {
            ShowDataGridView(99);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
