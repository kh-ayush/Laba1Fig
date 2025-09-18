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
        private Points p00;
        private Points p01;
        private Points p11;
        private Points p10;
        private int storona;

        public Square(Points startPoint, int side)
        {
            p00 = startPoint;
            storona = side;
            p01=new Points(p00.getX()+storona, p00.getY());
            p10 = new Points(p00.getX(), p00.getY()+storona);
            p11 = new Points(p00.getX()+storona, p00.getY() + storona);
        }

        public List<Points> getPoints()
        {
            return  new List <Points> {p00,p01,p11,p10};
        }

        public void addX(int X)
        {
            p00.addX(X);
            p01.addX(X);
            p10.addX(X);
            p11.addX(X);
        }

        public void addY(int Y)
        {
            p00.addY(Y);
            p01.addY(Y);
            p10.addY(Y);
            p11.addY(Y);
        }
    }
}
