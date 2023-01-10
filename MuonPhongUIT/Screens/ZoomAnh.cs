﻿using System;
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
    public partial class ZoomAnh : Form
    {
        private static int w, h,i=0;
        private Image[] img;
        public ZoomAnh(Image[] image)
        {
            InitializeComponent();
            w = pictureBoxImage.Width;
            h = pictureBoxImage.Height;
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
            w = pictureBoxImage.Width;
            h = pictureBoxImage.Height;
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
            w = pictureBoxImage.Width;
            h = pictureBoxImage.Height;
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
