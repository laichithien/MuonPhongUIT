using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuonPhongUIT.Components
{
    public class RoomWeek
    {
        public Room room;
        public string[] tkb = new string[7]; // index la thu, tietBD|tietKT|TenLop
        public RoomWeek()
        {
            room = new Room();
            for (int i = 0; i < 7; i++)
            {
                tkb[i] = "";
            }
}
        public RoomWeek(Room room, string[] tkb)
        {
            this.room = room;
            this.tkb = tkb;
        }
    }
}
