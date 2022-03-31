using System;

namespace Practice_5.Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            int sum = 0;
            int CountOtr = 0;
            int CountZero = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-10,10);
                Console.Write("Массив: ");
                Console.Write($"{arr[i]} ");
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
                else if (arr[i] < 0)
                {
                    CountOtr++;
                }
                else if (arr[i] == 0)
                {
                    CountZero++;
                }
                
            }
            Array.Sort(arr);
            Console.WriteLine("Отсортированный начальный массив: ", arr);
            Console.WriteLine("Введите число для поиска: ");
            int k = int.Parse(Console.ReadLine());
            int SortIndexSearch = Array.BinarySearch(arr, k);
            Console.WriteLine(SortIndexSearch);
            Console.WriteLine($"Сумма всех положительных элементов: {sum}");
            Console.WriteLine($"Кол-во отрицательных элементов: {CountZero}");
            Console.WriteLine($"Кол-во нулевых элементов: {CountOtr}");
        }
    }
}
