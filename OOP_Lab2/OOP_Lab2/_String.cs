using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class _String
    {
        public _String() { }
        private int length = 0;
        private char[] chars = new char[0];

        public char[] Chars { get => chars; set => chars = value; }
        public int Length { get => length; set => length = value; }

        public _String(char[] chars)
        {
            this.chars = new char[chars.Length];
            this.length += chars.Length;
            for (int i = 0; i < chars.Length; i++)
            {
                this.chars[i] = chars[i];
            }

        }

        //public void Add(char[] str)
        //{
        //    int n = this.Length;
        //    this.length+= str.Length;
        //    int k = this.length - n - 1;

        //    Array.Resize(ref this.chars,this.length);
        //    int p = 0;
        //    for (int i =k;i<this.length;i++)
        //    {
        //        this.chars[i] = str[p++];
        //    }

        //}
        public int FindIndex(char[] str)
        {
            int k = 0;
            int index = -1;
            for (int i = 0; i < this.length; i++)
            {
                if (this.chars[i] == str[0])
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (this.chars[i] == str[j]) k++;
                    }
                }
                if (k == str.Length) { index = i; return index; }

            }
            return index;
        }
        public void Delete(char[] s)
        {
            int k = FindIndex(s);
            Array.Resize(ref this.chars, k);
        }
    }
    public class Text : _String
    {
        private _String[] myText = new _String[] { };
        public Text()
        {
        }
        //indexator
        public _String this[int index]
        {
            get { return myText[index]; }

            set
            {
                myText[index] = value;
            }
        }
        public Text(char[] chars) : base(chars)
        {
            Add(new _String(chars));    
        }
        public void Add(_String str)
        {
            this.Concat(str.Chars);
            this.Concat(new char[] { ' ' });
            //String s = new String(str.Chars);
            //int n = this.length;
            //this.length+= 2;
            //Array.Resize(ref this.text, this.length);
            //this.text[n] = " ";
            //this.text[n + 1] = s;

        }

        private void Concat(char[] chars)
        {
            _String[] temp = new _String[MyText.Length + 1];
            for (int i = 0; i < MyText.Length; i++) 
               temp[i] = MyText[i];
            temp[temp.Length - 1] = new _String(chars);
            MyText = temp;
        }

        
        public int FindMinLenOfStr()
        {
            int min = -1;
            int k = 0;
            return min;
            
        }
        

        private static char[] excludedChars = new char[]{',','.',';',':',' ' };

        public _String[] MyText { get => myText; set => myText = value; }

        public override string ToString()
        {
            string str = "";
            foreach(var s in MyText)
            {
                foreach(var let in s.Chars)
                {
                    str += let;
                }
            }
            return str;
        }
    }
}
