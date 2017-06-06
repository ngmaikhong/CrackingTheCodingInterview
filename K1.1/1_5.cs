using System;
using System.Text;
using System.Collections.Generic;
namespace K1
{
    public class __5
    {
        public static string Compression(string a)
        {
            StringBuilder mystring = new StringBuilder();
            for (int i = 0; i < a.Length; ++i)
            {
                int e = 1;
                while ((i+1<a.Length)&&(a[i] == a[i + 1]))
                {
                    ++e;
                    ++i;
			    }
                mystring.Append(a[i]);
                mystring.Append(e.ToString());
            }
            if (mystring.ToString().Length > a.Length)
                       return a;
            else return mystring.ToString();
        }
        public static void Main()
        {
            Console.WriteLine("string");
            string a = Console.ReadLine();
            Console.WriteLine(Compression(a));
            Console.ReadKey();
        }
    }
}
