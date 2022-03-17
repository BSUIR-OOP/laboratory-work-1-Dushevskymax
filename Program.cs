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
            figures.Add(new Otrezok() { Name = "Отрезок"});
            figures.Add(new Treug() { Name = "Треугольник"});
            figures.Add(new Ellips() { Name = "Эллипс"});
            figures.Add(new Kvadrat() { Name = "Квадрат" });
            figures.Add(new Romb() { Name = "Ромб" });
            figures.Add(new Pryamoug() { Name = "Прямоугольник" });

            foreach (var fig in figures)
            {
                fig.Draw();
            }

        }
    }
}
