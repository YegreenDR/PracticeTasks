using System;

namespace Practice_4.Task_3
{

        class Rectangle
        {
            double _y1;
            double _y2;
            double _x1;
            double _x2;
            public Rectangle(double y1, double y2, double x1, double x2)
            {
                this._y1 = y1;
                this._y2 = y2;
                this._x1 = x1;
                this._x2 = x2;
            }
            public double P(double y1, double y2, double x1, double x2) 
            {
                return (Math.Abs(x2 - x1) + Math.Abs(y2 - y1) * 2);
            }
            public double S(double y1, double y2, double x1, double x2)
            {
                return (Math.Abs(x2 - x1) * Math.Abs(y2 - y1));
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Rectangle rect = new Rectangle(2, 4, 3, 6);
                Console.WriteLine($"периметр = {rect.P(2, 4, 3, 6)}");
                Console.WriteLine($"площадь = {rect.S(2, 4, 3, 6)}");
            }
        }

    }

