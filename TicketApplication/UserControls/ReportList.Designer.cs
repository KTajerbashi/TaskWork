namespace TicketApplication.UserControls
{
    partial class ReportList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ToDate = new Atf.UI.DateTimeSelector();
            this.FromDate = new Atf.UI.DateTimeSelector();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.FTDateBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new Glass.GlassButton();
            this.NextBtn = new Glass.GlassButton();
            this.Reloding = new Glass.GlassButton();
            this.ListTasks = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToDate);
            this.groupBox1.Controls.Add(this.FromDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SearchTxt);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.FTDateBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1249, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر";
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(740, 22);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(172, 28);
            this.ToDate.TabIndex = 15;
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(992, 22);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(172, 28);
            this.FromDate.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(915, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "تا تاریخ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(1170, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "از تاریخ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(442, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "جستجو :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(71, 23);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(354, 27);
            this.SearchTxt.TabIndex = 8;
            this.SearchTxt.Text = "جستجو ...";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(7, 21);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(57, 30);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "جستجو";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // FTDateBtn
            // 
            this.FTDateBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.FTDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FTDateBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTDateBtn.ForeColor = System.Drawing.Color.White;
            this.FTDateBtn.Location = new System.Drawing.Point(676, 21);
            this.FTDateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FTDateBtn.Name = "FTDateBtn";
            this.FTDateBtn.Size = new System.Drawing.Size(57, 30);
            this.FTDateBtn.TabIndex = 6;
            this.FTDateBtn.Text = "جستجو";
            this.FTDateBtn.UseVisualStyleBackColor = false;
            this.FTDateBtn.Click += new System.EventHandler(this.FTDateBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(52, 615);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(40, 40);
            this.PrevBtn.TabIndex = 4;
            this.PrevBtn.Text = "قبل";
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(6, 615);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(40, 40);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = "بعد";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Reloding
            // 
            this.Reloding.Location = new System.Drawing.Point(1210, 615);
            this.Reloding.Name = "Reloding";
            this.Reloding.Size = new System.Drawing.Size(40, 40);
            this.Reloding.TabIndex = 7;
            this.Reloding.Text = "تازه";
            this.Reloding.Click += new System.EventHandler(this.Reloding_Click);
            // 
            // ListTasks
            // 
            this.ListTasks.AllowUserToAddRows = false;
            this.ListTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListTasks.BackgroundColor = System.Drawing.Color.White;
            this.ListTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListTasks.Location = new System.Drawing.Point(2, 58);
            this.ListTasks.Name = "ListTasks";
            this.ListTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ListTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListTasks.Size = new System.Drawing.Size(1250, 545);
            this.ListTasks.TabIndex = 8;
            // 
            // ReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ListTasks);
            this.Controls.Add(this.Reloding);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportList";
            this.Size = new System.Drawing.Size(1255, 660);
            this.Load += new System.EventHandler(this.ReportList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button FTDateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Atf.UI.DateTimeSelector ToDate;
        private Atf.UI.DateTimeSelector FromDate;
        private Glass.GlassButton PrevBtn;
        private Glass.GlassButton NextBtn;
        private Glass.GlassButton Reloding;
        public System.Windows.Forms.DataGridView ListTasks;
    }
}
