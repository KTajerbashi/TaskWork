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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskList));
            this.ListTasks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SortDateBtn = new System.Windows.Forms.Button();
            this.NotDeliverBtn = new System.Windows.Forms.Button();
            this.DeliverBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.CountLBL = new System.Windows.Forms.Label();
            this.SearchTxt = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.ListTasks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.StripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListTasks
            // 
            this.ListTasks.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ListTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListTasks.BackgroundColor = System.Drawing.Color.White;
            this.ListTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTasks.Cursor = System.Windows.Forms.Cursors.PanWest;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListTasks.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListTasks.GridColor = System.Drawing.SystemColors.MenuHighlight;
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
            this.groupBox1.Controls.Add(this.SearchTxt);
            this.groupBox1.Controls.Add(this.SortDateBtn);
            this.groupBox1.Controls.Add(this.NotDeliverBtn);
            this.groupBox1.Controls.Add(this.DeliverBtn);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.AlphabetBtn);
            this.groupBox1.Controls.Add(this.NotPassBtn);
            this.groupBox1.Controls.Add(this.PassedBtn);
            this.groupBox1.Controls.Add(this.NewTaskBtn);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1249, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر";
            // 
            // SortDateBtn
            // 
            this.SortDateBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.SortDateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortDateBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortDateBtn.ForeColor = System.Drawing.Color.White;
            this.SortDateBtn.Location = new System.Drawing.Point(361, 23);
            this.SortDateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortDateBtn.Name = "SortDateBtn";
            this.SortDateBtn.Size = new System.Drawing.Size(119, 30);
            this.SortDateBtn.TabIndex = 7;
            this.SortDateBtn.Tag = "5";
            this.SortDateBtn.Text = "به ترتیب الویت";
            this.SortDateBtn.UseVisualStyleBackColor = false;
            this.SortDateBtn.Click += new System.EventHandler(this.SortDateBtn_Click);
            // 
            // NotDeliverBtn
            // 
            this.NotDeliverBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.NotDeliverBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotDeliverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotDeliverBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotDeliverBtn.ForeColor = System.Drawing.Color.White;
            this.NotDeliverBtn.Location = new System.Drawing.Point(615, 23);
            this.NotDeliverBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NotDeliverBtn.Name = "NotDeliverBtn";
            this.NotDeliverBtn.Size = new System.Drawing.Size(119, 30);
            this.NotDeliverBtn.TabIndex = 5;
            this.NotDeliverBtn.Tag = "6";
            this.NotDeliverBtn.Text = "تحویل نشده";
            this.NotDeliverBtn.UseVisualStyleBackColor = false;
            this.NotDeliverBtn.Click += new System.EventHandler(this.NotDeliverBtn_Click);
            // 
            // DeliverBtn
            // 
            this.DeliverBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.DeliverBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeliverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliverBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliverBtn.ForeColor = System.Drawing.Color.White;
            this.DeliverBtn.Location = new System.Drawing.Point(742, 23);
            this.DeliverBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeliverBtn.Name = "DeliverBtn";
            this.DeliverBtn.Size = new System.Drawing.Size(119, 30);
            this.DeliverBtn.TabIndex = 4;
            this.DeliverBtn.Tag = "4";
            this.DeliverBtn.Text = "تحویل شده";
            this.DeliverBtn.UseVisualStyleBackColor = false;
            this.DeliverBtn.Click += new System.EventHandler(this.DeliverBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(7, 22);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(119, 30);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "جستجو";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AlphabetBtn
            // 
            this.AlphabetBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.AlphabetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlphabetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlphabetBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlphabetBtn.ForeColor = System.Drawing.Color.White;
            this.AlphabetBtn.Location = new System.Drawing.Point(488, 23);
            this.AlphabetBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlphabetBtn.Name = "AlphabetBtn";
            this.AlphabetBtn.Size = new System.Drawing.Size(119, 30);
            this.AlphabetBtn.TabIndex = 6;
            this.AlphabetBtn.Tag = "0";
            this.AlphabetBtn.Text = "به ترتیب الفبا";
            this.AlphabetBtn.UseVisualStyleBackColor = false;
            this.AlphabetBtn.Click += new System.EventHandler(this.AlphabetBtn_Click);
            // 
            // NotPassBtn
            // 
            this.NotPassBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.NotPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotPassBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotPassBtn.ForeColor = System.Drawing.Color.White;
            this.NotPassBtn.Location = new System.Drawing.Point(869, 23);
            this.NotPassBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NotPassBtn.Name = "NotPassBtn";
            this.NotPassBtn.Size = new System.Drawing.Size(119, 30);
            this.NotPassBtn.TabIndex = 3;
            this.NotPassBtn.Tag = "2";
            this.NotPassBtn.Text = "پاس نشده";
            this.NotPassBtn.UseVisualStyleBackColor = false;
            this.NotPassBtn.Click += new System.EventHandler(this.NotPassBtn_Click);
            // 
            // PassedBtn
            // 
            this.PassedBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.PassedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassedBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassedBtn.ForeColor = System.Drawing.Color.White;
            this.PassedBtn.Location = new System.Drawing.Point(996, 23);
            this.PassedBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PassedBtn.Name = "PassedBtn";
            this.PassedBtn.Size = new System.Drawing.Size(119, 30);
            this.PassedBtn.TabIndex = 2;
            this.PassedBtn.Tag = "1";
            this.PassedBtn.Text = "پاس شده";
            this.PassedBtn.UseVisualStyleBackColor = false;
            this.PassedBtn.Click += new System.EventHandler(this.PassedBtn_Click);
            // 
            // NewTaskBtn
            // 
            this.NewTaskBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.NewTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTaskBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTaskBtn.ForeColor = System.Drawing.Color.White;
            this.NewTaskBtn.Location = new System.Drawing.Point(1123, 23);
            this.NewTaskBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewTaskBtn.Name = "NewTaskBtn";
            this.NewTaskBtn.Size = new System.Drawing.Size(119, 30);
            this.NewTaskBtn.TabIndex = 1;
            this.NewTaskBtn.Tag = "99";
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
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.Location = new System.Drawing.Point(10, 617);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(40, 40);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "بعد";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevBtn.Location = new System.Drawing.Point(56, 617);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(40, 40);
            this.PrevBtn.TabIndex = 1;
            this.PrevBtn.Text = "قبل";
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // Reloding
            // 
            this.Reloding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reloding.Location = new System.Drawing.Point(1212, 617);
            this.Reloding.Name = "Reloding";
            this.Reloding.Size = new System.Drawing.Size(40, 40);
            this.Reloding.TabIndex = 0;
            this.Reloding.Text = "تازه";
            this.Reloding.Click += new System.EventHandler(this.Reloding_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("IRANSansWeb", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(208, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "تعداد رکورد";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // CountLBL
            // 
            this.CountLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountLBL.BackColor = System.Drawing.Color.Transparent;
            this.CountLBL.Font = new System.Drawing.Font("IRANSansWeb", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLBL.ForeColor = System.Drawing.Color.Black;
            this.CountLBL.Location = new System.Drawing.Point(102, 622);
            this.CountLBL.Name = "CountLBL";
            this.CountLBL.Size = new System.Drawing.Size(100, 29);
            this.CountLBL.TabIndex = 11;
            this.CountLBL.Text = "تعداد رکورد";
            this.CountLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountLBL.UseMnemonic = false;
            // 
            // SearchTxt
            // 
            // 
            // 
            // 
            this.SearchTxt.Border.Class = "TextBoxBorder";
            this.SearchTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchTxt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SearchTxt.Location = new System.Drawing.Point(129, 24);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PreventEnterBeep = true;
            this.SearchTxt.Size = new System.Drawing.Size(218, 27);
            this.SearchTxt.TabIndex = 17;
            this.SearchTxt.WatermarkText = "جستجو ...";
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CountLBL);
            this.Controls.Add(this.label1);
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
            this.StripMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button SortDateBtn;
        private System.Windows.Forms.Button NotDeliverBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountLBL;
        private DevComponents.DotNetBar.Controls.TextBoxX SearchTxt;
    }
}
