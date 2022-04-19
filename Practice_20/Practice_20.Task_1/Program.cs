Task task1 = new Task(() =>
{
    Console.Write("Введите число:");
    string str = Console.ReadLine();
    for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);
    Console.WriteLine();
});
task1.Start();
task1.Wait();