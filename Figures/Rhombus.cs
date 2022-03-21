using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Rhombus : Figure
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Полиморфизм - все стороны равны");
        }
    }
}
