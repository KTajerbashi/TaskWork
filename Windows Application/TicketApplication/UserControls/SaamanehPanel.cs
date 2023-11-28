using Domain.Model;
using Infrastrucure.Library.DatabaseService;
using Infrastrucure.Library.Repository.SamanehService;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using TicketApplication.Common;
using TicketApplication.Extentions;

namespace TicketApplication.UserControls
{
    public partial class SaamanehPanel : UserControl
    {
        private readonly SamanehService _samanehService;
        private readonly SamanehQueries Show;
        private readonly IBaseQuery _baseQuery;
        Paging Paging;

        public SaamanehPanel()
        {
            InitializeComponent();
            _samanehService = new SamanehService();
            Show = new SamanehQueries();
            Paging = new Paging();
            _baseQuery = new BaseQuery();

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
            SaamanehDG.DataSource = _baseQuery.Execute(QUERY);
            var count = _baseQuery.Execute(Show.Count()).Rows[0].Field<int>(0);
            CountLBL.Text = $"تعداد کل رکورد {count} | رکورد های نمایشی {SaamanehDG.Rows.Count} | صفحه {Paging.Page + 1}";
        }


        private async void InsertBtn_Click(object sender, EventArgs e)
        {

            if (InsertBtn.Text == "ثبت")
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
                await _samanehService.Insert(entity);
            }
            else
            {
                //  Update
                var model =  await _samanehService.GetById(Int32.Parse(ID.Text));
                model.Name = SmnaNameTxt.Text;
                model.Title = SmnaTitleTxt.Text;
                model.UpdateDate = DateTime.Now;
                model.UpdateBy = 1;
                model.Description = DescriptionSTxt.Text;
                await _samanehService.Update(model);
            }

            InsertBtn.Text = "ثبت";
            ID.Text = "0";
            await _samanehService.Save();
            FormExtentions.ClearTextBoxes(this.Controls);
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
            Paging.Next(23, SaamanehDG.Rows.Count);
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

       

        private async void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var model = await _samanehService.GetById(Int64.Parse(ID.Text));
            SmnaNameTxt.Text = model.Name;
            SmnaTitleTxt.Text = model.Title;
            DescriptionSTxt.Text = model.Description;
            InsertBtn.Text = "ویرایش";
        }

        private async void تغییروضعیتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var model = await _samanehService.GetById(Int64.Parse(ID.Text));
            model.IsActive = model.IsActive ? false : true;
            await _samanehService.Update(model);
            await _samanehService.Save();
            ShowDataGridView(0);
        }

        private async void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var model = await _samanehService.GetById(Int64.Parse(ID.Text));
            model.IsDeleted = true;
            await _samanehService.Update(model);
            await _samanehService.Save();
            ShowDataGridView(0);
        }

        private void SaamanehDG_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = Convert.ToString(SaamanehDG.Rows[SaamanehDG.CurrentRow.Index].Cells["آیدی"].Value);

        }

        private void SaamanehDG_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
    }
}
