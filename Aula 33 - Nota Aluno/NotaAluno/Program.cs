using System;
using System.Globalization;

namespace NotaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, notafinal;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;

            notafinal = nota1 + nota2;

            if (notafinal < 60.00)
            {
                Console.WriteLine("NOTA FINAL = " + notafinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }
            



        }
    }
}