using System;
using System.Globalization;

namespace PrimeiroProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            x.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Lado A:" + x.LadoA.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lado B:" + x.LadoB.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lado C:" + x.LadoC.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area:" + x.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
