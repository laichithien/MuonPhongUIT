using MuonPhongUIT.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuonPhongUIT.Screens
{
    public partial class MuonPhongScreen : Form
    {
        string state = "Tất cả";
        private Form activeForm = null;
        string query = "";
        public MuonPhongScreen()
        {
            InitializeComponent();
            reloadAllForm();

        }
        private void reloadRoomList()
        {
            query = "select * from PHONG";
            loadRoomList();
        }
        private void loadRoomList()
        {
            Data_Provider provider = new Data_Provider();
            DataTable dt = provider.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string tenphong = dt.Rows[i]["TENPHONG"].ToString();
                int succhua = Convert.ToInt32(dt.Rows[i]["SUCCHUA"]);
                string loaiphong = dt.Rows[i]["LOAIPHONG"].ToString();
                string toa = dt.Rows[i]["TOA"].ToString();
                string baocao = dt.Rows[i]["BAOCAOHUHAI"].ToString();
                Room room = new Room(tenphong, succhua, toa, loaiphong);
                Item item = new Item(room);
                roomListContainer.Controls.Add(item);
            }
        }
        public void reloadAllForm()
        {
            reloadPeriod();
            resetBarSelected();
            reloadRoomList();
        }
        public void reloadPeriod()
        {
            fromPeriod.SelectedIndex = 0;
            toPeriod.SelectedIndex = 9;
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
        private void activateFilterButton_Click(object sender, EventArgs e)
        {
            if (fromPeriod.SelectedIndex > toPeriod.SelectedIndex)
            {
                MessageBox.Show("Tiết bắt đầu phải nhỏ hơn tiết kết thúc!!");
                return;
            }
            roomListContainer.Controls.Clear();
            string date = dateTimeFilter.Value.ToString("yyyy-MM-dd");
            int dayOfWeek = (int)dateTimeFilter.Value.DayOfWeek + 1;
            int from = fromPeriod.SelectedIndex + 1;
            int to = toPeriod.SelectedIndex + 1;
            query = "select distinct TKB.TENPHONG, SUCCHUA, LOAIPHONG, TOA, BAOCAOHUHAI from TKB inner join PHONG on TKB.TENPHONG = PHONG.TENPHONG where TKB.NGAYBD <= '"+date+ "' and '"+date+"' < TKB.NGAYKT and TKB.TENPHONG not in (select TENPHONG from TKB where (THU = "+dayOfWeek+" and (TIETBD >= "+from+ " and TIETBD <= "+to+") or (TIETKT >= "+from+" and TIETKT <= "+to+")))";
            string conditionCapa = " and SUCCHUA >= " + fromCapa.Text;
            
            string conditionAirConditioner = "";
            if (isAirConditioner.Checked == true)
            {
                conditionAirConditioner = " and (LOAIPHONG in ('CLC', 'PM', 'E-Learning', N'Hội trường', N'PM học tiếng Nhật', 'TTNN') or TKB.TENPHONG like '%E%')";
            }

            string conditionProjector = "";
            if (oneProjectorOption.Checked == true)
            {
                conditionProjector = " and SUCCHUA < 100";
            }
            else if (twoProjectorOption.Checked == true)
            {
                conditionProjector = " and SUCCHUA >= 100";
            }

            
            string condition0 = " and TOA like N'"+ state +"'";
            if (state.Trim() == "Tất cả")
            {
                condition0 = "";
            }
            //query += condition1 + condition2 + condition0;
            query += condition0 + conditionCapa + conditionAirConditioner + conditionProjector;

            loadRoomList();
        }

        private void buildingOption_Click(object sender, EventArgs e)
        {
            roomListContainer.Controls.Clear();


            Label lb = (Label)sender;
            state = lb.Text;
            resetBarSelected();
            query = "select * from PHONG where TOA like N'" + lb.Text + "'";
            reloadFilter();
            loadRoomList();
        }
        private void reloadFilter()
        {
            reloadPeriod();
            fromCapa.Value = 0;
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

        private void All_Click(object sender, EventArgs e)
        {
            roomListContainer.Controls.Clear();


            Label lb = (Label)sender;
            state = lb.Text;
            resetBarSelected();
            query = "select * from PHONG where TOA like N'" + "'";
            reloadFilter();
            loadRoomList();
        }

        private void projectorClicked(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            if (rd.Checked == true) { rd.Checked = false; }
            else if (oneProjectorOption.Checked == false && twoProjectorOption.Checked == false)
            {
                rd.Checked = true;
            }
            else 
            {
                if (oneProjectorOption.Checked == false)
                {
                    oneProjectorOption.Checked = true;
                    twoProjectorOption.Checked = false;
                }
                else if (twoProjectorOption.Checked == false)
                {
                    oneProjectorOption.Checked = false;
                    twoProjectorOption.Checked = true;
                }
            }
        }
    }
}
