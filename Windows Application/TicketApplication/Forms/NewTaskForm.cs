using BusinessLogic.Library;
using Domain.Library.Enums;
using Domain.Library.KeyValues;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TicketApplication.Authentication;
using TicketApplication.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketApplication.Forms
{
    public partial class NewTaskForm : Form
    {

        #region Code

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public NewTaskForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void NewTaskForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<ComboboxItem<int>> TypeTask = new List<ComboboxItem<int>>{
            new ComboboxItem<int>{ Text = "-- انتخاب کنید --" ,Value = 0},
            new ComboboxItem<int>{ Text = "-- توسعه سامانه --" ,Value = 1},
            new ComboboxItem<int>{ Text = "-- پشتیبانی سامانه --" ,Value = 2},
            new ComboboxItem<int>{ Text = "-- سمپا --" ,Value = 3},
        };
        private List<ComboboxItem<int>>  ImportanceTask = new List<ComboboxItem<int>>{
            new ComboboxItem<int>{ Text = "-- انتخاب کنید --" ,Value = 0},
            new ComboboxItem<int>{ Text = "-- پایین --" ,Value = 1},
            new ComboboxItem<int>{ Text = "-- متوسط --" ,Value = 2},
            new ComboboxItem<int>{ Text = "-- بالا --" ,Value = 3},
            new ComboboxItem<int>{ Text = "-- فوری --" ,Value = 4},
            new ComboboxItem<int>{ Text = "-- خیلی فوری --" ,Value = 5},
        };

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaamanehCombo.SelectedItem == null || SaamanehCombo.SelectedIndex == 0)
                {
                    ERR.Text = "سامانه را انتخاب کنید";
                }
                else if (TitleTaskTxt.Text.Trim() == "")
                {
                    ERR.Text = "عنوان را وارد کنید";
                }
                else if (DetailsTaskTxt.Text.Trim() == "")
                {
                    ERR.Text = "توضیحات وارد کنید";
                }
                else if (ImportanceCombo.Text.Trim() == "" || ImportanceCombo.SelectedIndex == 0)
                {
                    ERR.Text = "الویت را وارد کنید";
                }
                else if (TypeCombo.Text.Trim() == "" || ImportanceCombo.SelectedIndex == 0)
                {
                    ERR.Text = "نوع تسک را وارد کنید";
                }
                else if (UserIdCombo.Text.Trim() == "" || UserIdCombo.SelectedIndex == 0)
                {
                    ERR.Text = "نوع تسک را وارد کنید";
                }
                else
                {

                    TaskWorkService service = new TaskWorkService();
                    var SID =((ComboboxItem < long >)SaamanehCombo.SelectedItem).Value;
                    var ImpID =((ComboboxItem < long >)ImportanceCombo.SelectedItem).Value;
                    var typeID =((ComboboxItem < long >)TypeCombo.SelectedItem).Value;
                    var userID =((ComboboxItem < long >)UserIdCombo.SelectedItem).Value;
                    var roleId =((ComboboxItem < long >)RoleIdCombo.SelectedItem).Value;

                    if (ID.Text == "0")
                    {
                        TaskWork entity = new TaskWork();
                        entity.Title = TitleTaskTxt.Text;
                        entity.Answer = AnswerTaskTxt.Text;
                        entity.Description = DetailsTaskTxt.Text;
                        entity.SamanaID = SID;
                        entity.ImportanceType = (TaskImportanceType)ImpID;
                        entity.Type = (TaskType)typeID;
                        entity.UserID = userID;
                        entity.RoleId = roleId;
                        entity.SamanaID = SID;
                        entity.CreatedByUserRoleID = AppUser.UserRoleID;
                        service.Insert(entity);
                    }
                    else
                    {
                        TaskWork entity = service.GetById(long.Parse(ID.Text));
                        entity.Title = TitleTaskTxt.Text;
                        entity.Answer = AnswerTaskTxt.Text;
                        entity.Description = DetailsTaskTxt.Text;
                        entity.SamanaID = SID;
                        entity.ImportanceType = (TaskImportanceType)ImpID;
                        entity.Type = (TaskType)typeID;
                        entity.UserID = userID;
                        entity.RoleId = roleId;
                        entity.SamanaID = SID;
                        entity.CreatedByUserRoleID = AppUser.UserRoleID;
                        service.Update(entity);
                    }
                    service.Save();
                    ERR.Text = "با موفقیت ذخیره شد";
                    this.Close();
                }
            }
            catch
            {
                ERR.Text = "خطای ورودی ها : ذخیره نشد";
            }
        }

        private void NewTaskForm_Load(object sender, EventArgs e)
        {
            FillSaamanehCombo();
            FillImportanceCombo();
            FillTypeCombo();
            FillUserCombo();
            FillRoleCombo();
        }



        //  Samaneh Combo Config
        private void FillSaamanehCombo()
        {
            SamanehService samana = new SamanehService();
            SaamanehCombo.Items.Clear();
            SaamanehCombo.Items.Add(new ComboboxItem<long>()
            {
                Text = "--- انتخاب کنید ---",
                Value = 0
            });
            var items = samana.GetAll().Where(x => !x.IsDeleted).ToList();
            foreach (var item in items)
            {
                SaamanehCombo.Items.Add(new ComboboxItem<long>()
                {
                    Text = item.Title,
                    Value = Convert.ToByte(item.ID)
                });
            }
            if (SaamanehCombo.Tag != null)
            {
                var index = 0;
                var id = SaamanehCombo.Tag;
                foreach (var i in SaamanehCombo.Items)
                {
                    var t = (ComboboxItem<long>)i;
                    if (t.Value == Convert.ToByte(id))
                    {
                        SaamanehCombo.SelectedIndex = index;
                    }
                    index++;
                }
            }
            else
            {
                SaamanehCombo.SelectedIndex = 0;

            }
        }
        //  Importance Combo Config
        private void FillImportanceCombo()
        {
            ImportanceCombo.Items.Clear();
            for (int i = 0; i < ImportanceTask.Count; i++)
            {
                ImportanceCombo.Items.Add(new ComboboxItem<long>()
                {
                    Text = $"{ImportanceTask[i]}",
                    Value = Convert.ToByte(i)
                });
            }
            if (ImportanceCombo.Tag != null)
            {
                var index = 0;
                var id = (int) (TaskImportanceType)ImportanceCombo.Tag;
                foreach (var i in ImportanceCombo.Items)
                {
                    var t = (ComboboxItem<long>)i;
                    if (t.Value == Convert.ToByte(id))
                    {
                        ImportanceCombo.SelectedIndex = index;
                    }
                    index++;
                }
            }
            else
            {
                ImportanceCombo.SelectedIndex = 0;
            }
        }
        //  TaskType Combo Config
        private void FillTypeCombo()
        {
            TypeCombo.Items.Clear();
            for (int i = 0; i < TypeTask.Count; i++)
            {
                TypeCombo.Items.Add(new ComboboxItem<long>()
                {
                    Text = $"{TypeTask[i]}",
                    Value = Convert.ToByte(i)
                });
            }
            if (TypeCombo.Tag != null)
            {
                var index = 0;
                var id = TypeCombo.Tag;
                foreach (var i in TypeCombo.Items)
                {
                    var t = (ComboboxItem<long>)i;
                    if (t.Value == Convert.ToByte(id))
                    {
                        TypeCombo.SelectedIndex = index;
                    }
                    index++;
                }
            }
            else
            {
                TypeCombo.SelectedIndex = 0;
            }
        }
        //  UserId Combo Config
        private void FillUserCombo()
        {
            UserService service = new UserService();
            UserIdCombo.Items.Clear();
            UserIdCombo.Items.Add(new ComboboxItem<long>()
            {
                Text = "--- انتخاب کنید ---",
                Value = 0
            });
            var users = service.ReadKeyValue();
            for (int i = 0; i < users.Data.Count; i++)
            {
                UserIdCombo.Items.Add(users.Data[i]);
            }
            if (UserIdCombo.Tag != null)
            {
                var index = 0;
                var id = UserIdCombo.Tag;
                foreach (var i in UserIdCombo.Items)
                {
                    var t = (ComboboxItem<long>)i;
                    if (t.Value == Convert.ToByte(id))
                    {
                        UserIdCombo.SelectedIndex = index;
                    }
                    index++;
                }
            }
            else
            {
                UserIdCombo.SelectedIndex = 0;
            }
        }
        //  RoleId Combo Config
        private void FillRoleCombo()
        {
            RoleService service = new RoleService();
            RoleIdCombo.Items.Clear();
            RoleIdCombo.Items.Add(new ComboboxItem<long>()
            {
                Text = "--- انتخاب کنید ---",
                Value = 0
            });
            var roles = service.ReadKeyValue();
            for (int i = 0; i < roles.Data.Count; i++)
            {
                RoleIdCombo.Items.Add(roles.Data[i]);
            }
            if (RoleIdCombo.Tag != null)
            {
                var index = 0;
                var id = RoleIdCombo.Tag;
                foreach (var i in RoleIdCombo.Items)
                {
                    var t = (ComboboxItem<long>)i;
                    if (t.Value == Convert.ToByte(id))
                    {
                        RoleIdCombo.SelectedIndex = index;
                    }
                    index++;
                }
            }
            else
            {
                RoleIdCombo.SelectedIndex = 0;
            }
        }





    }
}
