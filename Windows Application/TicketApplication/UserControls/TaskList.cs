using BusinessLogic.Library;
using Domain.Library.Enums;
using Domain.Model;
using Infrastrucure.Library.DatabaseService;
using Infrastrucure.Library.Repository.TaskService;
using System;
using System.Data;
using System.Windows.Forms;
using TicketApplication.Common;
using TicketApplication.Forms;

namespace TicketApplication.UserControls
{
    public partial class TaskList : UserControl
    {
        private readonly IBaseQuery _baseQuery;
        private TaskService _taskService;
        private Paging Paging;
        private TaskQueries _query;
        private int tab;
        public TaskList()
        {
            InitializeComponent();
            Paging = new Paging();
            _baseQuery = new BaseQuery();
            _taskService = new TaskService();
            _query = new TaskQueries();
        }

        private long ID;

        private void ShowDataGridView(int type)
        {
            string QUERY;
            switch (type)
            {
                case 0: // الفبا
                    {
                        QUERY = _query.ShowAlphabet(Paging.Order(Paging.Page));
                        break;
                    }
                case 1: // تمام شده
                    {
                        QUERY = _query.ShowPassed(Paging.Order(Paging.Page));
                        break;
                    }
                case 2: // تمام نشده
                    {
                        QUERY = _query.ShowNotPassed(Paging.Order(Paging.Page));
                        break;
                    }
                case 3: // جستجو
                    {
                        QUERY = _query.ShowSearchDate(SearchTxt.Text);
                        break;
                    }
                case 4: // تحویل شده
                    {
                        QUERY = _query.ShowDeliver(Paging.Order(Paging.Page));
                        break;
                    }
                case 5: // به ترتیب الویت
                    {
                        QUERY = _query.ShowImportant(Paging.Order(Paging.Page));
                        break;
                    }
                case 6: // تحویل شده
                    {
                        QUERY = _query.ShowNotDeliver(Paging.Order(Paging.Page));
                        break;
                    }
                default: // جدید ترین
                    {
                        QUERY = _query.ShowAll(Paging.Order(Paging.Page));
                        break;
                    }
            }
            ListTasks.DataSource = null;
            ListTasks.DataSource = _baseQuery.Execute(QUERY);
            var count = _baseQuery.Execute(_query.Count()).Rows[0].Field<int>(0);
            CountLBL.Text = $"تعداد کل رکورد {count} | رکورد های نمایشی {ListTasks.Rows.Count} | صفحه {Paging.Page + 1}";
        }

        private void TaskList_Load(object sender, EventArgs e)
        {
            ShowDataGridView(99);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ShowDataGridView(3);
        }

        private void NewTaskBtn_Click(object sender, EventArgs e)
        {
            tab = 99;
            ShowDataGridView(99);
        }

        private void ListTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListTasks.Rows.Count > 0)
            {
                ID = Convert.ToInt32(ListTasks.Rows[ListTasks.CurrentRow.Index].Cells["آیدی"].Value);
            }
        }

        private void ListTasks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                StripMenu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void PassedBtn_Click(object sender, EventArgs e)
        {
            tab = 1;
            ShowDataGridView(1);
        }

        private void AlphabetBtn_Click(object sender, EventArgs e)
        {
            tab = 0;
            ShowDataGridView(0);
        }

        private void NotPassBtn_Click(object sender, EventArgs e)
        {
            tab = 2;
            ShowDataGridView(2);
        }

        private void تغییروضعیتپاسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string query = $@"Update BUS.TaskWorks SET IsPassed = 0 WHERE ID = 1";
            if (ID > 0)
            {
                TaskWork entity=  _taskService.GetById(ID).Data;
                entity.IsPassed = entity.IsPassed ? false : true;
                _taskService.Save();
                ShowDataGridView(tab);
            }
        }

        private void تغییروضعیتتحویلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                TaskWork entity=  _taskService.GetById(ID).Data;
                entity.IsDeliver = entity.IsDeliver ? false : true;
                _taskService.Save();
                ShowDataGridView(tab);
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskWork entity =  _taskService.GetById(ID).Data;
            entity.IsDeleted = true;
             _taskService.Save();

            ShowDataGridView(tab);
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                TaskWork model=  _taskService.GetById(ID).Data;

                NewTaskForm form = new NewTaskForm();
                form.SaamanehCombo.Tag = model.SamanaID;
                form.ImportanceCombo.Tag = (TaskImportanceType)model.ImportanceType;
                form.TypeCombo.Tag = (TaskType)model.Type;
                form.UserIdCombo.Tag = model.UserID;
                form.RoleIdCombo.Tag = model.RoleId;
                form.TitleTaskTxt.Text = model.Title;
                form.AnswerTaskTxt.Text = model.Answer;
                form.DetailsTaskTxt.Text = model.Description;
                form.ID.Text = model.ID.ToString();
                form.ShowDialog();
                tab = 99;
                ShowDataGridView(tab);
            }
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

        private void DeliverBtn_Click(object sender, EventArgs e)
        {
            tab = 4;
            ShowDataGridView(4);
        }

        private void SortDateBtn_Click(object sender, EventArgs e)
        {
            tab = 5;
            ShowDataGridView(5);
        }

        private void NotDeliverBtn_Click(object sender, EventArgs e)
        {
            tab = 6;
            ShowDataGridView(6);

        }
    }
}
