using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Figure
    {
        public string Name { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine($"Фигура - {Name}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            List<Figure> figures = new List<Figure>();
            figures.Add(new Segment() { Name = "Отрезок" });
            figures.Add(new Triangle() { Name = "Треугольник" });
            figures.Add(new Ellipse() { Name = "Эллипс" });
            figures.Add(new Square() { Name = "Квадрат" });
            figures.Add(new Rhombus() { Name = "Ромб" });
            figures.Add(new Rectangle() { Name = "Прямоугольник" });

            foreach (var fig in figures)
            {
                fig.Draw();
            }

        }
    }
}
