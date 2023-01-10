using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MuonPhongUIT.Screens
{
    public partial class ZoomAnh : Form
    {
        private static int w, h,i=0;
        private Image[] img;
        public ZoomAnh(Image[] image)
        {
            InitializeComponent();
            w = 520;
            h = 600;
            img = image;
            Size newSize = new Size(w, h);
            Bitmap bmp = new Bitmap(img[0], newSize);
            pictureBoxImage.Image = bmp;
        }

        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            if (i == 2)
                i = 0;
            else
                i++;
            w = 520;
            h = 600;
            Size newSize = new Size(w, h);
            Bitmap bmp = new Bitmap(img[i], newSize);
            pictureBoxImage.Image = bmp;
        }

        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {
            if (i == 0)
                i = 2;
            else
                i--;
            w = 520;
            h = 600;
            Size newSize = new Size(w, h);
            Bitmap bmp = new Bitmap(img[i], newSize);
            pictureBoxImage.Image = bmp;
        }

        private void pictureBoxImage_MouseClick(object sender, MouseEventArgs e)
        { 
            if (e.Button == MouseButtons.Left)
            {
                Size newSize = new Size((int)(w * 2), (int)(h * 2));
                Bitmap bmp = new Bitmap(pictureBoxImage.Image, newSize);
                pictureBoxImage.Image = bmp;
                w = pictureBoxImage.Image.Height;
                h = pictureBoxImage.Image.Width;
            }
            else if (e.Button == MouseButtons.Right)
            {
                Size newSize = new Size((int)(w / 2), (int)(h / 2));
                Bitmap bmp = new Bitmap(pictureBoxImage.Image, newSize);
                pictureBoxImage.Image = bmp;
                w = pictureBoxImage.Image.Height;
                h = pictureBoxImage.Image.Width;
            }    
        }
    
    }
}
