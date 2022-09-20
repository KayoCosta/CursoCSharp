using System;
using System.Globalization;

namespace SomaSimples
{
    class Program
    {
        static void Main(String[] args)
        {
            int tempo, velocidadeMedia;
            tempo = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            double consumo = (tempo * velocidadeMedia / 12.0);
            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture));


        }

    }

}