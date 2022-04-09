public delegate string Stroka(string a);
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Введите действие: \n1 Перено строки после запятой \n2 Удалить первое слово  \n3 Замена точек на запятые.");
        string a = Console.ReadLine();
        Console.WriteLine("Введите строку: ");
        string x = Console.ReadLine();
        switch (a)
        {
            case "1":
                Stroka calc1 = (c) => c;
                string del1 = x.Replace(",", "\n");
                Console.WriteLine("Ответ:{0}", del1);
                break;
            case "2":
                Stroka calc = (c) => c;
                string del = x.Remove(0, x.IndexOf(' ') + 1);
                Console.WriteLine("Ответ:{0}", del);
                break;
            case "3":
                Stroka calc2 = (c) => c;
                string zamena = x.Replace(".", ",");
                Console.WriteLine("Ответ:{0}", zamena);
                break;
        }
        Console.ReadKey();
    }
}