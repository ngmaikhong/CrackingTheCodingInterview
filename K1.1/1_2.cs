using System;
namespace K1
{
    public class A1_2
    {
        public static void Reverse(string b){
            string a="";
            for (int i = b.Length - 1; i >= 0;--i){
                a += b[i];
            }
            Console.WriteLine(a);
        }
        public static void Reverse2(string b){
            int j = 0;
            char c = ' ';
            char[] a = b.ToCharArray();
			for (int i = b.Length - 1; j < i; --i)
			{
				// swap(b[i], b[j])
				c = a[i];
                a[i] = a[j];
                a[j] = c;
                ++j;
			}
            string s = new string(a);
            Console.WriteLine(s);
        }
		public static void Main()
		{
            Console.WriteLine("string ist");
            string b = Console.ReadLine();
            Reverse2(b);
            Console.ReadKey();
		}
    }

}
