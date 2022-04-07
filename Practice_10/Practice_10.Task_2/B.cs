using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10.Task_2
{
    internal class B : A
    {
        private int _d;
        public int c2
        {
        get 
            {
                for (int i = 0; i < 10; i++)
                {
                    _d += c;
                }
                return _d;
            }
            set 
            {
                _d = value;
            }
        }
        public B(int d)
        {
            d = 5;
        }
    }
}
