using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Divisão
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            double x, y;

            Random rnd = new Random();
            Stopwatch cronometro = new Stopwatch();
            double tempo = 0.0;

            double[] vetDiv = new double[30000];
            cronometro.Reset();

            Console.WriteLine("\t\t\tFLOPS (Ponto Flutuante) ");
            Console.WriteLine("Operação de Divisão: ");
            Console.WriteLine("Armazena-se num vetor de 30.000 posições, \n" +
                              "operações de divisão com ponto flutuante. \n" +
                              "Mede-se o tempo gasto para realizar 10.000 vezes esse processo.");
            Console.Write("Processando...");

            for (i = 0; i < 10000; i++)
            {
                for (j = 0; j < 30000; j++)
                {
                    x = rnd.Next(1, 101) + rnd.NextDouble();
                    y = rnd.Next(1, 101) + rnd.NextDouble();

                    cronometro.Start();
                    vetDiv[j] = (double)x / y;
                    cronometro.Stop();
                    tempo += cronometro.Elapsed.Milliseconds;
                }
            }

            Console.WriteLine("\n\nTempo gasto: {0} ms", tempo);
            Console.ReadKey();
        }
    }
}
