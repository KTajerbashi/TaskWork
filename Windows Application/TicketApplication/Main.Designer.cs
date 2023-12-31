﻿namespace TicketApplication
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.NewTaskBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.TasksListBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.ProgressBar();
            this.BLACK = new System.Windows.Forms.ProgressBar();
            this.BLUE1 = new System.Windows.Forms.ProgressBar();
            this.DateTimeLBL = new System.Windows.Forms.Label();
            this.SaamanehBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.UsernameLBL = new System.Windows.Forms.Label();
            this.AsidePanel = new System.Windows.Forms.Panel();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LockScreenBtn = new System.Windows.Forms.PictureBox();
            this.DbBackupBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AsidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LockScreenBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbBackupBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(10, 8);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1255, 660);
            this.MainPanel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("IranNastaliq", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 72);
            this.label5.TabIndex = 10;
            this.label5.Text = "توسعه سامانه ها";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewTaskBtn
            // 
            this.NewTaskBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTaskBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTaskBtn.ForeColor = System.Drawing.Color.White;
            this.NewTaskBtn.Location = new System.Drawing.Point(19, 255);
            this.NewTaskBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewTaskBtn.Name = "NewTaskBtn";
            this.NewTaskBtn.Size = new System.Drawing.Size(125, 31);
            this.NewTaskBtn.TabIndex = 1;
            this.NewTaskBtn.Text = "تسک جدید";
            this.NewTaskBtn.UseVisualStyleBackColor = false;
            this.NewTaskBtn.Click += new System.EventHandler(this.NewTaskBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.White;
            this.ReportBtn.Location = new System.Drawing.Point(19, 375);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(125, 31);
            this.ReportBtn.TabIndex = 4;
            this.ReportBtn.Text = "مدیریت گزارشات";
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // TasksListBtn
            // 
            this.TasksListBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TasksListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TasksListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TasksListBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksListBtn.ForeColor = System.Drawing.Color.White;
            this.TasksListBtn.Location = new System.Drawing.Point(19, 295);
            this.TasksListBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TasksListBtn.Name = "TasksListBtn";
            this.TasksListBtn.Size = new System.Drawing.Size(125, 31);
            this.TasksListBtn.TabIndex = 2;
            this.TasksListBtn.Text = "لیست تسک ها";
            this.TasksListBtn.UseVisualStyleBackColor = false;
            this.TasksListBtn.Click += new System.EventHandler(this.TasksListBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("IranNastaliq", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 77);
            this.label3.TabIndex = 8;
            this.label3.Text = "مدیریت فعالیت";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(-1, 10);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(164, 5);
            this.Red.TabIndex = 12;
            // 
            // BLACK
            // 
            this.BLACK.Location = new System.Drawing.Point(-1, 37);
            this.BLACK.Name = "BLACK";
            this.BLACK.Size = new System.Drawing.Size(164, 5);
            this.BLACK.TabIndex = 25;
            // 
            // BLUE1
            // 
            this.BLUE1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BLUE1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.BLUE1.Location = new System.Drawing.Point(-1, 142);
            this.BLUE1.Name = "BLUE1";
            this.BLUE1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BLUE1.Size = new System.Drawing.Size(164, 5);
            this.BLUE1.TabIndex = 15;
            // 
            // DateTimeLBL
            // 
            this.DateTimeLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimeLBL.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLBL.ForeColor = System.Drawing.Color.Transparent;
            this.DateTimeLBL.Location = new System.Drawing.Point(4, 581);
            this.DateTimeLBL.Name = "DateTimeLBL";
            this.DateTimeLBL.Size = new System.Drawing.Size(155, 18);
            this.DateTimeLBL.TabIndex = 52;
            this.DateTimeLBL.Text = "1402/01/01 12:00:00";
            this.DateTimeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaamanehBtn
            // 
            this.SaamanehBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaamanehBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaamanehBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaamanehBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaamanehBtn.ForeColor = System.Drawing.Color.White;
            this.SaamanehBtn.Location = new System.Drawing.Point(19, 335);
            this.SaamanehBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaamanehBtn.Name = "SaamanehBtn";
            this.SaamanehBtn.Size = new System.Drawing.Size(125, 31);
            this.SaamanehBtn.TabIndex = 3;
            this.SaamanehBtn.Text = "مدیریت سامانه ها";
            this.SaamanehBtn.UseVisualStyleBackColor = false;
            this.SaamanehBtn.Click += new System.EventHandler(this.SaamanehBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(19, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "کارتابل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(-13, 21);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(188, 10);
            this.progressBar4.TabIndex = 58;
            this.progressBar4.Value = 99;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "CRM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(-13, 185);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(188, 5);
            this.progressBar6.TabIndex = 60;
            this.progressBar6.Value = 99;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.progressBar2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.progressBar2.Location = new System.Drawing.Point(21, 601);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar2.Size = new System.Drawing.Size(121, 1);
            this.progressBar2.TabIndex = 62;
            // 
            // UsernameLBL
            // 
            this.UsernameLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLBL.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLBL.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLBL.ForeColor = System.Drawing.Color.AliceBlue;
            this.UsernameLBL.Location = new System.Drawing.Point(2, 150);
            this.UsernameLBL.Name = "UsernameLBL";
            this.UsernameLBL.Size = new System.Drawing.Size(159, 32);
            this.UsernameLBL.TabIndex = 63;
            this.UsernameLBL.Text = "کاربر جاری";
            this.UsernameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AsidePanel
            // 
            this.AsidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AsidePanel.Controls.Add(this.SettingBtn);
            this.AsidePanel.Controls.Add(this.progressBar1);
            this.AsidePanel.Controls.Add(this.LockScreenBtn);
            this.AsidePanel.Controls.Add(this.DbBackupBtn);
            this.AsidePanel.Controls.Add(this.pictureBox1);
            this.AsidePanel.Controls.Add(this.UsernameLBL);
            this.AsidePanel.Controls.Add(this.progressBar2);
            this.AsidePanel.Controls.Add(this.progressBar6);
            this.AsidePanel.Controls.Add(this.label2);
            this.AsidePanel.Controls.Add(this.progressBar4);
            this.AsidePanel.Controls.Add(this.button1);
            this.AsidePanel.Controls.Add(this.SaamanehBtn);
            this.AsidePanel.Controls.Add(this.DateTimeLBL);
            this.AsidePanel.Controls.Add(this.BLUE1);
            this.AsidePanel.Controls.Add(this.BLACK);
            this.AsidePanel.Controls.Add(this.Red);
            this.AsidePanel.Controls.Add(this.label3);
            this.AsidePanel.Controls.Add(this.TasksListBtn);
            this.AsidePanel.Controls.Add(this.ReportBtn);
            this.AsidePanel.Controls.Add(this.NewTaskBtn);
            this.AsidePanel.Controls.Add(this.label5);
            this.AsidePanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.AsidePanel.Location = new System.Drawing.Point(1273, 8);
            this.AsidePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AsidePanel.Name = "AsidePanel";
            this.AsidePanel.Size = new System.Drawing.Size(163, 660);
            this.AsidePanel.TabIndex = 0;
            this.AsidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AsidePanel_MouseDown);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Location = new System.Drawing.Point(19, 545);
            this.SettingBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(125, 31);
            this.SettingBtn.TabIndex = 68;
            this.SettingBtn.Text = "تنظیمات";
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-13, 608);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(188, 5);
            this.progressBar1.TabIndex = 67;
            this.progressBar1.Value = 99;
            // 
            // LockScreenBtn
            // 
            this.LockScreenBtn.BackColor = System.Drawing.Color.Transparent;
            this.LockScreenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LockScreenBtn.Image = ((System.Drawing.Image)(resources.GetObject("LockScreenBtn.Image")));
            this.LockScreenBtn.Location = new System.Drawing.Point(4, 617);
            this.LockScreenBtn.Name = "LockScreenBtn";
            this.LockScreenBtn.Size = new System.Drawing.Size(40, 40);
            this.LockScreenBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LockScreenBtn.TabIndex = 66;
            this.LockScreenBtn.TabStop = false;
            this.LockScreenBtn.Click += new System.EventHandler(this.LockScreenBtn_Click);
            // 
            // DbBackupBtn
            // 
            this.DbBackupBtn.BackColor = System.Drawing.Color.Transparent;
            this.DbBackupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DbBackupBtn.Image = ((System.Drawing.Image)(resources.GetObject("DbBackupBtn.Image")));
            this.DbBackupBtn.Location = new System.Drawing.Point(118, 617);
            this.DbBackupBtn.Name = "DbBackupBtn";
            this.DbBackupBtn.Size = new System.Drawing.Size(40, 40);
            this.DbBackupBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DbBackupBtn.TabIndex = 65;
            this.DbBackupBtn.TabStop = false;
            this.DbBackupBtn.Click += new System.EventHandler(this.DbBackupBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 617);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1445, 679);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.AsidePanel);
            this.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلی";
            this.Load += new System.EventHandler(this.Main_Load);
            this.AsidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LockScreenBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbBackupBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NewTaskBtn;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button TasksListBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar Red;
        private System.Windows.Forms.ProgressBar BLACK;
        private System.Windows.Forms.ProgressBar BLUE1;
        private System.Windows.Forms.Label DateTimeLBL;
        private System.Windows.Forms.Button SaamanehBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar2;
        public System.Windows.Forms.Label UsernameLBL;
        private System.Windows.Forms.Panel AsidePanel;
        private System.Windows.Forms.PictureBox LockScreenBtn;
        private System.Windows.Forms.PictureBox DbBackupBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button SettingBtn;
    }
}

