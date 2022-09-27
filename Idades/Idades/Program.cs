using System;
using System.Globalization;

namespace Idades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contagem, idade, soma;
            double media;

            idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contagem = 0;
            soma = 0;

            while (idade > 0)
            {                
                soma = soma + idade;
                contagem = contagem + 1;
                idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (double) soma / contagem;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}