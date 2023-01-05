namespace MuonPhongUIT.Components
{
    partial class Item
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
            this.roomName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.roomType = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.roomName.Location = new System.Drawing.Point(14, 11);
            this.roomName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(60, 25);
            this.roomName.TabIndex = 0;
            this.roomName.Text = "E10.8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sức chứa: ";
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.Location = new System.Drawing.Point(257, 54);
            this.capacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(25, 19);
            this.capacity.TabIndex = 0;
            this.capacity.Text = "50";
            // 
            // roomType
            // 
            this.roomType.AutoSize = true;
            this.roomType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType.ForeColor = System.Drawing.Color.DarkGreen;
            this.roomType.Location = new System.Drawing.Point(15, 54);
            this.roomType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(79, 19);
            this.roomType.TabIndex = 0;
            this.roomType.Text = "Phòng máy";
            // 
            // building
            // 
            this.building.AutoSize = true;
            this.building.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.building.ForeColor = System.Drawing.Color.SaddleBrown;
            this.building.Location = new System.Drawing.Point(178, 11);
            this.building.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(61, 25);
            this.building.TabIndex = 0;
            this.building.Text = "Toà A";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.building);
            this.Controls.Add(this.roomName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(300, 95);
            this.Load += new System.EventHandler(this.Item_Load);
            this.Click += new System.EventHandler(this.Item_Click);
            this.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label roomType;
        private System.Windows.Forms.Label building;
    }
}
