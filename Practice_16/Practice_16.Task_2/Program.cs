using Practice_16.Task_2;
class Program
{
    static void Main()
    {
        Console.WriteLine("Вывод текста из файла");
        PrintFromTXT.Print();
        Console.WriteLine("--------------");
        var filePath = @"D:\Practice16.txt";
        var filePath1 = @"D:\Practice16Dop.txt";
        int count = File.ReadAllLines(filePath).Length;
        Console.WriteLine($"Количество строк: {count}");
        var numbers = SymbolCount.SymCount(filePath);
        Console.Write($"Количество символов в строке: {numbers}");
        Console.WriteLine("\nУдаление последней строки и запись результата в другой файл");
        DeleteString.DeleteStringAndWrite(filePath, filePath1);
        Console.WriteLine("--------------");

        Console.ReadKey();
    }
}