using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingAtlas
{
    class Program
    {
        private static MazeCreate maze=null;
        

        static void Main(string[] args)
        {
            //房间生成
            maze = new MazeCreate(1000,800);

        }
    }
}
