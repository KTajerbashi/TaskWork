﻿using Domain.Library.Enums;
using Domain.Library.Models.Entity;
using Infrastrucure.Library.DatabaseService;
using Infrastrucure.Library.Repository.BackupService;
using Infrastrucure.Library.Repository.TaskService;
using MD.PersianDateTime;
using System;
using System.Data;
using System.Windows.Forms;
using TicketApplication.Authentication;
using TicketApplication.Common;

namespace TicketApplication.UserControls
{
    public partial class BackupPanel : UserControl
    {
        Paging Paging;
        private readonly BackupQueries Show;
        private readonly IBaseQuery _baseQuery;
        public BackupPanel()
        {
            InitializeComponent();
            Paging = new Paging();
            Show = new BackupQueries();
            _baseQuery = new BaseQuery();
        }
        private void ShowDataGridView(int type)
        {
            string QUERY;

            if (type == 0)  // ShowAll
            {
                QUERY = Show.ShowAll(Paging.Order(Paging.Page, 20));
            }
            else // ShowAll
            {
                QUERY = Show.ShowAll(Paging.Order(Paging.Page, 20));
            }

            Datagrid.DataSource = _baseQuery.Execute(QUERY);
            var count = _baseQuery.Execute(Show.Count()).Rows[0].Field<int>(0);
            CountLBL.Text = $"تعداد کل رکورد {count} | رکورد های نمایشی {Datagrid.Rows.Count} | صفحه {Paging.Page + 1}";
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            //  پشتیان گیری
            MsgLBl.Text = "منتظر اتمام عملیات بمانید";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            var model = new Backup
            {
                CreateDate = DateTime.Now,
                CreatedByUserRoleID= AppUser.UserRoleID,
                Description= MsgLBl.Text,
                BackupType = (BackupType) 1,
                FileAddress = fbd.SelectedPath,
                FileName = fbd.SelectedPath,
                IsActive = true,
                IsDeleted = false,
                Title = AppUser.DisplayName,
            };
            //_backupService(fbd.SelectedPath, model);
            MsgLBl.Text = "پشتیبان گیری با موفقیت انجام شد";
        }

        private void RecoverDbBtn_Click(object sender, EventArgs e)
        {
            ////BackupLogService _backuplogService = new BackupLogService() ;
            ////  باز نگری
            //MsgLBl.Text = "منتظر اتمام عملیات بمانید";
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            //var model = new BackupLog
            //{
            //    CreateDate = DateTime.Now,
            //    CreatedByUserRoleID= AppUser.UserRoleID,
            //    Description= MsgLBl.Text,
            //    BackupType = (BackupType) 1,
            //    FileAddress = ofd.SafeFileName,
            //    FileName = ofd.FileName,
            //    IsActive = true,
            //    IsDeleted = false,
            //    Title = AppUser.DisplayName,
            //};
            //if (ofd.FileName.Trim().Length != 0)
            //{
            //    _backuplogService.Restor(ofd.FileName, model);
            //    MsgLBl.Text = "بازگردانی اطلاعات با موفقیت انجام شد";
            //}
        }

        private void Reloding_Click(object sender, EventArgs e)
        {
            ShowDataGridView(99);
        }

        private void BackupPanel_Load(object sender, EventArgs e)
        {
            ShowDataGridView(99);
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            Paging.Prev();
            ShowDataGridView(99);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Datagrid.Rows.Count.ToString().Trim()) == 23)
            {
                Paging.Next(20, int.Parse(CountLBL.Text));
            }
            ShowDataGridView(99);
        }
    }
}
