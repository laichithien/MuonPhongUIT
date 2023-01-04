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
        public Timetable()
        {
            InitializeComponent();
            // Label màu xanh được đặt theo quy tắc:
            //      label + thứ (Mo,Tu,We,Th,Fr,Sa) + tiết
            //      ví dụ: labelMo10 : tiết 10 thứ 2
            // Nếu có tiết đổi sang màu xám/ đỏ... và hiện tên lớp
            // Nếu có đăng ký mượn thì đổi sang màu vàng vad hiện tên lớp

            // label tên phòng: labelTenPhong
            // text của labelTenPhong là tên phòng

            // label sức chứa: labelSucChua
            // text của labelSucChua là "Sức chứa: "+sức chứa

            // thực hiện query tìm ra được lịch học của phòng vào tuần này xx
            // các trường dữ liệu cần thiết: thứ, lớp, tiết bắt đầu, tiết kết thúc 
            // trong mỗi dòng dữ liệu:
            //      thứ, lớp, tiết bắt đầu, tiết kết thúc được gáng cho 4 biến ở dưới
            int thu = 2;
            int tietBD = 1;
            int tietKT = 2;
            string lop = "CS115.N11";
            string tenlabel = "";
            if (thu == 2)
            {
                tenlabel = "labelMo";
            } 
            else if (thu == 3)
            {
                tenlabel = "labelTu";
            } 
            else if (thu == 4)
            {
                tenlabel = "labelWe";
            }
            else if (thu == 5)
            {
                tenlabel = "labelTh";
            }
            else if (thu == 6)
            {
                tenlabel = "labelFr";
            }
            else if (thu == 7)
            {
                tenlabel = "labelSa";
            }
            for (int i=tietBD; i<=tietKT; i++)
            {
                tenlabel = tenlabel + i.ToString();
                Control[] control = this.Controls.Find("labelMo1", true);
                if (control != null)
                {

                    control[0].Text = lop;
                    control[0].BackColor = Color.Red;
                }
            }    
            // Tương tự như vậy với danh sách mượn phòng
            // nhưng màu là màu vàng
               
        }
   

    
    }
}
