using System;
using System.Text;
namespace K1
{
    public class __4
    {
        public static StringBuilder Replace(string a)
        {
            StringBuilder mystring = new StringBuilder(a);
            if (a.Contains(" "))
            {
                mystring.Replace(" ", "%20");
            }
            return mystring;
        }

        public static void Main()
        {
            Console.WriteLine("string");
            string a = Console.ReadLine();
            Console.WriteLine(Replace(a).ToString());
            Console.ReadKey();
        }
    }
}
