using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Назаров Максим Михайлович Группа ИУ5-33Б";
            double A = 0, B = 0, C = 0;
            if (args.Length == 3)
            {
                if (!double.TryParse(args[0], out A))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!!! Перезапустите программу и повторите ввод!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (!double.TryParse(args[1], out B))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!!! Перезапустите программу и повторите ввод!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (!double.TryParse(args[2], out C))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!!! Перезапустите программу и повторите ввод!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.Write("Введите значение А = ");
                while (!double.TryParse(Console.ReadLine(), out A))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!!! Введите значение А = ");
                    Console.ResetColor();
                }
                Console.Write("Введите значение B = ");
                while (!double.TryParse(Console.ReadLine(), out B))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!!! Введите значение B = ");
                    Console.ResetColor();
                }
                Console.Write("Введите значение C = ");
                while (!double.TryParse(Console.ReadLine(), out C))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!!! Введите значение C = ");
                    Console.ResetColor();
                }
            }
            //Console.Clear()//;
            double d, d1, d2, x1, x2, x3, x4;
            if (A != 0 && B != 0 && C != 0)
            {
                d = B * B - 4 * A * C;
                if (d > 0)
                {
                    d1 = (-B + Math.Sqrt(d)) / (2 * A);
                    d2 = (-B - Math.Sqrt(d)) / (2 * A);
                    if (d1 < 0 && d2 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет корней");
                        Console.ResetColor();
                    }
                    if ((d1 >= 0 && d2 >= 0))
                    {
                        x1 = Math.Sqrt(d1);
                        x2 = -Math.Sqrt(d1);
                        x3 = Math.Sqrt(d2);
                        x4 = -Math.Sqrt(d2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"x1={x1} x2={x2} x3={x3} x4={x4}");
                        Console.ResetColor();
                    }
                    if (d1 >= 0 && d2 < 0)
                    {
                        x1 = Math.Sqrt(d1);
                        x2 = -Math.Sqrt(d1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"x1={x1} x2={x2}");
                        Console.ResetColor();
                    }
                    if (d1 < 0 && d2 >= 0)
                    {
                        x3 = Math.Sqrt(d2);
                        x4 = -Math.Sqrt(d2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"x1={x3} x2={x4}");
                        Console.ResetColor();
                    }
                }
                if (d == 0)
                {
                    d1 = -B / (2 * A);
                    if (d1 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет корней");
                        Console.ResetColor();
                    }
                    else
                    {
                        x1 = Math.Sqrt(d1);
                        x2 = -Math.Sqrt(d1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"x1={x1} x2={x2}");
                        Console.ResetColor();
                    }
                }
                if (d < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет корней");
                    Console.ResetColor();
                }
            }
            if (A == 0 && B == 0 && C != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет корней");
                Console.ResetColor();
            }
            if (B == 0 && C == 0 && A != 0)
            {
                x1 = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x1=x2={x1}");
                Console.ResetColor();
            }
            if (A == 0 && C == 0 && B != 0)
            {
                x1 = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x1=x2={x1}");
                Console.ResetColor();
            }
            if (A == 0 && B != 0 && C != 0)
            {
                d1 = -C / B;
                if (d1 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет корней");
                    Console.ResetColor();
                }
                else
                {
                    x1 = Math.Sqrt(d1);
                    x2 = -Math.Sqrt(d1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"x1={x1} x2={x2}");
                    Console.ResetColor();
                }
            }
            if (B == 0 && A != 0 && C != 0)
            {
                d = -C / A;
                if (d < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет корней");
                    Console.ResetColor();
                }
                else if (d > 0)
                {
                    d1 = Math.Sqrt(d);
                    x1 = Math.Sqrt(d1);
                    x2 = -Math.Sqrt(d1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"x1={x1} x2={x2}");
                    Console.ResetColor();
                }
            }
            if (C == 0 && A != 0 && B != 0)
            {
                d1 = 0;
                d2 = -B / A;
                if (d2 < 0)
                {
                    x1 = Math.Sqrt(d1);
                    x2 = -Math.Sqrt(d1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"x1={x1} x2={x2}");
                    Console.ResetColor();
                }
                else
                {
                    x1 = Math.Sqrt(d1);
                    x2 = -Math.Sqrt(d1);
                    x3 = Math.Sqrt(d2);
                    x4 = -Math.Sqrt(d2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"x1={x1} x2={x2} x3={x3} x4={x4}");
                    Console.ResetColor();
                }
            }
            if (C == 0 && A == 0 && B == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Любое число является корнем");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
