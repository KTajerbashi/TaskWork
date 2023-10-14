namespace TicketApplication.Forms
{
    partial class LoginForm
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.CheckLocationLBL = new System.Windows.Forms.Label();
            this.SignInTitle = new System.Windows.Forms.Label();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.RecoveryPanel = new System.Windows.Forms.Panel();
            this.RecoverBtn = new System.Windows.Forms.Button();
            this.RecoverTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.SignInPanel.SuspendLayout();
            this.RecoveryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.Controls.Add(this.LoginBtn);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Location = new System.Drawing.Point(1035, 23);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(374, 627);
            this.LoginPanel.TabIndex = 0;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(53, 572);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(269, 34);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "تایید";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("IRANSansWeb", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "ورود به حساب";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignInPanel
            // 
            this.SignInPanel.BackColor = System.Drawing.Color.Black;
            this.SignInPanel.Controls.Add(this.CheckLocationLBL);
            this.SignInPanel.Controls.Add(this.SignInTitle);
            this.SignInPanel.Controls.Add(this.SignInBtn);
            this.SignInPanel.Location = new System.Drawing.Point(535, 23);
            this.SignInPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(374, 627);
            this.SignInPanel.TabIndex = 1;
            // 
            // CheckLocationLBL
            // 
            this.CheckLocationLBL.Font = new System.Drawing.Font("IRANSansWeb", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLocationLBL.ForeColor = System.Drawing.Color.White;
            this.CheckLocationLBL.Location = new System.Drawing.Point(4, 105);
            this.CheckLocationLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckLocationLBL.Name = "CheckLocationLBL";
            this.CheckLocationLBL.Size = new System.Drawing.Size(366, 238);
            this.CheckLocationLBL.TabIndex = 2;
            this.CheckLocationLBL.Text = "زمان";
            this.CheckLocationLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignInTitle
            // 
            this.SignInTitle.Font = new System.Drawing.Font("IRANSansWeb", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInTitle.ForeColor = System.Drawing.Color.White;
            this.SignInTitle.Location = new System.Drawing.Point(4, 500);
            this.SignInTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignInTitle.Name = "SignInTitle";
            this.SignInTitle.Size = new System.Drawing.Size(366, 59);
            this.SignInTitle.TabIndex = 1;
            this.SignInTitle.Text = "ثبت نام حساب جدید";
            this.SignInTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(53, 572);
            this.SignInBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(269, 34);
            this.SignInBtn.TabIndex = 0;
            this.SignInBtn.Text = "تایید";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // RecoveryPanel
            // 
            this.RecoveryPanel.BackColor = System.Drawing.Color.Gray;
            this.RecoveryPanel.Controls.Add(this.RecoverBtn);
            this.RecoveryPanel.Controls.Add(this.RecoverTitle);
            this.RecoveryPanel.Location = new System.Drawing.Point(35, 23);
            this.RecoveryPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecoveryPanel.Name = "RecoveryPanel";
            this.RecoveryPanel.Size = new System.Drawing.Size(374, 627);
            this.RecoveryPanel.TabIndex = 2;
            // 
            // RecoverBtn
            // 
            this.RecoverBtn.Location = new System.Drawing.Point(53, 572);
            this.RecoverBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecoverBtn.Name = "RecoverBtn";
            this.RecoverBtn.Size = new System.Drawing.Size(269, 34);
            this.RecoverBtn.TabIndex = 3;
            this.RecoverBtn.Text = "تایید";
            this.RecoverBtn.UseVisualStyleBackColor = true;
            // 
            // RecoverTitle
            // 
            this.RecoverTitle.Font = new System.Drawing.Font("IRANSansWeb", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoverTitle.Location = new System.Drawing.Point(4, 0);
            this.RecoverTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RecoverTitle.Name = "RecoverTitle";
            this.RecoverTitle.Size = new System.Drawing.Size(366, 59);
            this.RecoverTitle.TabIndex = 0;
            this.RecoverTitle.Text = "حساب خود را  برگردانید";
            this.RecoverTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(674, 652);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "خروج";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1445, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecoveryPanel);
            this.Controls.Add(this.SignInPanel);
            this.Controls.Add(this.LoginPanel);
            this.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginPanel.ResumeLayout(false);
            this.SignInPanel.ResumeLayout(false);
            this.RecoveryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel SignInPanel;
        private System.Windows.Forms.Panel RecoveryPanel;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Label RecoverTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SignInTitle;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button RecoverBtn;
        private System.Windows.Forms.Label CheckLocationLBL;
        private System.Windows.Forms.Label label1;
    }
}