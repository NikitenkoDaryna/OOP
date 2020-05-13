using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace OOP_LAB8
{ //var14
    class Program
    {
        delegate int del();
        delegate void message();
        static int res1, res2 = 0;
        
        static void Main(string[] args)
        {
            del _del1 = List.FindNumOfSymbs2;
            List lst = new List("HHHEerwerHET");
            del _del2= lst.FindNumOfSymbs1;
             res1 = _del1();
             res2 = _del2();
            message m = Message1;
            Console.WriteLine("result of delegates:"+res2);
            if (res1!=0)
            {
               m = new message(Message2);
                m();
            }
            if (res2 != 0)
            {
                 m = new message(Message1);
                m();
            }
            MathOperations math = new MathOperations();
            math.Notify += DisplayMessage;
            math.Add(2,-2);
            math.Divide(0,3);

            Console.ReadKey();
        }
        private static void Message1()
        {

            Console.WriteLine("Return number of uppercase letters from object method");
        }
        private static void Message2()
        {
            Console.WriteLine("Return number of uppercase letters from static method");
        }
        private static void DisplayMessage(object sender, EventHandler e)
        {
            
            Console.WriteLine(e.Message);
        }
    }

}
