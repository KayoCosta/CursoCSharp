using System;
using System.Globalization;

namespace PrimeiroProjeto

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double AreaTriangulo = (A * C) / 2.0;
            double AreaCirculo = 3.14159 * Math.Pow(C, 2.0);
            double AreaTrapezio = ((A + B) * C ) / 2.0;
            double AreaQuadrado = Math.Pow(B, 2.0);
            double AreaRetangulo = (A * B);

            Console.WriteLine("TRIANGULO: " + AreaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + AreaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + AreaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + AreaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + AreaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}