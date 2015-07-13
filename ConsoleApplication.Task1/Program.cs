using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Task1;
using ClassLibrary.Task2;

namespace ConsoleApplication.Task1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            double res = 0, number = 0; int degree = 1;
            //JaggedArraySort n = new JaggedArraySort();
            Console.Write("Введите основание: ");
            number = Double.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            degree = Int32.Parse(Console.ReadLine());
            res = Newton.GetRoot(number, degree, 0.00001);
            Console.WriteLine("Newton result is {0}", res);
            res = Math.Pow(number, 1 / degree);
            Console.WriteLine("Math.Pow result is {0}", res);
            Console.Read();
        }
    }
}
