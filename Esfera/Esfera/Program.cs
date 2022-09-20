using System;
using System.Globalization;

namespace PrimeiroProjeto

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double volume = (4 / 3.0) * 3.14159 * Math.Pow(r, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}