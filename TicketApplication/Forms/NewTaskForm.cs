using BusinessLogic.Library;
using Domain.Library.Enums;
using Domain.Library.KeyValues;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
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
        private List<string> importance = new List<string>{"کم","متوسط","مهم","خیلی مهم","فوری" };
        private List<string> typetask = new List<string>{ "-- انتخاب کنید --", "-- توسعه سامانه --","-- پشتیبانی سامانه --","-- سمپا --" };

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
                    ERR.Text = "الویت را وارد کنید";
                }
                else
                {

                    TaskWorkService service = new TaskWorkService();
                    var SID =((ComboboxItem)SaamanehCombo.SelectedItem).Value;
                    var ImpID =((ComboboxItem)ImportanceCombo.SelectedItem).Value;


                    if (ID.Text == "0")
                    {
                        TaskWork entity = new TaskWork();
                        entity.Title = TitleTaskTxt.Text;
                        entity.Answer = AnswerTaskTxt.Text;
                        entity.Description = DetailsTaskTxt.Text;
                        entity.SamanaID = SID;
                        entity.CreatedByUserRoleID = 1;
                        entity.ImportanceType = (TaskImportanceType)ImpID;
                        service.Insert(entity);
                    }
                    else
                    {
                        TaskWork entity = service.GetById(long.Parse(ID.Text));
                        entity.Title = TitleTaskTxt.Text;
                        entity.Description = DetailsTaskTxt.Text;
                        entity.Answer = AnswerTaskTxt.Text;
                        entity.SamanaID = SID;
                        entity.ImportanceType = (TaskImportanceType)ImpID;
                        entity.CreatedByUserRoleID = 1;
                        entity.UpdateBy = 1;
                        entity.UpdateDate = DateTime.Now;
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
            FillCombo();
            FillTypeCombo();
            SelectCombo();
        }
        private void FillCombo()
        {
            SamanehService samana = new SamanehService();
            var items = samana.GetAll().Where(x => !x.IsDeleted).ToList();
            if (TitleTaskTxt.Text.Trim().Length == 0)
            {
                SaamanehCombo.Items.Clear();
                ImportanceCombo.Items.Clear();
                TypeCombo.Items.Clear();
                SaamanehCombo.Items.Add(new ComboboxItem()
                {
                    Text = "--- انتخاب کنید ---",
                    Value = 0
                });
                ImportanceCombo.Items.Add(new ComboboxItem()
                {
                    Text = "--- انتخاب کنید ---",
                    Value = 0
                });


            }
            foreach (var item in items)
            {
                SaamanehCombo.Items.Add(new ComboboxItem()
                {
                    Text = item.Title,
                    Value = Convert.ToByte(item.ID)
                });
            }
            for (int i = 0; i < 5; i++)
            {
                ImportanceCombo.Items.Add(new ComboboxItem()
                {
                    Text = importance[i],
                    Value = Convert.ToByte(i)
                });
            }


        }
        private void FillTypeCombo()
        {
            for (int i = 0; i < typetask.Count; i++)
            {
                TypeCombo.Items.Add(new ComboboxItem()
                {
                    Text = $"{typetask[i]}",
                    Value = Convert.ToByte(i)
                });
            }
        }
        private void SelectCombo()
        {
            if (ImportanceCombo.Tag != null)
            {
                int index = 0;
                var samanehId = SaamanehCombo.Tag;
                var importanceId = (int) (TaskImportanceType)ImportanceCombo.Tag;
                foreach (var i in SaamanehCombo.Items)
                {
                    var t = (ComboboxItem)i;
                    if (t.Value == Convert.ToByte(samanehId))
                    {
                        SaamanehCombo.SelectedIndex = index;
                    }
                    index++;
                }
                index = 0;
                foreach (var i in ImportanceCombo.Items)
                {
                    var t = (ComboboxItem)i;
                    if (t.Value == Convert.ToByte(importanceId))
                    {
                        ImportanceCombo.SelectedIndex = index;
                    }
                    index++;
                }
            }
            else
            {
                SaamanehCombo.SelectedIndex = 0;
                ImportanceCombo.SelectedIndex = 0;
                TypeCombo.SelectedIndex = 0;
            }
        }
    }
}
