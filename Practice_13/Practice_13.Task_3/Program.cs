delegate void MyInfoStateHandler(string message);
class MyInfo
{
    string _name;
    public event MyInfoStateHandler Adding;
    public event MyInfoStateHandler Added;
    public MyInfo(string name)
    {
        _name = name;
    }
    public void AddLetter(string name)
    {
        Adding($"Будет добавлена буква а: {name}");
        name += "a";
        Added($"Была добавлена буква а: {name}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyInfo info = new MyInfo("Владислав");
        info.Adding += Display;
        info.Added += Display;
        info.AddLetter("Владислав");
    }
    static void Display(string message) => Console.WriteLine(message);
}

