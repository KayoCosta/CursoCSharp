using System;

namespace Idade

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N, anos, restoanos, meses, dias;

            N = int.Parse(Console.ReadLine());
            anos = N / 365;
            restoanos = N % 365;
            meses = restoanos / 30;
            dias =  restoanos % 30;                      
            
            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
            
        }
    }
}
