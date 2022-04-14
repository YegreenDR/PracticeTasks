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
        int i = 1;
        foreach (var num in numbers)
        {
            Console.WriteLine($"Кол-во символов в {i} строке: {num.ToString()}");
            i++;
        }
        Console.WriteLine("\nУдаление последней строки и запись результата в другой файл");
        DeleteString.DeleteStringAndWrite(filePath, filePath1);
        Console.WriteLine("--------------");
        S1toS2.GetStringsS1ToS2(filePath, 1, 3);
        LongestString.GetLongestString(filePath);
        GetStringFirstLetter.GetLineWithFirstLetter(filePath, 'в');
        ReverseOutput.PrintToFileReverseLinesInfile(filePath);
        Console.ReadKey();
    }
}