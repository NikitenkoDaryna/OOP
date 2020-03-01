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

            _String str = new _String(new char[] {'c','a','t'});
            Console.WriteLine("Create string:");
            printStr(str.Chars);
            Console.WriteLine("\nUsing text");
            _String s = new _String(new char[] {'d','o','g'});
            _String s2 = new _String(new char[] {'c','o','w'});
            Text text = new Text(s.Chars);
            text.Add(str);
            text.Add(s);
            text.Add(s2);
            //Console.WriteLine("Before:"+str.Chars.Length);
           // text.DeleteFirstAndLastSpace(str);
            //Console.WriteLine("After:"+str.Chars.Length);
           //text.DeleteByIndex(2,false);
            Console.WriteLine(text.ToString());
            //str.CalcConsonants(new char[] { 'h', 'e', 'l', 'l', 'o' });
            // Console.WriteLine(text.ToString());
            // text.FindMinLenOfStr();
            // text.DeleteFirstAndLastSpace(str);
            // printStr(str.Chars);
            Console.WriteLine("\nPercentage of consonants:"+text.FindPercentageOfConsonants()+"%");
            //text.deleteExtraSpaces(str);
           // printStr(str.Chars);
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
