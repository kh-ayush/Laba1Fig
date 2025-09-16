using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Fig
{
    public class Rectangle
    {
        private Points startPoint;
        private int width;
        private int height;

        public Rectangle(Points startPoint, int width, int height)
        {
            this.startPoint = startPoint;
            this.width = width;
            this.height = height;
        }

        public Points getStartPoint()
        {
            return startPoint;
        }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
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
