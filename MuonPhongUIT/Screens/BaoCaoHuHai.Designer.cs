namespace MuonPhongUIT.Screens
{
    partial class BaoCaoHuHai
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
            this.textBoxPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTenGV = new System.Windows.Forms.TextBox();
            this.textBoxMaGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPhong
            // 
            this.textBoxPhong.Location = new System.Drawing.Point(238, 150);
            this.textBoxPhong.Name = "textBoxPhong";
            this.textBoxPhong.Size = new System.Drawing.Size(297, 22);
            this.textBoxPhong.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Mã giảng viên:";
            // 
            // textBoxTenGV
            // 
            this.textBoxTenGV.Location = new System.Drawing.Point(238, 90);
            this.textBoxTenGV.Name = "textBoxTenGV";
            this.textBoxTenGV.Size = new System.Drawing.Size(297, 22);
            this.textBoxTenGV.TabIndex = 35;
            // 
            // textBoxMaGV
            // 
            this.textBoxMaGV.Location = new System.Drawing.Point(238, 40);
            this.textBoxMaGV.Name = "textBoxMaGV";
            this.textBoxMaGV.Size = new System.Drawing.Size(297, 22);
            this.textBoxMaGV.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên giảng viên: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 141);
            this.textBox1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Hư hại:";
            // 
            // BaoCaoHuHai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 360);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPhong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTenGV);
            this.Controls.Add(this.textBoxMaGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "BaoCaoHuHai";
            this.Text = "BaoCaoHuHai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTenGV;
        private System.Windows.Forms.TextBox textBoxMaGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}