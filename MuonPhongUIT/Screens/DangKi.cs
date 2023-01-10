using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuonPhongUIT.Screens
{
    public partial class DangKi : Form
    {
        private static int gt = 1;
        public DangKi()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (tbxUser.Text!=""&&tbxMK.Text!=""&& tbxMK2.Text!=""&&tbxEmail.Text!=""&&tbxTen.Text!=""&&comboBoxKhoa.Text!="")
            {
                if (tbxMK.Text!=tbxMK2.Text)
                {
                    MessageBox.Show("Mật khẩu không giống nhau");
                }    
                else
                {

                    // lưu dữ liệu vào database
                    // dữ liệu dược lưu ở
                        // tbxUser.Text -> tên user
                        // tbxMK.Text --> mk
                        // gt (0/1) --> giới tính
                        // tbxEmail.Text --> email
                        // comboBoxKhoa.Text --> khoa

                    // lưu hình đại diện ở picturebox1
                    // đống form này và mở form đăng nhập
                }
            }    
        }

        private void radioButtonNu_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonNam.Checked = false;
            gt = 1;
        }

        private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonNu.Checked = false;
            gt = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(op.FileName);
                pictureBox1.Name = op.FileName;
            }
        }
    }
}
