using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Trapez : Shape
    {
        Coordinate s1 = new Coordinate(-5d, 5d);
        Coordinate s2 = new Coordinate(-34d, 3d);
        Coordinate s3 = new Coordinate(-2d, 3d);
        Coordinate s4 = new Coordinate(0d, 3d);
        Coordinate s5 = new Coordinate(0.25d, 3d);
        public Trapez(Coordinate c1, Coordinate c2, Coordinate c3, Coordinate c4,Coordinate h) : base(c1, c2, c3, c4)
        {
            s1 = c1;
            s2 = c2;
            s3 = c3;
            s4 = c4;
            s5 = h;
        }
       
        public double ReturnPerimeter()
        {
            double a = FindSideLength(s1,s2);
            double b = FindSideLength(s2,s3);
            double c = FindSideLength(s3,s4);
            double d = FindSideLength(s4,s1);
            double res = a + b + c + d;
            return res;
        }
        public double ReturnSquare()
        {
            double h = Math.Sqrt(Math.Pow(s5.X,2)+Math.Pow(s5.Y,2));
            double b = FindSideLength(s2, s3);
            double d = FindSideLength(s4, s1);
            double m = (b+ d) / 2;
            return m * h;

        }
        public void PrintPerimeter()
        {
            Console.WriteLine("Trapez perimeter:"+ReturnPerimeter());
        }
        public void PrintSquare()
        {
            Console.WriteLine("Trapez square:" + ReturnSquare());
        }
    }
}
