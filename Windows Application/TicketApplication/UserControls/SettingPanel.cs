using Infrastrucure.Library.Repository.UserService;
using System.Windows.Forms;

namespace TicketApplication.UserControls
{
    public partial class SettingPanel : UserControl
    {
        public SettingPanel()
        {
            InitializeComponent();
        }

        private void UserTab_Click(object sender, System.EventArgs e)
        {
            UserService userService = new UserService();
            var a = userService.GetAll();
            DataGridUsers.DataSource = a;
        }
    }
}
