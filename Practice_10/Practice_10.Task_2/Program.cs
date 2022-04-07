namespace Practice_10.Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A classA = new A();
            B classB = new B(5);
            Console.WriteLine("Class A, write C = {0}",classA.c);
            Console.WriteLine("Class B, write c2 = {0}", classB.c2);
        }
    }
}