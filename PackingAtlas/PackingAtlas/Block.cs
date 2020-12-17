using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingAtlas
{
    public class Block
    {
        public int x;
        public int y;
        public int width;
        public int height;

        public Block(int xV,int yV,int w,int h)
        {
            x = xV;
            y = yV;
            width = w;
            height = h;
        }

        public Vec2 LeftUpVec2()
        {
            return new Vec2(x,y);
        }

        public Vec2 LeftDownVec2()
        {
            return new Vec2(x, y + height);
        }

        public Vec2 RightDownVec2()
        {
            return new Vec2(x + width, y + height);
        }

        public Vec2 RightUpVec2()
        {
            return new Vec2(x + width, y);
        }

        public bool Contain(Block block)
        {
            Vec2 left= block.LeftUpVec2();
            bool leftBool = left.x - x >= 0 && left.y - y >= 0;
            Vec2 right = block.RightDownVec2();
            bool rightBool = right.x - x >= 0 && right.y - y >= 0;
            return leftBool && rightBool;
        }

        public bool JudgeRange(Vec2 vec)
        {
            if(vec.x>=LeftUpVec2().x && vec.x <= RightUpVec2().x)
            {
                if (vec.y>=LeftDownVec2().y && vec.y<=RightDownVec2().y)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Block> removeIntersect(Block block)
        {
            List<Block> list = new List<Block>();

            return list;
        }
    }
}
