using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuonPhongUIT
{
    public partial class RoomDetail : Form
    {
        public RoomDetail()
        {
            InitializeComponent();
        }
  

        private void pictureBoxAnh1_Click(object sender, EventArgs e)
        {
            pictureBoxAnh.Image = pictureBoxAnh1.Image;
        }

        private void pictureBoxAnh2_Click(object sender, EventArgs e)
        {
            pictureBoxAnh.Image = pictureBoxAnh2.Image;
        }

        private void pictureBoxAnh3_Click(object sender, EventArgs e)
        {
            pictureBoxAnh.Image = pictureBoxAnh3.Image;
        }

        private void buttonMuon_Click(object sender, EventArgs e)
        {
            // truyền tên phòng cho form mượn phòng
        }
    }
}
