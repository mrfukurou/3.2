using System;

namespace ConsoleApp7
{
    class Program
    {
        static double f(double x)
        {
            double y = 0;
            if (x > 0) y = x;
            else if ((-1)<= x && x <= 0) y = 0;
            else y = x * x;
            return y;
        }

        static void Main(string[] args)
        {
            try
            {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
                if (h > 0 && b > a)
                {
                    for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0}) = {1}", i, f(i));
            }
                else { Console.WriteLine("Некорректный ввод!"); }
        }
            catch { Console.WriteLine("Некорректный ввод!"); }

}
    }
}
