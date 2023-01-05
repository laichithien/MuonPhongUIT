namespace MuonPhongUIT.Screens
{
    partial class LichPhongScreen
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
            this.header = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.playFieldButton = new System.Windows.Forms.Label();
            this.buildingEButton = new System.Windows.Forms.Label();
            this.buildingBButton = new System.Windows.Forms.Label();
            this.buildingCButton = new System.Windows.Forms.Label();
            this.buildingAButton = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTimeTableHeader = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.comboBox1);
            this.header.Controls.Add(this.playFieldButton);
            this.header.Controls.Add(this.buildingEButton);
            this.header.Controls.Add(this.buildingBButton);
            this.header.Controls.Add(this.buildingCButton);
            this.header.Controls.Add(this.buildingAButton);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(967, 94);
            this.header.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(420, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // playFieldButton
            // 
            this.playFieldButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playFieldButton.AutoSize = true;
            this.playFieldButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playFieldButton.ForeColor = System.Drawing.Color.White;
            this.playFieldButton.Location = new System.Drawing.Point(701, 15);
            this.playFieldButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playFieldButton.Name = "playFieldButton";
            this.playFieldButton.Size = new System.Drawing.Size(73, 24);
            this.playFieldButton.TabIndex = 3;
            this.playFieldButton.Text = "Sân tập";
            this.playFieldButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playFieldButton.Click += new System.EventHandler(this.buildingSelected);
            // 
            // buildingEButton
            // 
            this.buildingEButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buildingEButton.AutoSize = true;
            this.buildingEButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingEButton.ForeColor = System.Drawing.Color.White;
            this.buildingEButton.Location = new System.Drawing.Point(576, 15);
            this.buildingEButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingEButton.Name = "buildingEButton";
            this.buildingEButton.Size = new System.Drawing.Size(61, 24);
            this.buildingEButton.TabIndex = 3;
            this.buildingEButton.Text = "Tòa E";
            this.buildingEButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buildingEButton.Click += new System.EventHandler(this.buildingSelected);
            // 
            // buildingBButton
            // 
            this.buildingBButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buildingBButton.AutoSize = true;
            this.buildingBButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingBButton.ForeColor = System.Drawing.Color.White;
            this.buildingBButton.Location = new System.Drawing.Point(338, 15);
            this.buildingBButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingBButton.Name = "buildingBButton";
            this.buildingBButton.Size = new System.Drawing.Size(60, 24);
            this.buildingBButton.TabIndex = 5;
            this.buildingBButton.Text = "Tòa B";
            this.buildingBButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buildingBButton.Click += new System.EventHandler(this.buildingSelected);
            // 
            // buildingCButton
            // 
            this.buildingCButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buildingCButton.AutoSize = true;
            this.buildingCButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingCButton.ForeColor = System.Drawing.Color.White;
            this.buildingCButton.Location = new System.Drawing.Point(454, 15);
            this.buildingCButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingCButton.Name = "buildingCButton";
            this.buildingCButton.Size = new System.Drawing.Size(61, 24);
            this.buildingCButton.TabIndex = 4;
            this.buildingCButton.Text = "Tòa C";
            this.buildingCButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buildingCButton.Click += new System.EventHandler(this.buildingSelected);
            // 
            // buildingAButton
            // 
            this.buildingAButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buildingAButton.AutoSize = true;
            this.buildingAButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingAButton.ForeColor = System.Drawing.Color.White;
            this.buildingAButton.Location = new System.Drawing.Point(230, 15);
            this.buildingAButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingAButton.Name = "buildingAButton";
            this.buildingAButton.Size = new System.Drawing.Size(61, 24);
            this.buildingAButton.TabIndex = 6;
            this.buildingAButton.Text = "Tòa A";
            this.buildingAButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buildingAButton.Click += new System.EventHandler(this.buildingSelected);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.PowderBlue;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 134);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(967, 533);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.ClientSizeChanged += new System.EventHandler(this.flowLayoutPanel1_ClientSizeChanged);
            // 
            // panelTimeTableHeader
            // 
            this.panelTimeTableHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.panelTimeTableHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimeTableHeader.Location = new System.Drawing.Point(0, 94);
            this.panelTimeTableHeader.Name = "panelTimeTableHeader";
            this.panelTimeTableHeader.Size = new System.Drawing.Size(967, 40);
            this.panelTimeTableHeader.TabIndex = 2;
            // 
            // LichPhongScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(967, 667);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelTimeTableHeader);
            this.Controls.Add(this.header);
            this.Name = "LichPhongScreen";
            this.Text = "LichPhong";
            this.ClientSizeChanged += new System.EventHandler(this.LichPhongScreen_ClientSizeChanged);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label buildingEButton;
        private System.Windows.Forms.Label buildingBButton;
        private System.Windows.Forms.Label buildingCButton;
        private System.Windows.Forms.Label buildingAButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label playFieldButton;
        private System.Windows.Forms.Panel panelTimeTableHeader;
    }
}