using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class _Char : _String
    {
        public  _String s {get;set;}
        public _Char(_String str)
        {
            s = str;
        }
        public override void Add(String str)
        {
            int k = 0;
            int len = s.Size;
            for (int i =0;i<str.Length;i++)
            {
                if (str[i]=='k')  
                    k++;
            }
            s.Size += str.Length+k;
            char[] tmp = new char[s.Size];
            for (int i = 0; i < len; i++)
            {
                tmp[i] = s.Str[i];
            }
            int destIndex = s.Size - str.Length - k;
            foreach (char c in str)
            {
                tmp[destIndex++] = c;
                if (c == 'k'|| c=='K') tmp[destIndex++] = c;
               
                
            }
            s.Str = tmp;
        }
        public  override int getSize()
        {
            Console.WriteLine("Class _Char");
            return s.Size;
        }
    }
}
