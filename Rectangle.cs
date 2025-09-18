using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Fig
{
    public class Rectangle
    {
        private Points p00;
        private Points p01;
        private Points p10;
        private Points p11;

        public Rectangle(Points TLPoint, Points BRPoint)
        {
            p00 = TLPoint;
            p11 = BRPoint;
            p01=new Points(p00.getX(),p11.getY());
            p10=new Points(p11.getX(),p00.getY());
        }

        public List<Points> getPoints()
        {
            return new List<Points> { p00, p01, p11, p10 }; 
        }

        public void addX(int X)
        {
            p00.addX(X);
            p11.addX(X);
            p01.addX(X);
            p10.addX(X);
        }

        public void addY(int Y)
        {
            p00.addY(Y);
            p11.addY(Y);
            p01.addY(Y);
            p10.addY(Y);
            
        }
    }
}
