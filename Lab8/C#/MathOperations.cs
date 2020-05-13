using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace OOP_LAB8
{
    class MathOperations
    {
        public delegate void Handler(object sender, EventHandler e);
        public event Handler Notify;
        
        public double Add(int x, int y)
        {
            double res= x + y;
            if (res == 0) Notify?.Invoke(this,new EventHandler("Res is equal to zero.Invokation from Add()"));
            return res;
        }
        public double Multiply(int x, int y)
        {
            double res= x * y;
            if (res == 0) Notify?.Invoke(this, new EventHandler("res is equal to zero.Invokation from Multiply()"));
            return res;
        }
        public double Substract(int x, int y)
        {
            double res= x - y;
            if (res == 0) Notify?.Invoke(this, new EventHandler("res is equal to zero.Invokation from Substract()"));
            return res;
        }
        public double Divide(int x, int y)
        {
            int res = 0;
            try
            {
                res = x / y;
            }
            catch (DivideByZeroException exp)
            {
                Console.WriteLine($"{exp.Message}");
            }
            if (res == 0) Notify?.Invoke(this, new EventHandler("res is equal to zero.Invokation from Divide()"));
            return res;
        }
        public double Sqrt(int x)
        {
            double res = 0;
            try
            {
                res = Math.Sqrt(x);
            }
            catch (ArgumentException exp)
            {
                Console.WriteLine($"{exp.Message}");
            }
            if (res == 0) Notify?.Invoke(this, new EventHandler("res is equal to zero.Invokation from Sqrt()"));
            return res;
        }
        public double Pow(int x,int p)
        {
           double res = Math.Pow(x,p);
            if (res == 0) Notify?.Invoke(this, new EventHandler("res is equal to zero.Invokation from Sqrt()"));
            return res;
        }
    }
}
