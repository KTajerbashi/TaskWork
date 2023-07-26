using BusinessLogic.Library;
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

namespace TicketApplication.UserControls
{
    public partial class TaskList : UserControl
    {
        private readonly IBaseDatabaseRepository _baseDatabase;
        public TaskList()
        {
            InitializeComponent();
            _baseDatabase = new BaseDatabaseRepository();
        }

        private void TaskList_Load(object sender, EventArgs e)
        {
            TaskWorkService taskWorkService= new TaskWorkService();
            ListTasks.DataSource = _baseDatabase.Execute(@"
SELECT        BUS.TaskWorks.Title AS تسک, BUS.TaskWorks.Description AS توضیحات, BUS.TaskWorks.CreateDate AS [تاریخ ثبت], BUS.Samanehs.Name AS سامانه, BUS.Samanehs.Title AS عنوان
FROM            BUS.TaskWorks INNER JOIN
                         BUS.Samanehs ON BUS.TaskWorks.SamanaID = BUS.Samanehs.ID
");

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
