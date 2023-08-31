namespace GymApplication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnNotifacations = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnShowDashBoard = new Guna.UI.WinForms.GunaButton();
            this.btnShowMembers = new Guna.UI.WinForms.GunaButton();
            this.btnShowArchieve = new Guna.UI.WinForms.GunaButton();
            this.btnShowEmployees = new Guna.UI.WinForms.GunaButton();
            this.btnShowTransactions = new Guna.UI.WinForms.GunaButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panelNotifications = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblNotificationCount = new System.Windows.Forms.Label();
            this.labelNotif = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.trPanelNotifications = new Guna.UI.WinForms.GunaTransition(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            this.panelNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnNotifacations);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.gunaControlBox2);
            this.panelHeader.Controls.Add(this.gunaControlBox1);
            this.trPanelNotifications.SetDecoration(this.panelHeader, Guna.UI.Animation.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1070, 46);
            this.panelHeader.TabIndex = 0;
            // 
            // btnNotifacations
            // 
            this.btnNotifacations.AnimationHoverSpeed = 0.07F;
            this.btnNotifacations.AnimationSpeed = 0.03F;
            this.btnNotifacations.BackColor = System.Drawing.Color.Transparent;
            this.btnNotifacations.BaseColor = System.Drawing.Color.White;
            this.btnNotifacations.BorderColor = System.Drawing.Color.White;
            this.btnNotifacations.BorderSize = 1;
            this.btnNotifacations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trPanelNotifications.SetDecoration(this.btnNotifacations, Guna.UI.Animation.DecorationType.None);
            this.btnNotifacations.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNotifacations.FocusedColor = System.Drawing.Color.Empty;
            this.btnNotifacations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNotifacations.ForeColor = System.Drawing.Color.White;
            this.btnNotifacations.Image = ((System.Drawing.Image)(resources.GetObject("btnNotifacations.Image")));
            this.btnNotifacations.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNotifacations.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNotifacations.Location = new System.Drawing.Point(84, 0);
            this.btnNotifacations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNotifacations.Name = "btnNotifacations";
            this.btnNotifacations.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnNotifacations.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnNotifacations.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNotifacations.OnHoverImage = null;
            this.btnNotifacations.OnPressedColor = System.Drawing.Color.White;
            this.btnNotifacations.Radius = 8;
            this.btnNotifacations.Size = new System.Drawing.Size(30, 28);
            this.btnNotifacations.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnNotifacations, "الإشعارات");
            this.btnNotifacations.Click += new System.EventHandler(this.btnNotifacations_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trPanelNotifications.SetDecoration(this.pictureBox1, Guna.UI.Animation.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1002, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trPanelNotifications.SetDecoration(this.gunaControlBox2, Guna.UI.Animation.DecorationType.None);
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(41, 0);
            this.gunaControlBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(38, 24);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(168)))));
            this.gunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trPanelNotifications.SetDecoration(this.gunaControlBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(-3, 0);
            this.gunaControlBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(168)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(168)))));
            this.gunaControlBox1.Size = new System.Drawing.Size(38, 24);
            this.gunaControlBox1.TabIndex = 0;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelHeader;
            // 
            // btnShowDashBoard
            // 
            this.btnShowDashBoard.AnimationHoverSpeed = 0.07F;
            this.btnShowDashBoard.AnimationSpeed = 0.03F;
            this.btnShowDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.btnShowDashBoard.BaseColor = System.Drawing.Color.White;
            this.btnShowDashBoard.BorderColor = System.Drawing.Color.Silver;
            this.btnShowDashBoard.BorderSize = 1;
            this.trPanelNotifications.SetDecoration(this.btnShowDashBoard, Guna.UI.Animation.DecorationType.None);
            this.btnShowDashBoard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowDashBoard.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowDashBoard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnShowDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnShowDashBoard.Image")));
            this.btnShowDashBoard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowDashBoard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowDashBoard.Location = new System.Drawing.Point(7, 64);
            this.btnShowDashBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowDashBoard.Name = "btnShowDashBoard";
            this.btnShowDashBoard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.btnShowDashBoard.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btnShowDashBoard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowDashBoard.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowDashBoard.OnHoverImage")));
            this.btnShowDashBoard.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnShowDashBoard.Radius = 10;
            this.btnShowDashBoard.Size = new System.Drawing.Size(38, 37);
            this.btnShowDashBoard.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnShowDashBoard, "الحركة اليومية");
            this.btnShowDashBoard.Click += new System.EventHandler(this.btnShowDashBoard_Click);
            // 
            // btnShowMembers
            // 
            this.btnShowMembers.AnimationHoverSpeed = 0.07F;
            this.btnShowMembers.AnimationSpeed = 0.03F;
            this.btnShowMembers.BackColor = System.Drawing.Color.Transparent;
            this.btnShowMembers.BaseColor = System.Drawing.Color.White;
            this.btnShowMembers.BorderColor = System.Drawing.Color.Silver;
            this.btnShowMembers.BorderSize = 1;
            this.trPanelNotifications.SetDecoration(this.btnShowMembers, Guna.UI.Animation.DecorationType.None);
            this.btnShowMembers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowMembers.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowMembers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowMembers.ForeColor = System.Drawing.Color.White;
            this.btnShowMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMembers.Image")));
            this.btnShowMembers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowMembers.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowMembers.Location = new System.Drawing.Point(7, 106);
            this.btnShowMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowMembers.Name = "btnShowMembers";
            this.btnShowMembers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.btnShowMembers.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btnShowMembers.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowMembers.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowMembers.OnHoverImage")));
            this.btnShowMembers.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnShowMembers.Radius = 10;
            this.btnShowMembers.Size = new System.Drawing.Size(38, 37);
            this.btnShowMembers.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnShowMembers, "الأعضاء");
            this.btnShowMembers.Click += new System.EventHandler(this.btnShowMembers_Click);
            // 
            // btnShowArchieve
            // 
            this.btnShowArchieve.AnimationHoverSpeed = 0.07F;
            this.btnShowArchieve.AnimationSpeed = 0.03F;
            this.btnShowArchieve.BackColor = System.Drawing.Color.Transparent;
            this.btnShowArchieve.BaseColor = System.Drawing.Color.White;
            this.btnShowArchieve.BorderColor = System.Drawing.Color.Silver;
            this.btnShowArchieve.BorderSize = 1;
            this.trPanelNotifications.SetDecoration(this.btnShowArchieve, Guna.UI.Animation.DecorationType.None);
            this.btnShowArchieve.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowArchieve.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowArchieve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowArchieve.ForeColor = System.Drawing.Color.White;
            this.btnShowArchieve.Image = ((System.Drawing.Image)(resources.GetObject("btnShowArchieve.Image")));
            this.btnShowArchieve.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowArchieve.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShowArchieve.Location = new System.Drawing.Point(7, 147);
            this.btnShowArchieve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowArchieve.Name = "btnShowArchieve";
            this.btnShowArchieve.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.btnShowArchieve.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btnShowArchieve.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowArchieve.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowArchieve.OnHoverImage")));
            this.btnShowArchieve.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnShowArchieve.Radius = 10;
            this.btnShowArchieve.Size = new System.Drawing.Size(38, 37);
            this.btnShowArchieve.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnShowArchieve, "الأرشيف");
            this.btnShowArchieve.Click += new System.EventHandler(this.btnShowArchieve_Click);
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.AnimationHoverSpeed = 0.07F;
            this.btnShowEmployees.AnimationSpeed = 0.03F;
            this.btnShowEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnShowEmployees.BaseColor = System.Drawing.Color.White;
            this.btnShowEmployees.BorderColor = System.Drawing.Color.Silver;
            this.btnShowEmployees.BorderSize = 1;
            this.trPanelNotifications.SetDecoration(this.btnShowEmployees, Guna.UI.Animation.DecorationType.None);
            this.btnShowEmployees.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowEmployees.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowEmployees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowEmployees.ForeColor = System.Drawing.Color.White;
            this.btnShowEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnShowEmployees.Image")));
            this.btnShowEmployees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowEmployees.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowEmployees.Location = new System.Drawing.Point(7, 188);
            this.btnShowEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.btnShowEmployees.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btnShowEmployees.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowEmployees.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowEmployees.OnHoverImage")));
            this.btnShowEmployees.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnShowEmployees.Radius = 10;
            this.btnShowEmployees.Size = new System.Drawing.Size(38, 37);
            this.btnShowEmployees.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnShowEmployees, "الموظفين");
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // btnShowTransactions
            // 
            this.btnShowTransactions.AnimationHoverSpeed = 0.07F;
            this.btnShowTransactions.AnimationSpeed = 0.03F;
            this.btnShowTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnShowTransactions.BaseColor = System.Drawing.Color.White;
            this.btnShowTransactions.BorderColor = System.Drawing.Color.Silver;
            this.btnShowTransactions.BorderSize = 1;
            this.trPanelNotifications.SetDecoration(this.btnShowTransactions, Guna.UI.Animation.DecorationType.None);
            this.btnShowTransactions.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowTransactions.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowTransactions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowTransactions.ForeColor = System.Drawing.Color.White;
            this.btnShowTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowTransactions.Image")));
            this.btnShowTransactions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowTransactions.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowTransactions.Location = new System.Drawing.Point(7, 230);
            this.btnShowTransactions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowTransactions.Name = "btnShowTransactions";
            this.btnShowTransactions.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.btnShowTransactions.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btnShowTransactions.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowTransactions.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowTransactions.OnHoverImage")));
            this.btnShowTransactions.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnShowTransactions.Radius = 10;
            this.btnShowTransactions.Size = new System.Drawing.Size(38, 37);
            this.btnShowTransactions.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnShowTransactions, "المصروفات");
            this.btnShowTransactions.Click += new System.EventHandler(this.btnShowTransactions_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // panelContainer
            // 
            this.trPanelNotifications.SetDecoration(this.panelContainer, Guna.UI.Animation.DecorationType.None);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContainer.Location = new System.Drawing.Point(0, 46);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1018, 589);
            this.panelContainer.TabIndex = 2;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnShowDashBoard);
            this.gunaShadowPanel1.Controls.Add(this.btnShowTransactions);
            this.gunaShadowPanel1.Controls.Add(this.btnShowMembers);
            this.gunaShadowPanel1.Controls.Add(this.btnShowEmployees);
            this.gunaShadowPanel1.Controls.Add(this.btnShowArchieve);
            this.trPanelNotifications.SetDecoration(this.gunaShadowPanel1, Guna.UI.Animation.DecorationType.None);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(1020, 138);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 20;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 0;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(98, 325);
            this.gunaShadowPanel1.TabIndex = 7;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // panelNotifications
            // 
            this.panelNotifications.BackColor = System.Drawing.Color.Transparent;
            this.panelNotifications.BaseColor = System.Drawing.Color.White;
            this.panelNotifications.Controls.Add(this.lblNotificationCount);
            this.panelNotifications.Controls.Add(this.labelNotif);
            this.panelNotifications.Controls.Add(this.gunaButton1);
            this.trPanelNotifications.SetDecoration(this.panelNotifications, Guna.UI.Animation.DecorationType.None);
            this.panelNotifications.Location = new System.Drawing.Point(83, 34);
            this.panelNotifications.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNotifications.Name = "panelNotifications";
            this.panelNotifications.Radius = 10;
            this.panelNotifications.ShadowColor = System.Drawing.Color.DarkGray;
            this.panelNotifications.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelNotifications.Size = new System.Drawing.Size(323, 72);
            this.panelNotifications.TabIndex = 8;
            // 
            // lblNotificationCount
            // 
            this.lblNotificationCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trPanelNotifications.SetDecoration(this.lblNotificationCount, Guna.UI.Animation.DecorationType.None);
            this.lblNotificationCount.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationCount.Location = new System.Drawing.Point(-4, 32);
            this.lblNotificationCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotificationCount.Name = "lblNotificationCount";
            this.lblNotificationCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNotificationCount.Size = new System.Drawing.Size(252, 28);
            this.lblNotificationCount.TabIndex = 2;
            this.lblNotificationCount.Text = "11 من الأعضاء انتهت مدة اشتراكهم";
            // 
            // labelNotif
            // 
            this.labelNotif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNotif.AutoSize = true;
            this.trPanelNotifications.SetDecoration(this.labelNotif, Guna.UI.Animation.DecorationType.None);
            this.labelNotif.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotif.Location = new System.Drawing.Point(142, 4);
            this.labelNotif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotif.Name = "labelNotif";
            this.labelNotif.Size = new System.Drawing.Size(101, 28);
            this.labelNotif.TabIndex = 1;
            this.labelNotif.Text = "تنبية بالإشتراكات ";
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(200)))));
            this.gunaButton1.BorderSize = 2;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trPanelNotifications.SetDecoration(this.gunaButton1, Guna.UI.Animation.DecorationType.None);
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(60, 60);
            this.gunaButton1.Location = new System.Drawing.Point(254, 4);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(200)))));
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(60, 57);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "gunaButton1";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // trPanelNotifications
            // 
            this.trPanelNotifications.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.trPanelNotifications.Cursor = null;
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
            this.trPanelNotifications.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1070, 635);
            this.Controls.Add(this.panelNotifications);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelHeader);
            this.trPanelNotifications.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.panelNotifications.ResumeLayout(false);
            this.panelNotifications.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaButton btnShowDashBoard;
        private Guna.UI.WinForms.GunaButton btnShowTransactions;
        private Guna.UI.WinForms.GunaButton btnShowEmployees;
        private Guna.UI.WinForms.GunaButton btnShowArchieve;
        private Guna.UI.WinForms.GunaButton btnShowMembers;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaButton btnNotifacations;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaShadowPanel panelNotifications;
        private System.Windows.Forms.Label lblNotificationCount;
        private System.Windows.Forms.Label labelNotif;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaTransition trPanelNotifications;
    }
}

