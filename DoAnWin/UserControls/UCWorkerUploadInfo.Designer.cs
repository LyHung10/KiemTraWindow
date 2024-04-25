namespace DoAnWin.UserControls
{
    partial class UCWorkerUploadInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWorkerUploadInfo));
            this.panelContain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnDetail = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RSRate = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblHireCost = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.DefaultBackground = new System.Windows.Forms.ImageList(this.components);
            this.picImage = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageCheckBox2 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.guna2ImageCheckBox1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2ImageButton();
            this.WorkerBackground = new System.Windows.Forms.ImageList(this.components);
            this.panelContain.SuspendLayout();
            this.picImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.BorderColor = System.Drawing.Color.Silver;
            this.panelContain.BorderThickness = 3;
            this.panelContain.Controls.Add(this.btnDetail);
            this.panelContain.Controls.Add(this.RSRate);
            this.panelContain.Controls.Add(this.lblHireCost);
            this.panelContain.Controls.Add(this.lblPhone);
            this.panelContain.Controls.Add(this.lblAge);
            this.panelContain.Controls.Add(this.lblAddress);
            this.panelContain.Controls.Add(this.lblName);
            this.panelContain.Controls.Add(this.lblID);
            this.panelContain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContain.FillColor = System.Drawing.Color.White;
            this.panelContain.FillColor2 = System.Drawing.Color.White;
            this.panelContain.Location = new System.Drawing.Point(345, 0);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(721, 271);
            this.panelContain.TabIndex = 0;
            this.panelContain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContain_Paint);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnDetail.BorderColor = System.Drawing.Color.Transparent;
            this.btnDetail.BorderRadius = 10;
            this.btnDetail.BorderThickness = 2;
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.HoverState.BorderColor = System.Drawing.Color.Indigo;
            this.btnDetail.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDetail.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnDetail.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.HoverState.ForeColor = System.Drawing.Color.Indigo;
            this.btnDetail.Location = new System.Drawing.Point(423, 198);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(180, 45);
            this.btnDetail.TabIndex = 3;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // RSRate
            // 
            this.RSRate.BackColor = System.Drawing.Color.Transparent;
            this.RSRate.BorderColor = System.Drawing.Color.Gainsboro;
            this.RSRate.Location = new System.Drawing.Point(47, 29);
            this.RSRate.Name = "RSRate";
            this.RSRate.RatingColor = System.Drawing.Color.Cyan;
            this.RSRate.ReadOnly = true;
            this.RSRate.Size = new System.Drawing.Size(120, 28);
            this.RSRate.TabIndex = 2;
            this.RSRate.Value = 2.5F;
            this.RSRate.ValueChanged += new System.EventHandler(this.RSRate_ValueChanged);
            // 
            // lblHireCost
            // 
            this.lblHireCost.AutoSize = true;
            this.lblHireCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHireCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireCost.ForeColor = System.Drawing.Color.Indigo;
            this.lblHireCost.Location = new System.Drawing.Point(419, 156);
            this.lblHireCost.Name = "lblHireCost";
            this.lblHireCost.Size = new System.Drawing.Size(152, 20);
            this.lblHireCost.TabIndex = 1;
            this.lblHireCost.Text = "Giá thuê: 100000";
            this.lblHireCost.Click += new System.EventHandler(this.lblHireCost_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Indigo;
            this.lblPhone.Location = new System.Drawing.Point(419, 96);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(157, 20);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "SĐT: 0941862906";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Indigo;
            this.lblAge.Location = new System.Drawing.Point(419, 37);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(77, 20);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Tuổi: 28";
            this.lblAge.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Indigo;
            this.lblAddress.Location = new System.Drawing.Point(43, 210);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(184, 20);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Địa chỉ: Hồ Chí Minh";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Indigo;
            this.lblName.Location = new System.Drawing.Point(43, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên : Lục Ân";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Indigo;
            this.lblID.Location = new System.Drawing.Point(43, 96);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID: 100003";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // DefaultBackground
            // 
            this.DefaultBackground.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DefaultBackground.ImageStream")));
            this.DefaultBackground.TransparentColor = System.Drawing.Color.Transparent;
            this.DefaultBackground.Images.SetKeyName(0, "Background1.jpg");
            this.DefaultBackground.Images.SetKeyName(1, "Background2.jpg");
            this.DefaultBackground.Images.SetKeyName(2, "Background3.jpg");
            this.DefaultBackground.Images.SetKeyName(3, "Background4.jpg");
            // 
            // picImage
            // 
            this.picImage.BackgroundImage = global::DoAnWin.Properties.Resources.ImageLogin;
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImage.Controls.Add(this.guna2ImageCheckBox2);
            this.picImage.Controls.Add(this.guna2ImageCheckBox1);
            this.picImage.Controls.Add(this.btnNext);
            this.picImage.Controls.Add(this.btnPrevious);
            this.picImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(347, 271);
            this.picImage.TabIndex = 1;
            this.picImage.Paint += new System.Windows.Forms.PaintEventHandler(this.picImage_Paint);
            // 
            // guna2ImageCheckBox2
            // 
            this.guna2ImageCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageCheckBox2.CheckedState.Image = global::DoAnWin.Properties.Resources.bookmarkdo;
            this.guna2ImageCheckBox2.Image = global::DoAnWin.Properties.Resources.bookmarktrang;
            this.guna2ImageCheckBox2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox2.ImageRotate = 0F;
            this.guna2ImageCheckBox2.ImageSize = new System.Drawing.Size(17, 17);
            this.guna2ImageCheckBox2.Location = new System.Drawing.Point(45, 3);
            this.guna2ImageCheckBox2.Name = "guna2ImageCheckBox2";
            this.guna2ImageCheckBox2.Size = new System.Drawing.Size(26, 26);
            this.guna2ImageCheckBox2.TabIndex = 1;
            this.guna2ImageCheckBox2.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox2_CheckedChanged);
            // 
            // guna2ImageCheckBox1
            // 
            this.guna2ImageCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageCheckBox1.CheckedState.Image = global::DoAnWin.Properties.Resources.heartTim;
            this.guna2ImageCheckBox1.Image = global::DoAnWin.Properties.Resources.heartWhite;
            this.guna2ImageCheckBox1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox1.ImageRotate = 0F;
            this.guna2ImageCheckBox1.ImageSize = new System.Drawing.Size(17, 17);
            this.guna2ImageCheckBox1.Location = new System.Drawing.Point(11, 3);
            this.guna2ImageCheckBox1.Name = "guna2ImageCheckBox1";
            this.guna2ImageCheckBox1.Size = new System.Drawing.Size(26, 26);
            this.guna2ImageCheckBox1.TabIndex = 1;
            this.guna2ImageCheckBox1.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox1_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.AnimatedGIF = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.HoverState.Image = global::DoAnWin.Properties.Resources.right;
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnNext.Image = global::DoAnWin.Properties.Resources.angle_rightxam;
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.ImageRotate = 0F;
            this.btnNext.ImageSize = new System.Drawing.Size(22, 22);
            this.btnNext.Location = new System.Drawing.Point(308, 112);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.Image = global::DoAnWin.Properties.Resources.right;
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnNext.Size = new System.Drawing.Size(36, 54);
            this.btnNext.TabIndex = 0;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AnimatedGIF = true;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPrevious.HoverState.Image = global::DoAnWin.Properties.Resources.left;
            this.btnPrevious.HoverState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnPrevious.Image = global::DoAnWin.Properties.Resources.angle_leftxam;
            this.btnPrevious.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPrevious.ImageRotate = 0F;
            this.btnPrevious.ImageSize = new System.Drawing.Size(22, 22);
            this.btnPrevious.Location = new System.Drawing.Point(3, 112);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.PressedState.Image = global::DoAnWin.Properties.Resources.left;
            this.btnPrevious.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnPrevious.Size = new System.Drawing.Size(36, 54);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // WorkerBackground
            // 
            this.WorkerBackground.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.WorkerBackground.ImageSize = new System.Drawing.Size(200, 200);
            this.WorkerBackground.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UCWorkerUploadInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.panelContain);
            this.Name = "UCWorkerUploadInfo";
            this.Size = new System.Drawing.Size(1066, 271);
            this.Load += new System.EventHandler(this.UCWorkerUploadInfo_Load);
            this.panelContain.ResumeLayout(false);
            this.panelContain.PerformLayout();
            this.picImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2GradientPanel panelContain;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblID;
        public Guna.UI2.WinForms.Guna2RatingStar RSRate;
        public System.Windows.Forms.Label lblAge;
        public Guna.UI2.WinForms.Guna2Panel picImage;
        public System.Windows.Forms.Label lblPhone;
        public System.Windows.Forms.Label lblAddress;
        public Guna.UI2.WinForms.Guna2ImageButton btnNext;
        public Guna.UI2.WinForms.Guna2ImageButton btnPrevious;
        public Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox1;
        public Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox2;
        public System.Windows.Forms.ImageList DefaultBackground;
        public Guna.UI2.WinForms.Guna2GradientButton btnDetail;
        public System.Windows.Forms.Label lblHireCost;
        public System.Windows.Forms.ImageList WorkerBackground;
    }
}
