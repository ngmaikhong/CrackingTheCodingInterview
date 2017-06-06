using System;
using System.Collections.Generic;
namespace K1
{
    public class __7
    {
        public static int[,] ChangedMatrix (int[,] matrix)
        {
            int[,] newmatrix = (int[,])matrix.Clone();
            HashSet<int> Spalte = new HashSet<int>();
            HashSet<int> Zeile = new HashSet<int>();

            for (int i = 0; i < matrix.GetLength(0);++i)
            {
                for (int j = 0; j < matrix.GetLength(1);++j)
                {
                    if (matrix[i,j]==0)
                    {
                        Spalte.Add(i);
                        Zeile.Add(j);
                    }
                }
            }
			for (int i = 0; i < matrix.GetLength(0); ++i)
			{
				for (int j = 0; j < matrix.GetLength(1); ++j)
				{
                    if (Spalte.Contains(i))
                    {
                        newmatrix[i, j] = 0;
                    }
                    if (Zeile.Contains(j))
                    {
                        newmatrix[i, j] = 0;
                    }
				}
			}

            return newmatrix;
        }
        public static void Main()
        {
            int[,] matrix = new int[2, 3] { { 0, 1, 0 }, { 2, 3, 4 } };
            int[,] ergebnis = ChangedMatrix(matrix);
			for (int i = 0; i < 2; ++i)
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
