using Infrastrucure.Library.DatabaseService;
using Infrastrucure.Library.Repository.TaskService;
using System;
using System.Windows.Forms;
using TicketApplication.Common;

namespace TicketApplication.UserControls
{
    public partial class ReportList : UserControl
    {
        private readonly IBaseQuery _baseDatabase;
        Paging Paging;
        public ReportList()
        {
            InitializeComponent();
            Paging = new Paging();
            _baseDatabase = new BaseQuery();
        }
        private void ShowDataGridView(int type)
        {
            string QUERY;
            TaskQueries _taskQueries = new TaskQueries();
            if (type == 0)  //  From Date To Date
            {
                var from = Convert.ToDateTime(FromDate.Value).ToString("yyyy-MM-dd HH:mm:ss");
                var to = ToDate.Value.ToString();
                QUERY = _taskQueries.ShowFDateT(FromDate.Value.ToString(), ToDate.Value.ToString());
            }
            else if (type == 1)  //  Search Result
            {
                QUERY = _taskQueries.ShowSearchDate(SearchTxt.Text);
            }
            else
            {
                QUERY = _taskQueries.ShowAll(Paging.Order(Paging.Page));
            }
            ListTasks.DataSource = _baseDatabase.Execute(QUERY);
            CountLBL.Text = ListTasks.Rows.Count.ToString();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ShowDataGridView(1);
        }

        private void ReportList_Load(object sender, EventArgs e)
        {
            FromDate.UsePersianFormat = true;
            ToDate.UsePersianFormat = true;
            FromDate.Value = DateTime.Now;
            ToDate.Value = DateTime.Now;
            ShowDataGridView(99);
        }

        private void FTDateBtn_Click(object sender, EventArgs e)
        {
            ShowDataGridView(0);
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            Paging.Prev();
            ShowDataGridView(99);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            Paging.Next(23, ListTasks.Rows.Count);
            ShowDataGridView(99);
        }

        private void Reloding_Click(object sender, EventArgs e)
        {
            ShowDataGridView(99);
        }
    }
}
