using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Otrezok: Figure
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Полиморфизм - 2 точки");
        }

    }
}
