using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Fig
{
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

        public List<Points> getPoints()
        {
            return new List<Points> { p1, p2, p3 };
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
}
