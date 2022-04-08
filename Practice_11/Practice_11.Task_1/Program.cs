namespace Practice_11.Task_1;

class Program
{
    static void Main(string[] args)
    {
        Closet closet = new Closet();
        Furniture furniture = new Furniture();
        Sofa sofa = new Sofa();
        Console.WriteLine("Выберите что сделать: ");
        Console.WriteLine("1. Мебель \n2.Шкаф \n3.Диван");
        int i = 0;
        i = int.Parse(Console.ReadLine());
        switch (i)
        {
            case 1:
                furniture.GetInfo();
                break;
            case 2:
                closet.GetInfo();
                break;
            case 3: sofa.GetInfo();
                break;
        }
    }
}
