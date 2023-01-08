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
    public partial class Comment : UserControl
    {
        string tenGV;
        string noidung;
        DateTime ngayBinhLuan;
        double star;
        public Comment()
        {
            InitializeComponent();
            // LabelName = tên
            // LabelStar = sao
            // LabelComment = cmt
            // LabelDate = Ngày cmt
        }
        public Comment(string tenGV, string noidung, DateTime ngayBinhLuan, double star)
        {
            InitializeComponent();
            this.tenGV = tenGV;
            this.noidung = noidung;
            this.ngayBinhLuan = ngayBinhLuan;
            this.star = star;
            labelName.Text = tenGV;
            labelComment.Text = noidung;
            labelDate.Text = ngayBinhLuan.ToString("dd-MM-yyyy");
            labelStar.Text = "";
            for (int i = 0; i < star; i++)
            {
                labelStar.Text += "★";
            }
        }
    }
}
