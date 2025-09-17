using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Fig
{
    public class Rectangle
    {
        private Points TLPoint;
        private Points BRPoint;

        public Rectangle(Points TLPoint, Points BRPoint)
        {
            this.TLPoint = TLPoint;
            this.BRPoint = BRPoint;
        }

        public Points getTLPoint()
        {
            return TLPoint;
        }

        public Points getBRPoint()
        {
            return BRPoint;
        }

        public void addX(int X)
        {
            TLPoint.addX(X);
            BRPoint.addX(X);
        }

        public void addY(int Y)
        {
            TLPoint.addY(Y);
            BRPoint.addY(Y);
        }
    }
}
