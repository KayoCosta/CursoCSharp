using System;
using System.Globalization;

namespace TesteFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, x, soma;
            
            N = int.Parse(Console.ReadLine());

            soma = 0;

            //i++ vale a mesma coisa que i = i + 1
            for (int i=1; i<=N; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }

            Console.WriteLine(soma);
        }
    }
}