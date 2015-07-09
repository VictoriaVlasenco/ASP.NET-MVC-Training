using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Task1
{
    class Program
    {
        private static double F(double x, double n, double number)
        {
            return Math.Pow(x, n) - number;
        }

        private static double dFdx(double dx, double n)
        {
            return n * Math.Pow(dx, n - 1);
        }

        private static double Newton(double number, double n, double precision)
        {
            double current = 1, epsilon = 0;
            if (Math.Abs(number) < precision)
                return 0.0;
            if (Math.Abs(n) < precision)
                return 1.0;
            do
            {
                epsilon = -F(current, n, number) / dFdx(current, n);
                current += epsilon;

            } while ((Math.Abs(epsilon) > precision));
            return current;
        }

        static void Main(string[] args)
        {
            double res = 0, number = 0, degree = 1;
            Console.Write("Введите основание: ");
            number = Double.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            degree = Double.Parse(Console.ReadLine());
            res = Newton(number, degree, 0.00001);
            Console.WriteLine("Newton result is {0}", res);
            res = Math.Pow(number, 1 / degree);
            Console.WriteLine("Math.Pow result is {0}", res);
            Console.Read();
        }
    }
}
