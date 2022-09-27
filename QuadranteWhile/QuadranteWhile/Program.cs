using System;
using System.Globalization;

namespace QuadranteWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] valores = Console.ReadLine().Split(' ');

            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                valores = Console.ReadLine().Split(' ');

                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

            }
            
        }
    }
}