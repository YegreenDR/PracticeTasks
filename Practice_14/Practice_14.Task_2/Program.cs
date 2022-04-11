using System.Diagnostics;

static void mythread1()
{
    int sum = 0;
    for (int i = 0; i < 10; i++)
    {
        sum += i;
        Console.WriteLine("Поток 1 выводит " + sum);
    }
    
}

static void mythread2()
{
    int sum1 = 0;
    for (int i = 0; i < 10; i++)
    {
        sum1 += i;
        Console.WriteLine("Поток 2 выводит " + sum1);
    }
}

Stopwatch sWatch = new Stopwatch();
Thread thread1 = new Thread(mythread1);
Thread thread2 = new Thread(mythread2);
thread1.Priority = ThreadPriority.Highest;
thread2.Priority = ThreadPriority.AboveNormal;

sWatch.Start();
thread1.Start();
Thread.Sleep(1000);
sWatch.Stop();
thread2.Start();

Console.WriteLine("Время затраченное на первый поток (в мс.) = "+sWatch.ElapsedMilliseconds.ToString());
Console.ReadLine();


