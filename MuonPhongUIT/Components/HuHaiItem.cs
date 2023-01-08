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
    public partial class HuHaiItem : UserControl
    {
        string tenGV;
        string noidung;
        DateTime ngayBaoCao;
        bool tinhTrang;
        public HuHaiItem()
        {
            InitializeComponent();
        }
        public HuHaiItem(string tenGV, string noidung, DateTime ngayBaoCao, bool tinhTrang)
        {
            InitializeComponent();
            this.tenGV = tenGV;
            this.noidung = noidung;
            this.ngayBaoCao = ngayBaoCao;
            this.tinhTrang = tinhTrang;

            tenGVLabel.Text = tenGV;
            noiDung.Text = noidung;
            ngayBaoCaoLabel.Text = ngayBaoCao.ToString("dd-MM-yyyy");
            if ( tinhTrang )
            {
                tinhTrangLabel.Text = "Đã giải quyết";
                tinhTrangLabel.ForeColor = Color.Green;
            }
            else
            {
                tinhTrangLabel.Text = "Chưa giải quyết";
                tinhTrangLabel.ForeColor = Color.Red;
            }
        }
    }
}
