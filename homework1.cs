using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение квадратного уравнения: ax^2 + bx + c = 0");

            Console.Write("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Коэффициент 'a' не может быть равен 0.");
                return;
            }

            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = (b * b) - (4 * a * c);
            Console.WriteLine($"\nДискриминант (D) = {d}");

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Уравнение имеет два корня:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Уравнение имеет один корень:");
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных корней (D < 0).");
            }

            Console.ReadKey();
        }
    }
}