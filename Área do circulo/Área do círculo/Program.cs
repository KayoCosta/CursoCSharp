using System;
using System.Globalization;

namespace ExtremamenteBasico{
    class Program {
        static void Main(String[] args)
        {

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double A = pi * raio * raio;

            Console.WriteLine("A=" + A.ToString("F4",CultureInfo.InvariantCulture));

        }

    }

}

