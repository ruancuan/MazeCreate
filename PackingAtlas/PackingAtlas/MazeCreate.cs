using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingAtlas
{
    class MazeCreate
    {
        private int[,] mazeConfig=null;
        private int width = 0;
        private int height = 0;
        private List<Room> roomArray = new List<Room>();

        public MazeCreate(int width,int height)
        {
            mazeConfig = new int[width, height];
            this.width = width;
            this.height = height;
            //房间生成
            this.RoomGeneration();
            //道路生成
            this.RoadGeneration();
            //隔间生成
            this.DoorGeneration();
            //死胡同的去除
            this.ClearDeadEnd();
        }

        /// <summary>
        /// 房间的生成
        /// </summary>
        public void RoomGeneration()
        {
            roomArray = Room.createMazeRoom(width,height);
        }

        /// <summary>
        /// 道路的生成
        /// </summary>
        public void RoadGeneration()
        {

        }

        /// <summary>
        /// 隔间的生成
        /// </summary>
        public void DoorGeneration()
        {

        }

        /// <summary>
        /// 死胡同的去除
        /// </summary>
        public void ClearDeadEnd()
        {

        }

    }
}
