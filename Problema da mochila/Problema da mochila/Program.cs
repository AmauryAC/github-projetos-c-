using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_da_mochila
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int TAM = (int)Math.Pow(2, n) - 1;

            SubConjunto[] vet = new SubConjunto[TAM];

            GeraSubConjunto(n, ref vet);
            GeraCombinacao(n, n, ref vet);

            Console.Write("\t\t\t\tSuconjuntos \n");
            Console.Write("\nSubconjunto \tPeso \t\tValor");

            for (int i = 0; i < vet.Count(); i++)
            {
                Console.Write("\n{0} \t\t{1} \t\t{2}", vet[i].nome, vet[i].peso, vet[i].valor);
            }

            Console.ReadKey();
        }

        static void GeraSubConjunto(int n, ref SubConjunto[] vet)
        {
            int i;

            Random r;
            SubConjunto sc;

            for (i = 0; i < n; i++)
            {
                sc = new SubConjunto();

                sc.nome = (i + 1).ToString();

                r = new Random();
                sc.peso = r.Next(1, 11);

                for (int j = 0; j <= 10000000; j++)
                {
                    //Faz porra nenhuma
                }

                r = new Random();
                sc.valor = r.Next(1, 11);

                vet[i] = sc;
            }
        }

        static void GeraCombinacao(int n, int posInicio, ref SubConjunto[] vet)
        {
            int i, j;
            int aux;
            int qtde;

            for (qtde = 2; qtde <= n; qtde++)
            {
                aux = qtde;

                i = 0;
                j = i + 1;

                while (aux > 0)
                {
                    while (j < n && posInicio < (int)Math.Pow(2, n) - 1)
                    {
                        vet[posInicio] = new SubConjunto();
                        vet[posInicio].nome = vet[i].nome;
                        vet[posInicio].peso = vet[i].peso;
                        vet[posInicio].valor = vet[i].valor;

                        do
                        {
                            vet[posInicio].nome = vet[posInicio].nome + ',' + vet[j].nome;
                            vet[posInicio].peso += vet[j].peso;
                            vet[posInicio].valor += vet[j].valor;

                            j++;
                        } while (j < aux);
                        posInicio++;
                    }

                    i++;
                    j = i + 1;
                    aux--;
                }
            }
        }

        static void VerificaPesoMochila(double pesoMochila, SubConjunto[] vet)
        {

        }
    }
}
