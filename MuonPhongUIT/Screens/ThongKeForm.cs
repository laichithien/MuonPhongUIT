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
    public partial class ThongKeForm : Form
    {
        public ThongKeForm()
        {
            InitializeComponent();
        }

        private void luotXem_Click(object sender, EventArgs e)
        {
            luotXem.ForeColor = Color.Red;
            danhGia.ForeColor = Color.Black;
            huHong.ForeColor = Color.Black;
            // kiểm tra comboBox1.SelectedIndex
            // nếu 0 thì giảm dần
            // 1 thì tăng dần thực hiện select 
        }

        private void danhGia_Click(object sender, EventArgs e)
        {
            // số sao
            luotXem.ForeColor = Color.Black;
            danhGia.ForeColor = Color.Red;
            huHong.ForeColor = Color.Black;
            // kiểm tra comboBox1.SelectedIndex
            // nếu 0 thì giảm dần
            // 1 thì tăng dần thực hiện select 
        }

        private void huHong_Click(object sender, EventArgs e)
        {
            luotXem.ForeColor = Color.Black;
            danhGia.ForeColor = Color.Black;
            huHong.ForeColor = Color.Red;
            // kiểm tra comboBox1.SelectedIndex
            // nếu 0 thì giảm dần
            // 1 thì tăng dần thực hiện select 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                // sắp giảm dần theo lựa chọn lượt xem/ đánh giá/ hư hại
            }
            else
            {
                // sắp giảm dần theo lựa chọn lượt xem/ đánh giá/ hư hại
            }    
        }
    }
}
