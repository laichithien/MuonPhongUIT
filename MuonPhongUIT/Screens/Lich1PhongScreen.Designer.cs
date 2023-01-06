namespace MuonPhongUIT.Screens
{
    partial class Lich1PhongScreen
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TenPhimTiengViet = new System.Windows.Forms.Label();
            this.panelTimeTableHeader = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTimeTableHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(466, 41);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // TenPhimTiengViet
            // 
            this.TenPhimTiengViet.AutoSize = true;
            this.TenPhimTiengViet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenPhimTiengViet.ForeColor = System.Drawing.Color.Crimson;
            this.TenPhimTiengViet.Location = new System.Drawing.Point(500, -2);
            this.TenPhimTiengViet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TenPhimTiengViet.Name = "TenPhimTiengViet";
            this.TenPhimTiengViet.Size = new System.Drawing.Size(98, 41);
            this.TenPhimTiengViet.TabIndex = 9;
            this.TenPhimTiengViet.Text = "A10.8";
            // 
            // panelTimeTableHeader
            // 
            this.panelTimeTableHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTimeTableHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.panelTimeTableHeader.Controls.Add(this.flowLayoutPanel1);
            this.panelTimeTableHeader.Location = new System.Drawing.Point(1, 73);
            this.panelTimeTableHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelTimeTableHeader.Name = "panelTimeTableHeader";
            this.panelTimeTableHeader.Size = new System.Drawing.Size(956, 75);
            this.panelTimeTableHeader.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.PowderBlue;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(956, 75);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.PowderBlue;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 133);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(956, 337);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // Lich1PhongScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(962, 473);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panelTimeTableHeader);
            this.Controls.Add(this.TenPhimTiengViet);
            this.Controls.Add(this.comboBox1);
            this.Name = "Lich1PhongScreen";
            this.Text = "Lich1PhongScreen";
            this.panelTimeTableHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label TenPhimTiengViet;
        private System.Windows.Forms.Panel panelTimeTableHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}