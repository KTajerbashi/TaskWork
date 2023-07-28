namespace TicketApplication.UserControls
{
    partial class TaskList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskList));
            this.ListTasks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.AlphabetBtn = new System.Windows.Forms.Button();
            this.NotPassBtn = new System.Windows.Forms.Button();
            this.PassedBtn = new System.Windows.Forms.Button();
            this.NewTaskBtn = new System.Windows.Forms.Button();
            this.StripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تغییروضعیتپاسToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییروضعیتتحویلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextBtn = new Glass.GlassButton();
            this.PrevBtn = new Glass.GlassButton();
            this.Reloding = new Glass.GlassButton();
            this.DeliverBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListTasks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.StripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListTasks
            // 
            this.ListTasks.AllowUserToAddRows = false;
            this.ListTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListTasks.BackgroundColor = System.Drawing.Color.White;
            this.ListTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListTasks.Location = new System.Drawing.Point(3, 70);
            this.ListTasks.Name = "ListTasks";
            this.ListTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ListTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListTasks.Size = new System.Drawing.Size(1250, 545);
            this.ListTasks.TabIndex = 0;
            this.ListTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListTasks_CellClick);
            this.ListTasks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListTasks_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeliverBtn);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SearchTxt);
            this.groupBox1.Controls.Add(this.AlphabetBtn);
            this.groupBox1.Controls.Add(this.NotPassBtn);
            this.groupBox1.Controls.Add(this.PassedBtn);
            this.groupBox1.Controls.Add(this.NewTaskBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1249, 61);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(7, 22);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(119, 30);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "جستجو";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(487, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "جستجو :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(129, 24);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(354, 27);
            this.SearchTxt.TabIndex = 8;
            this.SearchTxt.Text = "جستجو ...";
            // 
            // AlphabetBtn
            // 
            this.AlphabetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.AlphabetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AlphabetBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlphabetBtn.ForeColor = System.Drawing.Color.White;
            this.AlphabetBtn.Location = new System.Drawing.Point(742, 23);
            this.AlphabetBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlphabetBtn.Name = "AlphabetBtn";
            this.AlphabetBtn.Size = new System.Drawing.Size(119, 30);
            this.AlphabetBtn.TabIndex = 5;
            this.AlphabetBtn.Text = "به ترتیب الفبا";
            this.AlphabetBtn.UseVisualStyleBackColor = false;
            this.AlphabetBtn.Click += new System.EventHandler(this.AlphabetBtn_Click);
            // 
            // NotPassBtn
            // 
            this.NotPassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.NotPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NotPassBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotPassBtn.ForeColor = System.Drawing.Color.White;
            this.NotPassBtn.Location = new System.Drawing.Point(869, 23);
            this.NotPassBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NotPassBtn.Name = "NotPassBtn";
            this.NotPassBtn.Size = new System.Drawing.Size(119, 30);
            this.NotPassBtn.TabIndex = 4;
            this.NotPassBtn.Text = "نا تمام";
            this.NotPassBtn.UseVisualStyleBackColor = false;
            this.NotPassBtn.Click += new System.EventHandler(this.NotPassBtn_Click);
            // 
            // PassedBtn
            // 
            this.PassedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.PassedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PassedBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassedBtn.ForeColor = System.Drawing.Color.White;
            this.PassedBtn.Location = new System.Drawing.Point(996, 23);
            this.PassedBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PassedBtn.Name = "PassedBtn";
            this.PassedBtn.Size = new System.Drawing.Size(119, 30);
            this.PassedBtn.TabIndex = 3;
            this.PassedBtn.Text = "پاس شده";
            this.PassedBtn.UseVisualStyleBackColor = false;
            this.PassedBtn.Click += new System.EventHandler(this.PassedBtn_Click);
            // 
            // NewTaskBtn
            // 
            this.NewTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.NewTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewTaskBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTaskBtn.ForeColor = System.Drawing.Color.White;
            this.NewTaskBtn.Location = new System.Drawing.Point(1123, 23);
            this.NewTaskBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewTaskBtn.Name = "NewTaskBtn";
            this.NewTaskBtn.Size = new System.Drawing.Size(119, 30);
            this.NewTaskBtn.TabIndex = 2;
            this.NewTaskBtn.Text = "جدیدترین";
            this.NewTaskBtn.UseVisualStyleBackColor = false;
            this.NewTaskBtn.Click += new System.EventHandler(this.NewTaskBtn_Click);
            // 
            // StripMenu
            // 
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تغییروضعیتپاسToolStripMenuItem,
            this.تغییروضعیتتحویلToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.ویرایشToolStripMenuItem});
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StripMenu.Size = new System.Drawing.Size(175, 92);
            // 
            // تغییروضعیتپاسToolStripMenuItem
            // 
            this.تغییروضعیتپاسToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تغییروضعیتپاسToolStripMenuItem.Image")));
            this.تغییروضعیتپاسToolStripMenuItem.Name = "تغییروضعیتپاسToolStripMenuItem";
            this.تغییروضعیتپاسToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.تغییروضعیتپاسToolStripMenuItem.Text = "تغییر وضعیت پاس";
            this.تغییروضعیتپاسToolStripMenuItem.Click += new System.EventHandler(this.تغییروضعیتپاسToolStripMenuItem_Click);
            // 
            // تغییروضعیتتحویلToolStripMenuItem
            // 
            this.تغییروضعیتتحویلToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تغییروضعیتتحویلToolStripMenuItem.Image")));
            this.تغییروضعیتتحویلToolStripMenuItem.Name = "تغییروضعیتتحویلToolStripMenuItem";
            this.تغییروضعیتتحویلToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.تغییروضعیتتحویلToolStripMenuItem.Text = "تغییر وضعیت تحویل";
            this.تغییروضعیتتحویلToolStripMenuItem.Click += new System.EventHandler(this.تغییروضعیتتحویلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفToolStripMenuItem.Image")));
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Image = global::TicketApplication.Properties.Resources._1486504369_change_edit_options_pencil_settings_tools_write_81307;
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(3, 617);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(40, 40);
            this.NextBtn.TabIndex = 7;
            this.NextBtn.Text = "بعد";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(49, 617);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(40, 40);
            this.PrevBtn.TabIndex = 6;
            this.PrevBtn.Text = "قبل";
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // Reloding
            // 
            this.Reloding.Location = new System.Drawing.Point(1212, 617);
            this.Reloding.Name = "Reloding";
            this.Reloding.Size = new System.Drawing.Size(40, 40);
            this.Reloding.TabIndex = 8;
            this.Reloding.Text = "تازه";
            this.Reloding.Click += new System.EventHandler(this.Reloding_Click);
            // 
            // DeliverBtn
            // 
            this.DeliverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.DeliverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeliverBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliverBtn.ForeColor = System.Drawing.Color.White;
            this.DeliverBtn.Location = new System.Drawing.Point(615, 23);
            this.DeliverBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeliverBtn.Name = "DeliverBtn";
            this.DeliverBtn.Size = new System.Drawing.Size(119, 30);
            this.DeliverBtn.TabIndex = 11;
            this.DeliverBtn.Text = "تحویل شده";
            this.DeliverBtn.UseVisualStyleBackColor = false;
            this.DeliverBtn.Click += new System.EventHandler(this.DeliverBtn_Click);
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Reloding);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListTasks);
            this.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaskList";
            this.Size = new System.Drawing.Size(1255, 660);
            this.Load += new System.EventHandler(this.TaskList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListTasks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.StripMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button AlphabetBtn;
        private System.Windows.Forms.Button NotPassBtn;
        private System.Windows.Forms.Button PassedBtn;
        private System.Windows.Forms.Button NewTaskBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ContextMenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem تغییروضعیتپاسToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تغییروضعیتتحویلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        public System.Windows.Forms.DataGridView ListTasks;
        private Glass.GlassButton NextBtn;
        private Glass.GlassButton PrevBtn;
        private Glass.GlassButton Reloding;
        private System.Windows.Forms.Button DeliverBtn;
    }
}
