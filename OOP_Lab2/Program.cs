using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
namespace OOP_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            _String str = new _String(new char[] { 'h','e','l','l','o'});
            Console.WriteLine("Create string:");
            printStr(str.Chars);
           // Console.WriteLine("Adding a string:");
            //printStr(str.Chars);
            //Console.WriteLine("Find index:"+str.FindIndex(new char[] {'l'}));
            //str.Delete(new char[] { 'l'});
            //Console.WriteLine("\nAfter delete:");
          //  printStr(str.Chars);
            Console.WriteLine("\nUsing text");
            //create text
            //Text text = new Text(str.Chars);
            //String[] txt = text.getText;
           // printText(txt);
            _String s = new _String(new char[] { 'c','a','t'});
            Text text = new Text(s.Chars);
            text.Add(s);
            text.Add(s);
            text.Add(str);
            
            
            Console.ReadKey();
            
        }
        static void printStr(char[] str)
        {
            foreach (char ch in str)
            {
                Console.Write(ch);
            }
        }
        //static void printText(Text text)
        //{
        //    foreach (char ch in text)
        //    {
        //        Console.Write(ch);
        //    }

        //}
        
    }
}
