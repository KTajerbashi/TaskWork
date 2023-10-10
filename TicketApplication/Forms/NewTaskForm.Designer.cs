namespace TicketApplication.Forms
{
    partial class NewTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTaskForm));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TitleTaskTxt = new System.Windows.Forms.TextBox();
            this.DetailsTaskTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaamanehCombo = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.ERR = new System.Windows.Forms.Label();
            this.AnswerTaskTxt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ImportanceCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Location = new System.Drawing.Point(10, 368);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(121, 33);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "خروج";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Location = new System.Drawing.Point(137, 368);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(121, 33);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "ثبت";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TitleTaskTxt
            // 
            this.TitleTaskTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleTaskTxt.BackColor = System.Drawing.Color.White;
            this.TitleTaskTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTaskTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TitleTaskTxt.Font = new System.Drawing.Font("IRANSansWeb", 13F);
            this.TitleTaskTxt.ForeColor = System.Drawing.Color.Black;
            this.TitleTaskTxt.Location = new System.Drawing.Point(206, 52);
            this.TitleTaskTxt.MaxLength = 50;
            this.TitleTaskTxt.Name = "TitleTaskTxt";
            this.TitleTaskTxt.Size = new System.Drawing.Size(426, 29);
            this.TitleTaskTxt.TabIndex = 1;
            // 
            // DetailsTaskTxt
            // 
            this.DetailsTaskTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetailsTaskTxt.BackColor = System.Drawing.Color.White;
            this.DetailsTaskTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailsTaskTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetailsTaskTxt.ForeColor = System.Drawing.Color.Black;
            this.DetailsTaskTxt.Location = new System.Drawing.Point(445, 116);
            this.DetailsTaskTxt.Name = "DetailsTaskTxt";
            this.DetailsTaskTxt.Size = new System.Drawing.Size(429, 246);
            this.DetailsTaskTxt.TabIndex = 2;
            this.DetailsTaskTxt.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(543, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "عنوان تسک";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(756, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "توضیحات تسک";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(787, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "سامانه";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaamanehCombo
            // 
            this.SaamanehCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaamanehCombo.BackColor = System.Drawing.Color.White;
            this.SaamanehCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaamanehCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaamanehCombo.ForeColor = System.Drawing.Color.Black;
            this.SaamanehCombo.FormattingEnabled = true;
            this.SaamanehCombo.Location = new System.Drawing.Point(636, 51);
            this.SaamanehCombo.Name = "SaamanehCombo";
            this.SaamanehCombo.Size = new System.Drawing.Size(237, 30);
            this.SaamanehCombo.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ID.Location = new System.Drawing.Point(13, 276);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 29);
            this.ID.TabIndex = 9;
            this.ID.Text = "0";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ERR
            // 
            this.ERR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ERR.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ERR.Location = new System.Drawing.Point(261, 371);
            this.ERR.Name = "ERR";
            this.ERR.Size = new System.Drawing.Size(615, 29);
            this.ERR.TabIndex = 10;
            this.ERR.Text = "پیام :";
            this.ERR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnswerTaskTxt
            // 
            this.AnswerTaskTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnswerTaskTxt.BackColor = System.Drawing.Color.White;
            this.AnswerTaskTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerTaskTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnswerTaskTxt.ForeColor = System.Drawing.Color.Black;
            this.AnswerTaskTxt.Location = new System.Drawing.Point(10, 116);
            this.AnswerTaskTxt.Name = "AnswerTaskTxt";
            this.AnswerTaskTxt.Size = new System.Drawing.Size(429, 246);
            this.AnswerTaskTxt.TabIndex = 3;
            this.AnswerTaskTxt.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(356, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "پاسخ تسک";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(154, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "الویت";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImportanceCombo
            // 
            this.ImportanceCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImportanceCombo.BackColor = System.Drawing.Color.White;
            this.ImportanceCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportanceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImportanceCombo.ForeColor = System.Drawing.Color.Black;
            this.ImportanceCombo.FormattingEnabled = true;
            this.ImportanceCombo.Location = new System.Drawing.Point(13, 51);
            this.ImportanceCombo.Name = "ImportanceCombo";
            this.ImportanceCombo.Size = new System.Drawing.Size(189, 30);
            this.ImportanceCombo.TabIndex = 15;
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(887, 411);
            this.Controls.Add(this.ImportanceCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AnswerTaskTxt);
            this.Controls.Add(this.ERR);
            this.Controls.Add(this.SaamanehCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetailsTaskTxt);
            this.Controls.Add(this.TitleTaskTxt);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ID);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewTaskForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTaskForm";
            this.Load += new System.EventHandler(this.NewTaskForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewTaskForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TitleTaskTxt;
        public System.Windows.Forms.RichTextBox DetailsTaskTxt;
        public System.Windows.Forms.ComboBox SaamanehCombo;
        public System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label ERR;
        public System.Windows.Forms.RichTextBox AnswerTaskTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox ImportanceCombo;
    }
}