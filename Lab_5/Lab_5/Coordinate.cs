using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Coordinate
    {
        public double X { get; set; } = 0d;
        public double Y { get; set; } = 0d;
        public Coordinate(double x,double y)
        {
            X = x;
            Y = y;
        }
        public Coordinate()
        {

        }
    }
}
