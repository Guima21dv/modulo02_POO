using System;
using System.Globalization;

namespace exer_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double percent;
            Funcionario f;
            f = new Funcionario();
            Console.Write("Nome: ");
            f.nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.salario_bruto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Desconto: ");
            f.desconto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            f.toString();
            Console.WriteLine();

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            percent = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.aumentarSalario(percent);
            Console.WriteLine();

            f.toString();

            Console.ReadLine();

        }
    }
}
