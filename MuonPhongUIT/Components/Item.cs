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
    public partial class Item : UserControl
    {
        Data_Provider dataProvider = new Data_Provider();
        Room room;
        private Form activeForm = null;
        public Item()
        {
            InitializeComponent();
        }
        public Item(Room r)
        {
            InitializeComponent();
            room = r;

            roomName.Text = r.thisRoomName;
            capacity.Text = r.thisCapacity.ToString();
            building.Text = r.thisBuilding;
            roomType.Text = r.thisRoomType;
            luotxem.Text = r.LUOTXEM.ToString();
            loadStar();
        }
        private void loadStar()
        {
            string query = "select STARS from COMMENTS where TENPHONG like N'%" + room.thisRoomName + "%'";
            DataTable dt = dataProvider.ExecuteQuery(query);
            int sum = 0;
            for (int i =0; i < dt.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dt.Rows[i]["STARS"]);
            }
            int star = 0;
            if (dt.Rows.Count != 0)
            {

                star = sum / dt.Rows.Count;
            }
            labelStar.Text = "";
            for (int i = 0;i < star; i++)
            {
                labelStar.Text += "★";
            }
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(childForm);
            Variables.ListFormPanel.ListFormsPanel[0].Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Item_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.CornflowerBlue;
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(58, 108, 181);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            RoomDetail roomDetail = new RoomDetail(room);
            openChildForm(roomDetail);
        }
    }
}
