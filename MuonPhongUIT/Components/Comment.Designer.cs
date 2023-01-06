namespace MuonPhongUIT.Components
{
    partial class Comment
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
            this.labelComment = new System.Windows.Forms.Label();
            this.labelStar = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComment.Location = new System.Drawing.Point(9, 56);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(208, 20);
            this.labelComment.TabIndex = 5;
            this.labelComment.Text = "Bài hát hay nhất từng nghe";
            // 
            // labelStar
            // 
            this.labelStar.AutoSize = true;
            this.labelStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStar.ForeColor = System.Drawing.Color.Yellow;
            this.labelStar.Location = new System.Drawing.Point(9, 26);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(82, 25);
            this.labelStar.TabIndex = 4;
            this.labelStar.Text = "★★★★★";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(8, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Vy Lê";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(431, 6);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(91, 20);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "11/11/2022";
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(108)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelStar);
            this.Controls.Add(this.labelName);
            this.Name = "Comment";
            this.Size = new System.Drawing.Size(528, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelStar;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
    }
}
