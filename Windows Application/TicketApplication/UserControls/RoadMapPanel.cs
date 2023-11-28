using Domain.Library.KeyValues;
using Domain.Library.Models.Entity;
using Infrastrucure.Library.DatabaseService;
using Infrastrucure.Library.Repository.RoadMapPanel;
using System;
using System.Data;
using System.Windows.Forms;
using TicketApplication.Common;
using TicketApplication.Extentions;

namespace TicketApplication.UserControls
{
    public partial class RoadMapPanel : UserControl
    {
        private readonly IBaseQuery _baseDatabase;
        private Paging Paging;
        public RoadMapPanel()
        {
            InitializeComponent();
            Paging = new Paging();
            _baseDatabase = new BaseQuery();
        }
        private void ShowDataGridView(int type)
        {
            string Query = "";
            RoadmapQueries roadmapQueries = new RoadmapQueries();
            if (type == 0)
            {
                Query = roadmapQueries.ShowAll(Paging.Order(Paging.Page));
            }
            else
            {
                Query = roadmapQueries.SearchData(SearchTxt.Text);
            }

            DataGridLesson.DataSource = _baseDatabase.Execute(Query);
            var count = _baseDatabase.Execute(roadmapQueries.Count()).Rows[0].Field<int>(0);
            CountLBL.Text = $"تعداد کل رکورد {count} | رکورد های نمایشی {DataGridLesson.Rows.Count} | صفحه {Paging.Page + 1}";

        }
        private long ID = 0;
        private void RoadMapPanel_Load(object sender, EventArgs e)
        {
            FillCombo();
            ShowDataGridView(0);
        }
        private void FillCombo()
        {
            RoadmapService roadmapService = new RoadmapService();
            ParentIdCombo.Items.Clear();
            ParentIdCombo.Items.Add(new ComboboxItem<long>
            {
                Text = "--- انتخاب کنید ---",
                Value = 0
            });
            var result = roadmapService.KeyValueList();
            foreach (var item in result.Data)
            {
                ParentIdCombo.Items.Add(item);
            }
            ParentIdCombo.SelectedIndex = 0;
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            RoadmapService roadmapService = new RoadmapService();
            var pId = ((ComboboxItem<long>)ParentIdCombo.SelectedItem).Value;

            RoadmapLesson roadmap = new RoadmapLesson()
            {
                CreateDate = DateTime.Now,
                CreatedByUserRoleID = 0,
                Description = DescTxt.Text,
                HasFile = FileCheck.Checked,
                InProgress = InProgressCheck.Checked,
                IsFinishid = FinishidCheck.Checked,
                IsActive = true,
                IsDeleted = false,
                IsImplemented=ImplementedCheck.Checked,
                IsStarted = StartCheck.Checked,
                Title = TitleTxt.Text,

            };
            if (pId == 0)
            {
                roadmap.ParentId = null;
            }
            else
            {
                roadmap.ParentId = pId;
            }
            if (ID != 0)
            {
                await roadmapService.Update(roadmap);
            }
            else
            {
                await roadmapService.Insert(roadmap);
            }
            ID = 0;
            SaveBtn.Text = "ثبت اطلاعات";
            ShowDataGridView(0);
            FillCombo();
            FormExtentions.ClearTextBoxes(this.Controls);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ShowDataGridView(1);
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            Paging.Prev();
            ShowDataGridView(0);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            Paging.Next(25, DataGridLesson.Rows.Count);
            ShowDataGridView(0);
        }

        private void DataGridLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt64(DataGridLesson.Rows[DataGridLesson.CurrentRow.Index].Cells["آیدی"].Value);
        }

        private void DataGridLesson_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RoadmapContext.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private async void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoadmapService roadmapService = new RoadmapService();
            var model = await roadmapService.GetById(ID);
            if (model.ParentId != null)
            {
                foreach (var item in ParentIdCombo.Items)
                {
                    if (model.ParentId == ((ComboboxItem<long>)item).Value)
                    {
                        ParentIdCombo.SelectedItem = item;
                    }
                }
            }
            TitleTxt.Text = model.Title;
            DescTxt.Text = model.Description;
            StartCheck.Checked = model.IsStarted;
            InProgressCheck.Checked = model.InProgress;
            FinishidCheck.Checked = model.IsFinishid;
            ImplementedCheck.Checked = model.IsImplemented;
            FileCheck.Checked = model.HasFile;

            SaveBtn.Text = "ویرایش اطلاعات";
        }

        private async void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoadmapService roadmapService = new RoadmapService();
            var model = await roadmapService.GetById(ID);
            model.IsDeleted = true;
            await roadmapService.SaveAsync();
            ID = 0;
            ShowDataGridView(0);
        }

        private async void شروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoadmapService roadmapService = new RoadmapService();
            var model = await roadmapService.GetById(ID);
            model.IsStarted = model.IsStarted ? false : true;
            await roadmapService.SaveAsync();
            ID = 0;
            ShowDataGridView(0);
        }

        private async void اجراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoadmapService roadmapService = new RoadmapService();
            var model = await roadmapService.GetById(ID);
            model.InProgress = model.InProgress ? false : true;
            await roadmapService.SaveAsync();
            ID = 0;
            ShowDataGridView(0);
        }

        private async void پایانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoadmapService roadmapService = new RoadmapService();
            var model = await roadmapService.GetById(ID);
            model.IsFinishid = model.IsFinishid ? false : true;
            await roadmapService.SaveAsync();
            ID = 0;
            ShowDataGridView(0);
        }

        private async void پیادهسازیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoadmapService roadmapService = new RoadmapService();
            var model = await roadmapService.GetById(ID);
            model.IsImplemented = model.IsImplemented ? false : true;
            await roadmapService.SaveAsync();
            ID = 0;
            ShowDataGridView(0);
        }

        private async void فایلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoadmapService roadmapService = new RoadmapService();
            var model = await roadmapService.GetById(ID);
            model.HasFile = model.HasFile ? false : true;
            await roadmapService.SaveAsync();
            ID = 0;
            ShowDataGridView(0);
        }
    }
}
