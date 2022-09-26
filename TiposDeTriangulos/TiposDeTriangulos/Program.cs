using System;
using System.Globalization;

namespace TriangleTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            string[] vet = Console.ReadLine().Split(' ');
            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double A, B, C;
            if (n1 > n2 && n1 > n3)
            {
                A = n1;
                if (n2 > n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 > n3)
            {
                A = n2;
                if (n1 > n3)
                {
                    B = n1;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else
            {
                A = n3;
                if (n1 > n2)
                {
                    B = n1;
                    C = n2;
                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if ((A * A) == (B * B) + (C * C))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if ((A * A) > (B * B) + (C * C))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if ((A * A) < (B * B) + (C * C))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            
            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}