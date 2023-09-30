using BusinessLogic.Library;
using System;
using System.Windows.Forms;
using TicketApplication.Common;

namespace TicketApplication.UserControls
{
    public partial class ReportList : UserControl
    {
        private readonly IBaseDatabaseRepository _baseDatabase;
        Paging Paging;
        private readonly TaskWorkShowGird Show;
        public ReportList()
        {
            InitializeComponent();
            Paging = new Paging();
            Show = new TaskWorkShowGird();
            _baseDatabase = new BaseDatabaseRepository();

        }
        private void ShowDataGridView(int type)
        {
            string QUERY;

            if (type == 0)  //  From Date To Date
            {
                QUERY = Show.ShowFDateT(FromDate.Value.ToString(), ToDate.Value.ToString());
            }
            else if (type == 1)  //  Search Result
            {
                QUERY = Show.ShowSearchDate(SearchTxt.Text);
            }
            else
            {
                QUERY = Show.ShowAll(Paging.Order(Paging.Page));
            }
            ListTasks.DataSource = _baseDatabase.Execute(QUERY);
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
            Paging.Next();
            ShowDataGridView(99);
        }

        private void Reloding_Click(object sender, EventArgs e)
        {
            ShowDataGridView(99);
        }
    }
}
