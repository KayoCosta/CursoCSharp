using System;
using System.Globalization;

namespace ImpostoDeRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (salario < 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario >= 2000.01 && salario <= 3000.00)
            {
                double imposto = (salario - 2000.01) * 8 / 100;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario >= 3000.01 && salario <= 4500.00)
            {
                double imposto = (salario - 3000.01) * 18 / 100;
                double impostoFinal = imposto + 80;

                Console.WriteLine("R$ " + impostoFinal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 4500.00)
            {
                double imposto = (salario - 4500.00) * 28 / 100;
                double impostoFinal = imposto + 350.00;

                Console.WriteLine("R$ " + impostoFinal.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}