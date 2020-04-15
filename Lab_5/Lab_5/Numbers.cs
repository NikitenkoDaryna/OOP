using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Numbers : _String
    {
        public _String s { get; set; }

       
        public Numbers(_String str)
        {
            s = str;
            
        }

        public override void Add(String str)
        {
            int len = s.Size;
            s.Size += str.Length * 2;
            char[] tmp = new char[s.Size];
            for (int i = 0; i <len; i++)
            {
                tmp[i] = s.Str[i];
            }
            int destIndex = s.Size - str.Length * 2;
            foreach (char c in str)
            {
                tmp[destIndex++] = c;
                tmp[destIndex++] = c;
            }
            s.Str = tmp;
        }

        public override int getSize()
        {
            Console.WriteLine("Class Numbers");
            return s.Size;
        }
    }
}
