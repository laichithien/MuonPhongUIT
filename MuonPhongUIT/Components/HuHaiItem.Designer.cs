namespace MuonPhongUIT.Components
{
    partial class HuHaiItem
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
            this.tenGVLabel = new System.Windows.Forms.Label();
            this.noiDung = new System.Windows.Forms.Label();
            this.tinhTrangLabel = new System.Windows.Forms.Label();
            this.ngayBaoCaoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tenGVLabel
            // 
            this.tenGVLabel.AutoSize = true;
            this.tenGVLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenGVLabel.ForeColor = System.Drawing.Color.Gold;
            this.tenGVLabel.Location = new System.Drawing.Point(3, 6);
            this.tenGVLabel.Name = "tenGVLabel";
            this.tenGVLabel.Size = new System.Drawing.Size(110, 20);
            this.tenGVLabel.TabIndex = 1;
            this.tenGVLabel.Text = "Tên giảng viên";
            // 
            // noiDung
            // 
            this.noiDung.AllowDrop = true;
            this.noiDung.AutoSize = true;
            this.noiDung.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiDung.ForeColor = System.Drawing.Color.White;
            this.noiDung.Location = new System.Drawing.Point(114, 6);
            this.noiDung.MaximumSize = new System.Drawing.Size(260, 10000);
            this.noiDung.Name = "noiDung";
            this.noiDung.Size = new System.Drawing.Size(219, 40);
            this.noiDung.TabIndex = 1;
            this.noiDung.Text = "Nội dung báo cáo hư hỏng của phòng ";
            // 
            // tinhTrangLabel
            // 
            this.tinhTrangLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tinhTrangLabel.AutoSize = true;
            this.tinhTrangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangLabel.ForeColor = System.Drawing.Color.Red;
            this.tinhTrangLabel.Location = new System.Drawing.Point(255, 36);
            this.tinhTrangLabel.Name = "tinhTrangLabel";
            this.tinhTrangLabel.Size = new System.Drawing.Size(121, 17);
            this.tinhTrangLabel.TabIndex = 2;
            this.tinhTrangLabel.Text = "Chưa giải quyết";
            // 
            // ngayBaoCaoLabel
            // 
            this.ngayBaoCaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ngayBaoCaoLabel.AutoSize = true;
            this.ngayBaoCaoLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.ngayBaoCaoLabel.Location = new System.Drawing.Point(4, 39);
            this.ngayBaoCaoLabel.Name = "ngayBaoCaoLabel";
            this.ngayBaoCaoLabel.Size = new System.Drawing.Size(74, 13);
            this.ngayBaoCaoLabel.TabIndex = 3;
            this.ngayBaoCaoLabel.Text = "Ngày báo cáo";
            // 
            // HuHaiItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(108)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.ngayBaoCaoLabel);
            this.Controls.Add(this.tinhTrangLabel);
            this.Controls.Add(this.noiDung);
            this.Controls.Add(this.tenGVLabel);
            this.MaximumSize = new System.Drawing.Size(390, 10000);
            this.Name = "HuHaiItem";
            this.Size = new System.Drawing.Size(390, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tenGVLabel;
        private System.Windows.Forms.Label noiDung;
        private System.Windows.Forms.Label tinhTrangLabel;
        private System.Windows.Forms.Label ngayBaoCaoLabel;
    }
}
