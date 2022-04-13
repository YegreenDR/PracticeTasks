using System.Collections;
using System.Collections.Generic;

        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("Evegniy", "Gus");
        myDict.Add("Vadim", "Vodila");
        myDict.Add("Daniil", "Bold");
        foreach (var item in myDict)
        {
            Console.Write($"{item.Key} | {item.Value}\n");
        }
        Console.WriteLine($"Количество пар: {myDict.Count}");
        Console.WriteLine("Выберите: ");
        var key = Console.ReadLine();
        Console.WriteLine($"{myDict[key]}");
        Console.ReadLine();