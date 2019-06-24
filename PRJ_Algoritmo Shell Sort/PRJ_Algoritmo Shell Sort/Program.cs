/*Programa que faz o gerenciamento de prateleiras de supermercado,
 * utilizando algoritmos de substituição de páginas: 1)FIFO (First In First Out)
 *                                                   2)LRU (Least Recently Used)
 *                                                   3)SC (Second Chance)
 *Programadores: Amaury Alexandrino da Costa - 499960
 *               Caroline Francisco Magalhães dos Santos - 499951
 *               Débora Amaral Marques de Freitas - 494510
 *               Felipe Henrique da Silva Rocha - 495779
 *Data de Entrega: 01/06/2015
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PRJ_Algoritmo_Shell_Sort
{
    class Program
    {
        static string caminho = @"C:\Users\User\Documents\Visual Studio 2013\Projects\PRJ_Algoritmo Shell Sort\Shell.txt";
        static bool OK;

        static void Main(string[] args)
        {
            int op = -1;

            int i, j;
            int TAM = 500;

            Registro[] vet = new Registro[TAM];

            Stopwatch cronometro = new Stopwatch();          

            do
            {
                Console.Clear();
                MenuPrincipal(ref op);

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("\t\t\tGerar Registros \n");
                        Console.Write("\nGerando Registros e guardando em arquivo.");
                        Console.Write("\nAguarde alguns segundos...");
                        GeraRegistros(ref vet, TAM);

                        try
                        {
                            Serializar(ref vet, caminho);

                            if (OK)
                            {
                                System.Threading.Thread.Sleep(3000);
                                Console.Write("\a\n\nRegistros gerados com sucesso!!!");
                            }
                            else
                            {
                                Console.Write("\a\n\nOcorreu algum ERRO!!! \nProvavelmente o arquivo não foi encontrado.");
                            }
                        }
                        catch (XmlException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (FileLoadException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (FileNotFoundException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.Write(ex.Message);
                        }

                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("\t\t\tShell Sort: Algoritmo Shell \n");

                        try
                        {
                            Desserializar(ref vet, caminho);

                            Console.Write("\nVetor Lido do arquivo: \n");
                            for (i = 0; i < TAM; i++)
                            {
                                Console.Write("\n{0} - {1}", vet[i].Codigo, vet[i].Nome);
                            }

                            cronometro.Reset();
                            cronometro.Start();
                            vet = OrdenaPorAlgoritmoShell(vet);
                            cronometro.Stop();

                            Console.Write("\n\nVetor Ordenado - Algoritmo Shell: \n");
                            for (i = 0; i < TAM; i++)
                            {
                                Console.Write("\n{0} - {1}", vet[i].Codigo, vet[i].Nome);
                            }
                            Console.Write("\n\nTempo gasto: {0} ms\n", cronometro.Elapsed.TotalMilliseconds);
                        }
                        catch (XmlException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (FileLoadException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (FileNotFoundException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.Write(ex.Message);
                        }

                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("\t\t\tShell Sort: Algoritmo Knuth \n");
                        
                        try
                        {
                            Desserializar(ref vet, caminho);

                            Console.Write("\nVetor Lido do arquivo: \n");
                            for (i = 0; i < TAM; i++)
                            {
                                Console.Write("\n{0} - {1}", vet[i].Codigo, vet[i].Nome);
                            }

                            cronometro.Reset();
                            cronometro.Start();
                            OrdenaPorAlgoritmoKnuth(vet);
                            cronometro.Stop();

                            Console.Write("\n\nVetor Ordenado - Algoritmo Knuth: \n");
                            for (i = 0; i < TAM; i++)
                            {
                                Console.Write("\n{0} - {1}", vet[i].Codigo, vet[i].Nome);
                            }
                            Console.Write("\n\nTempo gasto: {0} ms\n", cronometro.Elapsed.TotalMilliseconds);
                        }
                        catch (XmlException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (FileLoadException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (FileNotFoundException ex)
                        {
                            Console.Write(ex.Message);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.Write(ex.Message);
                        }

                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();

                        int linFinal, colFinal;

                        linFinal = 12;
                        colFinal = 56;

                        //Rotina para mostrar os créditos, de acordo com a estética escolhida.
                        for (i = 0; i <= linFinal; i++)
                        {
                            for (j = 0; j <= colFinal; j++)
                            {
                                Console.Write("");
                                if (i == 0 || i == linFinal)
                                    Console.Write("*");
                                else if (i > 0 && i < linFinal)
                                {
                                    if (j == 0 || j == colFinal)
                                        Console.Write("*");
                                }

                                if (j == 1)
                                {
                                    if (i == 1)
                                        Console.Write("\t\tC-R-É-D-I-T-O-S\t\t\t\t");
                                    if (i == 2)
                                        Console.Write("Funcionamento Algoritmo Shell Sort.\t\t\t");
                                    if (i == 3)
                                        Console.Write("Programadores: Amaury A. Costa - 499960\t\t");
                                    if (i == 4)
                                        Console.Write("\t\tCaroline F. Magalhães - 499951\t\t");
                                    if (i == 5)
                                        Console.Write("\t\tDébora Amaral M. de Freitas - 494510\t");
                                    if (i == 6)
                                        Console.Write("\t\tFelipe Henrique Rocha - 495779\t\t");
                                    if (i == 7)
                                        Console.Write("Turma: 3º Período - Sist. Informação\t\t\t");
                                    if (i == 8)
                                        Console.Write("Instituição: PUC Minas - Betim\t\t\t\t");
                                    if (i == 9)
                                        Console.Write("Data desenvolvimento: 29/05/2015\t\t\t");
                                    if (i == 10)
                                        Console.Write("Agradecimento: \t\t\t\t\t");
                                    if (i == 11)
                                        Console.Write("\tOBRIGADO POR USAR ESSE SOFTWARE!!!\t\t");
                                }
                            }
                            Console.Write("\n");
                        }

                        Console.Write("\n\nPressione <QUALQUER TECLA> para retornar ao menu principal.");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);

            //Serializar(ref h.tabela);

            Console.Write("\n\aSaindo do Programa...");
            System.Threading.Thread.Sleep(1000);
        }

        static bool VerificaSeExiste(Registro[] vet, int valor, int cont, ref bool achou)
        {
            int i;

            i = 0;
            while (i < cont && !achou)
            {
                if (vet[i].Codigo == valor)
                    achou = true;
                i++;
            }

            return achou;
        }

        static void GeraRegistros(ref Registro[] vet, int TAM)
        {
            int i, j;

            int codGerado;
            int tamString;
            char ch;

            bool achou;

            Registro xReg;

            Random r = new Random();

            for (i = 0; i < TAM; i++)
            {
                xReg = new Registro();

                do
                {
                    achou = false;
                    codGerado = r.Next(1000, 10000);
                    VerificaSeExiste(vet, codGerado, i, ref achou);
                } while (achou);

                xReg.Codigo = codGerado;

                tamString = r.Next(3, 11);

                for (j = 0; j < tamString; j++)
                {
                    ch = Convert.ToChar(r.Next(65, 91));
                    xReg.Nome = xReg.Nome + ch.ToString();
                }

                vet[i] = xReg;

                Serializar(ref vet, caminho);
            }
        }

        static Registro[] OrdenaPorAlgoritmoShell(Registro[] vet)
        {
            int i, j = 0;
            int n, h;

            Registro aux = new Registro();

            n = vet.Length;
            h = n / 2;

            while (h > 0)
            {
                i = h;

                while (i < n)
                {
                    aux = vet[i];
                    j = i;

                    while (j >= h && aux.Codigo < vet[j - h].Codigo)
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

        static Registro[] OrdenaPorAlgoritmoKnuth(Registro[] vet)
        {
            int i, j = 0;
            int n, h;

            Registro aux = new Registro();

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

                    while (j >= 0 && aux.Codigo < vet[j].Codigo)
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

        static void Serializar(ref Registro[] vet, string caminho)
        {
            TextWriter gravacao = null;           
            try
            {
                gravacao = new StreamWriter(caminho);
                XmlSerializer serializador = new XmlSerializer(vet.GetType());

                serializador.Serialize(gravacao, vet);
                OK = true;

                gravacao.Close();
            }
            catch (System.UnauthorizedAccessException)
            {
                OK = false;
            }
        }

        static void Desserializar(ref Registro[] vet, string caminho)
        {
            FileStream leitura = null;
            try
            {
                leitura = new FileStream(caminho, FileMode.Open);
                XmlSerializer serializador = new XmlSerializer(vet.GetType());

                vet = (Registro[])serializador.Deserialize(leitura);
                OK = true;

                leitura.Close();
            }
            catch (System.UnauthorizedAccessException)
            {
                OK = false;
            }
        }

        //-----Função para mostrar o Menu Principal, quando requisitado.
        static void MenuPrincipal(ref int op)
        {
            //Esboço Menu Principal
            try
            {
                Console.Write("\t\t\t*** M - E - N - U ***");
                Console.Write("\nDicionário de Informática: ");
                Console.Write("\n1 - Gerar Registros ");
                Console.Write("\n2 - Shell Sort: Algoritmo Shell ");
                Console.Write("\n3 - Shell Sort: Algoritmo Knuth ");
                Console.Write("\n4 - Créditos ");
                Console.Write("\n0 - Sair da Aplicação ");
                Console.Write("\n\nDigite a opção: ?\b");
                op = Convert.ToInt16(Console.ReadLine());
            }

            catch (FormatException)   //Captura uma exceção, caso o usuário digite uma string, char ou formato diferente de int na variável op.
            {
                op = -1;   //Caso o usuário digitar um formato diferente, op irá valer -1, fazendo uma nova chamada à função menu.
            }
        }
    }
}
