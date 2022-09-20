using System;
using System.Globalization;

namespace PrimeiroProjeto

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = (Console.ReadLine());
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = salario + (0.15 * vendas);

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
