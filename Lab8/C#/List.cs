using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOP_LAB8
{
    class List
    {
        public static string STR { get; private set; }
        public static int LENGTH { get; private set; }
        public List(string str)
        {
            STR = str;
            LENGTH = str.Length;
        }
        public List() { }
        //ordinary version for counting UpperCase letters
        public int FindNumOfSymbs1()
        {
            int counter = 0;
            for (int i = 0; i < LENGTH; i++)
            {
                if (Char.IsUpper(STR[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
       
        //static version for counting UpperCase letters
        public static int FindNumOfSymbs2()
        {
            int counter = 0;
            for (int i = 0; i < STR.Length; i++)
            {
                if (Char.IsUpper(STR[i]))
                {
                    counter++;
                }
            }

            return counter;

        }

    }
}
