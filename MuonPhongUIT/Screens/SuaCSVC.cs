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
    public partial class SuaCSVC : Form
    {
        public SuaCSVC()
        {
            InitializeComponent();
        }

        private void tatCa_Click(object sender, EventArgs e)
        {
            tatCa.ForeColor = Color.Red;
            chuaGiaiQuyet.ForeColor = Color.Black;
            daGiaiQuyet.ForeColor = Color.Black;
        }

        private void daGiaiQuyet_Click(object sender, EventArgs e)
        {
            tatCa.ForeColor = Color.Black;
            chuaGiaiQuyet.ForeColor = Color.Black;
            daGiaiQuyet.ForeColor = Color.Red;
        }

        private void chuaGiaiQuyet_Click(object sender, EventArgs e)
        {
            tatCa.ForeColor = Color.Black;
            chuaGiaiQuyet.ForeColor = Color.Red;
            daGiaiQuyet.ForeColor = Color.Black;

        }
    }
}
