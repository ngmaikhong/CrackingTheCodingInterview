using System;
namespace K1
{
    public class __3
    {
		public static int NummerofDuplicates(char a, string b)
		{
            int no = 0;
			for (int i = 0; i < b.Length; ++i)
			{
                if (b[i] == a) ++no;
			}
			return no ;
		}
        public static bool Permutation(string a, string b)
        {
            if (a.Length != b.Length) return false;
            for (char c = (char)0; c < (char)128; ++c) {
                if (NummerofDuplicates(c, a) != NummerofDuplicates(c, b))
                    return false;
            }
            return true;
        }

        public static int[] getCharacterCounts(string a) {
			int[] counts = new int[128];
			foreach (char c in a) {
				counts[c] += 1;
			}
            return counts;
        }

		public static bool PermutationAlternative(string a, string b) {
			int[] countsA = getCharacterCounts(a);
			int[] countsB = getCharacterCounts(b);
            for (int i = 0; i < countsA.Length; ++i) {
                if (countsA[i] != countsB[i]) {
                    return false;
                }
            }
            return true;
        }
        public static void Main()
        {
            Console.WriteLine("2 Strings");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (PermutationAlternative(a, b))
                Console.WriteLine("Permutation");
            else Console.WriteLine("keine Permutation");
            Console.ReadKey();
        }
    }
}
