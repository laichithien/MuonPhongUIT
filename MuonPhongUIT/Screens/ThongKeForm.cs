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
        string state = "Tất cả";
        private Form activeFrom = null;
        string query = "";
        public ThongKeForm()
        {
            InitializeComponent();
            resetBarSelected();
            
        }
        private void resetBarSelected()
        {
            All.ForeColor = Color.White;
            buildingAButton.ForeColor = Color.White;
            buildingBButton.ForeColor = Color.White;
            buildingCButton.ForeColor = Color.White;
            buildingEButton.ForeColor = Color.White;
            playField.ForeColor = Color.White;

            switch (state)
            {
                case "Tất cả":
                    All.ForeColor = Color.Gold;
                    break;
                case "Tòa A":
                    buildingAButton.ForeColor = Color.Gold;
                    break;
                case "Tòa B":
                    buildingBButton.ForeColor = Color.Gold;
                    break;
                case "Tòa C":
                    buildingCButton.ForeColor = Color.Gold;
                    break;
                case "Tòa E":
                    buildingEButton.ForeColor = Color.Gold;
                    break;
                case "Sân tập":
                    playField.ForeColor = Color.Gold;
                    break;
                default:
                    break;
            }
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

        private void buildingOption_Click(object sender, EventArgs e)
        {
            //roomListContainer.Controls.Clear();


            Label lb = (Label)sender;
            state = lb.Text;
            resetBarSelected();
            query = "select * from PHONG where TOA like N'" + lb.Text + "'";
            //reloadFilter();
            //loadRoomList();
        }

        private void All_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            state = lb.Text;
            resetBarSelected();
            query = "select * from PHONG where TOA like N'" + "'";
        }
    }
}
