using Practice_15.Task_1;
    static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();
        for (int i = 0; i < 10; i++)
        {
            myList.Add(i);
        }
        foreach (var item in myList)
        {
            Console.Write($"{item},");
        }
        var count = myList.count;
        Console.WriteLine($"\nКоличество элементов: {count} \n3й элемент: {myList[2]}");
        Console.ReadLine();
    }