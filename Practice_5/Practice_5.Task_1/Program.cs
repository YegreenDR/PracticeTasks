using System;

namespace Practice_5.Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random((int)DateTime.Now.Ticks);
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100, 201);
                Console.Write("{0}, ", arr[i]);
                if (min > arr[i])
                {
                    min = arr[i];

                }
            }
            Console.WriteLine("\n min={0}", min);
            Console.WriteLine("Индекс минимального числ: " + Array.IndexOf(arr, min));
        }
    }
}
