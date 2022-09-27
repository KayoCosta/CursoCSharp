using System;
using System.Globalization;

namespace ValidacaoDeNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;            
            
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (nota1 < 0 || nota1 > 10)
            {                
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                    
                
            }

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            media = (nota1 + nota2) / 2;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));            
        }
    }
}