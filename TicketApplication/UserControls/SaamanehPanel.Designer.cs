namespace TicketApplication.UserControls
{
    partial class SaamanehPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaamanehPanel));
            this.group1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchDateBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.ToDate = new Atf.UI.DateTimeSelector();
            this.FromDate = new Atf.UI.DateTimeSelector();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SmnaTitleTxt = new System.Windows.Forms.TextBox();
            this.SmnaNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.DescriptionSTxt = new System.Windows.Forms.RichTextBox();
            this.ID = new System.Windows.Forms.Label();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.CountLBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Reloding = new Glass.GlassButton();
            this.NextBtn = new Glass.GlassButton();
            this.PrevBtn = new Glass.GlassButton();
            this.SaamanehDG = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییروضعیتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.group2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaamanehDG)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // group1
            // 
            this.group1.Controls.Add(this.groupBox3);
            this.group1.Controls.Add(this.groupBox2);
            this.group1.ForeColor = System.Drawing.Color.White;
            this.group1.Location = new System.Drawing.Point(948, 3);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(304, 654);
            this.group1.TabIndex = 0;
            this.group1.TabStop = false;
            this.group1.Text = "ابزار";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SearchDateBtn);
            this.groupBox3.Controls.Add(this.SearchTxt);
            this.groupBox3.Controls.Add(this.ToDate);
            this.groupBox3.Controls.Add(this.FromDate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.SearchBtn);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 295);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "جستجو";
            // 
            // SearchDateBtn
            // 
            this.SearchDateBtn.BackColor = System.Drawing.Color.White;
            this.SearchDateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchDateBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDateBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchDateBtn.Location = new System.Drawing.Point(8, 92);
            this.SearchDateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchDateBtn.Name = "SearchDateBtn";
            this.SearchDateBtn.Size = new System.Drawing.Size(280, 37);
            this.SearchDateBtn.TabIndex = 21;
            this.SearchDateBtn.Text = "جستجو براساس تاریخ";
            this.SearchDateBtn.UseVisualStyleBackColor = false;
            this.SearchDateBtn.Click += new System.EventHandler(this.SearchDateBtn_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.BackColor = System.Drawing.Color.White;
            this.SearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTxt.ForeColor = System.Drawing.Color.Black;
            this.SearchTxt.Location = new System.Drawing.Point(8, 215);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(280, 27);
            this.SearchTxt.TabIndex = 13;
            this.SearchTxt.Text = "جستجو ...";
            // 
            // ToDate
            // 
            this.ToDate.BackColor = System.Drawing.Color.White;
            this.ToDate.ForeColor = System.Drawing.Color.Black;
            this.ToDate.Location = new System.Drawing.Point(6, 60);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(215, 28);
            this.ToDate.TabIndex = 20;
            // 
            // FromDate
            // 
            this.FromDate.BackColor = System.Drawing.Color.White;
            this.FromDate.ForeColor = System.Drawing.Color.Black;
            this.FromDate.Location = new System.Drawing.Point(6, 26);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(215, 28);
            this.FromDate.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(227, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "تا تاریخ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(227, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "از تاریخ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.White;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchBtn.Location = new System.Drawing.Point(8, 250);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(280, 37);
            this.SearchBtn.TabIndex = 16;
            this.SearchBtn.Text = "جستجو";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SmnaTitleTxt);
            this.groupBox2.Controls.Add(this.SmnaNameTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.InsertBtn);
            this.groupBox2.Controls.Add(this.DescriptionSTxt);
            this.groupBox2.Controls.Add(this.ID);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 321);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(207, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "عنوان سامانه";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SmnaTitleTxt
            // 
            this.SmnaTitleTxt.BackColor = System.Drawing.Color.White;
            this.SmnaTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SmnaTitleTxt.ForeColor = System.Drawing.Color.Black;
            this.SmnaTitleTxt.Location = new System.Drawing.Point(6, 109);
            this.SmnaTitleTxt.Name = "SmnaTitleTxt";
            this.SmnaTitleTxt.Size = new System.Drawing.Size(280, 27);
            this.SmnaTitleTxt.TabIndex = 24;
            // 
            // SmnaNameTxt
            // 
            this.SmnaNameTxt.BackColor = System.Drawing.Color.White;
            this.SmnaNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SmnaNameTxt.ForeColor = System.Drawing.Color.Black;
            this.SmnaNameTxt.Location = new System.Drawing.Point(6, 51);
            this.SmnaNameTxt.Name = "SmnaNameTxt";
            this.SmnaNameTxt.Size = new System.Drawing.Size(280, 27);
            this.SmnaNameTxt.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(207, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "توضیحات";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "نام سامانه";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.White;
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.ForeColor = System.Drawing.Color.Black;
            this.InsertBtn.Location = new System.Drawing.Point(7, 283);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(278, 30);
            this.InsertBtn.TabIndex = 10;
            this.InsertBtn.Text = "ثبت";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // DescriptionSTxt
            // 
            this.DescriptionSTxt.BackColor = System.Drawing.Color.White;
            this.DescriptionSTxt.ForeColor = System.Drawing.Color.Black;
            this.DescriptionSTxt.Location = new System.Drawing.Point(8, 167);
            this.DescriptionSTxt.Name = "DescriptionSTxt";
            this.DescriptionSTxt.Size = new System.Drawing.Size(276, 108);
            this.DescriptionSTxt.TabIndex = 23;
            this.DescriptionSTxt.Text = "";
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ID.Location = new System.Drawing.Point(24, 237);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(73, 17);
            this.ID.TabIndex = 21;
            this.ID.Text = "0";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group2
            // 
            this.group2.Controls.Add(this.CountLBL);
            this.group2.Controls.Add(this.label6);
            this.group2.Controls.Add(this.Reloding);
            this.group2.Controls.Add(this.NextBtn);
            this.group2.Controls.Add(this.PrevBtn);
            this.group2.Controls.Add(this.SaamanehDG);
            this.group2.ForeColor = System.Drawing.Color.White;
            this.group2.Location = new System.Drawing.Point(3, 3);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(939, 654);
            this.group2.TabIndex = 1;
            this.group2.TabStop = false;
            this.group2.Text = "اطلاعات";
            this.group2.Enter += new System.EventHandler(this.group2_Enter);
            // 
            // CountLBL
            // 
            this.CountLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountLBL.BackColor = System.Drawing.Color.Transparent;
            this.CountLBL.Font = new System.Drawing.Font("IRANSansWeb", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLBL.ForeColor = System.Drawing.Color.Black;
            this.CountLBL.Location = new System.Drawing.Point(98, 613);
            this.CountLBL.Name = "CountLBL";
            this.CountLBL.Size = new System.Drawing.Size(100, 29);
            this.CountLBL.TabIndex = 13;
            this.CountLBL.Text = "تعداد رکورد";
            this.CountLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountLBL.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("IRANSansWeb", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(204, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "تعداد رکورد";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseMnemonic = false;
            // 
            // Reloding
            // 
            this.Reloding.Location = new System.Drawing.Point(893, 608);
            this.Reloding.Name = "Reloding";
            this.Reloding.Size = new System.Drawing.Size(40, 40);
            this.Reloding.TabIndex = 8;
            this.Reloding.Text = "تازه";
            this.Reloding.Click += new System.EventHandler(this.Reloding_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(6, 608);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(40, 40);
            this.NextBtn.TabIndex = 7;
            this.NextBtn.Text = "بعد";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(52, 608);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(40, 40);
            this.PrevBtn.TabIndex = 6;
            this.PrevBtn.Text = "قبل";
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // SaamanehDG
            // 
            this.SaamanehDG.AllowUserToAddRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.SaamanehDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.SaamanehDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SaamanehDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.SaamanehDG.BackgroundColor = System.Drawing.Color.White;
            this.SaamanehDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaamanehDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaamanehDG.Cursor = System.Windows.Forms.Cursors.PanWest;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SaamanehDG.DefaultCellStyle = dataGridViewCellStyle4;
            this.SaamanehDG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SaamanehDG.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaamanehDG.Location = new System.Drawing.Point(6, 17);
            this.SaamanehDG.Name = "SaamanehDG";
            this.SaamanehDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SaamanehDG.Size = new System.Drawing.Size(927, 585);
            this.SaamanehDG.TabIndex = 0;
            this.SaamanehDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaamanehDG_CellClick);
            this.SaamanehDG.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SaamanehDG_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.تغییروضعیتToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening_1);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Image = global::TicketApplication.Properties.Resources._1486504369_change_edit_options_pencil_settings_tools_write_81307;
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // تغییروضعیتToolStripMenuItem
            // 
            this.تغییروضعیتToolStripMenuItem.Image = global::TicketApplication.Properties.Resources.twocirclingarrows_120593;
            this.تغییروضعیتToolStripMenuItem.Name = "تغییروضعیتToolStripMenuItem";
            this.تغییروضعیتToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.تغییروضعیتToolStripMenuItem.Text = "تغییر وضعیت";
            this.تغییروضعیتToolStripMenuItem.Click += new System.EventHandler(this.تغییروضعیتToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفToolStripMenuItem.Image")));
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // SaamanehPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.group2);
            this.Controls.Add(this.group1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SaamanehPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1255, 660);
            this.Load += new System.EventHandler(this.SaamanehPanel_Load);
            this.group1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.group2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaamanehDG)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Button InsertBtn;
        private Atf.UI.DateTimeSelector ToDate;
        private Atf.UI.DateTimeSelector FromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private Glass.GlassButton NextBtn;
        private Glass.GlassButton PrevBtn;
        private Glass.GlassButton Reloding;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SmnaNameTxt;
        public System.Windows.Forms.RichTextBox DescriptionSTxt;
        public System.Windows.Forms.DataGridView SaamanehDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SmnaTitleTxt;
        private System.Windows.Forms.Button SearchDateBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تغییروضعیتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.Label CountLBL;
        private System.Windows.Forms.Label label6;
    }
}
