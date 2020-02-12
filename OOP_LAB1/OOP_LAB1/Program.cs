using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int tmp = a;
            int b = 4;
            Console.WriteLine("is " +a+" equal to "+b+"? "+EqualNumbers(a,b));
            Add(ref a, b);
            Console.WriteLine("a=" + tmp + "\n" + "b=" + b + "\n" + "a+b=" + a + "\n");
            Console.ReadKey();
        }
        static bool EqualNumbers(int a, int b)
        {
            int isEqual=1;
            if (Convert.ToBoolean((a ^ b) )) isEqual = 0;
            return Convert.ToBoolean(isEqual);
        }
        static void Add( ref int a, int b)
        {
            while (!EqualNumbers( b,0))
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }  
        }
    }
}
