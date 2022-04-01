using System;

namespace Pracice_5.Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 23;
            const int m = 40;
            int c = 0;
            int[,] Matrix = new int[n, m];
            Random random = new Random();
            int rand;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    rand = random.Next(0, 2);
                    Matrix[i,j] = rand;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                    if (Matrix[0,i] == 0)
                    {
                        c++;
                    }
            }
            Console.WriteLine($"Число свободных мест в первом ряду: {c}");
        }
    }
}
