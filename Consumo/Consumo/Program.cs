using System;
using System.Globalization;

namespace SomaSimples
{
    class Program
    {
        static void Main(String[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            double combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double consumo = distancia / combustivel;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

          
        }

    }

}