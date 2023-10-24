using Infrastrucure.Library.Repository.TaskService;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TicketApplication.Forms;

namespace TicketApplication.UserControls
{
    public partial class CartablePanel : UserControl
    {
        public delegate void ClickButton();
        private object _sender;
        private EventArgs _e;
        public CartablePanel()
        {
            InitializeComponent();
        }
        public string GetPersionDate(DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            var pdate = string.Format("{0}/{1}/{2} {3}:{4}:{5}",
                pc.GetYear(date), pc.GetMonth(date), pc.GetDayOfMonth(date),
                pc.GetHour(date),pc.GetMinute(date),pc.GetSecond(date)
                );
            return pdate;
        }
        private Button CreateButton(Button button, int x, int y, string text, long ID)
        {
            button.Text = ($"{text}");
            button.Location = new Point(x, y);
            button.Tag = ID;
            button.Size = new Size(150, 130);
            button.Click += new EventHandler(ShowData);
            return button;
        }
        protected void ShowData(object sender, EventArgs e)
        {
            TaskService _taskService = new TaskService();
            var tag = (sender as Button).Tag;
            var model = _taskService.GetById(Int64.Parse(tag.ToString())).Data;
            SamNameLBL.Text = $"{model.Samaneh.Title}";
            TaskSaveDateLBL.Text = GetPersionDate(model.CreateDate);
            TaskTitleLBL.Text = model.Title;
            TaskDescriptionLBL.Text = model.Description;
            TaskAnswerLBL.Text = model.Answer;
            DescriptionTxt.Text = model.Description;
            AnswerTxt.Text = model.Answer;
            TaskAddDescBtn.Tag = tag;
            TaskAnswerBtn.Tag = tag;
            DeliverBtn.Tag = tag;
            PassBtn.Tag = tag;
            this.Tag = tag;
            MessageTxt.Text = "";
        }


        private void CartablePanel_Load(object sender, EventArgs e)
        {
            TaskService _taskService = new TaskService();
            _sender = sender;
            _e = e;
            var data = _taskService.GetAllIncluded();
            int x = 20,y = 20;

            var btn = this.Controls.OfType<Button>().OrderBy(z => z.Text).ToList() ;
            foreach (var c in btn)
            {
                if (c.Text != "")
                {
                    this.Controls.Remove(c);
                    c.Dispose();
                }
            }


            for (int i = 0; i < data.Data.Count; i++)
            {
                Button newButton = new Button();
                newButton.FlatStyle = FlatStyle.Popup;
                switch (Convert.ToByte(data.Data[i].ImportanceType))
                {
                    case 1:
                        {
                            newButton.BackColor = System.Drawing.Color.FromArgb(255, 255, 92);
                            break;
                        }
                    case 2:
                        {
                            newButton.BackColor = System.Drawing.Color.FromArgb(255, 191, 92);
                            break;
                        }
                    case 3:
                        {
                            newButton.BackColor = System.Drawing.Color.FromArgb(255, 147, 92);
                            break;
                        }
                    case 4:
                        {
                            newButton.BackColor = System.Drawing.Color.FromArgb(188, 76, 21);
                            break;
                        }
                    case 5:
                        {
                            newButton.BackColor = System.Drawing.Color.FromArgb(255, 85, 0);
                            break;
                        }
                    default:
                        {
                            newButton.BackColor = System.Drawing.Color.FromArgb(255, 250, 150);
                            break;
                        }
                }

                if (data.Data[i].IsDeliver)
                {
                    newButton.BackColor = System.Drawing.Color.FromArgb(255, 0, 110);
                }
                if (data.Data[i].IsPassed)
                {
                    newButton.BackColor = System.Drawing.Color.FromArgb(146, 220, 148);
                }
                newButton.ForeColor = System.Drawing.Color.Black;
                var text = $"{data.Data[i].Title} \n {data.Data[i].Samaneh.Title} \n {($"{((int)(DateTime.Now - data.Data[i].CreateDate).TotalDays)} روز گذشت")}";
                CreateButton(newButton, x, y, text, data.Data[i].ID);
                x += 160;
                if (i == 6)
                {
                    y = 165;
                    x = 20;
                }
                this.Controls.Add(newButton);
            }
            data.Data.Clear();

        }

        private async void TaskAddDescBtn_Click(object sender, EventArgs e)
        {
            TaskService _taskService = new TaskService();
            var tag = (sender as Button).Tag;
            if (tag != null)
            {
                if (DescriptionTxt.Visible)
                {
                    var model = await _taskService.GetById(tag);
                    model.Description = DescriptionTxt.Text;
                    await _taskService.Save();
                    DescriptionTxt.Visible = false;
                    TaskAddDescBtn.Text = "افزودن یادداشت";
                    TaskAddDescBtn.ForeColor = System.Drawing.Color.White;
                    TaskAddDescBtn.BackColor = System.Drawing.Color.DodgerBlue;
                }
                else
                {

                    TaskAddDescBtn.Text = "ذخیره سازی تغییرات";
                    TaskAddDescBtn.BackColor = System.Drawing.Color.FromArgb(0, 0, 51);
                    TaskAddDescBtn.ForeColor = System.Drawing.Color.White;
                    DescriptionTxt.Visible = true;
                }
                TaskDescriptionLBL.Text = DescriptionTxt.Text;
            }
            else
            {
                Message("هنوز هیچ تسک انتخاب نشده است لطفا یک تسک را برای انجام فعالیت انتخاب کنید....", System.Drawing.Color.Red);
            }

        }

        private async void TaskAnswerBtn_Click(object sender, EventArgs e)
        {
            TaskService _taskService = new TaskService();
            var tag = (sender as Button).Tag;
            if (tag != null)
            {
                if (AnswerTxt.Visible)
                {
                    var model = await _taskService.GetById(tag);
                    model.Answer = AnswerTxt.Text;
                    await _taskService.Save();
                    AnswerTxt.Visible = false;
                    TaskAnswerBtn.Text = "ارایه پاسخ";
                    TaskAnswerBtn.ForeColor = System.Drawing.Color.White;
                    TaskAnswerBtn.BackColor = System.Drawing.Color.DodgerBlue;
                }
                else
                {

                    TaskAnswerBtn.Text = "ذخیره سازی تغییرات";
                    TaskAnswerBtn.BackColor = System.Drawing.Color.FromArgb(0, 0, 51);
                    TaskAnswerBtn.ForeColor = System.Drawing.Color.White;
                    AnswerTxt.Visible = true;
                }
                TaskAnswerLBL.Text = AnswerTxt.Text;
            }
            else
            {
                Message("هنوز هیچ تسک انتخاب نشده است لطفا یک تسک را برای انجام فعالیت انتخاب کنید....", System.Drawing.Color.Red);
            }
        }

        private void DeliverBtn_Click(object sender, EventArgs e)
        {
            var tag = (sender as Button).Tag;
            if (tag != null)
            {
                MessageBoxForm box = new MessageBoxForm();
                box.Name = "DeliverTask";
                box.YesBtn.Tag = Tag;
                box.MsgTxt.Text = "آیا از تحویل دادن این تسک مطمیین هستید؟";
                box.ShowDialog();
                Message("عملیات با موفقیت انجام شد", System.Drawing.Color.DarkGreen);
                this.CartablePanel_Load(_sender, _e);
                Clear();
            }
            else
            {
                Message("هنوز هیچ تسک انتخاب نشده است لطفا یک تسک را برای انجام فعالیت انتخاب کنید....", System.Drawing.Color.Red);
            }

        }

        private void PassBtn_Click(object sender, EventArgs e)
        {
            var tag = (sender as Button).Tag;
            if (tag != null)
            {
                MessageBoxForm box = new MessageBoxForm();
                box.Name = "PassTask";
                box.YesBtn.Tag = Tag;
                box.MsgTxt.Text = "آیا از پاس کردن این تسک مطمیین هستید؟";
                box.ShowDialog();
                Message("عملیات با موفقیت انجام شد", System.Drawing.Color.DarkGreen);
                this.CartablePanel_Load(_sender, _e);
            }
            else
            {
                Message("هنوز هیچ تسک انتخاب نشده است لطفا یک تسک را برای انجام فعالیت انتخاب کنید....", System.Drawing.Color.Red);
            }

        }
        private void Message(string msg, Color color)
        {
            MessageTxt.ForeColor = color;
            MessageTxt.Text = msg;
        }
        private void Clear()
        {
            SamNameLBL.Text = string.Empty;
            TaskSaveDateLBL.Text = string.Empty;
            TaskTitleLBL.Text = string.Empty;

            DescriptionTxt.Text = string.Empty;
            TaskDescriptionLBL.Text = string.Empty;

            AnswerTxt.Text = string.Empty;
            TaskAnswerLBL.Text = string.Empty;

            DeliverBtn.Tag = null;
            PassBtn.Tag = null;
            TaskAddDescBtn.Tag = null;
            TaskAnswerBtn.Tag = null;
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
