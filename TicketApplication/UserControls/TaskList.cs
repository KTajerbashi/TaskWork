using BusinessLogic.Library;
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
        TaskWorkService _taskWork;
        Paging Paging;
        private readonly TaskWorkShowGird Show;
        public TaskList()
        {
            InitializeComponent();
            Paging = new Paging();
            _baseDatabase = new BaseDatabaseRepository();
            Show = new TaskWorkShowGird();
        }
        private long ID;

        public void ShowDataGridView(int type)
        {
            _taskWork = new TaskWorkService();
            string QUERY;
            switch (type)
            {
                case 0: // الفبا
                    {
                        QUERY = Show.ShowAlphabet();
                        break;
                    }
                case 1: // تمام شده
                    {
                        QUERY = Show.ShowPassed();
                        break;
                    }
                case 2: // تمام نشده
                    {
                        QUERY = Show.ShowNotPassed();
                        break;
                    }
                case 3: // جستجو
                    {
                        QUERY = Show.ShowSearchDate(SearchTxt.Text);
                        break;
                    }
                case 4: // تحویل شده
                    {
                        QUERY = Show.ShowDeliver();
                        break;
                    }
                default: // جدید ترین
                    {
                        QUERY = Show.ShowAll(Paging.Order(Paging.Page));
                        break;
                    }
            }
            ListTasks.DataSource = _baseDatabase.Execute(QUERY);

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
            ShowDataGridView(1);
        }

        private void AlphabetBtn_Click(object sender, EventArgs e)
        {
            ShowDataGridView(0);
        }

        private void NotPassBtn_Click(object sender, EventArgs e)
        {
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
                ShowDataGridView(99);
            }
        }

        private void تغییروضعیتتحویلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                TaskWork entity= _taskWork.GetById(ID);
                entity.IsDeliver = entity.IsDeliver ? false : true;
                _taskWork.Save();
                ShowDataGridView(99);
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskWork entity= _taskWork.GetById(ID);
            entity.IsDeleted = true;
            _taskWork.Save();
            ShowDataGridView(99);
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                TaskWork model= _taskWork.GetById(ID);

                NewTaskForm form = new NewTaskForm();
                form.comboBox1.SelectedValue = model.SamanaID;
                form.TitleTaskTxt.Text = model.Title;
                form.AnswerTaskTxt.Text = model.Answer;
                form.DetailsTaskTxt.Text = model.Description;
                form.ID.Text = model.ID.ToString();
                form.ShowDialog();
                ShowDataGridView(99);
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
            ShowDataGridView(4);
        }
    }
}
