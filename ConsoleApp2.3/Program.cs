using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._3
{
    class Program //Средний уровень
    {
        static void Main(string[] args)
        {
            try
            {
                double y;
                Console.WriteLine("Введите число x для всех вариантов параметров: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число (k), чтобы выбрать вариант параметров: ");
                double k = double.Parse(Console.ReadLine());
                if (k == 1)
                {
                    double a = 2.2;
                    Console.WriteLine($"Число a = {a}");
                    double b = 2.4;
                    Console.WriteLine($"Число b = {b}");
                    double c = Math.Log10(Math.Abs(b * x));
                    Console.WriteLine($"Число с = {c}");
                    switch (k)
                    {
                        case 1:
                            y = c * Math.Sin(Math.Pow(b, 2) * x) + b * Math.Log10(c * x + a);
                            Console.WriteLine("При х<a y равен: " + y);
                            break;
                        case 2:
                            y = a + Math.Log10(b * x) - Math.Pow(Math.Sin(1), 2) * (a + c * x);
                            Console.WriteLine("При a<=x<b y равен: " + y);
                            break;
                        case 3:
                            y = Math.Sqrt(Math.Abs(Math.Cos(a + b * x) + c * Math.Pow(x, 2)));
                            Console.WriteLine("При х>=b у равен: " + y);
                            break;
                    }
                }
                else if (k == 2)
                {
                    double a = 1.6;
                    Console.WriteLine($"Число a = {a}");
                    double b = 1.7;
                    Console.WriteLine($"Число b = {b}");
                    double c = Math.Log10(Math.Abs(b * x));
                    Console.WriteLine($"Число с = {c}");
                    switch (k)
                    {
                        case 1:
                            y = c * Math.Sin(Math.Pow(b, 2) * x) + b * Math.Log10(c * x + a);
                            Console.WriteLine("При х<a y равен: " + y);
                            break;
                        case 2:
                            y = a + Math.Log10(b * x) - Math.Pow(Math.Sin(1), 2) * (a + c * x);
                            Console.WriteLine("При a<=x<b y равен: " + y);
                            break;
                        case 3:
                            y = Math.Sqrt(Math.Abs(Math.Cos(a + b * x) + c * Math.Pow(x, 2)));
                            Console.WriteLine("При х>=b у равен: " + y);
                            break;
                    }
                }
                else if (k == 3)
                {
                    double a = 1.3;
                    Console.WriteLine($"Число a = {a}");
                    double b = 4.2;
                    Console.WriteLine($"Число b = {b}");
                    double c = Math.Log10(Math.Abs(Math.Pow(b, 2) * x));
                    Console.WriteLine($"Число с = {c}");
                    switch (k)
                    {
                        case 1:
                            y = c * Math.Sin(Math.Pow(b, 2) * x) + b * Math.Log10(c * x + a);
                            Console.WriteLine("При х<a y равен: " + y);
                            break;
                        case 2:
                            y = a + Math.Log10(b * x) - Math.Pow(Math.Sin(1), 2) * (a + c * x);
                            Console.WriteLine("При a<=x<b y равен: " + y);
                            break;
                        case 3:
                            y = Math.Sqrt(Math.Abs(Math.Cos(a + b * x) + c * Math.Pow(x, 2)));
                            Console.WriteLine("При х>=b у равен: " + y);
                            break;
                    }
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
