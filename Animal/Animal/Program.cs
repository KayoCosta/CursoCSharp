using System;
using System.Globalization;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ossos = Console.ReadLine();         
            string tipo = Console.ReadLine();
            string alimento = Console.ReadLine();

            if (ossos == "vertebrado" && tipo == "ave" && alimento == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            else if (ossos == "vertebrado" && tipo == "ave" && alimento == "onivoro")
            {
                Console.WriteLine("pomba");
            }
            else if (ossos == "vertebrado" && tipo == "mamifero" && alimento == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (ossos == "vertebrado" && tipo == "mamifero" && alimento == "herbivoro")
            {
                Console.WriteLine("vaca");
            }
            else if (ossos == "invertebrado" && tipo == "inseto" && alimento == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            else if (ossos == "invertebrado" && tipo == "inseto" && alimento == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }
            else if (ossos == "invertebrado" && tipo == "anelideo" && alimento == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else if (ossos == "invertebrado" && tipo == "anelideo" && alimento == "onivoro")
            {
                Console.WriteLine("minhoca");
            }
        }
    }
}

