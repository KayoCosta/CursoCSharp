using System;

namespace Cedulas

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N, cem, restocem, cinquenta, restocinquenta, vinte, restovinte, dez, restodez, cinco, restocinco, dois, restodois,  um;

            N = int.Parse(Console.ReadLine());
            cem = N / 100;
            restocem = N % 100;

            cinquenta = restocem / 50;
            restocinquenta = restocem % 50;

            vinte = restocinquenta / 20;
            restovinte = restocinquenta % 20;

            dez = restovinte / 10;
            restodez = restovinte % 10;

            cinco = restodez / 5;
            restocinco = restodez % 5;

            dois = restocinco / 2;
            restodois = restocinco % 2;

            um = restodois / 1;

            Console.WriteLine(N);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");
        }
    }
}
