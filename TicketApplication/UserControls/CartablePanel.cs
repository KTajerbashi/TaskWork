using BusinessLogic.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApplication.UserControls
{
    public partial class CartablePanel : UserControl
    {
        private readonly TaskWorkService _service;
        private void button1_Click(object sender, EventArgs e)
        {

        }
        public delegate void ClickButton();
        public CartablePanel()
        {
            InitializeComponent();
            _service = new TaskWorkService();
        }
        private Button CreateButton(Button button, int x, int y, string text,long ID)
        {
            button.Text = text;
            button.Location = new Point(x, y);
            button.Size = new Size(160, 140);
            button.TabIndex= (int)ID;
            return button;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
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
                        newButton.BackColor = System.Drawing.Color.GreenYellow;
                    }
                    else
                    {
                        newButton.BackColor = System.Drawing.Color.DeepSkyBlue;
                    }
                }
                else
                {
                    newButton.BackColor = System.Drawing.Color.OrangeRed;
                }
                newButton.ForeColor = System.Drawing.Color.Black;
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
    }
}
