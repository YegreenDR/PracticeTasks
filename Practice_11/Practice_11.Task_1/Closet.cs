using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_11.Task_1
{
    internal class Closet : Furniture
    {
        public double capacity;
        public string material;
        public double cost;
        public Closet()
        {
            this.capacity = 0;
            this.material = null;
            this.cost = 0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите объём шкафа в см:");
            capacity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите материал:");
            material = Console.ReadLine();
        }
        public virtual void CostCloset()
        { 
            cost = Math.Sqrt(capacity) * 0.75;
        }
        public override void GetInfo()
        {
            CostCloset();
            Console.WriteLine("Объём шкафа: {0} \nМатериал: {1} \nЦена: {2}",capacity,material,cost);
        }
    }
}
