using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PackingAtlas
{
    public class RandomTool
    {
        private Random rd;
        public Random Rd
        {
            get
            {
                if (rd == null)
                {
                    SetRandom();
                }
                return rd;
            }
        }

        private static RandomTool _Instance;
        public static RandomTool Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new RandomTool();
                return _Instance;
            }
        }

        public static long ConvertDateTimeToInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            long t = (time.Ticks - startTime.Ticks) / 10000;  //除10000调整为13位  
            return t;
        }

        public void SetRandom(int r=-1)
        {
            if (r == -1)
            {
                long ts = ConvertDateTimeToInt(DateTime.Now);
                rd = new Random();
            }
            else
            {
                rd = new Random(r);
            }
        }

        public Vec2 GetRandomRoom(int maxW=0,int minW=0,int maxH=0,int minH=0)
        {
            Vec2 vec;
            int minWidth = Math.Max(DataDefine.RoomMinWidth, minW);
            int maxWidth = Math.Min(DataDefine.RoomMaxWidth, maxW);
            int minHeight = Math.Max(DataDefine.RoomMinWidth, minH);
            int maxHeight = Math.Min(DataDefine.RoomMaxWidth, maxH);
            int width = GetRandomValue(minWidth, maxWidth);
            int height = GetRandomValue(minHeight, maxHeight);
            vec = new Vec2(width, height);
            return vec;
        }        

        public int GetRandomValue(int val1,int val2)
        {
            return rd.Next(val1, val2);
        }


    }
}
