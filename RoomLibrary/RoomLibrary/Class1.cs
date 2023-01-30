using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLenght;
        double roomWidth;

        public double RoomLenght
        {
            get { return roomLenght; }
            set { roomLenght = value; }
        }

        public double RoonWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }

        public double RoomPerimetr()
        {
            return 2 * (roomLenght + roomWidth);
        }

        public double RoomArea()
        {
            return roomLenght * roomWidth;
        }

        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
    }

    
}
