namespace MuonPhongUIT.Screens
{
    partial class MuonPhongScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.twoProjectorOption = new System.Windows.Forms.RadioButton();
            this.oneProjectorOption = new System.Windows.Forms.RadioButton();
            this.isAirConditioner = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toPeriod = new System.Windows.Forms.ComboBox();
            this.fromPeriod = new System.Windows.Forms.ComboBox();
            this.dateTimeFilter = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromCapa = new System.Windows.Forms.NumericUpDown();
            this.activateFilterButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.playField = new System.Windows.Forms.Label();
            this.buildingEButton = new System.Windows.Forms.Label();
            this.buildingCButton = new System.Windows.Forms.Label();
            this.buildingBButton = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.Label();
            this.buildingAButton = new System.Windows.Forms.Label();
            this.roomListContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.filterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromCapa)).BeginInit();
            this.optionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.panel1);
            this.filterPanel.Controls.Add(this.isAirConditioner);
            this.filterPanel.Controls.Add(this.label8);
            this.filterPanel.Controls.Add(this.toPeriod);
            this.filterPanel.Controls.Add(this.fromPeriod);
            this.filterPanel.Controls.Add(this.dateTimeFilter);
            this.filterPanel.Controls.Add(this.label7);
            this.filterPanel.Controls.Add(this.label4);
            this.filterPanel.Controls.Add(this.fromCapa);
            this.filterPanel.Controls.Add(this.activateFilterButton);
            this.filterPanel.Controls.Add(this.label6);
            this.filterPanel.Controls.Add(this.label3);
            this.filterPanel.Controls.Add(this.label2);
            this.filterPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPanel.Location = new System.Drawing.Point(0, 49);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1114, 56);
            this.filterPanel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.twoProjectorOption);
            this.panel1.Controls.Add(this.oneProjectorOption);
            this.panel1.Location = new System.Drawing.Point(731, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 56);
            this.panel1.TabIndex = 10;
            // 
            // twoProjectorOption
            // 
            this.twoProjectorOption.AutoCheck = false;
            this.twoProjectorOption.AutoSize = true;
            this.twoProjectorOption.Location = new System.Drawing.Point(103, 23);
            this.twoProjectorOption.Name = "twoProjectorOption";
            this.twoProjectorOption.Size = new System.Drawing.Size(92, 17);
            this.twoProjectorOption.TabIndex = 1;
            this.twoProjectorOption.Text = "Hai máy chiếu";
            this.twoProjectorOption.UseVisualStyleBackColor = true;
            this.twoProjectorOption.Click += new System.EventHandler(this.projectorClicked);
            // 
            // oneProjectorOption
            // 
            this.oneProjectorOption.AutoCheck = false;
            this.oneProjectorOption.AutoSize = true;
            this.oneProjectorOption.Location = new System.Drawing.Point(3, 23);
            this.oneProjectorOption.Name = "oneProjectorOption";
            this.oneProjectorOption.Size = new System.Drawing.Size(94, 17);
            this.oneProjectorOption.TabIndex = 0;
            this.oneProjectorOption.Text = "Một máy chiếu";
            this.oneProjectorOption.UseVisualStyleBackColor = true;
            this.oneProjectorOption.Click += new System.EventHandler(this.projectorClicked);
            // 
            // isAirConditioner
            // 
            this.isAirConditioner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.isAirConditioner.AutoSize = true;
            this.isAirConditioner.Location = new System.Drawing.Point(658, 23);
            this.isAirConditioner.Name = "isAirConditioner";
            this.isAirConditioner.Size = new System.Drawing.Size(69, 17);
            this.isAirConditioner.TabIndex = 9;
            this.isAirConditioner.Text = "Máy lạnh";
            this.isAirConditioner.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Đến";
            // 
            // toPeriod
            // 
            this.toPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toPeriod.FormattingEnabled = true;
            this.toPeriod.Items.AddRange(new object[] {
            "Tiết 1",
            "Tiết 2",
            "Tiết 3",
            "Tiết 4",
            "Tiết 5",
            "Tiết 6",
            "Tiết 7",
            "Tiết 8",
            "Tiết 9",
            "Tiết 10"});
            this.toPeriod.Location = new System.Drawing.Point(552, 32);
            this.toPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.toPeriod.Name = "toPeriod";
            this.toPeriod.Size = new System.Drawing.Size(92, 21);
            this.toPeriod.TabIndex = 7;
            // 
            // fromPeriod
            // 
            this.fromPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromPeriod.FormattingEnabled = true;
            this.fromPeriod.Items.AddRange(new object[] {
            "Tiết 1",
            "Tiết 2",
            "Tiết 3",
            "Tiết 4",
            "Tiết 5",
            "Tiết 6",
            "Tiết 7",
            "Tiết 8",
            "Tiết 9",
            "Tiết 10"});
            this.fromPeriod.Location = new System.Drawing.Point(457, 32);
            this.fromPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.fromPeriod.Name = "fromPeriod";
            this.fromPeriod.Size = new System.Drawing.Size(92, 21);
            this.fromPeriod.TabIndex = 7;
            // 
            // dateTimeFilter
            // 
            this.dateTimeFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeFilter.Location = new System.Drawing.Point(262, 32);
            this.dateTimeFilter.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFilter.Name = "dateTimeFilter";
            this.dateTimeFilter.Size = new System.Drawing.Size(182, 19);
            this.dateTimeFilter.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Từ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ";
            // 
            // fromCapa
            // 
            this.fromCapa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromCapa.Location = new System.Drawing.Point(181, 32);
            this.fromCapa.Margin = new System.Windows.Forms.Padding(2);
            this.fromCapa.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.fromCapa.Name = "fromCapa";
            this.fromCapa.Size = new System.Drawing.Size(62, 19);
            this.fromCapa.TabIndex = 4;
            // 
            // activateFilterButton
            // 
            this.activateFilterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activateFilterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activateFilterButton.Location = new System.Drawing.Point(958, 13);
            this.activateFilterButton.Margin = new System.Windows.Forms.Padding(2);
            this.activateFilterButton.Name = "activateFilterButton";
            this.activateFilterButton.Size = new System.Drawing.Size(64, 32);
            this.activateFilterButton.TabIndex = 3;
            this.activateFilterButton.Text = "Áp dụng";
            this.activateFilterButton.UseVisualStyleBackColor = true;
            this.activateFilterButton.Click += new System.EventHandler(this.activateFilterButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sức chứa";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bộ lọc";
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
            this.optionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(1114, 49);
            this.optionPanel.TabIndex = 9;
            // 
            // playField
            // 
            this.playField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playField.AutoSize = true;
            this.playField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playField.ForeColor = System.Drawing.Color.White;
            this.playField.Location = new System.Drawing.Point(806, 13);
            this.playField.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playField.Name = "playField";
            this.playField.Size = new System.Drawing.Size(73, 24);
            this.playField.TabIndex = 2;
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
            this.buildingEButton.Location = new System.Drawing.Point(691, 13);
            this.buildingEButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingEButton.Name = "buildingEButton";
            this.buildingEButton.Size = new System.Drawing.Size(61, 24);
            this.buildingEButton.TabIndex = 2;
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
            this.buildingCButton.Location = new System.Drawing.Point(569, 13);
            this.buildingCButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingCButton.Name = "buildingCButton";
            this.buildingCButton.Size = new System.Drawing.Size(61, 24);
            this.buildingCButton.TabIndex = 2;
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
            this.buildingBButton.Location = new System.Drawing.Point(453, 13);
            this.buildingBButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingBButton.Name = "buildingBButton";
            this.buildingBButton.Size = new System.Drawing.Size(60, 24);
            this.buildingBButton.TabIndex = 2;
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
            this.All.Location = new System.Drawing.Point(233, 13);
            this.All.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(61, 24);
            this.All.TabIndex = 2;
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
            this.buildingAButton.Location = new System.Drawing.Point(345, 13);
            this.buildingAButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buildingAButton.Name = "buildingAButton";
            this.buildingAButton.Size = new System.Drawing.Size(61, 24);
            this.buildingAButton.TabIndex = 2;
            this.buildingAButton.Text = "Tòa A";
            this.buildingAButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buildingAButton.Click += new System.EventHandler(this.buildingOption_Click);
            // 
            // roomListContainer
            // 
            this.roomListContainer.AutoScroll = true;
            this.roomListContainer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.roomListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomListContainer.Location = new System.Drawing.Point(0, 105);
            this.roomListContainer.Name = "roomListContainer";
            this.roomListContainer.Size = new System.Drawing.Size(1114, 599);
            this.roomListContainer.TabIndex = 11;
            // 
            // MuonPhongScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 704);
            this.Controls.Add(this.roomListContainer);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.optionPanel);
            this.Name = "MuonPhongScreen";
            this.Text = "MuonPhongScreen";
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromCapa)).EndInit();
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox toPeriod;
        private System.Windows.Forms.ComboBox fromPeriod;
        private System.Windows.Forms.DateTimePicker dateTimeFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown fromCapa;
        private System.Windows.Forms.Button activateFilterButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Label playField;
        private System.Windows.Forms.Label buildingEButton;
        private System.Windows.Forms.Label buildingCButton;
        private System.Windows.Forms.Label buildingBButton;
        private System.Windows.Forms.Label All;
        private System.Windows.Forms.Label buildingAButton;
        private System.Windows.Forms.FlowLayoutPanel roomListContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton oneProjectorOption;
        private System.Windows.Forms.CheckBox isAirConditioner;
        private System.Windows.Forms.RadioButton twoProjectorOption;
    }
}