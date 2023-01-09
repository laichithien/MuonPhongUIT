using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace MuonPhongUIT.Screens
{
    public partial class ThemPhong : Form
    {       
        public ThemPhong()
        {
            InitializeComponent();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChon1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAnh1.Image  = new Bitmap(op.FileName);
                pictureBoxAnh1.Name = op.FileName;
                
            }    
        }

        private void buttonChon2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAnh2.Image = new Bitmap(op.FileName);
                pictureBoxAnh2.Name = op.FileName;

            }
        }

        private void buttonChon3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAnh3.Image = new Bitmap(op.FileName);
                pictureBoxAnh3.Name = op.FileName;

            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxTenPhong.Text!="" && textBoxSucChua.Text!=""&&comboBoxLoaiPhong.Text!=""&&comboBoxToa.Text!=""&&pictureBoxAnh1.Name!=""&& pictureBoxAnh2.Name != ""&& pictureBoxAnh2.Name != "")
            {
                //copy ảnh trong 3 picturebox vào tên folder ảnh
                //với tên lần lượt là tenphong.png tenphong.1.png tenphong.1.png
                // lưu thông tin vào cơ sở dữ liệu
                
                this.Close();
            }    
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }    
        }
    }
}
