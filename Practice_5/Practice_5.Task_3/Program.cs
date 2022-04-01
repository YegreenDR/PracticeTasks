using System;

namespace Practice_5.Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер квадратной матрицы: ");
            int r = Convert.ToInt16(Console.ReadLine());
            int[,] Matrix = new int[r, r];
            Random random = new Random();
            int rand;
            int count = 0;
            Console.WriteLine("Введите диапазон чисел (2 числа через Enter): ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    rand = random.Next(a, b);
                    Matrix[i, j] = rand;
                }
            }
            Console.WriteLine("Введите число поиска меньшего значения: ");
            int d = int.Parse(Console.ReadLine());
            int averageColumnSum = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    //count=Matrix[i, j] < d ? count++:;
                    if (Matrix[i, j] < d)
                    {
                        count++;
                    }
                    Console.Write($"{Matrix[i, j],5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Кол-во чисел меньше указанного: {count}");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    averageColumnSum += Matrix[j, i];
                }
            }
            Console.WriteLine($"average sum = {averageColumnSum}");
            Console.ReadKey();
        }
    }
}
