using System;
using System.Globalization;


namespace PlanoTelefonico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutos = int.Parse(Console.ReadLine());
            double x = 50.0;

            if (minutos < 100)
            {
                Console.WriteLine("Valor a pagar: R$ " + x);
            }
            else
            {
                double y = ((minutos - 100) * 2);
                double z = (x + y);

                Console.WriteLine("Valor a pagar: R$ " + z.ToString("F2",CultureInfo.InvariantCulture));

            }
            
        }
    }
}