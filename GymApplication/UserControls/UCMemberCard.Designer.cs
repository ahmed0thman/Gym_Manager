namespace GymApplication.UserControls
{
    partial class UCMemberCard
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
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMemberCard));
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.cardOption = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnHideMemberCard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPrintMemberCard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEditMemberCard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDeleteMemberCard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.picCardMember = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnShowCardOption = new System.Windows.Forms.PictureBox();
            this.lblMemershipCardStatus = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.trOptionCard = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaShadowPanel1.SuspendLayout();
            this.cardOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCardMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCardOption)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.cardOption);
            this.gunaShadowPanel1.Controls.Add(this.picCardMember);
            this.gunaShadowPanel1.Controls.Add(this.btnShowCardOption);
            this.gunaShadowPanel1.Controls.Add(this.lblMemershipCardStatus);
            this.gunaShadowPanel1.Controls.Add(this.lblCardName);
            this.gunaShadowPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trOptionCard.SetDecoration(this.gunaShadowPanel1, Guna.UI.Animation.DecorationType.None);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(421, 104);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // cardOption
            // 
            this.cardOption.BackColor = System.Drawing.Color.Transparent;
            this.cardOption.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.cardOption.Controls.Add(this.btnHideMemberCard);
            this.cardOption.Controls.Add(this.btnPrintMemberCard);
            this.cardOption.Controls.Add(this.btnEditMemberCard);
            this.cardOption.Controls.Add(this.btnDeleteMemberCard);
            this.trOptionCard.SetDecoration(this.cardOption, Guna.UI.Animation.DecorationType.None);
            this.cardOption.Location = new System.Drawing.Point(42, 46);
            this.cardOption.Name = "cardOption";
            this.cardOption.Radius = 5;
            this.cardOption.ShadowColor = System.Drawing.Color.Black;
            this.cardOption.ShadowShift = 0;
            this.cardOption.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.cardOption.Size = new System.Drawing.Size(187, 43);
            this.cardOption.TabIndex = 56;
            // 
            // btnHideMemberCard
            // 
            this.btnHideMemberCard.AnimationHoverSpeed = 0.07F;
            this.btnHideMemberCard.AnimationSpeed = 0.03F;
            this.btnHideMemberCard.BackColor = System.Drawing.Color.Transparent;
            this.btnHideMemberCard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnHideMemberCard.BorderColor = System.Drawing.Color.Black;
            this.btnHideMemberCard.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnHideMemberCard.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnHideMemberCard.CheckedForeColor = System.Drawing.Color.White;
            this.btnHideMemberCard.CheckedImage = null;
            this.btnHideMemberCard.CheckedLineColor = System.Drawing.Color.DimGray;
            this.trOptionCard.SetDecoration(this.btnHideMemberCard, Guna.UI.Animation.DecorationType.None);
            this.btnHideMemberCard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHideMemberCard.FocusedColor = System.Drawing.Color.Empty;
            this.btnHideMemberCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHideMemberCard.ForeColor = System.Drawing.Color.White;
            this.btnHideMemberCard.Image = null;
            this.btnHideMemberCard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHideMemberCard.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHideMemberCard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnHideMemberCard.Location = new System.Drawing.Point(160, 14);
            this.btnHideMemberCard.Name = "btnHideMemberCard";
            this.btnHideMemberCard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnHideMemberCard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHideMemberCard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHideMemberCard.OnHoverImage = null;
            this.btnHideMemberCard.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnHideMemberCard.OnPressedColor = System.Drawing.Color.Black;
            this.btnHideMemberCard.Radius = 7;
            this.btnHideMemberCard.Size = new System.Drawing.Size(17, 15);
            this.btnHideMemberCard.TabIndex = 3;
            this.btnHideMemberCard.Click += new System.EventHandler(this.btnHideMemberCard_Click);
            // 
            // btnPrintMemberCard
            // 
            this.btnPrintMemberCard.AnimationHoverSpeed = 0.07F;
            this.btnPrintMemberCard.AnimationSpeed = 0.03F;
            this.btnPrintMemberCard.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintMemberCard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnPrintMemberCard.BorderColor = System.Drawing.Color.Black;
            this.btnPrintMemberCard.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPrintMemberCard.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPrintMemberCard.CheckedForeColor = System.Drawing.Color.White;
            this.btnPrintMemberCard.CheckedImage = null;
            this.btnPrintMemberCard.CheckedLineColor = System.Drawing.Color.DimGray;
            this.trOptionCard.SetDecoration(this.btnPrintMemberCard, Guna.UI.Animation.DecorationType.None);
            this.btnPrintMemberCard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintMemberCard.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintMemberCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrintMemberCard.ForeColor = System.Drawing.Color.White;
            this.btnPrintMemberCard.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintMemberCard.Image")));
            this.btnPrintMemberCard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrintMemberCard.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrintMemberCard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnPrintMemberCard.Location = new System.Drawing.Point(95, 6);
            this.btnPrintMemberCard.Name = "btnPrintMemberCard";
            this.btnPrintMemberCard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnPrintMemberCard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrintMemberCard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrintMemberCard.OnHoverImage = null;
            this.btnPrintMemberCard.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnPrintMemberCard.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrintMemberCard.Radius = 10;
            this.btnPrintMemberCard.Size = new System.Drawing.Size(34, 30);
            this.btnPrintMemberCard.TabIndex = 2;
            // 
            // btnEditMemberCard
            // 
            this.btnEditMemberCard.AnimationHoverSpeed = 0.07F;
            this.btnEditMemberCard.AnimationSpeed = 0.03F;
            this.btnEditMemberCard.BackColor = System.Drawing.Color.Transparent;
            this.btnEditMemberCard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnEditMemberCard.BorderColor = System.Drawing.Color.Black;
            this.btnEditMemberCard.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEditMemberCard.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEditMemberCard.CheckedForeColor = System.Drawing.Color.White;
            this.btnEditMemberCard.CheckedImage = null;
            this.btnEditMemberCard.CheckedLineColor = System.Drawing.Color.DimGray;
            this.trOptionCard.SetDecoration(this.btnEditMemberCard, Guna.UI.Animation.DecorationType.None);
            this.btnEditMemberCard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditMemberCard.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditMemberCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditMemberCard.ForeColor = System.Drawing.Color.White;
            this.btnEditMemberCard.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMemberCard.Image")));
            this.btnEditMemberCard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditMemberCard.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditMemberCard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnEditMemberCard.Location = new System.Drawing.Point(56, 6);
            this.btnEditMemberCard.Name = "btnEditMemberCard";
            this.btnEditMemberCard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnEditMemberCard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditMemberCard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditMemberCard.OnHoverImage = null;
            this.btnEditMemberCard.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.btnEditMemberCard.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditMemberCard.Radius = 10;
            this.btnEditMemberCard.Size = new System.Drawing.Size(34, 30);
            this.btnEditMemberCard.TabIndex = 1;
            this.btnEditMemberCard.Click += new System.EventHandler(this.btnEditMemberCard_Click);
            // 
            // btnDeleteMemberCard
            // 
            this.btnDeleteMemberCard.AnimationHoverSpeed = 0.07F;
            this.btnDeleteMemberCard.AnimationSpeed = 0.03F;
            this.btnDeleteMemberCard.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMemberCard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnDeleteMemberCard.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteMemberCard.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDeleteMemberCard.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDeleteMemberCard.CheckedForeColor = System.Drawing.Color.White;
            this.btnDeleteMemberCard.CheckedImage = null;
            this.btnDeleteMemberCard.CheckedLineColor = System.Drawing.Color.DimGray;
            this.trOptionCard.SetDecoration(this.btnDeleteMemberCard, Guna.UI.Animation.DecorationType.None);
            this.btnDeleteMemberCard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteMemberCard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteMemberCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteMemberCard.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMemberCard.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMemberCard.Image")));
            this.btnDeleteMemberCard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteMemberCard.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteMemberCard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnDeleteMemberCard.Location = new System.Drawing.Point(15, 6);
            this.btnDeleteMemberCard.Name = "btnDeleteMemberCard";
            this.btnDeleteMemberCard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnDeleteMemberCard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteMemberCard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteMemberCard.OnHoverImage = null;
            this.btnDeleteMemberCard.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnDeleteMemberCard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteMemberCard.Radius = 10;
            this.btnDeleteMemberCard.Size = new System.Drawing.Size(34, 30);
            this.btnDeleteMemberCard.TabIndex = 0;
            this.btnDeleteMemberCard.Click += new System.EventHandler(this.btnDeleteMemberCard_Click);
            // 
            // picCardMember
            // 
            this.picCardMember.BaseColor = System.Drawing.Color.White;
            this.trOptionCard.SetDecoration(this.picCardMember, Guna.UI.Animation.DecorationType.None);
            this.picCardMember.Image = ((System.Drawing.Image)(resources.GetObject("picCardMember.Image")));
            this.picCardMember.Location = new System.Drawing.Point(329, 12);
            this.picCardMember.Name = "picCardMember";
            this.picCardMember.Size = new System.Drawing.Size(80, 70);
            this.picCardMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCardMember.TabIndex = 55;
            this.picCardMember.TabStop = false;
            this.picCardMember.UseTransfarantBackground = false;
            this.picCardMember.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click);
            this.picCardMember.MouseEnter += new System.EventHandler(this.gunaCirclePictureBox1_MouseEnter);
            this.picCardMember.MouseLeave += new System.EventHandler(this.gunaCirclePictureBox1_MouseLeave);
            // 
            // btnShowCardOption
            // 
            this.trOptionCard.SetDecoration(this.btnShowCardOption, Guna.UI.Animation.DecorationType.None);
            this.btnShowCardOption.Image = ((System.Drawing.Image)(resources.GetObject("btnShowCardOption.Image")));
            this.btnShowCardOption.Location = new System.Drawing.Point(7, 38);
            this.btnShowCardOption.Name = "btnShowCardOption";
            this.btnShowCardOption.Size = new System.Drawing.Size(29, 50);
            this.btnShowCardOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowCardOption.TabIndex = 54;
            this.btnShowCardOption.TabStop = false;
            this.btnShowCardOption.Click += new System.EventHandler(this.btnShowCardOption_Click);
            // 
            // lblMemershipCardStatus
            // 
            this.trOptionCard.SetDecoration(this.lblMemershipCardStatus, Guna.UI.Animation.DecorationType.None);
            this.lblMemershipCardStatus.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemershipCardStatus.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblMemershipCardStatus.Location = new System.Drawing.Point(131, 45);
            this.lblMemershipCardStatus.Name = "lblMemershipCardStatus";
            this.lblMemershipCardStatus.Size = new System.Drawing.Size(191, 29);
            this.lblMemershipCardStatus.TabIndex = 53;
            this.lblMemershipCardStatus.Text = "إشتراك جارى";
            this.lblMemershipCardStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCardName
            // 
            this.trOptionCard.SetDecoration(this.lblCardName, Guna.UI.Animation.DecorationType.None);
            this.lblCardName.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.ForeColor = System.Drawing.Color.Black;
            this.lblCardName.Location = new System.Drawing.Point(23, 12);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(299, 31);
            this.lblCardName.TabIndex = 52;
            this.lblCardName.Text = "أحمد هشام سعد عثمان";
            this.lblCardName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trOptionCard
            // 
            this.trOptionCard.AnimationType = Guna.UI.Animation.AnimationType.Leaf;
            this.trOptionCard.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
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
            animation1.TransparencyCoeff = 0F;
            this.trOptionCard.DefaultAnimation = animation1;
            // 
            // UCMemberCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaShadowPanel1);
            this.trOptionCard.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Name = "UCMemberCard";
            this.Size = new System.Drawing.Size(421, 104);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.cardOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCardMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCardOption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.PictureBox btnShowCardOption;
        private System.Windows.Forms.Label lblMemershipCardStatus;
        private Guna.UI.WinForms.GunaShadowPanel cardOption;
        private Guna.UI.WinForms.GunaAdvenceButton btnHideMemberCard;
        private Guna.UI.WinForms.GunaTransition trOptionCard;
        private Guna.UI.WinForms.GunaAdvenceButton btnPrintMemberCard;
        private Guna.UI.WinForms.GunaAdvenceButton btnEditMemberCard;
        private Guna.UI.WinForms.GunaAdvenceButton btnDeleteMemberCard;
        public System.Windows.Forms.Label lblCardName;
        public Guna.UI.WinForms.GunaCirclePictureBox picCardMember;
    }
}
