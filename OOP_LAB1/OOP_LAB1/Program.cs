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
            int b = 4;
            int tmp = a;
            Console.WriteLine("is " +a+" equal to "+b+"? "+EqualNumbers(a,b));
            Add(ref a, b);
            Console.WriteLine("a=" + tmp + "\n" + "b=" + b + "\n" + "a+b=" + a + "\n");
           // a = 3;
           // b = 4;
            Add2(ref a,b);
         //   Console.WriteLine(a);       
            Console.ReadKey();
        }
        static bool EqualNumbers(int a, int b)
        {
            int aa, bb, ii;
            int equal = 0;
            for (int i =sizeof(int)*8;i>0;i--)
            {
                ii=i >> 1;
                aa = a & i;
                bb = b & i;
                if(!Convert.ToBoolean(aa ^ bb))
                {
                    equal = 1;
                }
                else
                {
                    equal = 0;
                }
            }
            return Convert.ToBoolean(equal);
            
        }
        static void Add( ref int a, int b)
        {
            while (b!=0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }  
        }
        static void Add2(ref int a,int b)
        {
            int result = 0;
            int abit, bbit, cbit = 0, nbit;
            int last_bit = sizeof(int) * 8;
            for (int n =0;n<last_bit;n++)
            {
                nbit =  1 << n;
                abit = a & nbit;
                bbit = b & nbit;
                if (Convert.ToBoolean(abit ^ bbit))
                {
                    result |= ~cbit & nbit;
                }
                else if (Convert.ToBoolean(abit))
                {
                    result |= cbit;
                    cbit = nbit;
                }
                else
                {
                    result |= cbit;
                    cbit = 0;
                }
                cbit <<=1;
               
            }
            a = result;
        }
    }
}
