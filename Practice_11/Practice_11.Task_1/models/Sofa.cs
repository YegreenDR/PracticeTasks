using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_11.Task_1.models

{
    internal class Sofa : Furniture
    {
        public double s;
        public string material;
        public string corner;
        public double cost;
        public Sofa()
        {
            this.s = 0;
            this.material = null;
            this.corner = null;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите площадь дивана: ");
            s = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите материал: ");
            material = Console.ReadLine();
            Console.Write("Диван будет угловым? y/n ");
            corner = Console.ReadLine();
            if ((corner == "Y")| (corner == "y")) { corner = "True"; } 
            else if ((corner == "N")| (corner == "n")) { corner = "False"; }
        }
        public virtual void CostSofa()
        {
            cost = (Math.Pow(s, 2) / 3) + 5000;
        }
        public override void GetInfo()
        {
            CostSofa();
            Console.WriteLine("Площадь: {0} \nМатериал: {1} \nУгловой: {2} \nСтоимость: {3}",s,material,corner,cost);
        }
    }
}
