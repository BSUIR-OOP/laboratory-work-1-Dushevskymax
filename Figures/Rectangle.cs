using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Rectangle : Figure
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Полиморфизм - четырехугольник с прямыми углами");
        }
    }
}
