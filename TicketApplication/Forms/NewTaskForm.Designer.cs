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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TitleTaskTxt = new System.Windows.Forms.TextBox();
            this.DetailsTaskTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Location = new System.Drawing.Point(35, 284);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 33);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "خروج";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Location = new System.Drawing.Point(116, 284);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 33);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "ثبت";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TitleTaskTxt
            // 
            this.TitleTaskTxt.Location = new System.Drawing.Point(35, 113);
            this.TitleTaskTxt.Name = "TitleTaskTxt";
            this.TitleTaskTxt.Size = new System.Drawing.Size(564, 29);
            this.TitleTaskTxt.TabIndex = 2;
            // 
            // DetailsTaskTxt
            // 
            this.DetailsTaskTxt.Location = new System.Drawing.Point(32, 177);
            this.DetailsTaskTxt.Name = "DetailsTaskTxt";
            this.DetailsTaskTxt.Size = new System.Drawing.Size(567, 101);
            this.DetailsTaskTxt.TabIndex = 3;
            this.DetailsTaskTxt.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(516, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "عنوان تسک";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(516, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "توضیحات تسک";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(516, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "سامانه";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(35, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(564, 30);
            this.comboBox1.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ID.Location = new System.Drawing.Point(516, 249);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(88, 29);
            this.ID.TabIndex = 9;
            this.ID.Text = "0";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(634, 340);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetailsTaskTxt);
            this.Controls.Add(this.TitleTaskTxt);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ID);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label ID;
    }
}