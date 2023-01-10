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
    public partial class UpdateUserInfor : Form
    {
        private static int gt = 1;
        public UpdateUserInfor()
        {
            InitializeComponent();

            // load dữ liệu từ database lên
            // tbxUser.Text -> tên user
            // tbxMK.Text --> mk
            //  giới tính --> 
                    //// + 0: radioButtonNu.Checked = true; và gt = 0
                    //// + 1: radioButtonNam.Checked = true; và gt = 1

            //  email -->tbxEmail.Text
            // Khoa -> comboxKhoa : thứ tự trong comboxKhoa
                    ////Khoa Khoa học Máy tính
                    ////Khoa Kỹ thuật Máy tính
                    ////Khoa Công nghệ Phần mềm
                    ////Khoa Hệ thống Thông tin
                    ////Khoa Mạng máy tính và Truyền thông
                    ////Khoa Khoa học và kỹ thuật Thông tin
                    ////Bộ môn Toán Lý
                    ////Phòng thí nghiệm Truyền thông Đa phương tiện

            // ảnh đại diện --> picturebox1
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string mk = "";
            string user = "";
            // lấy user và mk của tk này
            if (tbxMK2.Text == mk)
            {
                if (tbxMK.Text !="")
                {
                    mk = tbxMK.Text;
                }
                // update liệu vào database
                // dữ liệu dược lưu ở
                // tbxUser.Text -> tên user
                // mk --> mật khẩu
                // gt (0/1) --> giới tính
                // tbxEmail.Text --> email
                // comboBoxKhoa.Text --> khoa

                // lưu hình đại diện ở picturebox1
            }
        }

        private void radioButtonNu_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonNam.Checked = false;
            gt = 0;
          
        }

        private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonNu.Checked = false;
            gt = 1;
        }
    }
}
