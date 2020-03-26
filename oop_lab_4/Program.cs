using System;
using System.Runtime.CompilerServices;

namespace oop_lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //var 12
            Rectangle rectangle1 = new Rectangle(0, 0, 0, 5, 4, 5, 4, 0);
            Rectangle rectangle2 = new Rectangle(rectangle1);
            Rectangle rectangle3 = new Rectangle();
            double P = rectangle1.ReturnPerimeter();
            double S = rectangle1.ReturnArea();
            Console.WriteLine("S:" + S + " P:" + P );
            Rectangle rrectangle2 = rectangle2 / 2;
            Console.WriteLine("rectangle2 after /2"+rrectangle2.ReturnArea());
           Rectangle rrectangle3=rectangle3-rrectangle2;
           Console.WriteLine("Before:"+rectangle1.X1);
           rectangle1 += rrectangle3;
           Console.WriteLine(rectangle1.X1);

        }
    }

    class Rectangle
    {
        private double x1, y1;
        private double x2, y2;
        private double x3, y3;
        private double x4, y4;

        public double X1
        {
            get => x1;
            set => x1 = value;
        }

        public double Y1
        {
            get => y1;
            set => y1 = value;
        }

        public double X2
        {
            get => x2;
            set => x2 = value;
        }

        public double Y2
        {
            get => y2;
            set => y2 = value;
        }

        public double X3
        {
            get => x3;
            set => x3 = value;
        }

        public double Y3
        {
            get => y3;
            set => y3 = value;
        }

        public double X4
        {
            get => x4;
            set => x4 = value;
        }

        public double Y4
        {
            get => y4;
            set => y4 = value;
        }


        public Rectangle()
        {
            this.x1 = -2;
            this.y1 = 0;
            this.x2 = -2;
            this.y2 = 2;
            this.x3 = 3;
            this.y3 = 2;
            this.x4 = 3;
            this.y4 = 0;
        }

        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
        }

        public Rectangle(Rectangle previousRectangle)
        {
            previousRectangle.x1 = 0d;
            previousRectangle.x2 = 0d;
            previousRectangle.x3 = 0d;
            previousRectangle.x4 = 5d;
            previousRectangle.y1 = 3d;
            previousRectangle.y2 = 5d;
            previousRectangle.y3 = 3d;
            previousRectangle.y4 = 0d;
        }

        public double ReturnPerimeter()
        {
            double p = ReturnSide(x1, y1, x2, y2);
            double q = ReturnSide(x1, y1, x4, y4);
            return 2 * p + 2 * q;
        }

        public double ReturnArea()
        {
            return ReturnSide(x1, y1, x2, y2) * ReturnSide(x1, y1, x4, y4);
        }

        private double ReturnSide(double x1, double y1, double x2, double y2)
        {
            double a = x2 - x1;
            double b = y2 - y1;
            double ab = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return ab;
        }

        public static Rectangle operator /(Rectangle rec, double divisor )
        {
            rec.x1 /= divisor;
            rec.x2 /= divisor;
            rec.x3 /= divisor;
            rec.x4 /= divisor;
            rec.y1 /= divisor;
            rec.y2 /= divisor;
            rec.y3 /= divisor;
            rec.y4 /= divisor;
            return new Rectangle(rec.x1, rec.y1, rec.x2, rec.y2, rec.x3, rec.y3, rec.x4, rec.y4);
        }

        public static Rectangle operator -(Rectangle rec3, Rectangle rec2)
        {
            return new Rectangle(rec3.x1 - rec2.x1, rec3.y1 - rec2.y1, rec3.x2 - rec2.x2, rec3.y2 - rec2.y2,
                rec3.x3 - rec2.x3, rec3.y3 - rec2.y3,
                rec3.x4 - rec2.x4, rec3.y4 - rec2.y4);
        }
       public static Rectangle operator +(Rectangle rec1,Rectangle c)
       {
           rec1.x1 += c.x1;
           rec1.x2 += c.x2;
           rec1.x3 += c.x3;
           rec1.x4 += c.x4;
           rec1.y1 += c.y1;
           rec1.y2+=c.y2;
           rec1.y3 += c.y3;
           rec1.y4 += c.y4;
           return new Rectangle(rec1.x1,rec1.y1,rec1.x2,rec1.y2,rec1.x3,rec1.y3,rec1.x4,rec1.y4);
       }
   
    }
}