using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Square : Figure
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Полиморфизм - ромб с равными сторонами");
        }
    }
}
