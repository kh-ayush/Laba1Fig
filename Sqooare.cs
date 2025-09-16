using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Laba1Fig
{
    public class Square
    {
        private Points startPoint;
        private int side;

        public Square(Points startPoint, int side)
        {
            this.startPoint = startPoint;
            this.side = side;
        }

        public Points getStartPoint()
        {
            return startPoint;
        }

        public int getSide() 
        {
            return side;
        }

        public void addX(int X)
        {
            startPoint.addX(X);
        }

        public void addY(int Y)
        {
            startPoint.addY(Y);
        }
    }
}
