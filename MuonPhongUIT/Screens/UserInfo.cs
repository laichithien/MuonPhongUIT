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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
            

            // lấy thông tinh truyền vào
            // ảnh đại diện --> avatar
            // tên --> lblTen
            // khoa --> lblKhoa
            // giới tính --> lblGT
            // user -->lblUser
            // email --> lblEmail
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
