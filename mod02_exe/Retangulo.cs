using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exers
{
    class Retangulo
    {
        public double largura, altura;

        public double area()
        {
            return altura * largura;
        }
        public double perimetro()
        {
            return 2 * (altura + largura);
        }
        public double diagonal()
        {
            double diag;
            diag = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));
            return diag;
        }
        public void toString()
        {
            Console.WriteLine("AREA = " + area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA = " + diagonal().ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
