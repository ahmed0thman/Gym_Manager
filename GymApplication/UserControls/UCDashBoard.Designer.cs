namespace GymApplication.UserControls
{
    partial class UCDashBoard
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
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDashBoard));
            this.panelDashboardContainer = new System.Windows.Forms.Panel();
            this.btnShowPanelLesson = new Guna.UI.WinForms.GunaButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelLessonInfo = new Guna.UI.WinForms.GunaShadowPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.cbxGender = new Guna.UI.WinForms.GunaComboBox();
            this.btnSaveLesson = new Guna.UI.WinForms.GunaCircleButton();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbxTradeMile = new Guna.UI.WinForms.GunaCheckBox();
            this.dtLesson = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCaptinName = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVisitorName = new Guna.UI.WinForms.GunaTextBox();
            this.trPanelLesson = new Guna.UI.WinForms.GunaTransition(this.components);
            this.panelLessonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashboardContainer
            // 
            this.trPanelLesson.SetDecoration(this.panelDashboardContainer, Guna.UI.Animation.DecorationType.None);
            this.panelDashboardContainer.Location = new System.Drawing.Point(83, 37);
            this.panelDashboardContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDashboardContainer.Name = "panelDashboardContainer";
            this.panelDashboardContainer.Size = new System.Drawing.Size(857, 517);
            this.panelDashboardContainer.TabIndex = 2;
            // 
            // btnShowPanelLesson
            // 
            this.btnShowPanelLesson.AnimationHoverSpeed = 0.07F;
            this.btnShowPanelLesson.AnimationSpeed = 0.03F;
            this.btnShowPanelLesson.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPanelLesson.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(200)))));
            this.btnShowPanelLesson.BorderColor = System.Drawing.Color.Black;
            this.trPanelLesson.SetDecoration(this.btnShowPanelLesson, Guna.UI.Animation.DecorationType.None);
            this.btnShowPanelLesson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowPanelLesson.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowPanelLesson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPanelLesson.ForeColor = System.Drawing.Color.White;
            this.btnShowPanelLesson.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPanelLesson.Image")));
            this.btnShowPanelLesson.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowPanelLesson.ImageSize = new System.Drawing.Size(17, 17);
            this.btnShowPanelLesson.Location = new System.Drawing.Point(966, 7);
            this.btnShowPanelLesson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowPanelLesson.Name = "btnShowPanelLesson";
            this.btnShowPanelLesson.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(200)))));
            this.btnShowPanelLesson.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShowPanelLesson.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowPanelLesson.OnHoverImage = null;
            this.btnShowPanelLesson.OnPressedColor = System.Drawing.Color.Black;
            this.btnShowPanelLesson.Radius = 10;
            this.btnShowPanelLesson.Size = new System.Drawing.Size(34, 32);
            this.btnShowPanelLesson.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnShowPanelLesson, "إضافة حصة");
            this.btnShowPanelLesson.Click += new System.EventHandler(this.btnShowPanelLesson_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // panelLessonInfo
            // 
            this.panelLessonInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelLessonInfo.BaseColor = System.Drawing.Color.White;
            this.panelLessonInfo.Controls.Add(this.label5);
            this.panelLessonInfo.Controls.Add(this.label4);
            this.panelLessonInfo.Controls.Add(this.txtPhone);
            this.panelLessonInfo.Controls.Add(this.cbxGender);
            this.panelLessonInfo.Controls.Add(this.btnSaveLesson);
            this.panelLessonInfo.Controls.Add(this.txtPrice);
            this.panelLessonInfo.Controls.Add(this.label3);
            this.panelLessonInfo.Controls.Add(this.chkbxTradeMile);
            this.panelLessonInfo.Controls.Add(this.dtLesson);
            this.panelLessonInfo.Controls.Add(this.label2);
            this.panelLessonInfo.Controls.Add(this.cbxCaptinName);
            this.panelLessonInfo.Controls.Add(this.label1);
            this.panelLessonInfo.Controls.Add(this.txtVisitorName);
            this.trPanelLesson.SetDecoration(this.panelLessonInfo, Guna.UI.Animation.DecorationType.None);
            this.panelLessonInfo.Location = new System.Drawing.Point(131, 14);
            this.panelLessonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLessonInfo.Name = "panelLessonInfo";
            this.panelLessonInfo.Radius = 10;
            this.panelLessonInfo.ShadowColor = System.Drawing.Color.Black;
            this.panelLessonInfo.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelLessonInfo.Size = new System.Drawing.Size(830, 98);
            this.panelLessonInfo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.trPanelLesson.SetDecoration(this.label5, Guna.UI.Animation.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "النوع";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.trPanelLesson.SetDecoration(this.label4, Guna.UI.Animation.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "الهاتف";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.BorderSize = 1;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelLesson.SetDecoration(this.txtPhone, Guna.UI.Animation.DecorationType.None);
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(323, 6);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 10;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(174, 33);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxGender
            // 
            this.cbxGender.BackColor = System.Drawing.Color.Transparent;
            this.cbxGender.BaseColor = System.Drawing.Color.White;
            this.cbxGender.BorderColor = System.Drawing.Color.Silver;
            this.cbxGender.BorderSize = 1;
            this.trPanelLesson.SetDecoration(this.cbxGender, Guna.UI.Animation.DecorationType.None);
            this.cbxGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FocusedColor = System.Drawing.Color.Empty;
            this.cbxGender.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.ForeColor = System.Drawing.Color.Black;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.cbxGender.Location = new System.Drawing.Point(96, 49);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxGender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxGender.Radius = 10;
            this.cbxGender.Size = new System.Drawing.Size(125, 31);
            this.cbxGender.StartIndex = 0;
            this.cbxGender.TabIndex = 9;
            // 
            // btnSaveLesson
            // 
            this.btnSaveLesson.AnimationHoverSpeed = 0.07F;
            this.btnSaveLesson.AnimationSpeed = 0.03F;
            this.btnSaveLesson.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(200)))));
            this.btnSaveLesson.BorderColor = System.Drawing.Color.Black;
            this.trPanelLesson.SetDecoration(this.btnSaveLesson, Guna.UI.Animation.DecorationType.None);
            this.btnSaveLesson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveLesson.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveLesson.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLesson.ForeColor = System.Drawing.Color.White;
            this.btnSaveLesson.Image = null;
            this.btnSaveLesson.ImageSize = new System.Drawing.Size(52, 52);
            this.btnSaveLesson.Location = new System.Drawing.Point(8, 11);
            this.btnSaveLesson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveLesson.Name = "btnSaveLesson";
            this.btnSaveLesson.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(200)))));
            this.btnSaveLesson.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveLesson.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveLesson.OnHoverImage = null;
            this.btnSaveLesson.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveLesson.Size = new System.Drawing.Size(69, 65);
            this.btnSaveLesson.TabIndex = 8;
            this.btnSaveLesson.Text = "حفظ";
            this.btnSaveLesson.Click += new System.EventHandler(this.btnSaveLesson_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtPrice.BorderSize = 1;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelLesson.SetDecoration(this.txtPrice, Guna.UI.Animation.DecorationType.None);
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(277, 48);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.Radius = 10;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(147, 33);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.trPanelLesson.SetDecoration(this.label3, Guna.UI.Animation.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "السعر";
            // 
            // chkbxTradeMile
            // 
            this.chkbxTradeMile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxTradeMile.BaseColor = System.Drawing.Color.White;
            this.chkbxTradeMile.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkbxTradeMile.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.trPanelLesson.SetDecoration(this.chkbxTradeMile, Guna.UI.Animation.DecorationType.None);
            this.chkbxTradeMile.FillColor = System.Drawing.Color.White;
            this.chkbxTradeMile.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold);
            this.chkbxTradeMile.Location = new System.Drawing.Point(488, 54);
            this.chkbxTradeMile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbxTradeMile.Name = "chkbxTradeMile";
            this.chkbxTradeMile.Size = new System.Drawing.Size(58, 26);
            this.chkbxTradeMile.TabIndex = 5;
            this.chkbxTradeMile.Text = "مشاية";
            // 
            // dtLesson
            // 
            this.dtLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLesson.BackColor = System.Drawing.Color.Transparent;
            this.dtLesson.BaseColor = System.Drawing.Color.White;
            this.dtLesson.BorderColor = System.Drawing.Color.Silver;
            this.dtLesson.BorderSize = 1;
            this.dtLesson.CustomFormat = null;
            this.trPanelLesson.SetDecoration(this.dtLesson, Guna.UI.Animation.DecorationType.None);
            this.dtLesson.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtLesson.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtLesson.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLesson.ForeColor = System.Drawing.Color.Black;
            this.dtLesson.Location = new System.Drawing.Point(97, 12);
            this.dtLesson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtLesson.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtLesson.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtLesson.Name = "dtLesson";
            this.dtLesson.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtLesson.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtLesson.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtLesson.OnPressedColor = System.Drawing.Color.Black;
            this.dtLesson.Radius = 10;
            this.dtLesson.Size = new System.Drawing.Size(219, 24);
            this.dtLesson.TabIndex = 4;
            this.dtLesson.Text = "Friday, 26 June, 2020";
            this.dtLesson.Value = new System.DateTime(2020, 6, 26, 21, 4, 27, 582);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.trPanelLesson.SetDecoration(this.label2, Guna.UI.Animation.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(777, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "الكابتن";
            // 
            // cbxCaptinName
            // 
            this.cbxCaptinName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCaptinName.BackColor = System.Drawing.Color.Transparent;
            this.cbxCaptinName.BaseColor = System.Drawing.Color.White;
            this.cbxCaptinName.BorderColor = System.Drawing.Color.Silver;
            this.cbxCaptinName.BorderSize = 1;
            this.trPanelLesson.SetDecoration(this.cbxCaptinName, Guna.UI.Animation.DecorationType.None);
            this.cbxCaptinName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCaptinName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaptinName.FocusedColor = System.Drawing.Color.Empty;
            this.cbxCaptinName.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCaptinName.ForeColor = System.Drawing.Color.Black;
            this.cbxCaptinName.FormattingEnabled = true;
            this.cbxCaptinName.Location = new System.Drawing.Point(549, 48);
            this.cbxCaptinName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCaptinName.Name = "cbxCaptinName";
            this.cbxCaptinName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxCaptinName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxCaptinName.Radius = 10;
            this.cbxCaptinName.Size = new System.Drawing.Size(222, 31);
            this.cbxCaptinName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.trPanelLesson.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(784, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "الإسم";
            // 
            // txtVisitorName
            // 
            this.txtVisitorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisitorName.BackColor = System.Drawing.Color.Transparent;
            this.txtVisitorName.BaseColor = System.Drawing.Color.White;
            this.txtVisitorName.BorderColor = System.Drawing.Color.Silver;
            this.txtVisitorName.BorderSize = 1;
            this.txtVisitorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelLesson.SetDecoration(this.txtVisitorName, Guna.UI.Animation.DecorationType.None);
            this.txtVisitorName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtVisitorName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtVisitorName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtVisitorName.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorName.Location = new System.Drawing.Point(558, 4);
            this.txtVisitorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVisitorName.Name = "txtVisitorName";
            this.txtVisitorName.PasswordChar = '\0';
            this.txtVisitorName.Radius = 10;
            this.txtVisitorName.SelectedText = "";
            this.txtVisitorName.Size = new System.Drawing.Size(213, 33);
            this.txtVisitorName.TabIndex = 0;
            this.txtVisitorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trPanelLesson
            // 
            this.trPanelLesson.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.trPanelLesson.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.trPanelLesson.DefaultAnimation = animation2;
            // 
            // UCDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.panelLessonInfo);
            this.Controls.Add(this.btnShowPanelLesson);
            this.Controls.Add(this.panelDashboardContainer);
            this.trPanelLesson.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCDashBoard";
            this.Size = new System.Drawing.Size(1018, 590);
            this.Load += new System.EventHandler(this.UCDashBoard_Load);
            this.panelLessonInfo.ResumeLayout(false);
            this.panelLessonInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDashboardContainer;
        private Guna.UI.WinForms.GunaTransition trPanelLesson;
        private Guna.UI.WinForms.GunaButton btnShowPanelLesson;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI.WinForms.GunaShadowPanel panelLessonInfo;
        private Guna.UI.WinForms.GunaCircleButton btnSaveLesson;
        private Guna.UI.WinForms.GunaTextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaCheckBox chkbxTradeMile;
        private Guna.UI.WinForms.GunaDateTimePicker dtLesson;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cbxCaptinName;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtVisitorName;
        private Guna.UI.WinForms.GunaComboBox cbxGender;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private System.Windows.Forms.Label label5;
    }
}
