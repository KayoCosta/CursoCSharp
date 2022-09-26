using System;
using System.Globalization;

namespace Intervalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //[0,25], (25,50], (50,75], (75,100]]

            if (entrada < 0 || entrada > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (entrada >= 0.00 && entrada <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (entrada > 25.00 && entrada <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (entrada > 50.00 && entrada <= 75.00)
            {
                Console.WriteLine("Intervalo (50, 75]");
            }
            else if (entrada > 75.00 && entrada <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}