using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    //віртуальні функції обчислення довжини і 
    class _String
    {
       
       
        public int Size{ get; set;}
       public char[] Str { get; set;}

        public virtual void Add(String str)
        {
            Size += str.Length;
            char[] tmp = new char[Size];
            for (int i =0;i<Str.Length;i++)
            {
                tmp[i] = Str[i];
            }
            for (int i = Size - str.Length , k = 0; i < tmp.Length; i++)
            {
                tmp[i] = str[k++];
            }
            Str = tmp;
        }
        public _String()
        {
            Str= new char[0];
        }
        public void PrintStr()
        {
            String res = "";
            for (int i =0;i<Size;i++)
            {
                res+= Str[i]+"";
            }
            Console.WriteLine(res);
        }
        public virtual int getSize()
        {
            return Size;
        }
    }
}
