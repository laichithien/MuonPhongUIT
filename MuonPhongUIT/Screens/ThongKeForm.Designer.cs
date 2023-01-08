namespace MuonPhongUIT.Screens
{
    partial class ThongKeForm
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
            this.filterPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.danhGia = new System.Windows.Forms.Label();
            this.huHong = new System.Windows.Forms.Label();
            this.luotXem = new System.Windows.Forms.Label();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.playField = new System.Windows.Forms.Label();
            this.buildingEButton = new System.Windows.Forms.Label();
            this.buildingCButton = new System.Windows.Forms.Label();
            this.buildingBButton = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.Label();
            this.buildingAButton = new System.Windows.Forms.Label();
            this.filterPanel.SuspendLayout();
            this.optionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.label4);
            this.filterPanel.Controls.Add(this.comboBox1);
            this.filterPanel.Controls.Add(this.danhGia);
            this.filterPanel.Controls.Add(this.huHong);
            this.filterPanel.Controls.Add(this.luotXem);
            this.filterPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPanel.Location = new System.Drawing.Point(0, 60);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1114, 69);
            this.filterPanel.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sắp xếp:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Giảm dần",
            "Tăng dần"});
            this.comboBox1.Location = new System.Drawing.Point(765, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Giảm dần";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // danhGia
            // 
            this.danhGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.danhGia.AutoSize = true;
            this.danhGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.danhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhGia.Location = new System.Drawing.Point(376, 23);
            this.danhGia.Name = "danhGia";
            this.danhGia.Size = new System.Drawing.Size(81, 20);
            this.danhGia.TabIndex = 2;
            this.danhGia.Text = "Đánh giá";
            this.danhGia.Click += new System.EventHandler(this.danhGia_Click);
            // 
            // huHong
            // 
            this.huHong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.huHong.AutoSize = true;
            this.huHong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.huHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huHong.Location = new System.Drawing.Point(508, 23);
            this.huHong.Name = "huHong";
            this.huHong.Size = new System.Drawing.Size(77, 20);
            this.huHong.TabIndex = 1;
            this.huHong.Text = "Hư hỏng";
            this.huHong.Click += new System.EventHandler(this.huHong_Click);
            // 
            // luotXem
            // 
            this.luotXem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.luotXem.AutoSize = true;
            this.luotXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luotXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luotXem.ForeColor = System.Drawing.Color.Red;
            this.luotXem.Location = new System.Drawing.Point(234, 23);
            this.luotXem.Name = "luotXem";
            this.luotXem.Size = new System.Drawing.Size(82, 20);
            this.luotXem.TabIndex = 0;
            this.luotXem.Text = "Lượt xem";
            this.luotXem.Click += new System.EventHandler(this.luotXem_Click);
            // 
            // optionPanel
            // 
            this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(108)))), ((int)(((byte)(181)))));
            this.optionPanel.Controls.Add(this.playField);
            this.optionPanel.Controls.Add(this.buildingEButton);
            this.optionPanel.Controls.Add(this.buildingCButton);
            this.optionPanel.Controls.Add(this.buildingBButton);
            this.optionPanel.Controls.Add(this.All);
            this.optionPanel.Controls.Add(this.buildingAButton);
            this.optionPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.optionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionPanel.Location = new System.Drawing.Point(0, 0);
            this.optionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(1114, 60);
            this.optionPanel.TabIndex = 12;
            // 
            // playField
            // 
            this.playField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playField.AutoSize = true;
            this.playField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playField.ForeColor = System.Drawing.Color.White;
            this.playField.Location = new System.Drawing.Point(807, 18);
            this.playField.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playField.Name = "playField";
            this.playField.Size = new System.Drawing.Size(73, 24);
            this.playField.TabIndex = 3;
            this.playField.Text = "Sân tập";
            this.playField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playField.Click += new System.EventHandler(this.buildingOption_Click);
            // 
            // buildingEButton
            // 
            this.buildingEButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buildingEButton.AutoSize = true;
            this.buildingEButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingEButton.ForeColor = System.Drawing.Color.White;
            this.buildingEButton.Location = new System.Drawing.Point(692, 18);
            this.buildingEButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingEButton.Name = "buildingEButton";
            this.buildingEButton.Size = new System.Drawing.Size(61, 24);
            this.buildingEButton.TabIndex = 4;
            this.buildingEButton.Text = "Tòa E";
            this.buildingEButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buildingEButton.Click += new System.EventHandler(this.buildingOption_Click);
            // 
            // buildingCButton
            // 
            this.buildingCButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buildingCButton.AutoSize = true;
            this.buildingCButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingCButton.ForeColor = System.Drawing.Color.White;
            this.buildingCButton.Location = new System.Drawing.Point(570, 18);
            this.buildingCButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingCButton.Name = "buildingCButton";
            this.buildingCButton.Size = new System.Drawing.Size(61, 24);
            this.buildingCButton.TabIndex = 5;
            this.buildingCButton.Text = "Tòa C";
            this.buildingCButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buildingCButton.Click += new System.EventHandler(this.buildingOption_Click);
            // 
            // buildingBButton
            // 
            this.buildingBButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buildingBButton.AutoSize = true;
            this.buildingBButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingBButton.ForeColor = System.Drawing.Color.White;
            this.buildingBButton.Location = new System.Drawing.Point(454, 18);
            this.buildingBButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingBButton.Name = "buildingBButton";
            this.buildingBButton.Size = new System.Drawing.Size(60, 24);
            this.buildingBButton.TabIndex = 6;
            this.buildingBButton.Text = "Tòa B";
            this.buildingBButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buildingBButton.Click += new System.EventHandler(this.buildingOption_Click);
            // 
            // All
            // 
            this.All.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.All.AutoSize = true;
            this.All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.All.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All.ForeColor = System.Drawing.Color.White;
            this.All.Location = new System.Drawing.Point(234, 18);
            this.All.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(61, 24);
            this.All.TabIndex = 7;
            this.All.Text = "Tất cả";
            this.All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // buildingAButton
            // 
            this.buildingAButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buildingAButton.AutoSize = true;
            this.buildingAButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingAButton.ForeColor = System.Drawing.Color.White;
            this.buildingAButton.Location = new System.Drawing.Point(346, 18);
            this.buildingAButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingAButton.Name = "buildingAButton";
            this.buildingAButton.Size = new System.Drawing.Size(61, 24);
            this.buildingAButton.TabIndex = 8;
            this.buildingAButton.Text = "Tòa A";
            this.buildingAButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buildingAButton.Click += new System.EventHandler(this.buildingOption_Click);
            // 
            // ThongKeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1114, 704);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.optionPanel);
            this.Name = "ThongKeForm";
            this.Text = "ThongKeForm";
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label danhGia;
        private System.Windows.Forms.Label huHong;
        private System.Windows.Forms.Label luotXem;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playField;
        private System.Windows.Forms.Label buildingEButton;
        private System.Windows.Forms.Label buildingCButton;
        private System.Windows.Forms.Label buildingBButton;
        private System.Windows.Forms.Label All;
        private System.Windows.Forms.Label buildingAButton;
    }
}