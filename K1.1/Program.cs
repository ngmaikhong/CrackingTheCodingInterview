using System;
using System.Collections.Generic;

namespace K1
{
    class MainClass
    {
        public static bool Unique(string a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = i + 1; j < a.Length; ++j)
                {
                    if (a[i] == a[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("gib String ein");
            string a = Console.ReadLine();
            if (Unique(a)) {
                Console.WriteLine("Unique");
            }
            else {Console.WriteLine("nicht unique");}
            Console.ReadKey();
        }
    }
}
