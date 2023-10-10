using BusinessLogic.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketApplication.Forms;

namespace TicketApplication.UserControls
{
    public partial class CartablePanel : UserControl
    {
        private readonly TaskWorkService _service;
        public delegate void ClickButton();
        public CartablePanel()
        {
            InitializeComponent();
            _service = new TaskWorkService();
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
            var tag = (sender as Button).Tag;
            var model = _service.GetById(Int64.Parse(tag.ToString()));
            SamNameLBL.Text = $"{model.Samaneh.Title}";
            TaskSaveDateLBL.Text = GetPersionDate(model.CreateDate);
            TaskTitleLBL.Text = model.Title;
            TaskDescriptionLBL.Text = model.Description;
            TaskAnswerLBL.Text = model.Answer;
            DescriptionTxt.Text = model.Description;
            AnswerTxt.Text = model.Answer;
            TaskAddDescBtn.Tag = tag;
            TaskAnswerBtn.Tag = tag;
            DeliverBtn.Tag= tag;
            PassBtn.Tag= tag;
            this.Tag = tag;
        }


        private void CartablePanel_Load(object sender, EventArgs e)
        {
            var data = _service.GetAllIncluded();
            int x = 20,y = 20;
            for (int i = 0; i < data.Count; i++)
            {
                Button newButton = new Button();
                newButton.FlatStyle = FlatStyle.Popup;
                if (data[i].IsPassed)
                {
                    newButton.BackColor = System.Drawing.Color.FromArgb(146, 220, 148);
                }
                else
                {
                    switch (Convert.ToByte(data[i].ImportanceType))
                    {
                        case 0:
                            {
                                newButton.BackColor = System.Drawing.Color.FromArgb(255, 255, 92);
                                break;
                            }
                        case 1:
                            {
                                newButton.BackColor = System.Drawing.Color.FromArgb(255, 191, 92);
                                break;
                            }
                        case 2:
                            {
                                newButton.BackColor = System.Drawing.Color.FromArgb(255, 147, 92);
                                break;
                            }
                        case 3:
                            {
                                newButton.BackColor = System.Drawing.Color.FromArgb(188, 76, 21);
                                break;
                            }
                        case 4:
                            {
                                newButton.BackColor = System.Drawing.Color.FromArgb(255, 85, 0);
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                newButton.ForeColor = System.Drawing.Color.Black;
                var text = $"{data[i].Title}-{data[i].Samaneh.Title} \n {($"{((int)(DateTime.Now - data[i].CreateDate).TotalDays)} روز گذشت")}";
                CreateButton(newButton, x, y, text, data[i].ID);
                x += 160;
                if (i == 6)
                {
                    y = 165;
                    x = 20;
                }
                this.Controls.Add(newButton);
            }
        }

        private void TaskAddDescBtn_Click(object sender, EventArgs e)
        {
            var tag = (sender as Button).Tag;
            if (tag != null)
            {
                if (DescriptionTxt.Visible)
                {
                    var model = _service.GetById(tag);
                    model.Description = DescriptionTxt.Text;
                    _service.Save();
                    DescriptionTxt.Visible = false;
                    TaskAddDescBtn.Text = "افزودن یادداشت";
                    TaskAddDescBtn.ForeColor = System.Drawing.Color.White;
                    TaskAddDescBtn.BackColor = System.Drawing.Color.SteelBlue;
                }
                else
                {
                    
                    TaskAddDescBtn.Text = "ذخیره سازی تغییرات";
                    TaskAddDescBtn.BackColor = System.Drawing.Color.FromArgb(0, 0, 51);
                    TaskAddDescBtn.ForeColor = System.Drawing.Color.White;
                    DescriptionTxt.Visible = true;

                }
            }
            else
            {
                Message("هنوز هیچ تسک انتخاب نشده است لطفا یک تسک را برای انجام فعالیت انتخاب کنید....", System.Drawing.Color.Red);
            }

        }

        private void TaskAnswerBtn_Click(object sender, EventArgs e)
        {
            var tag = (sender as Button).Tag;
            if (tag != null)
            {
                if (AnswerTxt.Visible)
                {
                    var model = _service.GetById(tag);
                    model.Answer = AnswerTxt.Text;
                    _service.Save();
                    AnswerTxt.Visible = false;
                    TaskAnswerBtn.Text = "ارایه پاسخ";
                    TaskAnswerBtn.ForeColor = System.Drawing.Color.Black;
                    TaskAnswerBtn.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }
                else
                {
                    
                    TaskAnswerBtn.Text = "ذخیره سازی تغییرات";
                    TaskAnswerBtn.BackColor = System.Drawing.Color.FromArgb(0, 0, 51);
                    TaskAnswerBtn.ForeColor = System.Drawing.Color.White;
                    AnswerTxt.Visible = true;
                }
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
                this.Refresh();
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
                this.Refresh();
            }
            else
            {
                Message("هنوز هیچ تسک انتخاب نشده است لطفا یک تسک را برای انجام فعالیت انتخاب کنید....", System.Drawing.Color.Red);
            }

        }
        private void Message(string msg,Color color)
        {
            MessageTxt.ForeColor = color;
            MessageTxt.Text = msg;
        }
    }
}
