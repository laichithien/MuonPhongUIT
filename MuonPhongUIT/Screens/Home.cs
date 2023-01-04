using MuonPhongUIT.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuonPhongUIT
{
    public partial class Home : Form
    {
        bool sidebarExpand = false;
        string sidebarState = "Mượn phòng";
        private Form activeForm = null;
        public Home()
        {
            InitializeComponent();


            Variables.ListFormPanel.ListFormsPanel.Add(containPanel);
            containPanel.Controls.Clear();


            //MuonPhongScreen muonPhongScreen = new MuonPhongScreen();
            //openChildForm(muonPhongScreen);
            loadPanels();
            loadSelectedSidebar();
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 4;
                containPanel.Width = this.Width - sidebar.Width;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
                sidebar.Width += 4;
                containPanel.Width = this.Width - sidebar.Width;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer1.Stop();
                }
            }
        }

        private void Home_ClientSizeChanged(object sender, EventArgs e)
        {
            containPanel.Width = this.Width - sidebar.Width;

            sidebar.Height = this.Height - sidebar.Location.Y;
        }
        private void loadPanels()
        {
            sidebar.Width = 0;
            containPanel.Width = this.Width - sidebar.Width;
        }

        private void sidebarMouseEnter(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.ForeColor = Color.Gold;
        }
        private void loadSelectedSidebar()
        {
            switch (sidebarState.Trim())
            {
                case "Mượn phòng":
                    MuonPhongScreen muonPhongScreen = new MuonPhongScreen();
                    openChildForm(muonPhongScreen);
                    muonPhongOption.ForeColor = Color.Purple;
                    break;
                case "Xem lịch phòng":

                    break;
                case "Báo cáo hư hại":

                    break;

                default: break; 
            }
        }
        private void sidebarMouseLeave(object sender, EventArgs e)
        {
            Label lb = (Label)(sender);
            if (lb.Text.Trim() == sidebarState.Trim())
            {
                lb.ForeColor = Color.Purple;
            }
            else lb.ForeColor = Color.Black;
        }

        private void sidebarSelect(object sender, EventArgs e)
        {
            Label lb = (Label)(sender);
            sidebarState = lb.Text;
            loadSelectedSidebar();
        }
    }
}
