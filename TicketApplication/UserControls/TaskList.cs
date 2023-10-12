using BusinessLogic.Library;
using Domain.Library.Enums;
using Domain.Model;
using System;
using System.Windows.Forms;
using TicketApplication.Common;
using TicketApplication.Forms;

namespace TicketApplication.UserControls
{
    public partial class TaskList : UserControl
    {
        private readonly IBaseDatabaseRepository _baseDatabase;
        private TaskWorkService _taskWork;
        private Paging Paging;
        private int tab;
        private readonly TaskWorkShowGird Show;
        public TaskList()
        {
            InitializeComponent();
            Paging = new Paging();
            _baseDatabase = new BaseDatabaseRepository();
            Show = new TaskWorkShowGird();
        }

        private long ID;

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
            ID = Convert.ToInt32(ListTasks.Rows[ListTasks.CurrentRow.Index].Cells["آیدی"].Value);
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
                TaskWork entity= _taskWork.GetById(ID);
                entity.IsPassed = entity.IsPassed ? false : true;
                _taskWork.Save();
                ShowDataGridView(tab);
            }
        }

        private void تغییروضعیتتحویلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                TaskWork entity= _taskWork.GetById(ID);
                entity.IsDeliver = entity.IsDeliver ? false : true;
                _taskWork.Save();
                ShowDataGridView(tab);
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskWork entity= _taskWork.GetById(ID);
            entity.IsDeleted = true;
            _taskWork.Save();
            ShowDataGridView(tab);
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                TaskWork model= _taskWork.GetById(ID);

                NewTaskForm form = new NewTaskForm();
                form.SaamanehCombo.Tag = model.SamanaID;
                form.ImportanceCombo.Tag = (TaskImportanceType)model.ImportanceType;
                form.TitleTaskTxt.Text = model.Title;
                form.AnswerTaskTxt.Text = model.Answer;
                form.DetailsTaskTxt.Text = model.Description;
                form.ID.Text = model.ID.ToString();
                form.ShowDialog();
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
            Paging.Next();
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
