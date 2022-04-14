using Practice_16.Task_2;
class Program
{
    static void Main()
    {
        Console.WriteLine("Вывод текста из файла");
        PrintFromTXT.Print();
        Console.WriteLine("--------------");
        int count = File.ReadAllLines("D:\\Practice16.txt").Length;
        Console.WriteLine($"Кол-во строк: {count}");
        Console.WriteLine("Кол-во символов в строке: ");
        Console.WriteLine("--------------");
        SymbolCount.SymCount();

        Console.ReadKey();
    }
}