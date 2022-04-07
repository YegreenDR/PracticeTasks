using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10.Task_1
{
    internal class PotatoField : Field
    {
        string _name;
        double s;
        public PotatoField() : base()
        {
            _name = null;
            Input();
        }
        public void Input()
        {
            
        }
        public override void AllHarvest()
        {
            Harvest = Semena * Math.Pow(S,2);
        }
        public void Info()
        {
            Console.WriteLine("Название картофеля {0} \nПлозадь поля {1} \nКоэффициент {2} \nКол-во урожая {3}", Name, S, K, Harvest);
        }
    }
}
