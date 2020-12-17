using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingAtlas
{
    public class DataDefine
    {
        public static int RoomMinWidth = 20;
        public static int RoomMaxWidth = 50;
        public static int RoomMinHeight = 20;
        public static int RoomMaxHeight = 50;
    }

    public class Vec2
    {
        public int x;
        public int y;
        public Vec2(int xVal=0,int yVal=0)
        {
            x = xVal;
            y = yVal;
        }
        
    }
}
