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
            this.AsidePanel = new System.Windows.Forms.Panel();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NewTaskBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TasksListBtn = new System.Windows.Forms.Button();
            this.AsidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AsidePanel
            // 
            this.AsidePanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.AsidePanel.Controls.Add(this.TasksListBtn);
            this.AsidePanel.Controls.Add(this.ReportBtn);
            this.AsidePanel.Controls.Add(this.button3);
            this.AsidePanel.Controls.Add(this.button2);
            this.AsidePanel.Controls.Add(this.NewTaskBtn);
            this.AsidePanel.Controls.Add(this.ExitBtn);
            this.AsidePanel.Location = new System.Drawing.Point(1273, 8);
            this.AsidePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AsidePanel.Name = "AsidePanel";
            this.AsidePanel.Size = new System.Drawing.Size(163, 660);
            this.AsidePanel.TabIndex = 1;
            this.AsidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AsidePanel_MouseDown);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReportBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.White;
            this.ReportBtn.Location = new System.Drawing.Point(21, 364);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(119, 30);
            this.ReportBtn.TabIndex = 4;
            this.ReportBtn.Text = "گزارشات";
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(21, 324);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "تسک باز";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(21, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "تمام شده";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // NewTaskBtn
            // 
            this.NewTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.NewTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewTaskBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTaskBtn.ForeColor = System.Drawing.Color.White;
            this.NewTaskBtn.Location = new System.Drawing.Point(21, 244);
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
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(4, 617);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(155, 38);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "خروج";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.MainPanel.Location = new System.Drawing.Point(10, 8);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1255, 660);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // TasksListBtn
            // 
            this.TasksListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.TasksListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TasksListBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksListBtn.ForeColor = System.Drawing.Color.White;
            this.TasksListBtn.Location = new System.Drawing.Point(21, 204);
            this.TasksListBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TasksListBtn.Name = "TasksListBtn";
            this.TasksListBtn.Size = new System.Drawing.Size(119, 30);
            this.TasksListBtn.TabIndex = 5;
            this.TasksListBtn.Text = "لیست تسک ها";
            this.TasksListBtn.UseVisualStyleBackColor = false;
            this.TasksListBtn.Click += new System.EventHandler(this.TasksListBtn_Click);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TasksListBtn;
    }
}

