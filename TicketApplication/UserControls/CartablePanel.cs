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
            button.Size = new Size(160, 140);
            button.Click += new EventHandler(ShowData);
            return button;
        }
        protected void ShowData(object sender, EventArgs e)
        {
            var tag = (sender as Button).Tag;
            var model = _service.GetById(Int64.Parse(tag.ToString()));
            SamNameLBL.Text = model.Samaneh.Title;
            TaskSaveDateLBL.Text = GetPersionDate(model.CreateDate);
            TaskTitleLBL.Text = model.Title;
            TaskDayLaterLBL.Text = ($"{((int)(DateTime.Now - model.CreateDate).TotalDays)} روز گذشت");
            TaskDescriptionLBL.Text = model.Description;
            TaskAnswerLBL.Text = model.Answer;
            TaskAddDescBtn.Tag = tag;
            TaskAnswerBtn.Tag = tag;
        }


        private void CartablePanel_Load(object sender, EventArgs e)
        {
            var data = _service.GetAllIncluded();
            int x = 50,y = 20;
            for (int i = 0; i < 14; i++)
            {
                Button newButton = new Button();
                newButton.FlatStyle = FlatStyle.Popup;
                if (data[i].IsPassed)
                {
                    if (data[i].IsDeliver)
                    {
                        newButton.BackColor = System.Drawing.Color.ForestGreen;
                    }
                    else
                    {
                        newButton.BackColor = System.Drawing.Color.CadetBlue;
                    }
                }
                else
                {
                    newButton.BackColor = System.Drawing.Color.OrangeRed;
                }
                newButton.ForeColor = System.Drawing.Color.White;
                CreateButton(newButton, x, y, $"{data[i].Title}-{data[i].Samaneh.Title}", data[i].ID);
                x += 165;
                if (i == 6)
                {
                    y = 170;
                    x = 50;
                }
                this.Controls.Add(newButton);
            }
            var yy = y;
        }

        private void TaskAddDescBtn_Click(object sender, EventArgs e)
        {
            var tag = (sender as Button).Tag;

        }

        private void TaskAnswerBtn_Click(object sender, EventArgs e)
        {
            var tag = (sender as Button).Tag;

        }
    }
}
