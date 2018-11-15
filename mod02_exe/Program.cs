using System;
using System.Globalization;

namespace exers
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;
            r = new Retangulo();

            r.largura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.altura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            r.toString();
        }
    }
}
