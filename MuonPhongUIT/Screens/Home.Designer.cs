namespace MuonPhongUIT
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.containPanel = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.thongKe = new System.Windows.Forms.Label();
            this.baoCaoOption = new System.Windows.Forms.Label();
            this.lichPhong = new System.Windows.Forms.Label();
            this.muonPhongOption = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Controls.Add(this.searchField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 94);
            this.panel1.TabIndex = 4;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(12, 25);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(40, 34);
            this.menuButton.TabIndex = 9;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // searchField
            // 
            this.searchField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.Location = new System.Drawing.Point(442, 24);
            this.searchField.Margin = new System.Windows.Forms.Padding(2);
            this.searchField.Multiline = false;
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(511, 38);
            this.searchField.TabIndex = 5;
            this.searchField.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(57, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 81);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Location = new System.Drawing.Point(960, 23);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(36, 39);
            this.searchButton.TabIndex = 4;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // containPanel
            // 
            this.containPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.containPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.containPanel.Location = new System.Drawing.Point(184, 94);
            this.containPanel.Margin = new System.Windows.Forms.Padding(2);
            this.containPanel.Name = "containPanel";
            this.containPanel.Size = new System.Drawing.Size(1029, 691);
            this.containPanel.TabIndex = 8;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sidebar.Controls.Add(this.thongKe);
            this.sidebar.Controls.Add(this.baoCaoOption);
            this.sidebar.Controls.Add(this.lichPhong);
            this.sidebar.Controls.Add(this.muonPhongOption);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 94);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 1000);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(180, 691);
            this.sidebar.TabIndex = 0;
            // 
            // thongKe
            // 
            this.thongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thongKe.AutoSize = true;
            this.thongKe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.thongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongKe.Location = new System.Drawing.Point(20, 132);
            this.thongKe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thongKe.Name = "thongKe";
            this.thongKe.Size = new System.Drawing.Size(83, 20);
            this.thongKe.TabIndex = 1;
            this.thongKe.Text = "Thống kê";
            this.thongKe.Click += new System.EventHandler(this.sidebarSelect);
            // 
            // baoCaoOption
            // 
            this.baoCaoOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baoCaoOption.AutoSize = true;
            this.baoCaoOption.BackColor = System.Drawing.Color.LightSkyBlue;
            this.baoCaoOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baoCaoOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baoCaoOption.Location = new System.Drawing.Point(20, 96);
            this.baoCaoOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baoCaoOption.Name = "baoCaoOption";
            this.baoCaoOption.Size = new System.Drawing.Size(129, 20);
            this.baoCaoOption.TabIndex = 0;
            this.baoCaoOption.Text = "Báo cáo hư hại";
            this.baoCaoOption.Click += new System.EventHandler(this.sidebarSelect);
            this.baoCaoOption.MouseEnter += new System.EventHandler(this.sidebarMouseEnter);
            this.baoCaoOption.MouseLeave += new System.EventHandler(this.sidebarMouseLeave);
            // 
            // lichPhong
            // 
            this.lichPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lichPhong.AutoSize = true;
            this.lichPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lichPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lichPhong.Location = new System.Drawing.Point(20, 61);
            this.lichPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lichPhong.Name = "lichPhong";
            this.lichPhong.Size = new System.Drawing.Size(132, 20);
            this.lichPhong.TabIndex = 0;
            this.lichPhong.Text = "Xem lịch phòng";
            this.lichPhong.Click += new System.EventHandler(this.sidebarSelect);
            this.lichPhong.MouseEnter += new System.EventHandler(this.sidebarMouseEnter);
            this.lichPhong.MouseLeave += new System.EventHandler(this.sidebarMouseLeave);
            // 
            // muonPhongOption
            // 
            this.muonPhongOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.muonPhongOption.AutoSize = true;
            this.muonPhongOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muonPhongOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muonPhongOption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.muonPhongOption.Location = new System.Drawing.Point(20, 24);
            this.muonPhongOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.muonPhongOption.Name = "muonPhongOption";
            this.muonPhongOption.Size = new System.Drawing.Size(108, 20);
            this.muonPhongOption.TabIndex = 0;
            this.muonPhongOption.Text = "Mượn phòng";
            this.muonPhongOption.Click += new System.EventHandler(this.sidebarSelect);
            this.muonPhongOption.MouseEnter += new System.EventHandler(this.sidebarMouseEnter);
            this.muonPhongOption.MouseLeave += new System.EventHandler(this.sidebarMouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 785);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.containPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ClientSizeChanged += new System.EventHandler(this.Home_ClientSizeChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel containPanel;
        private System.Windows.Forms.RichTextBox searchField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label baoCaoOption;
        private System.Windows.Forms.Label lichPhong;
        private System.Windows.Forms.Label muonPhongOption;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label thongKe;
    }
}