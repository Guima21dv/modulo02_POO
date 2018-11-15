using System;
using System.Globalization;

namespace exer_02
{
    class Funcionario
    {
        public double salario_bruto, desconto;
        public string nome;

        public double salarioLiquido()
        {
            return salario_bruto - desconto;
        }
        public void aumentarSalario(double porcentagem)
        {
            salario_bruto += salario_bruto * (porcentagem / 100);
        }

        public void toString()
        {
            Console.WriteLine("Dados do funcionário: " + nome + ", R$ " +  salarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
