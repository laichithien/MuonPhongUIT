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
    public partial class DangKiMuonPhong : Form
    {
        Room room;
        public DangKiMuonPhong()
        {
            InitializeComponent();
        }
        public DangKiMuonPhong(Room room)
        { 
            InitializeComponent();
            this.room = room;
            labelPhong.Text = room.thisRoomName;
        }

        private void muonPhongButton_Click(object sender, EventArgs e)
        {
            if (isRoomAvailable())
            {
                //Đặt thành công
                //Ghi vào database
            }
            else
            {
                //Đặt không thành công do phòng không trống
            }
        }
        private bool isRoomAvailable()
        {
            return true;
        }
    }
}
