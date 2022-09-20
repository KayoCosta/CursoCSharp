using System;
using System.Globalization;

namespace PrimeiroProjeto

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            int C = int.Parse(valores[2]);

            int maiorAB = (A + B + Math.Abs(A-B)) / 2;
            int maior = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;


            Console.WriteLine(maior + " eh o maior");

        }
    }
}