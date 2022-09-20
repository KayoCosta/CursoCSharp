using System;
using System.Globalization;

namespace SomaSimples
{
    class Program
    {
        static void Main(String[] args)
        {

            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double MEDIA = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));


        }

    }

}