using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _5_.OOP_Glava_6
{
    public static class MyStr 
    {
        public static int CountDigital(this string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch=str[i];
                try
                {
                    int value = int.Parse(ch.ToString());
                    count++;
                }
                catch { }
            }
            return count;
        }
    }
}
