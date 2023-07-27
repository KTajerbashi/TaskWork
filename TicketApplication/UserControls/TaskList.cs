using BusinessLogic.Library;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketApplication.Forms;

namespace TicketApplication.UserControls
{
    public partial class TaskList : UserControl
    {
        private readonly IBaseDatabaseRepository _baseDatabase;
        TaskWorkService _taskWork;
        public TaskList()
        {
            InitializeComponent();
            _baseDatabase = new BaseDatabaseRepository();
        }
        private long ID;

        public void ShowDataGridView(int type)
        {
            _taskWork = new TaskWorkService();
            string QUERY;
            string ORDER = " ORDER BY BUS.TaskWorks.ID DESC ";
            string WHERE = "WHERE (BUS.TaskWorks.IsActive = 1) AND (BUS.TaskWorks.IsDeleted = 0)";
            switch (type)
            {
                case 0: // الفبا
                    {
                        ORDER = " ORDER BY BUS.TaskWorks.Title ";
                        break;
                    }
                case 1: // تمام شده
                    {
                        WHERE = "WHERE (BUS.TaskWorks.IsActive = 1) AND (BUS.TaskWorks.IsDeleted = 0) AND (BUS.TaskWorks.IsPassed = 1)";
                        break;
                    }
                case 2: // تمام نشده
                    {
                        WHERE = "WHERE (BUS.TaskWorks.IsActive = 1) AND (BUS.TaskWorks.IsDeleted = 0) AND (BUS.TaskWorks.IsPassed = 0)";
                        break;
                    }
                case 3: // جستجو
                    {
                        WHERE = $@"
WHERE 
    (BUS.TaskWorks.IsActive = 1) 
AND (BUS.TaskWorks.IsDeleted = 0)
AND (BUS.TaskWorks.Title LIKE N'%{SearchTxt.Text}%')
";
                        break;
                    }
                default: // جدید ترین
                    {
                        ORDER = " ORDER BY BUS.TaskWorks.ID DESC ";
                        break;
                    }
            }
            QUERY = $@"
                    SELECT			BUS.TaskWorks.ID AS [آیدی], BUS.TaskWorks.Title AS [عنوان تسک],
                    				BUS.TaskWorks.Description AS [توضیحات تسک],
                    				format(BUS.TaskWorks.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
                    				CASE 
                    					WHEN BUS.TaskWorks.IsPassed = 0 THEN N'نخیر'
                    					ELSE N'بلی'
                    				END [پاس شده؟], 
                    				CASE 
                    					WHEN BUS.TaskWorks.IsDeliver = 0 THEN N'نخیر'
                    					ELSE N'بلی'
                    				END [تحویل شده؟], 
                    				BUS.Samanehs.Title AS سامانه
                    FROM            BUS.TaskWorks INNER JOIN
                                             BUS.Samanehs ON BUS.TaskWorks.SamanaID = BUS.Samanehs.ID
                    {WHERE}
                    {ORDER}
                   ";
            ListTasks.DataSource = _baseDatabase.Execute(QUERY);

        }
        private void TaskList_Load(object sender, EventArgs e)
        {
            ShowDataGridView(4);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ShowDataGridView(3);
        }

        private void NewTaskBtn_Click(object sender, EventArgs e)
        {
            ShowDataGridView(4);
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
            TaskWork entity= _taskWork.GetById(ID);
            entity.IsPassed = entity.IsPassed ? false : true;
            _taskWork.Save();
            ShowDataGridView(4);
        }

        private void تغییروضعیتتحویلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskWork entity= _taskWork.GetById(ID);
            entity.IsDeliver = entity.IsDeliver ? false : true;
            _taskWork.Save();
            ShowDataGridView(4);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskWork entity= _taskWork.GetById(ID);
            entity.IsDeleted = true;
            _taskWork.Save();
            ShowDataGridView(4);
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                TaskWork model= _taskWork.GetById(ID);

                NewTaskForm form = new NewTaskForm();
                form.comboBox1.SelectedValue = model.SamanaID;
                form.TitleTaskTxt.Text = model.Title;
                form.DetailsTaskTxt.Text = model.Description;
                form.ID.Text = model.ID.ToString();
                form.ShowDialog();
                ShowDataGridView(4);
            }
        }
    }
}
