using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Ellips : Figure
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Полиморфизм - Почти круг");
        }
    }
}
