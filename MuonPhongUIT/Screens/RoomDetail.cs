﻿using MuonPhongUIT.Screens;
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
        Room room;
        public RoomDetail()
        {
            InitializeComponent();
        }
  
        public RoomDetail(Room room)
        {
            InitializeComponent();
            this.room = room;   
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
            DangKiMuonPhong dangKiMuonPhong = new DangKiMuonPhong(room);
            dangKiMuonPhong.Show();
            // truyền tên phòng cho form mượn phòng
        }

        private void buttonLich_Click(object sender, EventArgs e)
        {
            // show form chỉ có lịch mỗi phòng đó
        }
    }
}
