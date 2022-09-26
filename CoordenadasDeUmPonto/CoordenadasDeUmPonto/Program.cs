using System;
using System.Globalization;

namespace CoordenadasDeUmPonto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double X, Y;
            string[] vet = Console.ReadLine().Split(' ');

            X = double.Parse(vet[0], CultureInfo.InvariantCulture);
            Y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (X == 0.0 && Y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (X == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (Y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (X > 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (X > 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}