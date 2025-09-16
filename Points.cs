using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Fig
{
    public class Points
    {
        private int X;
        private int Y;

        public Points(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int getX()
        {
            return X;
        }

        public int getY()
        {
            return Y;
        }

        public void addX(int x)
        {
            X += x;
        }

        public void addY(int y)
        {
            Y += y;
        }
    }
}
