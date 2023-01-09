namespace MuonPhongUIT.Screens
{
    partial class SuaCSVC
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
            this.roomListContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.daGiaiQuyet = new System.Windows.Forms.Label();
            this.tatCa = new System.Windows.Forms.Label();
            this.chuaGiaiQuyet = new System.Windows.Forms.Label();
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
            // roomListContainer
            // 
            this.roomListContainer.AutoScroll = true;
            this.roomListContainer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.roomListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomListContainer.Location = new System.Drawing.Point(0, 129);
            this.roomListContainer.Margin = new System.Windows.Forms.Padding(4);
            this.roomListContainer.Name = "roomListContainer";
            this.roomListContainer.Size = new System.Drawing.Size(1485, 737);
            this.roomListContainer.TabIndex = 17;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.daGiaiQuyet);
            this.filterPanel.Controls.Add(this.tatCa);
            this.filterPanel.Controls.Add(this.chuaGiaiQuyet);
            this.filterPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPanel.Location = new System.Drawing.Point(0, 60);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1485, 69);
            this.filterPanel.TabIndex = 16;
            // 
            // daGiaiQuyet
            // 
            this.daGiaiQuyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.daGiaiQuyet.AutoSize = true;
            this.daGiaiQuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daGiaiQuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daGiaiQuyet.Location = new System.Drawing.Point(717, 21);
            this.daGiaiQuyet.Name = "daGiaiQuyet";
            this.daGiaiQuyet.Size = new System.Drawing.Size(138, 25);
            this.daGiaiQuyet.TabIndex = 2;
            this.daGiaiQuyet.Text = "Đã giải quyết";
            this.daGiaiQuyet.Click += new System.EventHandler(this.daGiaiQuyet_Click);
            // 
            // tatCa
            // 
            this.tatCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tatCa.AutoSize = true;
            this.tatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tatCa.Location = new System.Drawing.Point(1001, 21);
            this.tatCa.Name = "tatCa";
            this.tatCa.Size = new System.Drawing.Size(73, 25);
            this.tatCa.TabIndex = 1;
            this.tatCa.Text = "Tất cả";
            this.tatCa.Click += new System.EventHandler(this.tatCa_Click);
            // 
            // chuaGiaiQuyet
            // 
            this.chuaGiaiQuyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chuaGiaiQuyet.AutoSize = true;
            this.chuaGiaiQuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chuaGiaiQuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuaGiaiQuyet.ForeColor = System.Drawing.Color.Red;
            this.chuaGiaiQuyet.Location = new System.Drawing.Point(385, 21);
            this.chuaGiaiQuyet.Name = "chuaGiaiQuyet";
            this.chuaGiaiQuyet.Size = new System.Drawing.Size(163, 25);
            this.chuaGiaiQuyet.TabIndex = 0;
            this.chuaGiaiQuyet.Text = "Chưa giải quyết";
            this.chuaGiaiQuyet.Click += new System.EventHandler(this.chuaGiaiQuyet_Click);
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
            this.optionPanel.Size = new System.Drawing.Size(1485, 60);
            this.optionPanel.TabIndex = 15;
            // 
            // playField
            // 
            this.playField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playField.AutoSize = true;
            this.playField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playField.ForeColor = System.Drawing.Color.White;
            this.playField.Location = new System.Drawing.Point(1075, 16);
            this.playField.Name = "playField";
            this.playField.Size = new System.Drawing.Size(94, 29);
            this.playField.TabIndex = 2;
            this.playField.Text = "Sân tập";
            this.playField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buildingEButton
            // 
            this.buildingEButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buildingEButton.AutoSize = true;
            this.buildingEButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingEButton.ForeColor = System.Drawing.Color.White;
            this.buildingEButton.Location = new System.Drawing.Point(921, 16);
            this.buildingEButton.Name = "buildingEButton";
            this.buildingEButton.Size = new System.Drawing.Size(78, 29);
            this.buildingEButton.TabIndex = 2;
            this.buildingEButton.Text = "Tòa E";
            this.buildingEButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buildingCButton
            // 
            this.buildingCButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buildingCButton.AutoSize = true;
            this.buildingCButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingCButton.ForeColor = System.Drawing.Color.White;
            this.buildingCButton.Location = new System.Drawing.Point(759, 16);
            this.buildingCButton.Name = "buildingCButton";
            this.buildingCButton.Size = new System.Drawing.Size(79, 29);
            this.buildingCButton.TabIndex = 2;
            this.buildingCButton.Text = "Tòa C";
            this.buildingCButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buildingBButton
            // 
            this.buildingBButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buildingBButton.AutoSize = true;
            this.buildingBButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingBButton.ForeColor = System.Drawing.Color.White;
            this.buildingBButton.Location = new System.Drawing.Point(604, 16);
            this.buildingBButton.Name = "buildingBButton";
            this.buildingBButton.Size = new System.Drawing.Size(78, 29);
            this.buildingBButton.TabIndex = 2;
            this.buildingBButton.Text = "Tòa B";
            this.buildingBButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // All
            // 
            this.All.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.All.AutoSize = true;
            this.All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.All.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All.ForeColor = System.Drawing.Color.White;
            this.All.Location = new System.Drawing.Point(311, 16);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(79, 29);
            this.All.TabIndex = 2;
            this.All.Text = "Tất cả";
            this.All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buildingAButton
            // 
            this.buildingAButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buildingAButton.AutoSize = true;
            this.buildingAButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingAButton.ForeColor = System.Drawing.Color.White;
            this.buildingAButton.Location = new System.Drawing.Point(460, 16);
            this.buildingAButton.Name = "buildingAButton";
            this.buildingAButton.Size = new System.Drawing.Size(77, 29);
            this.buildingAButton.TabIndex = 2;
            this.buildingAButton.Text = "Tòa A";
            this.buildingAButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuaCSVC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1485, 866);
            this.Controls.Add(this.roomListContainer);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.optionPanel);
            this.Name = "SuaCSVC";
            this.Text = "SuaCSVC";
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel roomListContainer;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label daGiaiQuyet;
        private System.Windows.Forms.Label tatCa;
        private System.Windows.Forms.Label chuaGiaiQuyet;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Label playField;
        private System.Windows.Forms.Label buildingEButton;
        private System.Windows.Forms.Label buildingCButton;
        private System.Windows.Forms.Label buildingBButton;
        private System.Windows.Forms.Label All;
        private System.Windows.Forms.Label buildingAButton;
    }
}