using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Teste_Shell_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int TAM = 10;

            int num;

            bool achou;

            int[] vet = new int[TAM];

            Random r;

            Stopwatch cronometro = new Stopwatch();

            Console.Write("Vetor Gerado: \n");
            for (i = 0; i < TAM; i++)
            {
                do
                {
                    r = new Random();

                    achou = false;
                    num = r.Next(0, 100000);
                    VerificaSeExiste(vet, num, i, ref achou);
                } while (achou);

                vet[i] = num;

                Console.Write("{0}   ", vet[i]);
            }

            cronometro.Reset();
            cronometro.Start();
            vet = OrdenaPorAlgoritmoShell(vet);
            cronometro.Stop();

            Console.Write("\n\nVetor Ordenado - Algoritmo Shell: \n");
            for (i = 0; i < TAM; i++)
            {
                Console.Write("{0}   ", vet[i]);
            }
            Console.Write("\nTempo gasto: {0} ms\n", cronometro.Elapsed.TotalMilliseconds);

            cronometro.Reset();
            cronometro.Start();
            OrdenaPorAlgoritmoKnuth(vet);
            cronometro.Stop();

            Console.Write("\n\nVetor Ordenado - Algoritmo Knuth: \n");
            for (i = 0; i < TAM; i++)
            {
                Console.Write("{0}   ", vet[i]);
            }
            Console.Write("\nTempo gasto: {0} ms\n", cronometro.Elapsed.TotalMilliseconds);

            Console.ReadKey();
        }

        static bool VerificaSeExiste(int[] vet, int valor, int cont, ref bool achou)
        {
            int i;

            i = 0;
            while (i < cont && !achou)
            {
                if (vet[i] == valor)
                    achou = true;
                i++;
            }

            return achou;
        }

        static int[] OrdenaPorAlgoritmoShell(int[] vet)
        {
            int i, j = 0;
            int n, h;
            int aux = 0;

            n = vet.Length;
            h = n / 2;

            while (h > 0)
            {
                i = h;

                while (i < n)
                {
                    aux = vet[i];
                    j = i;

                    while (j >= h && aux < vet[j - h])
                    {
                        vet[j] = vet[j - h];
                        j = j - h;
                    }

                    vet[j] = aux;
                    i = i + 1;
                }

                h = h / 2;
            }

            return vet;
        }

        static int[] OrdenaPorAlgoritmoKnuth(int[] vet)
        {
            int i, j = 0;
            int n, h;
            int aux = 0;

            n = vet.Length;
            h = 1;

            while (h < n)
            {
                h = h * 3 + 1;
            }

            while (h > 1)
            {
                h = (h - 1) / 3;
                i = h;

                while (i < n)
                {
                    aux = vet[i];
                    j = i - h;

                    while (j >= 0 && aux < vet[j])
                    {
                        vet[j + h] = vet[j];
                        j = j - h;
                    }

                    vet[j + h] = aux;
                    i = i + 1;
                }
            }

            return vet;
        }
    }
}
