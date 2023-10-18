namespace TicketApplication.UserControls
{
    partial class SampaPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchTxt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Reloding = new Glass.GlassButton();
            this.CountLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NextBtn = new Glass.GlassButton();
            this.PrevBtn = new Glass.GlassButton();
            this.ListTasks = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchTxt);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1249, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت";
            // 
            // SearchTxt
            // 
            // 
            // 
            // 
            this.SearchTxt.Border.Class = "TextBoxBorder";
            this.SearchTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchTxt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SearchTxt.Location = new System.Drawing.Point(81, 30);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PreventEnterBeep = true;
            this.SearchTxt.Size = new System.Drawing.Size(218, 27);
            this.SearchTxt.TabIndex = 20;
            this.SearchTxt.WatermarkText = "جستجو ...";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(7, 28);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(68, 30);
            this.SearchBtn.TabIndex = 19;
            this.SearchBtn.Text = "جستجو";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(1190, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "فعالیت :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.UseMnemonic = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Reloding);
            this.groupBox2.Controls.Add(this.CountLBL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NextBtn);
            this.groupBox2.Controls.Add(this.PrevBtn);
            this.groupBox2.Controls.Add(this.ListTasks);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(3, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 570);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نمایش";
            // 
            // Reloding
            // 
            this.Reloding.Location = new System.Drawing.Point(983, 523);
            this.Reloding.Name = "Reloding";
            this.Reloding.Size = new System.Drawing.Size(40, 40);
            this.Reloding.TabIndex = 18;
            this.Reloding.Text = "تازه";
            // 
            // CountLBL
            // 
            this.CountLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountLBL.BackColor = System.Drawing.Color.Transparent;
            this.CountLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountLBL.Font = new System.Drawing.Font("IRANSansWeb", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLBL.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CountLBL.Location = new System.Drawing.Point(98, 529);
            this.CountLBL.Name = "CountLBL";
            this.CountLBL.Size = new System.Drawing.Size(100, 29);
            this.CountLBL.TabIndex = 17;
            this.CountLBL.Text = "تعداد رکورد";
            this.CountLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountLBL.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("IRANSansWeb", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(204, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "تعداد رکورد";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(6, 523);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(40, 40);
            this.NextBtn.TabIndex = 15;
            this.NextBtn.Text = "بعد";
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(52, 523);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(40, 40);
            this.PrevBtn.TabIndex = 14;
            this.PrevBtn.Text = "قبل";
            // 
            // ListTasks
            // 
            this.ListTasks.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ListTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListTasks.BackgroundColor = System.Drawing.Color.White;
            this.ListTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListTasks.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListTasks.Location = new System.Drawing.Point(6, 26);
            this.ListTasks.Name = "ListTasks";
            this.ListTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ListTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListTasks.Size = new System.Drawing.Size(1017, 494);
            this.ListTasks.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Location = new System.Drawing.Point(1038, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 569);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ابزار";
            // 
            // SampaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SampaPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1255, 660);
            this.Load += new System.EventHandler(this.SampaPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView ListTasks;
        private System.Windows.Forms.Label CountLBL;
        private System.Windows.Forms.Label label4;
        private Glass.GlassButton NextBtn;
        private Glass.GlassButton PrevBtn;
        private Glass.GlassButton Reloding;
        private System.Windows.Forms.Button SearchBtn;
        private DevComponents.DotNetBar.Controls.TextBoxX SearchTxt;
    }
}
