using System;
using System.Globalization;

namespace exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a;
            a = new Aluno();

            a.nome = Console.ReadLine();
            a.n1 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.n2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.n3 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(a.n1 > 30 || a.n2 > 35 || a.n3 > 35)
            {
                Console.WriteLine("NOTAS INVÁLIDAS!");
                Console.ReadLine();
            }
            else
            {
                a.toString();
                Console.ReadLine();
            }
        }
    }
}
