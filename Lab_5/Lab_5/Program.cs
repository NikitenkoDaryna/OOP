using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Coordinate t1 = new Coordinate(-5d, 0d);
            Coordinate t2 = new Coordinate(-4d, 3d);
            Coordinate t3 = new Coordinate(-2d, 3d);
            Coordinate t4 = new Coordinate(0d, 0d);
            Coordinate h= new Coordinate(0d, 3d);
            Trapez trapez = new Trapez(t1,t2,t3,t4,h);
            trapez.PrintPerimeter();
            trapez.PrintSquare();
            _String _str1 = new _String();
            _str1.Add("Hello");
            _str1.Add("My");
            _str1.Add("Apple");
            _str1.PrintStr();
            Console.WriteLine("Size:"+_str1.Size);
            _String _str2 = new _String();
            Numbers numbers = new Numbers(_str2);
            numbers.Add("hi");
            numbers.Add("bii");
            numbers.s.PrintStr();
            Console.WriteLine("Numbers' Size:"+numbers.getSize());
            _String _str3 = new _String();
            _Char _char = new _Char(_str3);
            _char.Add("aladu");
            _char.Add("APAkA");
            _char.s.PrintStr();
            Console.WriteLine("_Char Size:"+_char.s.Size);
            Console.ReadLine();
            
        }
    }
}
