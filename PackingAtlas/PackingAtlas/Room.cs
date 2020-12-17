using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingAtlas
{
    public class Room
    {
        public int x = 0;
        public int y = 0;
        public int width = 0;
        public int height = 0;

        private int roomCreateInterval = 5;

        public void getRealRoomPosition()
        {
            x += roomCreateInterval;
            y += roomCreateInterval;
            width -= 2 * roomCreateInterval;
            height -= 2 * roomCreateInterval;
        }
                       
        public static List<Room> createMazeRoom(int totalWidth,int totalHeight)
        {

            return null;
        }
    }
}
