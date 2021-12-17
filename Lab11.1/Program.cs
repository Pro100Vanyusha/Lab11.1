using System;
using System.Collections.Generic;

namespace Lab11._1
{
    class Program
    {
        static string Replace(string str, int pos)
        {
            string _str = str.Substring(0, pos);
            for (int i = pos; i < str.Length; i++)
                _str += str[i] == '0' ? '1' : (str[i] == '1' ? '0' : str[i]);
            return _str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Replace("101010101010", 3));
            Console.ReadKey(true);
        }
    }
}
