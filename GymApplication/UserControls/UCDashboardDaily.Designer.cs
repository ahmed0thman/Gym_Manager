namespace GymApplication.UserControls
{
    partial class UCDashboardDaily
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
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDashboardDaily));
            this.panelLessonInfo = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblTotalLessonsPrice = new System.Windows.Forms.Label();
            this.lblLessonsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelnewMemmeberShipsInfo = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblTotalMempershipsPrice = new System.Windows.Forms.Label();
            this.lblNewMembershipsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRenewMembershipsInfo = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblTotalRenewMembershipsPrice = new System.Windows.Forms.Label();
            this.lblRenewMembershipsCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.panelDtTo = new System.Windows.Forms.Panel();
            this.dt2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxReportType = new Guna.UI.WinForms.GunaComboBox();
            this.dgActivities = new Guna.UI.WinForms.GunaDataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCouch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintRepot = new Guna.UI.WinForms.GunaButton();
            this.dt1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trPanelDtTo = new Guna.UI.WinForms.GunaTransition(this.components);
            this.panelLessonInfo.SuspendLayout();
            this.panelnewMemmeberShipsInfo.SuspendLayout();
            this.panelRenewMembershipsInfo.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            this.panelDtTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLessonInfo
            // 
            this.panelLessonInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelLessonInfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.panelLessonInfo.Controls.Add(this.lblTotalLessonsPrice);
            this.panelLessonInfo.Controls.Add(this.lblLessonsCount);
            this.panelLessonInfo.Controls.Add(this.label1);
            this.trPanelDtTo.SetDecoration(this.panelLessonInfo, Guna.UI.Animation.DecorationType.None);
            this.panelLessonInfo.Location = new System.Drawing.Point(635, 29);
            this.panelLessonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLessonInfo.Name = "panelLessonInfo";
            this.panelLessonInfo.Radius = 10;
            this.panelLessonInfo.ShadowColor = System.Drawing.Color.Black;
            this.panelLessonInfo.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelLessonInfo.Size = new System.Drawing.Size(213, 89);
            this.panelLessonInfo.TabIndex = 0;
            // 
            // lblTotalLessonsPrice
            // 
            this.lblTotalLessonsPrice.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.lblTotalLessonsPrice, Guna.UI.Animation.DecorationType.None);
            this.lblTotalLessonsPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLessonsPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalLessonsPrice.Location = new System.Drawing.Point(19, 48);
            this.lblTotalLessonsPrice.Name = "lblTotalLessonsPrice";
            this.lblTotalLessonsPrice.Size = new System.Drawing.Size(19, 19);
            this.lblTotalLessonsPrice.TabIndex = 2;
            this.lblTotalLessonsPrice.Text = "0";
            // 
            // lblLessonsCount
            // 
            this.lblLessonsCount.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.lblLessonsCount, Guna.UI.Animation.DecorationType.None);
            this.lblLessonsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessonsCount.ForeColor = System.Drawing.Color.White;
            this.lblLessonsCount.Location = new System.Drawing.Point(19, 17);
            this.lblLessonsCount.Name = "lblLessonsCount";
            this.lblLessonsCount.Size = new System.Drawing.Size(19, 19);
            this.lblLessonsCount.TabIndex = 1;
            this.lblLessonsCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(110, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "الحصص";
            // 
            // panelnewMemmeberShipsInfo
            // 
            this.panelnewMemmeberShipsInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelnewMemmeberShipsInfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.panelnewMemmeberShipsInfo.Controls.Add(this.lblTotalMempershipsPrice);
            this.panelnewMemmeberShipsInfo.Controls.Add(this.lblNewMembershipsCount);
            this.panelnewMemmeberShipsInfo.Controls.Add(this.label4);
            this.trPanelDtTo.SetDecoration(this.panelnewMemmeberShipsInfo, Guna.UI.Animation.DecorationType.None);
            this.panelnewMemmeberShipsInfo.Location = new System.Drawing.Point(635, 150);
            this.panelnewMemmeberShipsInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelnewMemmeberShipsInfo.Name = "panelnewMemmeberShipsInfo";
            this.panelnewMemmeberShipsInfo.Radius = 10;
            this.panelnewMemmeberShipsInfo.ShadowColor = System.Drawing.Color.Black;
            this.panelnewMemmeberShipsInfo.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelnewMemmeberShipsInfo.Size = new System.Drawing.Size(213, 89);
            this.panelnewMemmeberShipsInfo.TabIndex = 1;
            // 
            // lblTotalMempershipsPrice
            // 
            this.lblTotalMempershipsPrice.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.lblTotalMempershipsPrice, Guna.UI.Animation.DecorationType.None);
            this.lblTotalMempershipsPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMempershipsPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalMempershipsPrice.Location = new System.Drawing.Point(15, 50);
            this.lblTotalMempershipsPrice.Name = "lblTotalMempershipsPrice";
            this.lblTotalMempershipsPrice.Size = new System.Drawing.Size(19, 19);
            this.lblTotalMempershipsPrice.TabIndex = 5;
            this.lblTotalMempershipsPrice.Text = "0";
            // 
            // lblNewMembershipsCount
            // 
            this.lblNewMembershipsCount.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.lblNewMembershipsCount, Guna.UI.Animation.DecorationType.None);
            this.lblNewMembershipsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMembershipsCount.ForeColor = System.Drawing.Color.White;
            this.lblNewMembershipsCount.Location = new System.Drawing.Point(15, 20);
            this.lblNewMembershipsCount.Name = "lblNewMembershipsCount";
            this.lblNewMembershipsCount.Size = new System.Drawing.Size(19, 19);
            this.lblNewMembershipsCount.TabIndex = 4;
            this.lblNewMembershipsCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.label4, Guna.UI.Animation.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(80, 17);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(116, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "جديد أعضاء";
            // 
            // panelRenewMembershipsInfo
            // 
            this.panelRenewMembershipsInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelRenewMembershipsInfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.panelRenewMembershipsInfo.Controls.Add(this.lblTotalRenewMembershipsPrice);
            this.panelRenewMembershipsInfo.Controls.Add(this.lblRenewMembershipsCount);
            this.panelRenewMembershipsInfo.Controls.Add(this.label7);
            this.trPanelDtTo.SetDecoration(this.panelRenewMembershipsInfo, Guna.UI.Animation.DecorationType.None);
            this.panelRenewMembershipsInfo.Location = new System.Drawing.Point(635, 274);
            this.panelRenewMembershipsInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRenewMembershipsInfo.Name = "panelRenewMembershipsInfo";
            this.panelRenewMembershipsInfo.Radius = 10;
            this.panelRenewMembershipsInfo.ShadowColor = System.Drawing.Color.Black;
            this.panelRenewMembershipsInfo.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelRenewMembershipsInfo.Size = new System.Drawing.Size(213, 89);
            this.panelRenewMembershipsInfo.TabIndex = 2;
            // 
            // lblTotalRenewMembershipsPrice
            // 
            this.lblTotalRenewMembershipsPrice.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.lblTotalRenewMembershipsPrice, Guna.UI.Animation.DecorationType.None);
            this.lblTotalRenewMembershipsPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRenewMembershipsPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalRenewMembershipsPrice.Location = new System.Drawing.Point(15, 50);
            this.lblTotalRenewMembershipsPrice.Name = "lblTotalRenewMembershipsPrice";
            this.lblTotalRenewMembershipsPrice.Size = new System.Drawing.Size(19, 19);
            this.lblTotalRenewMembershipsPrice.TabIndex = 5;
            this.lblTotalRenewMembershipsPrice.Text = "0";
            // 
            // lblRenewMembershipsCount
            // 
            this.lblRenewMembershipsCount.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.lblRenewMembershipsCount, Guna.UI.Animation.DecorationType.None);
            this.lblRenewMembershipsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewMembershipsCount.ForeColor = System.Drawing.Color.White;
            this.lblRenewMembershipsCount.Location = new System.Drawing.Point(15, 20);
            this.lblRenewMembershipsCount.Name = "lblRenewMembershipsCount";
            this.lblRenewMembershipsCount.Size = new System.Drawing.Size(19, 19);
            this.lblRenewMembershipsCount.TabIndex = 4;
            this.lblRenewMembershipsCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.label7, Guna.UI.Animation.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(59, 20);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(138, 41);
            this.label7.TabIndex = 3;
            this.label7.Text = "تجديد عضويات";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.gunaShadowPanel1.Controls.Add(this.lblTotalPrice);
            this.gunaShadowPanel1.Controls.Add(this.label10);
            this.trPanelDtTo.SetDecoration(this.gunaShadowPanel1, Guna.UI.Animation.DecorationType.None);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(635, 392);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(213, 89);
            this.gunaShadowPanel1.TabIndex = 6;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.lblTotalPrice, Guna.UI.Animation.DecorationType.None);
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(19, 50);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(19, 19);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.label10, Guna.UI.Animation.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(59, 9);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(122, 41);
            this.label10.TabIndex = 3;
            this.label10.Text = "إجمالى الدخل";
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.panelDtTo);
            this.gunaShadowPanel2.Controls.Add(this.cbxReportType);
            this.gunaShadowPanel2.Controls.Add(this.dgActivities);
            this.gunaShadowPanel2.Controls.Add(this.btnPrintRepot);
            this.gunaShadowPanel2.Controls.Add(this.dt1);
            this.gunaShadowPanel2.Controls.Add(this.panel1);
            this.trPanelDtTo.SetDecoration(this.gunaShadowPanel2, Guna.UI.Animation.DecorationType.None);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(15, 29);
            this.gunaShadowPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 10;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(601, 459);
            this.gunaShadowPanel2.TabIndex = 7;
            // 
            // panelDtTo
            // 
            this.panelDtTo.Controls.Add(this.dt2);
            this.panelDtTo.Controls.Add(this.label15);
            this.trPanelDtTo.SetDecoration(this.panelDtTo, Guna.UI.Animation.DecorationType.None);
            this.panelDtTo.Location = new System.Drawing.Point(65, 4);
            this.panelDtTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDtTo.Name = "panelDtTo";
            this.panelDtTo.Size = new System.Drawing.Size(227, 40);
            this.panelDtTo.TabIndex = 58;
            // 
            // dt2
            // 
            this.dt2.BackColor = System.Drawing.Color.Transparent;
            this.dt2.BaseColor = System.Drawing.Color.White;
            this.dt2.BorderColor = System.Drawing.Color.Silver;
            this.dt2.BorderSize = 1;
            this.dt2.CustomFormat = null;
            this.trPanelDtTo.SetDecoration(this.dt2, Guna.UI.Animation.DecorationType.None);
            this.dt2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dt2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dt2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt2.ForeColor = System.Drawing.Color.Black;
            this.dt2.Location = new System.Drawing.Point(4, 9);
            this.dt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt2.Name = "dt2";
            this.dt2.OnHoverBaseColor = System.Drawing.Color.White;
            this.dt2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dt2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dt2.OnPressedColor = System.Drawing.Color.Black;
            this.dt2.Radius = 10;
            this.dt2.Size = new System.Drawing.Size(185, 24);
            this.dt2.TabIndex = 59;
            this.dt2.Text = "Thursday, 25 June, 2020";
            this.dt2.Value = new System.DateTime(2020, 6, 25, 19, 54, 35, 633);
            this.dt2.ValueChanged += new System.EventHandler(this.dt2_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.trPanelDtTo.SetDecoration(this.label15, Guna.UI.Animation.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(195, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 25);
            this.label15.TabIndex = 54;
            this.label15.Text = "الى";
            // 
            // cbxReportType
            // 
            this.cbxReportType.BackColor = System.Drawing.Color.Transparent;
            this.cbxReportType.BaseColor = System.Drawing.Color.White;
            this.cbxReportType.BorderColor = System.Drawing.Color.Silver;
            this.cbxReportType.BorderSize = 1;
            this.trPanelDtTo.SetDecoration(this.cbxReportType, Guna.UI.Animation.DecorationType.None);
            this.cbxReportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReportType.FocusedColor = System.Drawing.Color.Empty;
            this.cbxReportType.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxReportType.ForeColor = System.Drawing.Color.Black;
            this.cbxReportType.FormattingEnabled = true;
            this.cbxReportType.Items.AddRange(new object[] {
            "يومى",
            "شهرى"});
            this.cbxReportType.Location = new System.Drawing.Point(498, 11);
            this.cbxReportType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxReportType.Name = "cbxReportType";
            this.cbxReportType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxReportType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxReportType.Radius = 5;
            this.cbxReportType.Size = new System.Drawing.Size(91, 31);
            this.cbxReportType.StartIndex = 0;
            this.cbxReportType.TabIndex = 57;
            this.cbxReportType.SelectedIndexChanged += new System.EventHandler(this.cbxReportType_SelectedIndexChanged);
            // 
            // dgActivities
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgActivities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgActivities.BackgroundColor = System.Drawing.Color.White;
            this.dgActivities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgActivities.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgActivities.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgActivities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgActivities.ColumnHeadersHeight = 35;
            this.dgActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colType,
            this.colCouch,
            this.colName,
            this.colPrice});
            this.trPanelDtTo.SetDecoration(this.dgActivities, Guna.UI.Animation.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgActivities.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgActivities.EnableHeadersVisualStyles = false;
            this.dgActivities.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgActivities.Location = new System.Drawing.Point(14, 67);
            this.dgActivities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgActivities.Name = "dgActivities";
            this.dgActivities.ReadOnly = true;
            this.dgActivities.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgActivities.RowHeadersVisible = false;
            this.dgActivities.RowHeadersWidth = 51;
            this.dgActivities.RowTemplate.Height = 40;
            this.dgActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgActivities.Size = new System.Drawing.Size(574, 372);
            this.dgActivities.TabIndex = 56;
            this.dgActivities.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgActivities.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgActivities.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgActivities.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgActivities.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgActivities.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgActivities.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgActivities.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgActivities.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dgActivities.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgActivities.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgActivities.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgActivities.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgActivities.ThemeStyle.HeaderStyle.Height = 35;
            this.dgActivities.ThemeStyle.ReadOnly = true;
            this.dgActivities.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgActivities.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgActivities.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgActivities.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgActivities.ThemeStyle.RowsStyle.Height = 40;
            this.dgActivities.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgActivities.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "_date";
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "_type";
            this.colType.HeaderText = "نوع النشاط";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colCouch
            // 
            this.colCouch.DataPropertyName = "captin";
            this.colCouch.HeaderText = "الكابتن";
            this.colCouch.MinimumWidth = 6;
            this.colCouch.Name = "colCouch";
            this.colCouch.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "_name";
            this.colName.HeaderText = "الإسم";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "price";
            this.colPrice.HeaderText = "المبلغ المدفوع";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // btnPrintRepot
            // 
            this.btnPrintRepot.AnimationHoverSpeed = 0.07F;
            this.btnPrintRepot.AnimationSpeed = 0.03F;
            this.btnPrintRepot.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintRepot.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnPrintRepot.BorderColor = System.Drawing.Color.LightGray;
            this.btnPrintRepot.BorderSize = 1;
            this.trPanelDtTo.SetDecoration(this.btnPrintRepot, Guna.UI.Animation.DecorationType.None);
            this.btnPrintRepot.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintRepot.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintRepot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrintRepot.ForeColor = System.Drawing.Color.White;
            this.btnPrintRepot.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintRepot.Image")));
            this.btnPrintRepot.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrintRepot.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrintRepot.Location = new System.Drawing.Point(11, 11);
            this.btnPrintRepot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintRepot.Name = "btnPrintRepot";
            this.btnPrintRepot.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnPrintRepot.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintRepot.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrintRepot.OnHoverImage = null;
            this.btnPrintRepot.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrintRepot.Radius = 10;
            this.btnPrintRepot.Size = new System.Drawing.Size(34, 32);
            this.btnPrintRepot.TabIndex = 55;
            // 
            // dt1
            // 
            this.dt1.BackColor = System.Drawing.Color.Transparent;
            this.dt1.BaseColor = System.Drawing.Color.White;
            this.dt1.BorderColor = System.Drawing.Color.Silver;
            this.dt1.BorderSize = 1;
            this.dt1.CustomFormat = null;
            this.trPanelDtTo.SetDecoration(this.dt1, Guna.UI.Animation.DecorationType.None);
            this.dt1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dt1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dt1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt1.ForeColor = System.Drawing.Color.Black;
            this.dt1.Location = new System.Drawing.Point(302, 13);
            this.dt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt1.Name = "dt1";
            this.dt1.OnHoverBaseColor = System.Drawing.Color.White;
            this.dt1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dt1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dt1.OnPressedColor = System.Drawing.Color.Black;
            this.dt1.Radius = 10;
            this.dt1.Size = new System.Drawing.Size(185, 24);
            this.dt1.TabIndex = 53;
            this.dt1.Text = "Thursday, 25 June, 2020";
            this.dt1.Value = new System.DateTime(2020, 6, 25, 19, 54, 35, 633);
            this.dt1.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
            // 
            // panel1
            // 
            this.trPanelDtTo.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(-9, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 4);
            this.panel1.TabIndex = 38;
            // 
            // trPanelDtTo
            // 
            this.trPanelDtTo.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.trPanelDtTo.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.trPanelDtTo.DefaultAnimation = animation1;
            // 
            // UCDashboardDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.gunaShadowPanel2);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.panelRenewMembershipsInfo);
            this.Controls.Add(this.panelnewMemmeberShipsInfo);
            this.Controls.Add(this.panelLessonInfo);
            this.trPanelDtTo.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCDashboardDaily";
            this.Size = new System.Drawing.Size(857, 517);
            this.Load += new System.EventHandler(this.UCDashboardDaily_Load);
            this.panelLessonInfo.ResumeLayout(false);
            this.panelLessonInfo.PerformLayout();
            this.panelnewMemmeberShipsInfo.ResumeLayout(false);
            this.panelnewMemmeberShipsInfo.PerformLayout();
            this.panelRenewMembershipsInfo.ResumeLayout(false);
            this.panelRenewMembershipsInfo.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.gunaShadowPanel2.ResumeLayout(false);
            this.panelDtTo.ResumeLayout(false);
            this.panelDtTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgActivities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel panelLessonInfo;
        private Guna.UI.WinForms.GunaShadowPanel panelnewMemmeberShipsInfo;
        private Guna.UI.WinForms.GunaShadowPanel panelRenewMembershipsInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalLessonsPrice;
        private System.Windows.Forms.Label lblLessonsCount;
        private System.Windows.Forms.Label lblTotalMempershipsPrice;
        private System.Windows.Forms.Label lblNewMembershipsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalRenewMembershipsPrice;
        private System.Windows.Forms.Label lblRenewMembershipsCount;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaDateTimePicker dt1;
        private Guna.UI.WinForms.GunaButton btnPrintRepot;
        private Guna.UI.WinForms.GunaDataGridView dgActivities;
        private System.Windows.Forms.Panel panelDtTo;
        private Guna.UI.WinForms.GunaDateTimePicker dt2;
        private Guna.UI.WinForms.GunaComboBox cbxReportType;
        private Guna.UI.WinForms.GunaTransition trPanelDtTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCouch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}
