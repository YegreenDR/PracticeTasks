using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10.Task_1
{
    internal class Field
    {
        private string name;
        private double s;
        private double semena;
        private double harvest;
        private double k;
        public Field()
        {
            name = null;
            k = 0;
            s = 0;
            semena = 0;
            harvest = 0;
            Input();
        }
        public virtual void AllHarvest()
        {
            harvest = k * semena;
        }
        public string Name { get { return name; } set { name = value; } }
        public double S { get { return s; } set { s = value; } }
        public double Semena { get { return semena; } set { semena = value; } }
        public double Harvest { get { return harvest; } set { harvest = value; } }
        public double K { get { return k; } set { k = value; } }

        public void Input()
        {
            Console.Write("Введите название картохи: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Введите площадь поля: ");
            s = double.Parse(Console.ReadLine());
            Console.Write("Введите вес семян: ");
            semena =  double.Parse(Console.ReadLine());
            Console.Write("Введите коэфициент: ");
            k = double.Parse(Console.ReadLine());
        }
    }
}
