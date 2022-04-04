using System;
using System.Linq;

namespace Practice_8.Task_1
{
    internal class Program
    {

        
            static void Main(string[] args)
            {
                AEROFLOT[] masAERO = new AEROFLOT[7];
                for (int i = 0; i < masAERO.Length; i++)
                {
                    Console.WriteLine("Введите данные по {0}-ому рейсу:", i + 1);
                    Console.Write("Пункт назначения:");
                    masAERO[i].destination = Console.ReadLine();
                    Console.Write("Номер рейса:");
                    masAERO[i].number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Тип самолёта:");
                    masAERO[i].typeOfAircraft = Console.ReadLine();
                }
                masAERO = masAERO.OrderBy(x => x.destination).ToArray(); 
                string tp = "";
                bool had = false;
                do
                {
                    Console.WriteLine("\nВведите тип самолёта, обслуживаемого рейсы, данные по которым нужно узнать");
                    tp = Console.ReadLine();
                    Console.WriteLine("\nДанные по рейсам, обслуживаемых самолётом типа: {0}", tp);

                    for (int i = 0; i < masAERO.Length; i++)
                    {
                        if (tp == masAERO[i].typeOfAircraft)
                        {
                            Console.WriteLine("Пункт назначения: {0}", masAERO[i].destination);
                            Console.WriteLine("Номер рейса назначения: {0}", masAERO[i].number);
                            had = true;
                        }
                    }
                    if (!had)
                    {
                        Console.WriteLine("Не существует рейсов, обслуживаемых типом самолёта: {0}", tp);
                    }
                    Console.WriteLine("\nПродолжить работу? (y/n)");
                }
                while (Console.ReadLine() != "n");
            }
            public struct AEROFLOT
            {
                public string destination;
                public int number;
                public string typeOfAircraft;
            }
        }
    }

