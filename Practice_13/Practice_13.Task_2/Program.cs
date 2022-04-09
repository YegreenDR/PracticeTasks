class Program
{
    public delegate void NoParameters();
    delegate string Operation(string a, string b);

    static void Main()
    {

        NoParameters noprm = new(ShowMessage1);
        noprm += ShowMessage2;
        noprm += ShowMessage3;
        noprm();
        Console.ReadLine();
        DoOperation("Первое сообщение"," Второе сообщение" , Add);
    }
    static void ShowMessage1() => Console.WriteLine("Первое сообщение");
    static void ShowMessage2() => Console.WriteLine("Второе сообщение");
    static void ShowMessage3() => Console.WriteLine("Третье сообщение"); 
    static void DoOperation(string a, string b, Operation operation)
    {
        string res = a + b;
        Console.WriteLine(res);
    }
    static string Add(string a, string b)
    {
        return a + b;
    }

}