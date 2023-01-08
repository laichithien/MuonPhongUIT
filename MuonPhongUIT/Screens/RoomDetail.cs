using MuonPhongUIT.Components;
using MuonPhongUIT.Screens;
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
        string[] HuHai;
        Data_Provider data_Provider = new Data_Provider();
        public RoomDetail()
        {
            InitializeComponent();
        }
  
        public RoomDetail(Room room)
        {
            InitializeComponent();
            this.room = room;
            int luotxem = this.room.LUOTXEM + 1;

            string query = "update PHONG set LUOTXEM = "+luotxem+" where TENPHONG = N'"+this.room.thisRoomName+"'";
            data_Provider.ExecuteNonQuery(query);
            loadPage();
        }
        public void loadPage()
        {
            tenPhong.Text = room.thisRoomName;
            sucChua.Text = "Sức chứa: " + room.thisCapacity.ToString();
            string query = "select * from BAOCAOHUHAI where TENPHONG = N'"+room.thisRoomName+"'";

            DataTable dt = data_Provider.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string tenGV = dt.Rows[i]["TENGV"].ToString();
                string noidung = dt.Rows[i]["NOIDUNG"].ToString();
                DateTime ngayBaoCao = Convert.ToDateTime(dt.Rows[i]["NGAYBAOCAO"]);
                bool tinhTrang = Convert.ToBoolean(dt.Rows[i]["TINHTRANG"]);
                HuHaiItem huHaiItem = new HuHaiItem(tenGV, noidung, ngayBaoCao, tinhTrang);
                huHaiFlowPanel.Controls.Add(huHaiItem);
            }

            query = "select * from COMMENTS where TENPHONG = N'" + room.thisRoomName + "'";
            DataTable dttb = data_Provider.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string tenGV = dttb.Rows[i]["TENGV"].ToString();
                string noidung = dttb.Rows[i]["NOIDUNG"].ToString();
                DateTime ngayBinhLuan = Convert.ToDateTime(dttb.Rows[i]["NGAYBINHLUAN"]);
                double star = Convert.ToDouble(dttb.Rows[i]["STARS"]);
                Comment comment= new Comment(tenGV, noidung,ngayBinhLuan, star);
                commentFlowPanel.Controls.Add(comment);
            }
            loadStar();
        }
        private void loadStar()
        {
            string query = "select STARS from COMMENTS where TENPHONG like N'%" + room.thisRoomName + "%'";
            DataTable dt = data_Provider.ExecuteQuery(query);
            int sum = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dt.Rows[i]["STARS"]);
            }
            int star = 0;
            if (dt.Rows.Count != 0)
            {

                star = sum / dt.Rows.Count;
            }
            labelStar.Text = "";
            for (int i = 0; i < star; i++)
            {
                labelStar.Text += "★";
            }
            chuThichDanhGia.Text = "( "+dt.Rows.Count+" đánh giá)";
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
