using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Назаров Максим Михайлович Группа ИУ5-33Б";
            Rectangle rect = new Rectangle(8, 6);
            Square sq = new Square(8);
            Circle cir = new Circle(8);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nArrayList");
            Console.ResetColor();
            ArrayList list = new ArrayList();
            list.Add(rect);
            list.Add(sq);
            list.Add(cir);
            foreach (var i in list) Console.WriteLine(i.ToString() + " ");

            List<Geometric_figures> list2 = new List<Geometric_figures>();
            list2.Add(rect);
            list2.Add(cir);
            list2.Add(sq);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nПеред сортировкой:");
            Console.ResetColor();
            foreach (var i in list2) Console.Write(i.ToString() + " \n" + " ");
            list2.Sort();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nПосле сортировки:");
            Console.ResetColor();
            foreach (var i in list2) Console.Write(i.ToString() + " \n" + " ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nМатрица");
            Console.ResetColor();
            Matrix<Geometric_figures> matrix = new Matrix<Geometric_figures>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = rect;
            matrix[1, 1, 1] = sq;
            matrix[2, 2, 2] = cir;
            Console.WriteLine(matrix.ToString());

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nСтек");
            Console.ResetColor();
            SimpleStack<Geometric_figures> stack = new SimpleStack<Geometric_figures>();
            stack.Push(rect);
            stack.Push(sq);
            stack.Push(cir);
            while (stack.Count > 0)
            {
                Geometric_figures f = stack.Pop();
                Console.WriteLine(f);
            }
            
            Console.ReadKey();
        }
    }
}
