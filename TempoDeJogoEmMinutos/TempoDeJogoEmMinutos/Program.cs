using System;
using System.Globalization;

namespace TempoDeJogoEmMinutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasInicio, minutosInicio, horasFim, minutosFim, horasTotais, minutosTotais;
            string[] valores = Console.ReadLine().Split(' ');

            horasInicio = int.Parse(valores[0]);
            minutosInicio = int.Parse(valores[1]);
            horasFim = int.Parse(valores[2]);
            minutosFim = int.Parse(valores[3]);

            //Conversão para segundos

            int segundosInicio = (horasInicio * 60) + minutosInicio ;
            int segundosFim = (horasFim * 60) + minutosFim;
            int segundosTotais;


            //Após a verificação dos segundos, se o valor inicial for menor do que o final
            //a conta é uma simples subtração

            if (segundosFim > segundosInicio)
            {
                segundosTotais = segundosFim - segundosInicio;
            }

            //Caso o valor inicial seja maior do que o valor final, indica que começou no dia anterior,
            //então faz-se a conta do resto do tempo até fechar o dia
            //e soma-se com o tempo do dia seguinte

            else
            {
                segundosTotais = (24 * 60 - segundosInicio) + segundosFim;
            }

            horasTotais = segundosTotais / 60;
            minutosTotais = (segundosTotais % 60);            
            
            Console.WriteLine("O JOGO DUROU " + horasTotais + " HORA(S) E " + minutosTotais + " MINUTO(S)");
                                                           
        }
    }
}