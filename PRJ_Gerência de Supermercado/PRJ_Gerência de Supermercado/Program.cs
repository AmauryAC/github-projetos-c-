/*Programa que faz o gerenciamento de prateleiras de supermercado,
 * utilizando algoritmos de substituição de páginas: 1)FIFO (First In First Out)
 *                                                   2)LRU (Least Recently Used)
 *                                                   3)SC (Second Chance)
 *Programadores: Amaury Alexandrino da Costa - 499960
 *               Caroline Francisco Magalhães dos Santos - 499951
 *               Felipe Henrique da Silva Rocha - 495779
 *               João Fernando de Souza - 499972
 *Data de Entrega: 30/05/2015
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_Gerência_de_Supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = -1;

            Produto[] vetProd;          //Cria um vetor de Produtos que contém as informações de cada produto.
            Prateleira p = new Prateleira();            //Cria uma prateleira.

            do
            {
                //Chama o Menu Principal
                Console.Clear();
                MenuPrincipal(ref op);         

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("\t\t\tMétodo FIFO \n");

                        //Instancia o vetor e inicializa as variáveis
                        vetProd = new Produto[10];
                        Inicializa(ref vetProd);

                        //Chama a função que gerencia uma prateleira pelo Método FIFO
                        p.MetodoFIFO(vetProd);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("\t\t\tMétodo LRU \n");

                        //Instancia o vetor e inicializa as variáveis
                        vetProd = new Produto[10];
                        Inicializa(ref vetProd);

                        //Chama a função que gerencia uma prateleira pelo Método LRU
                        p.MetodoLRU(vetProd);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("\t\t\tMétodo Segunda Chance \n");

                        //Instancia o vetor e inicializa as variáveis
                        vetProd = new Produto[10];
                        Inicializa(ref vetProd);

                        //Chama a função que gerencia uma prateleira pelo Método Segunda Chance
                        p.MetodoSegundaChance(vetProd);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();

                        int i, j;
                        int linFinal, colFinal;

                        linFinal = 12;
                        colFinal = 64;

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
                                        Console.Write("\t\t\tC-R-É-D-I-T-O-S\t\t\t\t");
                                    if (i == 2)
                                        Console.Write("Gerenciador de Prateleiras.\t\t\t\t\t");
                                    if (i == 3)
                                        Console.Write("Programadores: Amaury Alexandrino da Costa - 499960\t\t");
                                    if (i == 4)
                                        Console.Write("\t\tCaroline Francisco Magalhães dos Santos - 499951");
                                    if (i == 5)
                                        Console.Write("\t\tFelipe Henrique da Silva Rocha - 495779\t\t");
                                    if (i == 6)
                                        Console.Write("\t\tJoão Fernando de Souza - 499972\t\t\t");
                                    if (i == 7)
                                        Console.Write("Turma: 3º Período - Sist. Informação\t\t\t\t");
                                    if (i == 8)
                                        Console.Write("Instituição: PUC Minas - Betim\t\t\t\t\t");
                                    if (i == 9)
                                        Console.Write("Data desenvolvimento: 23/05/2015\t\t\t\t");
                                    if (i == 10)
                                        Console.Write("Agradecimento: \t\t\t\t\t\t");
                                    if (i == 11)
                                        Console.Write("\tOBRIGADO POR USAR ESSE SOFTWARE!!!\t\t\t");
                                }
                            }
                            Console.Write("\n");
                        }

                        Console.Write("\n\nPressione <QUALQUER TECLA> para retornar ao menu principal.");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);

            Console.Write("\n\aSaindo do Programa...");
            System.Threading.Thread.Sleep(1000);
        }

        //-----Função para mostrar o Menu Principal, quando requisitado.
        static void MenuPrincipal(ref int op)
        {
            int i, j;
            int linFinal, colFinal;

            linFinal = 9;
            colFinal = 48;

            //Esboço Menu Principal
            try
            {
                for (i = 0; i <= linFinal; i++)
                {
                    for (j = 0; j <= colFinal; j++)
                    {
                        Console.Write("");
                        if (i == 0 || i == linFinal)
                            Console.Write("=");
                        else if (i > 0 && i < linFinal)
                        {
                            if (j == 0 || j == colFinal)
                                Console.Write("*");
                        }

                        if (j == 1)
                        {
                            if (i == 1)
                                Console.Write("\t\tM - E - N - U\t\t\t");
                            if (i == 2)
                                Console.Write("\tGerenciador de Prateleiras.\t\t");
                            if (i == 3)
                                Console.Write("Substituição de páginas.\t\t\t");
                            if (i == 4)
                                Console.Write("Algoritmos:\t1 - Método FIFO\t\t\t");
                            if (i == 5)
                                Console.Write("\t\t2 - Método LRU\t\t\t");
                            if (i == 6)
                                Console.Write("\t\t3 - Método Segunda Chance\t");
                            if (i == 7)
                                Console.Write("\t\t4 - Créditos\t\t\t");
                            if (i == 8)
                                Console.Write("\t\t0 - Sair da Aplicação\t\t");
                        }
                    }
                    Console.Write("\n");
                }

                Console.Write("\nDigite a opção: ?\b");
                op = Convert.ToInt16(Console.ReadLine());
            }

            catch (FormatException)         //Captura uma exceção, caso o usuário digite uma string, char ou formato diferente de int na variável op.
            {
                op = -1;            //Caso o usuário digitar um formato diferente, op irá valer -1, fazendo uma nova chamada à função menu.
            }
        }

        //Função que inicializa o vetor de Produtos, atribuindo códigos dos Produtos às descrições
        static void Inicializa(ref Produto[] vetProd)
        {
            int i;
            Produto xProd;
            string[] descricoes = { "Papel", "Biscoito", "Isotônico", "Pizza", "Refrigerante", "Café", "Shampoo", "Chocolate", "Arroz", "Doritos" };

            for (i = 0; i <= 9; i++)
            {
                //Instancia um novo produto e o atribui no vetor
                xProd = new Produto();
                xProd.Codigo = i;
                xProd.Descricao = descricoes[i];

                vetProd[i] = xProd;
            }
        }
    }
}
//------------------------------------FIM DO PROGRAMA
