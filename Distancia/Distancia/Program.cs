using System;
using System.Globalization;

namespace SomaSimples
{
    class Program
    {
        static void Main(String[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            int tempo = distancia * 2;

            Console.WriteLine(tempo + " minutos");

        }

    }

}