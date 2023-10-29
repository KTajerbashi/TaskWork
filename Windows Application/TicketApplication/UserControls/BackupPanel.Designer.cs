namespace TicketApplication.UserControls
{
    partial class BackupPanel
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.SearchBtn = new DevComponents.DotNetBar.ButtonX();
            this.SearchTxt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.RecoverDbBtn = new DevComponents.DotNetBar.ButtonX();
            this.BackupBtn = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.MsgLBl = new System.Windows.Forms.Label();
            this.CountLBL = new System.Windows.Forms.Label();
            this.NextBtn = new Glass.GlassButton();
            this.PrevBtn = new Glass.GlassButton();
            this.Reloding = new Glass.GlassButton();
            this.Datagrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.Color.Transparent;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.groupPanel1.Controls.Add(this.SearchBtn);
            this.groupPanel1.Controls.Add(this.SearchTxt);
            this.groupPanel1.Controls.Add(this.RecoverDbBtn);
            this.groupPanel1.Controls.Add(this.BackupBtn);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1249, 87);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "پشتیبان گیری";
            // 
            // SearchBtn
            // 
            this.SearchBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SearchBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(3, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 35);
            this.SearchBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "جستجو";
            // 
            // SearchTxt
            // 
            // 
            // 
            // 
            this.SearchTxt.Border.Class = "TextBoxBorder";
            this.SearchTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchTxt.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxt.Location = new System.Drawing.Point(109, 13);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PreventEnterBeep = true;
            this.SearchTxt.Size = new System.Drawing.Size(327, 34);
            this.SearchTxt.TabIndex = 2;
            this.SearchTxt.WatermarkText = "جستجو ......";
            // 
            // RecoverDbBtn
            // 
            this.RecoverDbBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.RecoverDbBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.RecoverDbBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecoverDbBtn.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoverDbBtn.Location = new System.Drawing.Point(798, 12);
            this.RecoverDbBtn.Name = "RecoverDbBtn";
            this.RecoverDbBtn.Size = new System.Drawing.Size(218, 35);
            this.RecoverDbBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.RecoverDbBtn.TabIndex = 1;
            this.RecoverDbBtn.Text = "بازگردانی اطلاعات";
            this.RecoverDbBtn.Click += new System.EventHandler(this.RecoverDbBtn_Click);
            // 
            // BackupBtn
            // 
            this.BackupBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BackupBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BackupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackupBtn.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupBtn.Location = new System.Drawing.Point(1022, 12);
            this.BackupBtn.Name = "BackupBtn";
            this.BackupBtn.Size = new System.Drawing.Size(218, 35);
            this.BackupBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.BackupBtn.TabIndex = 0;
            this.BackupBtn.Text = "پشتیبان گیری";
            this.BackupBtn.Click += new System.EventHandler(this.BackupBtn_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.Color.Transparent;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.groupPanel2.Controls.Add(this.MsgLBl);
            this.groupPanel2.Controls.Add(this.CountLBL);
            this.groupPanel2.Controls.Add(this.NextBtn);
            this.groupPanel2.Controls.Add(this.PrevBtn);
            this.groupPanel2.Controls.Add(this.Reloding);
            this.groupPanel2.Controls.Add(this.Datagrid);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(3, 96);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1249, 561);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            this.groupPanel2.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "پایگاه داده";
            // 
            // MsgLBl
            // 
            this.MsgLBl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MsgLBl.BackColor = System.Drawing.Color.Transparent;
            this.MsgLBl.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgLBl.ForeColor = System.Drawing.Color.DarkRed;
            this.MsgLBl.Location = new System.Drawing.Point(3, 12);
            this.MsgLBl.Name = "MsgLBl";
            this.MsgLBl.Size = new System.Drawing.Size(1237, 19);
            this.MsgLBl.TabIndex = 18;
            this.MsgLBl.Text = "نکته : پشتیبان گیری نباید در درایور ویندوز ذخیره شود از یک درایور دیگر برای نگهدا" +
    "ری فایل پشتیبانی استفاده شود";
            this.MsgLBl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MsgLBl.UseMnemonic = false;
            // 
            // CountLBL
            // 
            this.CountLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountLBL.BackColor = System.Drawing.Color.Transparent;
            this.CountLBL.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLBL.ForeColor = System.Drawing.Color.Black;
            this.CountLBL.Location = new System.Drawing.Point(571, 510);
            this.CountLBL.Name = "CountLBL";
            this.CountLBL.Size = new System.Drawing.Size(100, 29);
            this.CountLBL.TabIndex = 17;
            this.CountLBL.Text = "تعداد رکورد";
            this.CountLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountLBL.UseMnemonic = false;
            // 
            // NextBtn
            // 
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.Location = new System.Drawing.Point(3, 490);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(40, 40);
            this.NextBtn.TabIndex = 15;
            this.NextBtn.Text = "بعد";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevBtn.Location = new System.Drawing.Point(49, 490);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(40, 40);
            this.PrevBtn.TabIndex = 14;
            this.PrevBtn.Text = "قبل";
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // Reloding
            // 
            this.Reloding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reloding.Location = new System.Drawing.Point(1200, 490);
            this.Reloding.Name = "Reloding";
            this.Reloding.Size = new System.Drawing.Size(40, 40);
            this.Reloding.TabIndex = 8;
            this.Reloding.Text = "تازه";
            this.Reloding.Click += new System.EventHandler(this.Reloding_Click);
            // 
            // Datagrid
            // 
            this.Datagrid.AllowUserToAddRows = false;
            this.Datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.Datagrid.BackgroundColor = System.Drawing.Color.White;
            this.Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.Datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Datagrid.Location = new System.Drawing.Point(3, 34);
            this.Datagrid.Name = "Datagrid";
            this.Datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid.Size = new System.Drawing.Size(1237, 450);
            this.Datagrid.TabIndex = 0;
            // 
            // BackupPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BackupPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1255, 660);
            this.Load += new System.EventHandler(this.BackupPanel_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX RecoverDbBtn;
        private DevComponents.DotNetBar.ButtonX BackupBtn;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX Datagrid;
        private Glass.GlassButton Reloding;
        private System.Windows.Forms.Label CountLBL;
        private Glass.GlassButton NextBtn;
        private Glass.GlassButton PrevBtn;
        private System.Windows.Forms.Label MsgLBl;
        private DevComponents.DotNetBar.Controls.TextBoxX SearchTxt;
        private DevComponents.DotNetBar.ButtonX SearchBtn;
    }
}
