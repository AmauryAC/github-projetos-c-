using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace TF_Arquitetura
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            double x, y;

            Random rnd = new Random();
            Stopwatch cronometro = new Stopwatch();
            double[] tempo = new double[4];

            tempo[0] = 0;
            tempo[1] = 0;
            tempo[2] = 0;
            tempo[3] = 0;

            double[] vetSoma = new double[30000];
            double[] vetDif = new double[30000];
            double[] vetMult = new double[30000];
            double[] vetDiv = new double[30000];

            for (i = 0; i < 10000; i++)
            {
                for (j = 0; j < 30000; j++)
                {
                    x = rnd.Next(1, 101) + rnd.NextDouble();
                    y = rnd.Next(1, 101) + rnd.NextDouble();

                    cronometro.Reset();
                    cronometro.Start();
                    vetSoma[j] = x + y;
                    cronometro.Stop();
                    tempo[0] = tempo[0] + cronometro.Elapsed.TotalSeconds;

                    cronometro.Reset();
                    cronometro.Start();
                    vetDif[j] = x - y;
                    cronometro.Stop();
                    tempo[1] = tempo[1] + cronometro.Elapsed.TotalSeconds;

                    cronometro.Reset();
                    cronometro.Start();
                    vetMult[j] = x * y;
                    cronometro.Stop();
                    tempo[2] = tempo[2] + cronometro.Elapsed.TotalSeconds;

                    cronometro.Reset();
                    cronometro.Start();
                    vetDiv[j] = (double)x / y;
                    cronometro.Stop();
                    tempo[3] = tempo[3] + cronometro.Elapsed.TotalSeconds;
                }
            }

            Console.Write("Tempos cronometrados: ");
            Console.Write("\nSoma: {0:f0}h : {1:f0}m : {2:f0}s : {3}ms", tempo[0] / 3600, tempo[0] / 60, tempo[0], tempo[0] * 0.001);
            Console.Write("\nDiferença: {0:f0}h : {1:f0}m : {2:f0}s : {3}ms", tempo[1] / 3600, tempo[1] / 60, tempo[1], tempo[1] * 0.001);
            Console.Write("\nMultiplicação: {0:f0}h : {1:f0}m : {2:f0}s : {3}ms", tempo[2] / 3600, tempo[2] / 60, tempo[2], tempo[2] * 0.001);
            Console.Write("\nDivisão: {0:f0}h : {1:f0}m : {2:f0}s : {3}ms", tempo[3] / 3600, tempo[3] / 60, tempo[3], tempo[3] * 0.001);

            Console.ReadKey();
        }
    }
}
