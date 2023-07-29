namespace TicketApplication
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
            this.AsidePanel = new System.Windows.Forms.Panel();
            this.DateTimeLBL = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BLUE1 = new System.Windows.Forms.ProgressBar();
            this.REG1 = new System.Windows.Forms.ProgressBar();
            this.BLACK = new System.Windows.Forms.ProgressBar();
            this.Red = new System.Windows.Forms.ProgressBar();
            this.BLUE = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TasksListBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.NewTaskBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AsidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AsidePanel
            // 
            this.AsidePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.AsidePanel.Controls.Add(this.DateTimeLBL);
            this.AsidePanel.Controls.Add(this.progressBar1);
            this.AsidePanel.Controls.Add(this.BLUE1);
            this.AsidePanel.Controls.Add(this.REG1);
            this.AsidePanel.Controls.Add(this.BLACK);
            this.AsidePanel.Controls.Add(this.Red);
            this.AsidePanel.Controls.Add(this.BLUE);
            this.AsidePanel.Controls.Add(this.label3);
            this.AsidePanel.Controls.Add(this.label1);
            this.AsidePanel.Controls.Add(this.label2);
            this.AsidePanel.Controls.Add(this.TasksListBtn);
            this.AsidePanel.Controls.Add(this.ReportBtn);
            this.AsidePanel.Controls.Add(this.NewTaskBtn);
            this.AsidePanel.Controls.Add(this.ExitBtn);
            this.AsidePanel.Controls.Add(this.label5);
            this.AsidePanel.Location = new System.Drawing.Point(1273, 8);
            this.AsidePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AsidePanel.Name = "AsidePanel";
            this.AsidePanel.Size = new System.Drawing.Size(163, 660);
            this.AsidePanel.TabIndex = 1;
            this.AsidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AsidePanel_MouseDown);
            // 
            // DateTimeLBL
            // 
            this.DateTimeLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimeLBL.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLBL.ForeColor = System.Drawing.Color.Transparent;
            this.DateTimeLBL.Location = new System.Drawing.Point(4, 543);
            this.DateTimeLBL.Name = "DateTimeLBL";
            this.DateTimeLBL.Size = new System.Drawing.Size(155, 68);
            this.DateTimeLBL.TabIndex = 52;
            this.DateTimeLBL.Text = "1402/01/01 12:00:00";
            this.DateTimeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-1, 535);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(164, 5);
            this.progressBar1.TabIndex = 51;
            this.progressBar1.Value = 99;
            // 
            // BLUE1
            // 
            this.BLUE1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BLUE1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.BLUE1.Location = new System.Drawing.Point(-1, 150);
            this.BLUE1.Name = "BLUE1";
            this.BLUE1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BLUE1.Size = new System.Drawing.Size(164, 5);
            this.BLUE1.TabIndex = 15;
            // 
            // REG1
            // 
            this.REG1.Location = new System.Drawing.Point(-1, 141);
            this.REG1.Name = "REG1";
            this.REG1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.REG1.Size = new System.Drawing.Size(164, 5);
            this.REG1.TabIndex = 14;
            // 
            // BLACK
            // 
            this.BLACK.Location = new System.Drawing.Point(-1, 35);
            this.BLACK.Name = "BLACK";
            this.BLACK.Size = new System.Drawing.Size(164, 5);
            this.BLACK.TabIndex = 25;
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(-1, 15);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(164, 5);
            this.Red.TabIndex = 12;
            // 
            // BLUE
            // 
            this.BLUE.BackColor = System.Drawing.Color.Red;
            this.BLUE.Location = new System.Drawing.Point(-1, 25);
            this.BLUE.Name = "BLUE";
            this.BLUE.Size = new System.Drawing.Size(164, 5);
            this.BLUE.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("IranNastaliq", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 77);
            this.label3.TabIndex = 8;
            this.label3.Text = "مدیریت فعالیت";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(4, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 93);
            this.label1.TabIndex = 7;
            this.label1.Text = "TASK WROK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Parchment", 60F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(4, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 98);
            this.label2.TabIndex = 6;
            this.label2.Text = "KT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TasksListBtn
            // 
            this.TasksListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.TasksListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TasksListBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksListBtn.ForeColor = System.Drawing.Color.White;
            this.TasksListBtn.Location = new System.Drawing.Point(21, 169);
            this.TasksListBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TasksListBtn.Name = "TasksListBtn";
            this.TasksListBtn.Size = new System.Drawing.Size(119, 30);
            this.TasksListBtn.TabIndex = 5;
            this.TasksListBtn.Text = "لیست تسک ها";
            this.TasksListBtn.UseVisualStyleBackColor = false;
            this.TasksListBtn.Click += new System.EventHandler(this.TasksListBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReportBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.White;
            this.ReportBtn.Location = new System.Drawing.Point(21, 249);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(119, 30);
            this.ReportBtn.TabIndex = 4;
            this.ReportBtn.Text = "گزارشات";
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // NewTaskBtn
            // 
            this.NewTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.NewTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewTaskBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTaskBtn.ForeColor = System.Drawing.Color.White;
            this.NewTaskBtn.Location = new System.Drawing.Point(21, 209);
            this.NewTaskBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewTaskBtn.Name = "NewTaskBtn";
            this.NewTaskBtn.Size = new System.Drawing.Size(119, 30);
            this.NewTaskBtn.TabIndex = 1;
            this.NewTaskBtn.Text = "تسک جدید";
            this.NewTaskBtn.UseVisualStyleBackColor = false;
            this.NewTaskBtn.Click += new System.EventHandler(this.NewTaskBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(4, 617);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(155, 38);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "خروج";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("IranNastaliq", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 72);
            this.label5.TabIndex = 10;
            this.label5.Text = "توسعه سامانه ها";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Main_Load);
            this.AsidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AsidePanel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button NewTaskBtn;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button TasksListBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar BLACK;
        private System.Windows.Forms.ProgressBar Red;
        private System.Windows.Forms.ProgressBar BLUE;
        private System.Windows.Forms.ProgressBar BLUE1;
        private System.Windows.Forms.ProgressBar REG1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DateTimeLBL;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

