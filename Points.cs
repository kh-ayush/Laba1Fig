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

    public class Triangle
    {
        private Points p1;
        private Points p2;
        private Points p3;

        public Triangle(Points p1, Points p2, Points p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Points getP1()
        {
            return p1;
        }

        public Points getP2()
        {
            return p2;
        }

        public Points getP3()
        {
            return p3;
        }

        public void addX(int X)
        {
            p1.addX(X);
            p2.addX(X);
            p3.addX(X);
        }

        public void addY(int Y)
        {
            p1.addY(Y);
            p2.addY(Y);
            p3.addY(Y);
        }
    }

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
