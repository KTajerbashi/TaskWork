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
            ListTasks.DataSource = _baseDatabase.Execute(@"SELECT * FROM BES.TaskWorks");

        }


    }
}
