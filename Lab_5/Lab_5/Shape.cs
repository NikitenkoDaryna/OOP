using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Shape
    {
        //for quadrangle
        Coordinate _c1 = new Coordinate(0d,2d);
        Coordinate _c2 = new Coordinate(1d,-3d);
        Coordinate _c3 = new Coordinate(2d,4d);
        Coordinate _c4 = new Coordinate(5d,-10d);
        public Shape(Coordinate c1,Coordinate c2,Coordinate c3,Coordinate c4)
        {
            _c1 = c1;
            _c2 = c2;
            _c3 = c3;
            _c4 = c4;

        }
        public double FindSideLength(Coordinate a,Coordinate b)
        {
            Coordinate c = new Coordinate(b.X-a.X,b.Y-a.Y);
            double res = Math.Sqrt(Math.Pow(c.X,2)+Math.Pow(c.Y,2));
            return res;
        }

    }
}
