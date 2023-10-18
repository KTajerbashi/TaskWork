namespace TicketApplication.Forms
{
    partial class MessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.MsgTxt = new System.Windows.Forms.Label();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MsgTxt
            // 
            this.MsgTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MsgTxt.BackColor = System.Drawing.Color.Transparent;
            this.MsgTxt.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgTxt.ForeColor = System.Drawing.Color.White;
            this.MsgTxt.Location = new System.Drawing.Point(13, 25);
            this.MsgTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MsgTxt.Name = "MsgTxt";
            this.MsgTxt.Size = new System.Drawing.Size(420, 108);
            this.MsgTxt.TabIndex = 17;
            this.MsgTxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.MsgTxt.UseMnemonic = false;
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.Color.Green;
            this.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesBtn.ForeColor = System.Drawing.Color.White;
            this.YesBtn.Location = new System.Drawing.Point(260, 150);
            this.YesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(131, 30);
            this.YesBtn.TabIndex = 60;
            this.YesBtn.Text = "بلی";
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.BackColor = System.Drawing.Color.Red;
            this.NoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoBtn.ForeColor = System.Drawing.Color.White;
            this.NoBtn.Location = new System.Drawing.Point(56, 150);
            this.NoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(131, 30);
            this.NoBtn.TabIndex = 61;
            this.NoBtn.Text = "خیر";
            this.NoBtn.UseVisualStyleBackColor = false;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(446, 213);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.MsgTxt);
            this.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MessageBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیام";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label MsgTxt;
        public System.Windows.Forms.Button YesBtn;
        public System.Windows.Forms.Button NoBtn;
    }
}