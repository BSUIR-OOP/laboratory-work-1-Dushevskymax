using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Treug : Figure
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Полиморфизм - сумма углов = 180гр");
        }
    }
}
