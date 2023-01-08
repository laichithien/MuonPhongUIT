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
        public double STARS;
        public int LUOTXEM;

        public Room(string rname = "", int capa = 0, string type = "", string buil = "", double stars = 0, int luotxem = 0)
        {
            thisRoomName = rname;
            thisCapacity = capa;
            thisBuilding = buil;
            thisRoomType = type;
            STARS = stars;
            LUOTXEM = luotxem;
        }
    }
}
