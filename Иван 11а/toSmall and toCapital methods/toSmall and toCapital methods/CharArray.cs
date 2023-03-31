using System;
using System.Collections.Generic;
using System.Text;

namespace toSmall_and_toCapital_methods
{
    public class charArray
    {
        char[] el; int Length;
        public charArray()
        {
            el = new char[64];
            Length = 0;
        }
        public charArray(int n)
        {
            el = new char[n];
            Length = 0;
        }
        public charArray(string s)
        {
            int i;
            el = new char[s.Length + 1];
            this.Length = s.Length;

            for ( i = 0; i < s.Length; i++)
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
        public string toSamll()
        {
            string lowerCase_res = new string("");
            for (int i = 0; i < el.Length; i++)
            {
                if (el[i] == Char.ToLower(el[i]))
                {
                    el[i] = Char.ToUpper(el[i]);
                }
                lowerCase_res += el[i];
            }
            return lowerCase_res;
        }

        public string toCapital()
        {
            string upperCase_res = new string("");
            for (int i = 0; i < el.Length; i++)
            {
                if (el[i] == Char.ToUpper(el[i]))
                {
                    el[i] = Char.ToLower(el[i]);
                }
                upperCase_res += el[i];
            }
            return upperCase_res;
        }
    }
}
