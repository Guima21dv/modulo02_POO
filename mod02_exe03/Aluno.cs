using System;
using System.Globalization;

namespace exe03
{
    class Aluno
    {
        public string nome;
        public double n1, n2, n3;

        public double notaFinal()
        {
            return n1 + n2 + n3;
        }
        public double faltante()
        {
            return 60 - notaFinal();
        }
        public void toString()
        {
            Console.WriteLine("NOTA FINAL = " + notaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if ((n1 + n2 + n3) > 60) {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO \n" + "FALTARAM " + faltante().ToString("F2",CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
