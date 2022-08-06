using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1    // Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.
{
    internal class Program
    {
        static void Main(string[] args)
            {
            double a = Convert.ToDouble(Console.ReadLine());
            double k = Convert.ToDouble(Console.ReadLine());

            Lineq lineq = new Lineq();
            Console.WriteLine(lineq.Root());
            Console.ReadKey();
        }
    }
}
