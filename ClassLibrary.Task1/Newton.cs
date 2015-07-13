using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Task1
{
    public class Newton
    {
        private static double F(double x, int n, double number)
        {
            return Math.Pow(x, n) - number;
        }

        private static double dFdx(double dx, int n)
        {
            return n * Math.Pow(dx, n - 1);
        }

        public static double GetRoot(double number, int n, double precision = 0.00001)
        {
            double current = 1, epsilon = 0;
            if (Math.Abs(number) < precision)
                return 0.0;
            if (Math.Abs(n) == 0)
                return 1.0;
            if (n % 2.0 == 0 && number < 0.0)
                throw new Exception("Невозможно вычислить корень четной степени из отриц. числа");
            do
            {
                epsilon = -F(current, n, number) / dFdx(current, n);
                current += epsilon;

            } while ((Math.Abs(epsilon) > precision));
            return current;
        }
    }
}
