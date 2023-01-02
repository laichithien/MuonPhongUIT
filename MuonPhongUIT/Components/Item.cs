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
            this.BackColor = Color.FromArgb(218, 228, 238);
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            RoomDetail roomDetail = new RoomDetail();
            openChildForm(roomDetail);
        }
    }
}
