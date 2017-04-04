using System;
using Tao.Sdl;

namespace Centipede
{
    class CentipedeBlock : Image
    {
        bool isMovingLeft = false;
        public CentipedeBlock(string fileName, short width, short height)
        : base(fileName, width, height)
        {
        }
        public void Move()
        {
            if (isMovingLeft)
            {
                if (GetX() == 0)
                {
                    isMovingLeft = false;
                    MoveTo(GetX(), (short) (GetY() + 25));
                }
                else
                {
                    MoveTo((short)(GetX() - 1), GetY());
                }
            }
            else
            {
                if (GetX() == 775)
                {
                    isMovingLeft = true;
                    MoveTo(GetX(), (short)(GetY() + 25));
                }
                else
                {
                    MoveTo((short)(GetX() + 1), GetY());
                }
            }
        }
    }
}