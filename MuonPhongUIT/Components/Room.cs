using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuonPhongUIT
{
    public class Room
    {
        public string thisRoomName;
        public int thisCapacity;
        public string thisBuilding;
        public string thisRoomType;

        public Room(string rname = "", int capa = 0, string buil = "", string type = "")
        {
            thisRoomName = rname;
            thisCapacity = capa;
            thisBuilding = buil;
            thisRoomType = type;
        }
    }
}
