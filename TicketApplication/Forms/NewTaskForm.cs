﻿using BusinessLogic.Library;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TicketApplication.UserControls;

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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            TaskWorkService service = new TaskWorkService();
            var SID =((ComboboxItem)comboBox1.SelectedItem).Value;

            TaskWork entity = new TaskWork();
            entity.Title = TitleTaskTxt.Text;
            entity.Description = DetailsTaskTxt.Text;
            entity.SamanaID = SID;
            entity.CreatedByUserRoleID = 1;
            if (ID.Text == "0")
            {
                service.Insert(entity);
            }
            else
            {
               service.Update(entity);
            }
            service.Save();
            this.Close();
        }

        private void NewTaskForm_Load(object sender, EventArgs e)
        {
            SamanehService samana = new SamanehService();
            comboBox1.Items.Clear();
            var items = samana.GetAll();
            foreach (var item in items)
            {
                comboBox1.Items.Add(new ComboboxItem()
                {
                    Text = item.Title,
                    Value = item.ID
                });
            }
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public long Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

    }
}