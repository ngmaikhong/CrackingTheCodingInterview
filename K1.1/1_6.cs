using System;
using System.Collections.Generic;
namespace K1
{
    public class __6
    {
        public static int[,] Rotate(int[,] matrix)
        {
            int[,] ergebnis = new int[3, 3];
            for (int i = matrix.GetLength(0) - 1; i >= 0; --i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    ergebnis[i, j] = matrix[matrix.GetLength(0) - 1 - j, i];
                }
            }
            return ergebnis;
        }
        public static void Main()
        {
            int[,] matrix = new int[3, 3] { { 4, 5, 6 }, { 7, 8, 9 }, { 2, 3, 4 } };
            int[,] ergebnis = Rotate(matrix);

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    Console.Write(ergebnis[i, j]);
                }
                Console.WriteLine();

            }
        }
    }
}
