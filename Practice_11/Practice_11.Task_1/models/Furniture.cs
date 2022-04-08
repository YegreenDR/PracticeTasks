using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_11.Task_1.models
{
    internal class Furniture
    {
        public string name;
        public Furniture()
        {
            this.name = null;
        }
        public virtual void Input()
        {
            Console.Write("Введите название мебели: ");
            name = Console.ReadLine();
        }
        public virtual void GetInfo()
        {
            Console.WriteLine("Название: {0}",name);
        }
    }
}
