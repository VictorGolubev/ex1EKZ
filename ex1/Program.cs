using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Биссектрисса La = " + getL(a,b,c));
                Console.WriteLine();
                Console.WriteLine("Биссектрисса La = " + getL(b,a,c));
                Console.WriteLine();
                Console.WriteLine("Биссектрисса La = " + getL(c,a,b));
                Console.WriteLine("----------------------------------------------------------------------------");
            }

        }

        static double getL(double a, double b, double c)//Если первый парамметр А, то это биссектриса А и так далее
        {
            return Math.Sqrt(b*c*(Math.Pow(b+c,2)-Math.Pow(a,2)))/(b+c);
        }
    }
}
