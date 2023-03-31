using System;
using System.Collections.Generic;
using System.Text;

namespace FinfingNumbers
{
    class CharArray
    {
        char[] el; int Length;
        public CharArray()
        {
            el = new char[64];
            Length = 0;
        }
        public CharArray(int n)
        {
            el = new char[n];
            Length = 0;
        }
        public CharArray(string s)
        {
            int i;
            el = new char[s.Length + 1];
            this.Length = s.Length;

            for (i = 0; i < s.Length; i++)
            {
                this.el[i] = s[i];
            }


        }
        public string ToString12()
        {
            string res = new string("");
            for (int i = 0; i < this.Length; i++)
            {
                res = res + this.el[i];
            }
            return res;
        }

        public string NumberToStar()
        {
            string new_res = new string("");
            for (int i = 0; i < el.Length; i++)
            {
                if (Char.IsDigit(el[i]))
                {
                    el[i] = '*';
                }
                new_res += el[i];
            }
            return new_res;
        }
    }
}
