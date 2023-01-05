using MuonPhongUIT.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuonPhongUIT.Screens
{
    public partial class LichPhongScreen : Form
    {
        string state = "Tòa A";
        DateTime beginDateOfYear = new DateTime(2023, 03, 13);
        DateTime endDateOfYear = new DateTime(2023, 6, 17);
        DateTime beginDateOfFirstWeek;
        DateTime endDateOfFinalWeek;
        int numOfWeek = 0;
        DateTime beginDate;
        DateTime endDate;
        int currWeek;
        public LichPhongScreen()
        {
            InitializeComponent();
            loadWeekSelection();
            getBeginAndEndDayOfWeek();
            loadBuildingLabel();
            loadTable();
        }
        private void loadBuildingLabel()
        {
            buildingAButton.ForeColor = Color.White;
            buildingBButton.ForeColor = Color.White;
            buildingCButton.ForeColor = Color.White;
            buildingEButton.ForeColor = Color.White;
            playFieldButton.ForeColor = Color.White;
            switch (state.Trim()) 
            {
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
                    playFieldButton.ForeColor = Color.Gold;
                    break;
                default : break;
            }

        }
        private void getNumOfWeek()
        {
            int thuBD = (int)beginDateOfYear.DayOfWeek;
            int thuKT = (int )endDateOfYear.DayOfWeek;  
            beginDateOfFirstWeek = beginDateOfYear.AddDays(-thuBD);
            endDateOfFinalWeek = endDateOfYear.AddDays(6-thuKT);
            numOfWeek = ((endDateOfFinalWeek - beginDateOfFirstWeek).Days)/7 + 1;
        }
        private void loadWeekSelection()
        {
            string prefix = "Tuần ";
            getNumOfWeek();
            for (int i = 0; i <= numOfWeek; i++)
            {
                comboBox1.Items.Add(prefix + (i + 1).ToString());
            }
            comboBox1.SelectedIndex = 0;
            currWeek = comboBox1.SelectedIndex;
        }
        private void getBeginAndEndDayOfWeek()
        {

            DateTime begin = beginDateOfFirstWeek.AddDays(7*(currWeek));
            DateTime end = beginDateOfFirstWeek.AddDays(6 * (currWeek+1));
        }
        private void loadTable()
        {
            flowLayoutPanel1.Controls.Clear();

            string query = "select distinct PHONG.TENPHONG, SUCCHUA, TOA, LOAIPHONG, THU, TIETBD, TIETKT, MALOP FROM TKB RIGHT JOIN PHONG ON TKB.TENPHONG = PHONG.TENPHONG WHERE TOA LIKE '%"+state+"%'";
            Data_Provider dataProvider = new Data_Provider();
            DataTable dt = dataProvider.ExecuteQuery(query);
            string anchor = "";

            TimeTableHeader timeTableHeader = new TimeTableHeader();
            timeTableHeader.Anchor = AnchorStyles.Top;
            timeTableHeader.Location = new Point(flowLayoutPanel1.Width/2 - timeTableHeader.Width/2, timeTableHeader.Location.Y);

            panelTimeTableHeader.Controls.Add(timeTableHeader); 

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string TENPHONG = dt.Rows[i]["TENPHONG"].ToString();
                int SUCCHUA = Convert.ToInt16(dt.Rows[i]["SUCCHUA"]);
                string TOA = dt.Rows[i]["TOA"].ToString();
                string LOAIPHONG = dt.Rows[i]["LOAIPHONG"].ToString();
                
                if (TENPHONG.Trim() != anchor)
                {
                    RoomWeek rw = new RoomWeek();
                    rw.room.thisRoomName = TENPHONG;
                    rw.room.thisCapacity = SUCCHUA;
                    rw.room.thisRoomType = LOAIPHONG;
                    rw.room.thisBuilding = TOA;
                    
                    anchor = TENPHONG;
                    
                    while (anchor == TENPHONG && dt.Rows[i]["THU"] != DBNull.Value)
                    {

                        int thu = Convert.ToInt16(dt.Rows[i]["THU"]) - 1;
                        int tietBD = Convert.ToInt16(dt.Rows[i]["TIETBD"]);
                        int tietKT = Convert.ToInt16(dt.Rows[i]["TIETKT"]);
                        string malop = dt.Rows[i]["MALOP"].ToString();
                        rw.tkb[thu] = tietBD + "|" + tietKT + "|" + malop;
                        i++;
                        if (i == dt.Rows.Count)
                        {
                            break;
                        }
                        TENPHONG = dt.Rows[i]["TENPHONG"].ToString();
                    }
                    if (dt.Rows[i]["THU"] != DBNull.Value)
                    {
                        i--;   
                    }
                    Timetable timetable = new Timetable(rw);
                    timetable.Anchor = AnchorStyles.Top;
                    timetable.Location = new Point(flowLayoutPanel1.Width / 2 - timetable.Width / 2, timetable.Location.Y);


                    Panel timeTablePanel = new Panel();
                    timeTablePanel.Width = flowLayoutPanel1.Width;
                    timeTablePanel.Height = timetable.Height + 2;

                    timeTablePanel.Controls.Add(timetable);

                    flowLayoutPanel1.Controls.Add(timeTablePanel);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currWeek = comboBox1.SelectedIndex;
            getBeginAndEndDayOfWeek();
        }

        private void buildingSelected(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            state = lb.Text.Trim();
            loadBuildingLabel();
            loadTable();    
        }

        private void LichPhongScreen_ClientSizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = this.Width;
            header.Width = this.Width;
        }

        private void flowLayoutPanel1_ClientSizeChanged(object sender, EventArgs e)
        {
            foreach (var panel in flowLayoutPanel1.Controls.OfType<Panel>())
            {
                panel.Width= flowLayoutPanel1.Width;
            }
        }
    }
}
