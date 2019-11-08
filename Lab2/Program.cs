using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Назаров Максим Михайлович Группа ИУ5-33Б";
            Rectangle rect = new Rectangle();
            Square sq = new Square();
            Circle cir = new Circle();
            rect.property_shirina = 6;
            rect.property_visota = 3;
            sq.property_shirina = 6;
            sq.property_visota = 6;
            cir.property_radius = 5;
            rect.Print();
            sq.Print();
            cir.Print();
            Console.ReadKey();
        }
    }
}
