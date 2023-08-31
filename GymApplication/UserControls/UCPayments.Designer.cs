namespace GymApplication.UserControls
{
    partial class UCPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPayments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRight = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnSavePayment = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymentDetails = new Guna.UI.WinForms.GunaTextBox();
            this.txtPaymentPrice = new Guna.UI.WinForms.GunaTextBox();
            this.dtPayment = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtPaymentType = new Guna.UI.WinForms.GunaTextBox();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnArechieveLessonsMale = new Guna.UI.WinForms.GunaButton();
            this.dgPaymentArchieve = new Guna.UI.WinForms.GunaDataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtPaymentTo = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtPaymentFrom = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPaymentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEditPayment = new Guna.UI.WinForms.GunaButton();
            this.panelRight.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentArchieve)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.BaseColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.btnEditPayment);
            this.panelRight.Controls.Add(this.btnSavePayment);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.txtPaymentDetails);
            this.panelRight.Controls.Add(this.txtPaymentPrice);
            this.panelRight.Controls.Add(this.dtPayment);
            this.panelRight.Controls.Add(this.txtPaymentType);
            this.panelRight.Location = new System.Drawing.Point(745, 43);
            this.panelRight.Name = "panelRight";
            this.panelRight.Radius = 10;
            this.panelRight.ShadowColor = System.Drawing.Color.Black;
            this.panelRight.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelRight.Size = new System.Drawing.Size(397, 550);
            this.panelRight.TabIndex = 0;
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.AnimationHoverSpeed = 0.07F;
            this.btnSavePayment.AnimationSpeed = 0.03F;
            this.btnSavePayment.BackColor = System.Drawing.Color.Transparent;
            this.btnSavePayment.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(200)))));
            this.btnSavePayment.BorderColor = System.Drawing.Color.Black;
            this.btnSavePayment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSavePayment.FocusedColor = System.Drawing.Color.Empty;
            this.btnSavePayment.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePayment.ForeColor = System.Drawing.Color.White;
            this.btnSavePayment.Image = null;
            this.btnSavePayment.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSavePayment.Location = new System.Drawing.Point(240, 489);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(200)))));
            this.btnSavePayment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSavePayment.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSavePayment.OnHoverImage = null;
            this.btnSavePayment.OnPressedColor = System.Drawing.Color.Black;
            this.btnSavePayment.Radius = 10;
            this.btnSavePayment.Size = new System.Drawing.Size(119, 42);
            this.btnSavePayment.TabIndex = 8;
            this.btnSavePayment.Text = "حفظ";
            this.btnSavePayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 195);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(62, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "التفاصيل";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 142);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "المبلغ المدفوع";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 93);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(51, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "التاريخ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 44);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "نوع المصروف";
            // 
            // txtPaymentDetails
            // 
            this.txtPaymentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymentDetails.BackColor = System.Drawing.Color.Transparent;
            this.txtPaymentDetails.BaseColor = System.Drawing.Color.White;
            this.txtPaymentDetails.BorderColor = System.Drawing.Color.Silver;
            this.txtPaymentDetails.BorderSize = 1;
            this.txtPaymentDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentDetails.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPaymentDetails.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPaymentDetails.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPaymentDetails.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentDetails.Location = new System.Drawing.Point(26, 195);
            this.txtPaymentDetails.Multiline = true;
            this.txtPaymentDetails.Name = "txtPaymentDetails";
            this.txtPaymentDetails.PasswordChar = '\0';
            this.txtPaymentDetails.Radius = 10;
            this.txtPaymentDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPaymentDetails.SelectedText = "";
            this.txtPaymentDetails.Size = new System.Drawing.Size(233, 198);
            this.txtPaymentDetails.TabIndex = 3;
            this.txtPaymentDetails.TextOffsetX = 10;
            // 
            // txtPaymentPrice
            // 
            this.txtPaymentPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymentPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPaymentPrice.BaseColor = System.Drawing.Color.White;
            this.txtPaymentPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtPaymentPrice.BorderSize = 1;
            this.txtPaymentPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPaymentPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPaymentPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPaymentPrice.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentPrice.Location = new System.Drawing.Point(26, 138);
            this.txtPaymentPrice.Name = "txtPaymentPrice";
            this.txtPaymentPrice.PasswordChar = '\0';
            this.txtPaymentPrice.Radius = 10;
            this.txtPaymentPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPaymentPrice.SelectedText = "";
            this.txtPaymentPrice.Size = new System.Drawing.Size(233, 39);
            this.txtPaymentPrice.TabIndex = 2;
            this.txtPaymentPrice.TextOffsetX = 10;
            // 
            // dtPayment
            // 
            this.dtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPayment.BackColor = System.Drawing.Color.Transparent;
            this.dtPayment.BaseColor = System.Drawing.Color.White;
            this.dtPayment.BorderColor = System.Drawing.Color.Silver;
            this.dtPayment.CustomFormat = null;
            this.dtPayment.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPayment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPayment.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPayment.ForeColor = System.Drawing.Color.Black;
            this.dtPayment.Location = new System.Drawing.Point(26, 92);
            this.dtPayment.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPayment.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPayment.Name = "dtPayment";
            this.dtPayment.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtPayment.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPayment.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPayment.OnPressedColor = System.Drawing.Color.Black;
            this.dtPayment.Radius = 10;
            this.dtPayment.Size = new System.Drawing.Size(233, 30);
            this.dtPayment.TabIndex = 1;
            this.dtPayment.Text = "Friday, June 26, 2020";
            this.dtPayment.Value = new System.DateTime(2020, 6, 26, 14, 6, 5, 806);
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymentType.BackColor = System.Drawing.Color.Transparent;
            this.txtPaymentType.BaseColor = System.Drawing.Color.White;
            this.txtPaymentType.BorderColor = System.Drawing.Color.Silver;
            this.txtPaymentType.BorderSize = 1;
            this.txtPaymentType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentType.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPaymentType.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPaymentType.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPaymentType.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentType.Location = new System.Drawing.Point(26, 37);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.PasswordChar = '\0';
            this.txtPaymentType.Radius = 10;
            this.txtPaymentType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPaymentType.SelectedText = "";
            this.txtPaymentType.Size = new System.Drawing.Size(233, 39);
            this.txtPaymentType.TabIndex = 0;
            this.txtPaymentType.TextOffsetX = 10;
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.lblTotal);
            this.gunaShadowPanel2.Controls.Add(this.label5);
            this.gunaShadowPanel2.Controls.Add(this.btnArechieveLessonsMale);
            this.gunaShadowPanel2.Controls.Add(this.dgPaymentArchieve);
            this.gunaShadowPanel2.Controls.Add(this.label17);
            this.gunaShadowPanel2.Controls.Add(this.label15);
            this.gunaShadowPanel2.Controls.Add(this.dtPaymentTo);
            this.gunaShadowPanel2.Controls.Add(this.dtPaymentFrom);
            this.gunaShadowPanel2.Controls.Add(this.gunaSeparator1);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(53, 43);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 10;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(645, 657);
            this.gunaShadowPanel2.TabIndex = 9;
            // 
            // btnArechieveLessonsMale
            // 
            this.btnArechieveLessonsMale.AnimationHoverSpeed = 0.07F;
            this.btnArechieveLessonsMale.AnimationSpeed = 0.03F;
            this.btnArechieveLessonsMale.BackColor = System.Drawing.Color.Transparent;
            this.btnArechieveLessonsMale.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnArechieveLessonsMale.BorderColor = System.Drawing.Color.LightGray;
            this.btnArechieveLessonsMale.BorderSize = 1;
            this.btnArechieveLessonsMale.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnArechieveLessonsMale.FocusedColor = System.Drawing.Color.Empty;
            this.btnArechieveLessonsMale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnArechieveLessonsMale.ForeColor = System.Drawing.Color.White;
            this.btnArechieveLessonsMale.Image = ((System.Drawing.Image)(resources.GetObject("btnArechieveLessonsMale.Image")));
            this.btnArechieveLessonsMale.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnArechieveLessonsMale.ImageSize = new System.Drawing.Size(25, 25);
            this.btnArechieveLessonsMale.Location = new System.Drawing.Point(14, 13);
            this.btnArechieveLessonsMale.Name = "btnArechieveLessonsMale";
            this.btnArechieveLessonsMale.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnArechieveLessonsMale.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnArechieveLessonsMale.OnHoverForeColor = System.Drawing.Color.White;
            this.btnArechieveLessonsMale.OnHoverImage = null;
            this.btnArechieveLessonsMale.OnPressedColor = System.Drawing.Color.Black;
            this.btnArechieveLessonsMale.Radius = 10;
            this.btnArechieveLessonsMale.Size = new System.Drawing.Size(40, 40);
            this.btnArechieveLessonsMale.TabIndex = 59;
            // 
            // dgPaymentArchieve
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgPaymentArchieve.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgPaymentArchieve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPaymentArchieve.BackgroundColor = System.Drawing.Color.White;
            this.dgPaymentArchieve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPaymentArchieve.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgPaymentArchieve.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPaymentArchieve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgPaymentArchieve.ColumnHeadersHeight = 35;
            this.dgPaymentArchieve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDate,
            this.colPaymentType,
            this.ColPaymentPrice,
            this.colPaymentDetails});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPaymentArchieve.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgPaymentArchieve.EnableHeadersVisualStyles = false;
            this.dgPaymentArchieve.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgPaymentArchieve.Location = new System.Drawing.Point(14, 93);
            this.dgPaymentArchieve.Name = "dgPaymentArchieve";
            this.dgPaymentArchieve.ReadOnly = true;
            this.dgPaymentArchieve.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgPaymentArchieve.RowHeadersVisible = false;
            this.dgPaymentArchieve.RowHeadersWidth = 51;
            this.dgPaymentArchieve.RowTemplate.Height = 40;
            this.dgPaymentArchieve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPaymentArchieve.Size = new System.Drawing.Size(616, 504);
            this.dgPaymentArchieve.TabIndex = 58;
            this.dgPaymentArchieve.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgPaymentArchieve.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgPaymentArchieve.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgPaymentArchieve.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgPaymentArchieve.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgPaymentArchieve.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgPaymentArchieve.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgPaymentArchieve.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgPaymentArchieve.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dgPaymentArchieve.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgPaymentArchieve.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPaymentArchieve.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgPaymentArchieve.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgPaymentArchieve.ThemeStyle.HeaderStyle.Height = 35;
            this.dgPaymentArchieve.ThemeStyle.ReadOnly = true;
            this.dgPaymentArchieve.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgPaymentArchieve.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgPaymentArchieve.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgPaymentArchieve.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgPaymentArchieve.ThemeStyle.RowsStyle.Height = 40;
            this.dgPaymentArchieve.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgPaymentArchieve.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgPaymentArchieve.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPaymentArchieve_CellDoubleClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(332, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 29);
            this.label17.TabIndex = 57;
            this.label17.Text = "الى";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(601, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 29);
            this.label15.TabIndex = 56;
            this.label15.Text = "من";
            // 
            // dtPaymentTo
            // 
            this.dtPaymentTo.BackColor = System.Drawing.Color.Transparent;
            this.dtPaymentTo.BaseColor = System.Drawing.Color.White;
            this.dtPaymentTo.BorderColor = System.Drawing.Color.Silver;
            this.dtPaymentTo.BorderSize = 1;
            this.dtPaymentTo.CustomFormat = null;
            this.dtPaymentTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPaymentTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPaymentTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPaymentTo.ForeColor = System.Drawing.Color.Black;
            this.dtPaymentTo.Location = new System.Drawing.Point(93, 21);
            this.dtPaymentTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPaymentTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPaymentTo.Name = "dtPaymentTo";
            this.dtPaymentTo.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtPaymentTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPaymentTo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPaymentTo.OnPressedColor = System.Drawing.Color.Black;
            this.dtPaymentTo.Radius = 10;
            this.dtPaymentTo.Size = new System.Drawing.Size(214, 30);
            this.dtPaymentTo.TabIndex = 55;
            this.dtPaymentTo.Text = "Thursday, June 25, 2020";
            this.dtPaymentTo.Value = new System.DateTime(2020, 6, 25, 19, 54, 35, 633);
            this.dtPaymentTo.ValueChanged += new System.EventHandler(this.dtPaymentTo_ValueChanged);
            // 
            // dtPaymentFrom
            // 
            this.dtPaymentFrom.BackColor = System.Drawing.Color.Transparent;
            this.dtPaymentFrom.BaseColor = System.Drawing.Color.White;
            this.dtPaymentFrom.BorderColor = System.Drawing.Color.Silver;
            this.dtPaymentFrom.BorderSize = 1;
            this.dtPaymentFrom.CustomFormat = null;
            this.dtPaymentFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPaymentFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPaymentFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPaymentFrom.ForeColor = System.Drawing.Color.Black;
            this.dtPaymentFrom.Location = new System.Drawing.Point(379, 23);
            this.dtPaymentFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPaymentFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPaymentFrom.Name = "dtPaymentFrom";
            this.dtPaymentFrom.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtPaymentFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPaymentFrom.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPaymentFrom.OnPressedColor = System.Drawing.Color.Black;
            this.dtPaymentFrom.Radius = 10;
            this.dtPaymentFrom.Size = new System.Drawing.Size(216, 30);
            this.dtPaymentFrom.TabIndex = 54;
            this.dtPaymentFrom.Text = "Saturday, June 27, 2020";
            this.dtPaymentFrom.Value = new System.DateTime(2020, 6, 27, 0, 0, 0, 0);
            this.dtPaymentFrom.ValueChanged += new System.EventHandler(this.dtPaymentFrom_ValueChanged);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(-20, 71);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(688, 10);
            this.gunaSeparator1.TabIndex = 0;
            this.gunaSeparator1.Thickness = 5;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "التسلسلى";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "_date";
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colPaymentType
            // 
            this.colPaymentType.DataPropertyName = "activity";
            this.colPaymentType.HeaderText = "النوع";
            this.colPaymentType.MinimumWidth = 6;
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.ReadOnly = true;
            // 
            // ColPaymentPrice
            // 
            this.ColPaymentPrice.DataPropertyName = "price";
            this.ColPaymentPrice.HeaderText = "المبلغ";
            this.ColPaymentPrice.MinimumWidth = 6;
            this.ColPaymentPrice.Name = "ColPaymentPrice";
            this.ColPaymentPrice.ReadOnly = true;
            // 
            // colPaymentDetails
            // 
            this.colPaymentDetails.DataPropertyName = "details";
            this.colPaymentDetails.HeaderText = "التفاصيل";
            this.colPaymentDetails.MinimumWidth = 6;
            this.colPaymentDetails.Name = "colPaymentDetails";
            this.colPaymentDetails.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(547, 606);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "الاجمالى";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(298, 606);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(234, 29);
            this.lblTotal.TabIndex = 60;
            // 
            // btnEditPayment
            // 
            this.btnEditPayment.AnimationHoverSpeed = 0.07F;
            this.btnEditPayment.AnimationSpeed = 0.03F;
            this.btnEditPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPayment.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(200)))));
            this.btnEditPayment.BorderColor = System.Drawing.Color.Black;
            this.btnEditPayment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditPayment.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditPayment.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPayment.ForeColor = System.Drawing.Color.White;
            this.btnEditPayment.Image = null;
            this.btnEditPayment.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditPayment.Location = new System.Drawing.Point(50, 489);
            this.btnEditPayment.Name = "btnEditPayment";
            this.btnEditPayment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(200)))));
            this.btnEditPayment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditPayment.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditPayment.OnHoverImage = null;
            this.btnEditPayment.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditPayment.Radius = 10;
            this.btnEditPayment.Size = new System.Drawing.Size(119, 42);
            this.btnEditPayment.TabIndex = 9;
            this.btnEditPayment.Text = "تعديل";
            this.btnEditPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditPayment.Click += new System.EventHandler(this.btnEditPayment_Click);
            // 
            // UCPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.gunaShadowPanel2);
            this.Controls.Add(this.panelRight);
            this.Name = "UCPayments";
            this.Size = new System.Drawing.Size(1188, 726);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentArchieve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel panelRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtPaymentDetails;
        private Guna.UI.WinForms.GunaTextBox txtPaymentPrice;
        private Guna.UI.WinForms.GunaDateTimePicker dtPayment;
        private Guna.UI.WinForms.GunaTextBox txtPaymentType;
        private Guna.UI.WinForms.GunaButton btnSavePayment;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaDateTimePicker dtPaymentTo;
        private Guna.UI.WinForms.GunaDateTimePicker dtPaymentFrom;
        private Guna.UI.WinForms.GunaDataGridView dgPaymentArchieve;
        private Guna.UI.WinForms.GunaButton btnArechieveLessonsMale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaymentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDetails;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton btnEditPayment;
    }
}
