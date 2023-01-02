namespace MuonPhongUIT
{
    partial class ShowRoomList
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
            this.SuspendLayout();
            // 
            // roomListContainer
            // 
            this.roomListContainer.AutoScroll = true;
            this.roomListContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roomListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomListContainer.Location = new System.Drawing.Point(0, 0);
            this.roomListContainer.Margin = new System.Windows.Forms.Padding(4);
            this.roomListContainer.Name = "roomListContainer";
            this.roomListContainer.Size = new System.Drawing.Size(940, 542);
            this.roomListContainer.TabIndex = 1;
            // 
            // ShowRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 542);
            this.Controls.Add(this.roomListContainer);
            this.Name = "ShowRoomList";
            this.Text = "ShowRoomList";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel roomListContainer;
    }
}