using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuonPhongUIT.Components
{
    public partial class Timetable : UserControl
    {
        RoomWeek roomWeek;
        public Timetable()
        {
            InitializeComponent();
            //// Label màu xanh được đặt theo quy tắc:
            ////      label + thứ (Mo,Tu,We,Th,Fr,Sa) + tiết
            ////      ví dụ: labelMo10 : tiết 10 thứ 2
            //// Nếu có tiết đổi sang màu xám/ đỏ... và hiện tên lớp
            //// Nếu có đăng ký mượn thì đổi sang màu vàng vad hiện tên lớp

            //// label tên phòng: labelTenPhong
            //// text của labelTenPhong là tên phòng

            //// label sức chứa: labelSucChua
            //// text của labelSucChua là "Sức chứa: "+sức chứa

            //// thực hiện query tìm ra được lịch học của phòng vào tuần này xx
            //// các trường dữ liệu cần thiết: thứ, lớp, tiết bắt đầu, tiết kết thúc 
            //// trong mỗi dòng dữ liệu:
            ////      thứ, lớp, tiết bắt đầu, tiết kết thúc được gáng cho 4 biến ở dưới
            //int thu = 2;
            //int tietBD = 1;
            //int tietKT = 2;
            //string lop = "CS115.N11";
            //string tenlabel = "";
            //if (thu == 2)
            //{
            //    tenlabel = "labelMo";
            //} 
            //else if (thu == 3)
            //{
            //    tenlabel = "labelTu";
            //} 
            //else if (thu == 4)
            //{
            //    tenlabel = "labelWe";
            //}
            //else if (thu == 5)
            //{
            //    tenlabel = "labelTh";
            //}
            //else if (thu == 6)
            //{
            //    tenlabel = "labelFr";
            //}
            //else if (thu == 7)
            //{
            //    tenlabel = "labelSa";
            //}
            //for (int i=tietBD; i<=tietKT; i++)
            //{
            //    tenlabel = tenlabel + i.ToString();
            //    Control[] control = this.Controls.Find(tenlabel, true);
            //    if (control != null)
            //    {

            //        control[0].Text = lop;
            //        control[0].BackColor = Color.Red;
            //    }
            //}    
            //// Tương tự như vậy với danh sách mượn phòng
            //// nhưng màu là màu vàng
               
        }
        public Timetable(RoomWeek roomWeek)
        {
            InitializeComponent();
            this.roomWeek = roomWeek;
            loadTable();
        }
        private void loadTable()
        {
            labelTenPhong.Text = roomWeek.room.thisRoomName;
            
            for (int ii = 0; ii <= 6; ii++)
            {
                string tenlabel = "";
                if (ii == 1)
                {
                    tenlabel = "labelMo";
                }
                else if (ii == 2)
                {
                    tenlabel = "labelTu";
                }
                else if (ii == 3)
                {
                    tenlabel = "labelWe";
                }
                else if (ii == 4)
                {
                    tenlabel = "labelTh";
                }
                else if (ii == 5)
                {
                    tenlabel = "labelFr";
                }
                else if (ii == 6)
                {
                    tenlabel = "labelSa";
                }
                if (roomWeek.tkb[ii] == "")
                {
                    continue;
                }
                string[] bd_kt = roomWeek.tkb[ii].Split('|');
                int tietBD = Convert.ToInt16(bd_kt[0]);
                int tietKT = Convert.ToInt16(bd_kt[1]);
                string malop = bd_kt[2];
                for (int i = tietBD; i <= tietKT; i++)
                {
                    string tenlabell = tenlabel + i.ToString();
                    Control[] control = this.Controls.Find(tenlabell, true);
                    if (control != null)
                    {
                        control[0].Text = malop;
                        control[0].BackColor = Color.DarkRed;
                    }
                }
            }
            
        }
    }
}
