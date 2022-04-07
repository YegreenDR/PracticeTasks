using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10.Task_2
{
    internal class A
    {
        private int _a;
        private int _b;
        public A(int a, int b)
        {
            _a = a;
            _b = b;
        }
        public A()
        {
            _a = 4;
            _b = 5;
        }
        public int c
        {
            get
            {
                for (int i = 0; i < 10; i++)
                {
                    _a += _b;
                }
                return _a;
            }
            set { }
        }
    }
}
