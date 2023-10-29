namespace TicketApplication.UserControls
{
    partial class RoadMapPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoadMapPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTools = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ParentIdCombo = new System.Windows.Forms.ComboBox();
            this.DescTxt = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TitleTxt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PanelShow = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DataGridLesson = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CountLBL = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.FileCheck = new System.Windows.Forms.CheckBox();
            this.ImplementedCheck = new System.Windows.Forms.CheckBox();
            this.InProgressCheck = new System.Windows.Forms.CheckBox();
            this.FinishidCheck = new System.Windows.Forms.CheckBox();
            this.StartCheck = new System.Windows.Forms.CheckBox();
            this.RoadmapContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.شروعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اجراءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پایانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پیادهسازیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فایلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTools.SuspendLayout();
            this.PanelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLesson)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.RoadmapContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTools
            // 
            this.PanelTools.BackColor = System.Drawing.Color.Transparent;
            this.PanelTools.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelTools.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.PanelTools.Controls.Add(this.ParentIdCombo);
            this.PanelTools.Controls.Add(this.DescTxt);
            this.PanelTools.Controls.Add(this.SaveBtn);
            this.PanelTools.Controls.Add(this.TitleTxt);
            this.PanelTools.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelTools.Location = new System.Drawing.Point(881, 3);
            this.PanelTools.Name = "PanelTools";
            this.PanelTools.Size = new System.Drawing.Size(371, 487);
            // 
            // 
            // 
            this.PanelTools.Style.BackColorGradientAngle = 90;
            this.PanelTools.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PanelTools.Style.BorderBottomWidth = 1;
            this.PanelTools.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelTools.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PanelTools.Style.BorderLeftWidth = 1;
            this.PanelTools.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PanelTools.Style.BorderRightWidth = 1;
            this.PanelTools.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PanelTools.Style.BorderTopWidth = 1;
            this.PanelTools.Style.CornerDiameter = 4;
            this.PanelTools.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.PanelTools.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.PanelTools.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelTools.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.PanelTools.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.PanelTools.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PanelTools.TabIndex = 0;
            this.PanelTools.Text = "مسیر راه";
            // 
            // ParentIdCombo
            // 
            this.ParentIdCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParentIdCombo.BackColor = System.Drawing.Color.White;
            this.ParentIdCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParentIdCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParentIdCombo.ForeColor = System.Drawing.Color.Black;
            this.ParentIdCombo.FormattingEnabled = true;
            this.ParentIdCombo.Location = new System.Drawing.Point(8, 19);
            this.ParentIdCombo.Name = "ParentIdCombo";
            this.ParentIdCombo.Size = new System.Drawing.Size(349, 28);
            this.ParentIdCombo.TabIndex = 73;
            // 
            // DescTxt
            // 
            // 
            // 
            // 
            this.DescTxt.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DescTxt.BackgroundStyle.BackColor2 = System.Drawing.Color.CornflowerBlue;
            this.DescTxt.BackgroundStyle.Class = "RichTextBoxBorder";
            this.DescTxt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DescTxt.Location = new System.Drawing.Point(8, 81);
            this.DescTxt.Name = "DescTxt";
            this.DescTxt.Rtf = resources.GetString("DescTxt.Rtf");
            this.DescTxt.Size = new System.Drawing.Size(349, 330);
            this.DescTxt.TabIndex = 72;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(8, 419);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(349, 31);
            this.SaveBtn.TabIndex = 70;
            this.SaveBtn.Text = "ذخیره";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TitleTxt
            // 
            // 
            // 
            // 
            this.TitleTxt.Border.Class = "TextBoxBorder";
            this.TitleTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TitleTxt.Location = new System.Drawing.Point(7, 48);
            this.TitleTxt.MaxLength = 50;
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.PreventEnterBeep = true;
            this.TitleTxt.Size = new System.Drawing.Size(350, 27);
            this.TitleTxt.TabIndex = 3;
            this.TitleTxt.WatermarkText = "عنوان";
            // 
            // PanelShow
            // 
            this.PanelShow.BackColor = System.Drawing.Color.Transparent;
            this.PanelShow.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelShow.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.PanelShow.Controls.Add(this.DataGridLesson);
            this.PanelShow.Controls.Add(this.CountLBL);
            this.PanelShow.Controls.Add(this.SearchBtn);
            this.PanelShow.Controls.Add(this.SearchTxt);
            this.PanelShow.Controls.Add(this.NextBtn);
            this.PanelShow.Controls.Add(this.PrevBtn);
            this.PanelShow.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelShow.Location = new System.Drawing.Point(3, 3);
            this.PanelShow.Name = "PanelShow";
            this.PanelShow.Size = new System.Drawing.Size(872, 654);
            // 
            // 
            // 
            this.PanelShow.Style.BackColorGradientAngle = 90;
            this.PanelShow.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PanelShow.Style.BorderBottomWidth = 1;
            this.PanelShow.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelShow.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PanelShow.Style.BorderLeftWidth = 1;
            this.PanelShow.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PanelShow.Style.BorderRightWidth = 1;
            this.PanelShow.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PanelShow.Style.BorderTopWidth = 1;
            this.PanelShow.Style.CornerDiameter = 4;
            this.PanelShow.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.PanelShow.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.PanelShow.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelShow.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.PanelShow.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.PanelShow.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PanelShow.TabIndex = 1;
            this.PanelShow.Text = "نمایش راه";
            // 
            // DataGridLesson
            // 
            this.DataGridLesson.AllowDrop = true;
            this.DataGridLesson.AllowUserToAddRows = false;
            this.DataGridLesson.AllowUserToOrderColumns = true;
            this.DataGridLesson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridLesson.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DataGridLesson.BackgroundColor = System.Drawing.Color.White;
            this.DataGridLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridLesson.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridLesson.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridLesson.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataGridLesson.Location = new System.Drawing.Point(3, 35);
            this.DataGridLesson.Name = "DataGridLesson";
            this.DataGridLesson.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridLesson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridLesson.Size = new System.Drawing.Size(860, 552);
            this.DataGridLesson.TabIndex = 18;
            this.DataGridLesson.VirtualMode = true;
            this.DataGridLesson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridLesson_CellClick);
            this.DataGridLesson.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridLesson_CellMouseClick);
            // 
            // CountLBL
            // 
            this.CountLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountLBL.BackColor = System.Drawing.Color.Transparent;
            this.CountLBL.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLBL.ForeColor = System.Drawing.Color.Black;
            this.CountLBL.Location = new System.Drawing.Point(257, 603);
            this.CountLBL.Name = "CountLBL";
            this.CountLBL.Size = new System.Drawing.Size(352, 29);
            this.CountLBL.TabIndex = 14;
            this.CountLBL.Text = "تعداد رکورد | صفحه 1";
            this.CountLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountLBL.UseMnemonic = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(5, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(99, 30);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "جستجو";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTxt
            // 
            // 
            // 
            // 
            this.SearchTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchTxt.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxt.Location = new System.Drawing.Point(110, 6);
            this.SearchTxt.MaxLength = 35;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PreventEnterBeep = true;
            this.SearchTxt.Size = new System.Drawing.Size(205, 23);
            this.SearchTxt.TabIndex = 9;
            this.SearchTxt.WatermarkText = "جستجو ...";
            // 
            // NextBtn
            // 
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(3, 593);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(39, 30);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = ">";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevBtn.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevBtn.Location = new System.Drawing.Point(824, 593);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(39, 30);
            this.PrevBtn.TabIndex = 4;
            this.PrevBtn.Text = "<";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.groupPanel2.Controls.Add(this.FileCheck);
            this.groupPanel2.Controls.Add(this.ImplementedCheck);
            this.groupPanel2.Controls.Add(this.InProgressCheck);
            this.groupPanel2.Controls.Add(this.FinishidCheck);
            this.groupPanel2.Controls.Add(this.StartCheck);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(881, 496);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(371, 161);
            // 
            // 
            // 
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
            this.groupPanel2.Text = "تعیین وضعیت";
            // 
            // FileCheck
            // 
            this.FileCheck.AutoSize = true;
            this.FileCheck.Location = new System.Drawing.Point(275, 102);
            this.FileCheck.Name = "FileCheck";
            this.FileCheck.Size = new System.Drawing.Size(82, 24);
            this.FileCheck.TabIndex = 76;
            this.FileCheck.Text = "فایل موجود";
            this.FileCheck.UseVisualStyleBackColor = true;
            // 
            // ImplementedCheck
            // 
            this.ImplementedCheck.AutoSize = true;
            this.ImplementedCheck.Location = new System.Drawing.Point(253, 78);
            this.ImplementedCheck.Name = "ImplementedCheck";
            this.ImplementedCheck.Size = new System.Drawing.Size(104, 24);
            this.ImplementedCheck.TabIndex = 74;
            this.ImplementedCheck.Text = "پیاده سازی شده";
            this.ImplementedCheck.UseVisualStyleBackColor = true;
            // 
            // InProgressCheck
            // 
            this.InProgressCheck.AutoSize = true;
            this.InProgressCheck.Location = new System.Drawing.Point(271, 30);
            this.InProgressCheck.Name = "InProgressCheck";
            this.InProgressCheck.Size = new System.Drawing.Size(86, 24);
            this.InProgressCheck.TabIndex = 73;
            this.InProgressCheck.Text = "در حال اجراء";
            this.InProgressCheck.UseVisualStyleBackColor = true;
            // 
            // FinishidCheck
            // 
            this.FinishidCheck.AutoSize = true;
            this.FinishidCheck.Location = new System.Drawing.Point(278, 54);
            this.FinishidCheck.Name = "FinishidCheck";
            this.FinishidCheck.Size = new System.Drawing.Size(79, 24);
            this.FinishidCheck.TabIndex = 72;
            this.FinishidCheck.Text = "پایان یافته";
            this.FinishidCheck.UseVisualStyleBackColor = true;
            // 
            // StartCheck
            // 
            this.StartCheck.AutoSize = true;
            this.StartCheck.Location = new System.Drawing.Point(278, 6);
            this.StartCheck.Name = "StartCheck";
            this.StartCheck.Size = new System.Drawing.Size(79, 24);
            this.StartCheck.TabIndex = 71;
            this.StartCheck.Text = "شروع شده";
            this.StartCheck.UseVisualStyleBackColor = true;
            // 
            // RoadmapContext
            // 
            this.RoadmapContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.شروعToolStripMenuItem,
            this.اجراءToolStripMenuItem,
            this.پایانToolStripMenuItem,
            this.پیادهسازیToolStripMenuItem,
            this.فایلToolStripMenuItem});
            this.RoadmapContext.Name = "RoadmapContext";
            this.RoadmapContext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RoadmapContext.Size = new System.Drawing.Size(127, 158);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Image = global::TicketApplication.Properties.Resources._1486504369_change_edit_options_pencil_settings_tools_write_81307;
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = global::TicketApplication.Properties.Resources.Gakuseisean_Ivista_2_Alarm_Error_256;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // شروعToolStripMenuItem
            // 
            this.شروعToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("شروعToolStripMenuItem.Image")));
            this.شروعToolStripMenuItem.Name = "شروعToolStripMenuItem";
            this.شروعToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.شروعToolStripMenuItem.Text = "شروع";
            this.شروعToolStripMenuItem.Click += new System.EventHandler(this.شروعToolStripMenuItem_Click);
            // 
            // اجراءToolStripMenuItem
            // 
            this.اجراءToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("اجراءToolStripMenuItem.Image")));
            this.اجراءToolStripMenuItem.Name = "اجراءToolStripMenuItem";
            this.اجراءToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.اجراءToolStripMenuItem.Text = "اجراء";
            this.اجراءToolStripMenuItem.Click += new System.EventHandler(this.اجراءToolStripMenuItem_Click);
            // 
            // پایانToolStripMenuItem
            // 
            this.پایانToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("پایانToolStripMenuItem.Image")));
            this.پایانToolStripMenuItem.Name = "پایانToolStripMenuItem";
            this.پایانToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.پایانToolStripMenuItem.Text = "پایان";
            this.پایانToolStripMenuItem.Click += new System.EventHandler(this.پایانToolStripMenuItem_Click);
            // 
            // پیادهسازیToolStripMenuItem
            // 
            this.پیادهسازیToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("پیادهسازیToolStripMenuItem.Image")));
            this.پیادهسازیToolStripMenuItem.Name = "پیادهسازیToolStripMenuItem";
            this.پیادهسازیToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.پیادهسازیToolStripMenuItem.Text = "پیاده سازی";
            this.پیادهسازیToolStripMenuItem.Click += new System.EventHandler(this.پیادهسازیToolStripMenuItem_Click);
            // 
            // فایلToolStripMenuItem
            // 
            this.فایلToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("فایلToolStripMenuItem.Image")));
            this.فایلToolStripMenuItem.Name = "فایلToolStripMenuItem";
            this.فایلToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.فایلToolStripMenuItem.Text = "فایل";
            this.فایلToolStripMenuItem.Click += new System.EventHandler(this.فایلToolStripMenuItem_Click);
            // 
            // RoadMapPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.PanelShow);
            this.Controls.Add(this.PanelTools);
            this.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoadMapPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1255, 660);
            this.Load += new System.EventHandler(this.RoadMapPanel_Load);
            this.PanelTools.ResumeLayout(false);
            this.PanelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLesson)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.RoadmapContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel PanelTools;
        private DevComponents.DotNetBar.Controls.GroupPanel PanelShow;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PrevBtn;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.Button SearchBtn;
        private DevComponents.DotNetBar.Controls.TextBoxX SearchTxt;
        private DevComponents.DotNetBar.Controls.TextBoxX TitleTxt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox FinishidCheck;
        private System.Windows.Forms.CheckBox StartCheck;
        private System.Windows.Forms.CheckBox ImplementedCheck;
        private System.Windows.Forms.CheckBox InProgressCheck;
        private System.Windows.Forms.CheckBox FileCheck;
        private System.Windows.Forms.Label CountLBL;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx DescTxt;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataGridLesson;
        public System.Windows.Forms.ComboBox ParentIdCombo;
        private System.Windows.Forms.ContextMenuStrip RoadmapContext;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem شروعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اجراءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem پایانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem پیادهسازیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فایلToolStripMenuItem;
    }
}
