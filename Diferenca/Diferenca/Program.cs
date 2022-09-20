using System;
using System.Globalization;

namespace SomaSimples
{
    class Program
    {
        static void Main(String[] args)
        {

            int A, B, C, D;
            A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int diferenca = ((A * B) - (C * D));

            Console.WriteLine ("DIFERENCA = " + diferenca);

        }

    }

}