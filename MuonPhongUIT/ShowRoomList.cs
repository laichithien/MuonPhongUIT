using MuonPhongUIT.Components;
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
    public partial class ShowRoomList : Form
    {
        public ShowRoomList()
        {
            InitializeComponent();
            load();
        }
        public ShowRoomList(string query)
        {
            InitializeComponent();

            loadWithQuery(query);
        }
        private void loadWithQuery(string query)
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
        private void load()
        {
            string query = "select * from PHONG";
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
    }
}
