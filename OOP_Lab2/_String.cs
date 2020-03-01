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
        public char[] excludedChars = new char[] { ',', '.', ';', ':', ' ' };

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
        public char[] DeleteFirstandLast(char ch, char[] s)
        {
            //int k = FindIndex(s);
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch && (i == 0 || i == s.Length - 1)) continue;
                count++;
            }
            var temp = new char[count];
            for (int i = 0, p = 0; i < s.Length; i++)
            {
                if (s[i] == ch && (i == 0 || i == s.Length - 1)) continue;
                temp[p++] = chars[i];
            }
            chars = temp;
            return chars;
        }
        public int CalcLetters(char[] chars)
        {
            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != ' ') count++;

            }
            return count;
        }
        public char[] DeleteExtraSpaces(char[] chars)
        {
            chars = chars.Where((c, i) => !(char.IsWhiteSpace(c) && char.IsWhiteSpace(chars.ElementAtOrDefault(++i)))).ToArray();
            chars = chars.Where((c, i) => !(char.IsWhiteSpace(c) && char.IsPunctuation(chars.ElementAtOrDefault(++i)))).ToArray();
            this.chars = chars;
            return chars;
        }
        public int CalcConsonants(char[] chars)
        {
            int count = 0;
            char[] consonats = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z' };
            foreach (char ch in chars)
            {
                Char.ToLower(ch);
            }
            for (int i = 0; i < consonats.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (consonats[i] == chars[j]) count++;
                }
            }
            return count;
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
            }
            public void DeleteByIndex(int index, bool all)
            {
                var temp = new _String[this.myText.Length - 1];
                if (!all)
                {
                    for (int i = 0, k = 0; i < this.myText.Length; i++)
                    {
                        if (i == index) continue;
                        temp[k++] = this.myText[i];
                    }
                    this.myText = temp;
                }
                else
                {
                    for (int i = 0; i < this.myText.Length; i++)
                    {
                        this.myText[i] = new _String(new char[] { ' ' });
                    }
                }
            }
            private void Concat(char[] chars)
            {
                _String[] temp = new _String[MyText.Length + 2];
                for (int i = 0; i < MyText.Length; i++)
                    temp[i] = MyText[i];
                temp[temp.Length - 2] = new _String(chars);
                //разделитель в тексте
                temp[temp.Length - 1] = new _String(new char[] { ' ' });
                MyText = temp;
            }
            public int FindMinLenOfStr()
            {
                var lens = new int[this.myText.Length / 2];
                for (int i = 0, k = 0; i < this.myText.Length; i++)
                {
                    if (CalcLetters(myText[i].Chars) == 0) continue;
                    lens[k++] = CalcLetters(myText[i].Chars);
                }
                //Find min value
                int min = lens[0];
                for (int i = 0; i < lens.Length; i++)
                {
                    if (lens[i] < min) min = lens[i];
                }
                return min;
            }
            public void deleteExtraSpaces(_String str)
            {
                str.DeleteExtraSpaces(str.Chars);
            }
            public _String[] MyText { get => myText; set => myText = value; }
            public void DeleteFirstAndLastSpace(_String str)
            {

                str.DeleteFirstandLast(' ', str.Chars);
            }
            public double FindPercentageOfConsonants()
            {
                int letters = 0;
                int consonants = 0;
                double percentage = 0;
                for (int i = 0; i < this.myText.Length; i++)
                {
                    letters += CalcLetters(myText[i].Chars);
                }
                for (int i = 0; i < this.myText.Length; i++)
                {
                    consonants += CalcConsonants(myText[i].Chars);
                }
                percentage = (consonants * 100.0) / letters;
                return percentage;

            }
            public override string ToString()
            {
                string str = "";
                foreach (var s in MyText)
                {
                    foreach (var let in s.Chars)
                    {
                        str += let;
                    }
                }
                return str;
            }
        }  
}
