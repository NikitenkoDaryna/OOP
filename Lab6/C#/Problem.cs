using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB6
{
    class Problem
    {
        private double a;
        private double b;
        private double c;
        private double d;
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public double D { get => d; set => d = value; }
        public Problem(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            
        }
        public Problem()
        {

        }
        private double Lg()
        {
            double p = 0d;     
            try
            {
                p = 4 * b - c;
                if (p <=0)
                    throw new ArgumentException();
            }
            catch(Exception exp)
            {
                Console.WriteLine($"Argument of log10  must be positive.Error: {exp.Message}");
            }
            return Math.Log10(p);
        }
        
       private double Multiply()
        {
            return Lg() * a;
        }
        public static double operator /(Problem val1,double val2)
        {
            var t = 0d;
            try
            {
                
                if (val2 == 0 )
                    throw new DivideByZeroException();
                t = val1.c / val2;
            }
            catch (DivideByZeroException exp)
            {
                Console.WriteLine($"Error occured: {exp.Message}");
                
            }

            return t;
        }
        public static double operator *(Problem val1,double val2)
        {
            var t = 0d;
            if (val1 == null) val1 = new Problem();
            try
            {
                
               if ((val1.b + val1 / val2 - 1) == 0)
                    throw new DivideByZeroException();
                t = val1.Multiply() * (1 / (val1.b + val1 / val2 - 1));
            }
            catch (DivideByZeroException exp)
            {
                Console.WriteLine($"Error occured: {exp.Message}");
            }
            catch(NullReferenceException exp)
            {
                Console.WriteLine($"Error occured: {exp.Message}");
            }
            return t;
        }
       
       
    }
}
