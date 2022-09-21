using System;
using System.Globalization;

namespace ExtremamenteBasico
{
    class Program
    {
        static void Main(String[] args)
        {
            int diaInicio, horaInicio, minutoInicio, segundoInicio;
            int  diaFinal, horaFinal, minutoFinal, segundoFinal;

            string[] entrada = Console.ReadLine().Split(' ');
            diaInicio = int.Parse(entrada[1]);

            string[] N = Console.ReadLine().Split(':');

            horaInicio = int.Parse(N[0]);
            minutoInicio = int.Parse(N[1]);
            segundoInicio = int.Parse(N[2]);

            string[] saida = Console.ReadLine().Split(' ');
            diaFinal = int.Parse(saida[1]);

            N = Console.ReadLine().Split(':');
            horaFinal = int.Parse(N[0]);
            minutoFinal = int.Parse(N[1]);
            segundoFinal = int.Parse(N[2]);

            int segundoSomaInicio = diaInicio * 86400 + horaInicio * 3600 + minutoInicio * 60 + segundoInicio;
            int segundoSomaFinal = diaFinal * 86400 + horaFinal * 3600 + minutoFinal * 60 + segundoFinal;

            int segundoSomaTotal = segundoSomaFinal - segundoSomaInicio;

            int diaTotal = segundoSomaTotal / 86400;
            int diaTotalResto = segundoSomaTotal % 86400;

            int horaTotal = diaTotalResto / 3600;
            int horaTotalResto = diaTotalResto % 3600;

            int minutoTotal = horaTotalResto / 60;

            int msegundoTotal = horaTotalResto % 60;

            Console.WriteLine(diaTotal + " dia(s)");
            Console.WriteLine(horaTotal + " hora(s)");
            Console.WriteLine(minutoTotal + " minuto(s)");
            Console.WriteLine(msegundoTotal + " segundo(s)");

        }

    }

}

