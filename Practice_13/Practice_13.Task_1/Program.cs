class Program
{
    public delegate void NoParameters();

    static void Main()
    {
        NoParameters noprm = new(ShowMessage1);
        noprm += ShowMessage2;
        noprm += ShowMessage3;
        noprm();
        Console.ReadLine();
    }
    private static void ShowMessage1() => Console.WriteLine("Первое сообщение");
    private static void ShowMessage2() => Console.WriteLine("Второе сообщение");
    private static void ShowMessage3() => Console.WriteLine("Третье сообщение");
}