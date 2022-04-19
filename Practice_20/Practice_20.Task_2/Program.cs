double a = 2;
Task task1 = new Task(() =>
{
    double z1 = (Math.Cos(a) + Math.Sin(a)) / (Math.Cos(a) - Math.Sin(a));
    global::System.Console.WriteLine(z1);
});
Task task2 = new Task(() =>
{   
    double z2 = 2 * Math.Tan(a) + 2 * Math.Sin(a);
    global::System.Console.WriteLine(z2);
});
task1.Start();
task2.Start();
task1.Wait();
task2.Wait();