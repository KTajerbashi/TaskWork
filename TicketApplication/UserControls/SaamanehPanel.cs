using BusinessLogic.Library;
using Domain.Model;
using System;
using System.Windows.Forms;
using TicketApplication.Common;

namespace TicketApplication.UserControls
{
    public partial class SaamanehPanel : UserControl
    {
        private readonly IBaseDatabaseRepository _baseDatabase;
        SamanehService _service;
        Paging Paging;
        private readonly SaamanehShowGrid Show;

        public SaamanehPanel()
        {
            InitializeComponent();
            _service = new SamanehService();
            _baseDatabase = new BaseDatabaseRepository();
            Show = new SaamanehShowGrid();
            Paging = new Paging();

        }
        public void ShowDataGridView(int type)
        {
            string QUERY = "";
            switch (type)
            {
                case 0: // همه
                    {
                        QUERY = Show.ShowAll(Paging.Order(Paging.Page));
                        break;
                    }
                case 1: // تاریخ
                    {
                        QUERY = Show.ShowFDateT(FromDate.Value.ToString(), ToDate.Value.ToString());
                        break;
                    }
                case 2: // نام
                    {
                QUERY = Show.SearchText(SearchTxt.Text);
                        break;
                    }
                case 3: // کلید
                    {
                        //QUERY = Show.ShowSearchDate(SearchTxt.Text);
                        break;
                    }
                default: // جدید ترین
                    {
                        QUERY = Show.ShowAll(Paging.Order(Paging.Page));
                        break;
                    }
            }
            SaamanehDG.DataSource = _baseDatabase.Execute(QUERY);

        }


        private void InsertBtn_Click(object sender, EventArgs e)
        {
            SamanehService _service = new SamanehService();
            if (Int32.Parse(ID.Text) > 0)
            {
                //  Update
                var model = _service.GetById(Int32.Parse(ID.Text));
                model.Name = SmnaNameTxt.Text;
                model.Title = SmnaTitleTxt.Text;
                model.UpdateDate = DateTime.Now;
                model.UpdateBy = 1;
                model.Description = DescriptionSTxt.Text;
                _service.Update(model);
            }
            else
            {
                //  Insert
                Samaneh entity = new Samaneh
                {
                    Name=SmnaNameTxt.Text,
                    Title= SmnaTitleTxt.Text,
                    CreateDate = DateTime.Now,
                    CreatedByUserRoleID=1,
                    Description=DescriptionSTxt.Text,
                    IsActive = true,
                    IsDeleted = false,
                };
                _service.Insert(entity);
            }
            InsertBtn.Text = "ثبت";
            ID.Text = "0";
            _service.Save();
            ShowDataGridView(0);
        }

        private void SaamanehPanel_Load(object sender, EventArgs e)
        {
            FromDate.UsePersianFormat = true;
            ToDate.UsePersianFormat = true;
            FromDate.Value = DateTime.Now;
            ToDate.Value = DateTime.Now;
            ShowDataGridView(0);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ShowDataGridView(2);
        }

        private void Reloding_Click(object sender, EventArgs e)
        {
            ShowDataGridView(0);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            Paging.Next();
            ShowDataGridView(0);
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            Paging.Prev();
            ShowDataGridView(0);
        }

        private void SearchDateBtn_Click(object sender, EventArgs e)
        {
            ShowDataGridView(1);
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var model = _service.GetById(Int64.Parse(ID.Text));
            SmnaNameTxt.Text = model.Name;
            SmnaTitleTxt.Text = model.Title;
            DescriptionSTxt.Text = model.Description;
            InsertBtn.Text = "ویرایش";
        }

        private void تغییروضعیتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var model = _service.GetById(Int64.Parse(ID.Text));
            model.IsActive = model.IsActive ? false : true;
            _service.Update(model);
            _service.Save();
            ShowDataGridView(0);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var model = _service.GetById(Int64.Parse(ID.Text));
            model.IsDeleted = true;
            _service.Update(model);
            _service.Save();
            ShowDataGridView(0);
        }

        private void SaamanehDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = Convert.ToString(SaamanehDG.Rows[SaamanehDG.CurrentRow.Index].Cells["آیدی"].Value);

        }

        private void SaamanehDG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
    }
}
