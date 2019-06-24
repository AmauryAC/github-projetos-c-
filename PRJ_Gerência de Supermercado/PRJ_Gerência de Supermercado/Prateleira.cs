using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace PRJ_Gerência_de_Supermercado
{
    //Definindo a Classe Prateleira
    public class Prateleira
    {
        private int tamanho;            //Tamanho da prateleira.
        private int numFaltas;          //Nº de "faltas de páginas" na prateleira.
        private int compras;            //Nº de compras realizadas em uma prateleira.

        public int Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        public int NumFaltas
        {
            get { return numFaltas; }
            set { numFaltas = value; }
        }

        public int Compras
        {
            get { return compras; }
            set { compras = value; }
        }

        //Definição de variáveis globais que serão usadas nos 3 algoritmos
        int i;
        int tempo;
        int pos;
        int cont;

        string registro;
        string metodo;

        char ch;
        bool achou;

        string caminho = @"C:\Users\User\Documents\Visual Studio 2013\Projects\PRJ_Gerência de Supermercado\Teste.txt";           //Caminho do arquivo .txt que contém os dados do programa.

        //Função que implementa o Método FIFO para gerência da prateleira
        public void MetodoFIFO(Produto[] vetProd)
        {
            metodo = "FIFO";

            tempo = 0;
            registro = null;

            numFaltas = 0;
            compras = 0;

            Fila prateleira;            //Define uma prateleira do tipo Fila.

            try
            {
                //Tenta a abertura do arquivo
                StreamReader arq = new StreamReader(caminho);

                //EndOfStream significa o fim do arquivo
                while (!arq.EndOfStream)
                {                    
                    cont = 0;

                    Celula aux;
                    Produto xProd;

                    prateleira = new Fila();            //Cria-se uma nova prateleira do tipo Fila.

                    tamanho = Convert.ToInt16(arq.ReadLine());          //Pega na primeira linha do arquivo o tamanho da prateleira.

                    while (!arq.EndOfStream)
                    {
                        registro += arq.ReadLine();         //Lê o resto do arquivo até o final.
                    }

                    //Vai ser pego caractere por caractere do arquivo que será associado a um Produto que vai tentar entrar na prateleira
                    for (i = 0; i < registro.Length; i++)
                    {
                        achou = false;
                        ch = Convert.ToChar(registro.Substring(i, 1));          //Pega cada caractere.

                        if (ch >= '0' && ch <= '9')
                        {
                            pos = Convert.ToInt16(ch.ToString());           //Encontra o produto correspondente àquele caractere.

                            //Acresce no número de vendas do produto, além do tempo e nº de compras de uma prateleira
                            tempo++;

                            vetProd[pos].NumVendas++;
                            compras++;

                            //Atualiza o tempo de último acesso do Produto na prateleira
                            vetProd[pos].UltimoAcesso = tempo;

                            xProd = new Produto();
                            xProd = vetProd[pos];

                            //Percorre toda a prateleira, verificando se o Produto já se encontra na prateleira
                            aux = prateleira.Inicio;
                            while (aux != null && !achou)
                            {
                                if (vetProd[pos].Codigo == aux.item.Codigo)
                                    achou = true;
                                aux = aux.prox;
                            }

                            //Se não encontrou o Produto na prateleira, tenta-se inserí-lo 
                            if (!achou)
                            {
                                numFaltas++;

                                //Caso haja espaço, o Produto é inserido
                                if (cont < tamanho)
                                {
                                    prateleira.Enfileirar(xProd);
                                    cont++;
                                }
                                //Senão, deverá ser feita a substituição de Produtos
                                else
                                {
                                    prateleira.Inicio.item.NumSubstituido++;
                                    prateleira.Desenfileirar(ref prateleira.Inicio.item);
                                    prateleira.Enfileirar(xProd);
                                }
                            }
                        }
                        else if (ch == '.')
                        {
                            tempo++;
                        }

                        //Passo-a-passo mostrando o funcionamento do Algoritmo FIFO a cada tempo
                        Console.WriteLine("\n");
                        Console.Write("Tempo {0}", tempo);
                        aux = prateleira.Inicio;
                        while (aux != null)
                        {
                            Console.Write("\n{0} - {1}: Vendas: {2} Subst.: {3}", aux.item.Codigo, aux.item.Descricao, aux.item.NumVendas, aux.item.NumSubstituido);

                            aux = aux.prox;
                        }
                    }
                }

                arq.Close();            //Fecha o arquivo.

                Console.Write("\n\nPressione <QUALQUER TECLA> para gerar relatório.");
                Console.ReadKey();

                //Mostra relatório
                Relatorio(vetProd, numFaltas, compras, tempo, metodo);
            }

            //Caso gere uma exceção na abertura do arquivo, ela será tratada
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.Write(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.Write(ex.Message);
            }
            catch (FileLoadException ex)
            {
                Console.Write(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.Write(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.Write(ex.Message);
            }
        }

        //Função que implementa o Método LRU para gerência da prateleira
        public void MetodoLRU(Produto[] vetProd)
        {
            metodo = "LRU";

            tempo = 0;
            registro = null;

            numFaltas = 0;
            compras = 0;

            Lista prateleira;           //Define uma prateleira do tipo Lista.

            try
            {
                //Tenta a abertura do arquivo
                StreamReader arq = new StreamReader(caminho);

                //EndOfStream significa o fim do arquivo
                while (!arq.EndOfStream)
                {
                    cont = 0;

                    Celula aux;
                    Celula anterior = null;
                    Produto xProd;

                    prateleira = new Lista();

                    tamanho = Convert.ToInt16(arq.ReadLine());          //Pega na primeira linha do arquivo o tamanho da prateleira.

                    while (!arq.EndOfStream)
                    {
                        registro += arq.ReadLine();         //Lê o resto do arquivo até o final.
                    }

                    //Vai ser pego caractere por caractere do arquivo que será associado a um Produto que vai tentar entrar na prateleira
                    for (i = 0; i < registro.Length; i++)
                    {
                        achou = false;
                        ch = Convert.ToChar(registro.Substring(i, 1));          //Pega cada caractere.

                        if (ch >= '0' && ch <= '9')
                        {
                            pos = Convert.ToInt16(ch.ToString());           //Encontra o produto correspondente àquele caractere.

                            //Acresce no número de vendas do produto, além do tempo e nº de compras de uma prateleira
                            tempo++;

                            vetProd[pos].NumVendas++;
                            compras++;

                            //Atualiza o tempo de último acesso do Produto na prateleira
                            vetProd[pos].UltimoAcesso = tempo;

                            xProd = new Produto();
                            xProd = vetProd[pos];

                            //Busca se o Produto já se encontra na prateleira
                            prateleira.BuscaPosição(xProd.UltimoAcesso, ref anterior, ref achou);

                            //Se não encontrou o Produto na prateleira, tenta-se inserí-lo 
                            if (!achou)
                            {
                                numFaltas++;

                                //Caso haja espaço, o Produto é inserido
                                if (cont < tamanho)
                                {
                                    prateleira.InserirOrdenado(xProd, anterior);
                                    cont++;
                                }
                                //Senão, deverá ser feita a substituição de Produtos
                                else
                                {
                                    prateleira.Inicio.item.NumSubstituido++;
                                    prateleira.Retirar(prateleira.Inicio.item);
                                    prateleira.InserirOrdenado(xProd, anterior);
                                }
                            }
                            //Se o Produto já existe na prateleira, ele será realocado para o final da Lista
                            else
                            {
                                prateleira.Retirar(xProd);

                                prateleira.BuscaPosição(xProd.UltimoAcesso, ref anterior, ref achou);
                                prateleira.InserirOrdenado(xProd, anterior);
                            }
                        }
                        else if (ch == '.')
                        {
                            tempo++;
                        }

                        //Passo-a-passo mostrando o funcionamento do Algoritmo FIFO a cada tempo
                        Console.WriteLine("\n");
                        Console.Write("Tempo {0}", tempo);
                        aux = prateleira.Inicio;
                        while (aux != null)
                        {
                            Console.Write("\n{0} - {1}: Vendas: {2} Subst.: {3}", aux.item.Codigo, aux.item.Descricao, aux.item.NumVendas, aux.item.NumSubstituido);

                            aux = aux.prox;
                        }
                    }
                }

                arq.Close();            //Fecha o arquivo.

                Console.Write("\n\nPressione <QUALQUER TECLA> para gerar relatório.");
                Console.ReadKey();

                //Mostra relatório
                Relatorio(vetProd, numFaltas, compras, tempo, metodo);
            }

            //Caso gere uma exceção na abertura do arquivo, ela será tratada
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.Write(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.Write(ex.Message);
            }
            catch (FileLoadException ex)
            {
                Console.Write(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.Write(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.Write(ex.Message);
            }
        }

        //Função que implementa o Método Segunda Chance para gerência da prateleira
        public void MetodoSegundaChance(Produto[] vetProd)
        {
            metodo = "Segunda Chance";

            tempo = 0;
            registro = null;

            numFaltas = 0;
            compras = 0;

            Fila prateleira;            //Define uma prateleira do tipo Fila.

            try
            {
                //Tenta a abertura do arquivo
                StreamReader arq = new StreamReader(caminho);

                //EndOfStream significa o fim do arquivo
                while (!arq.EndOfStream)
                {

                    cont = 0;

                    Celula aux;
                    Produto xProd;

                    prateleira = new Fila();

                    tamanho = Convert.ToInt16(arq.ReadLine());          //Pega na primeira linha do arquivo o tamanho da prateleira.

                    while (!arq.EndOfStream)
                    {
                        registro += arq.ReadLine();         //Lê o resto do arquivo até o final.
                    }

                    //Vai ser pego caractere por caractere do arquivo que será associado a um Produto que vai tentar entrar na prateleira
                    for (i = 0; i < registro.Length; i++)
                    {
                        achou = false;
                        ch = Convert.ToChar(registro.Substring(i, 1));          //Pega cada caractere.

                        if (ch >= '0' && ch <= '9')
                        {
                            pos = Convert.ToInt16(ch.ToString());           //Encontra o produto correspondente àquele caractere.

                            //Acresce no número de vendas do produto, além do tempo e nº de compras de uma prateleira
                            tempo++;

                            vetProd[pos].NumVendas++;
                            vetProd[pos].BitR = 1;          //BitR - Bit que define se o Produto foi ultimamente referenciado (1 - Sim e 0 - Não).
                            compras++;

                            //Atualiza o tempo de último acesso do Produto na prateleira
                            vetProd[pos].UltimoAcesso = tempo;

                            xProd = new Produto();
                            xProd = vetProd[pos];

                            //Percorre toda a prateleira, verificando se o Produto já se encontra na prateleira
                            aux = prateleira.Inicio;
                            while (aux != null && !achou)
                            {
                                if (vetProd[pos].Codigo == aux.item.Codigo)
                                    achou = true;
                                aux = aux.prox;
                            }

                            //Se não encontrou o Produto na prateleira, tenta-se inserí-lo 
                            if (!achou)
                            {
                                numFaltas++;

                                //Caso haja espaço, o Produto é inserido
                                if (cont < tamanho)
                                {
                                    prateleira.Enfileirar(xProd);
                                    cont++;
                                }
                                //Senão, deverá ser feita a substituição de Produtos
                                else
                                {
                                    //Verifica o BitR do Produto no início da Fila. Se for 0, o produto é retirado.
                                    if (prateleira.Inicio.item.BitR == 0)
                                    {
                                        prateleira.Inicio.item.NumSubstituido++;
                                        prateleira.Desenfileirar(ref prateleira.Inicio.item);
                                        prateleira.Enfileirar(xProd);
                                    }
                                    //Se for 1, seu BitR será zerado e o Produto colocado no final da Fila, recebendo uma 2ª chance
                                    else
                                    {
                                        //Enquanto não encontrar um BitR = 0, a Fila continua sendo percorrida até encontrar
                                        while (prateleira.Inicio.item.BitR != 0)
                                        {
                                            prateleira.Inicio.item.BitR = 0;
                                            prateleira.Enfileirar(prateleira.Inicio.item);
                                            prateleira.Desenfileirar(ref prateleira.Inicio.item);
                                        }
                                        //Ao encontrar um Produto com BitR = 0, ele é substituído
                                        if (prateleira.Inicio.item.BitR == 0)
                                        {
                                            prateleira.Inicio.item.NumSubstituido++;
                                            prateleira.Desenfileirar(ref prateleira.Inicio.item);
                                            prateleira.Enfileirar(xProd);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                xProd.BitR = 1;
                            }
                        }
                        else if (ch == '.')
                        {
                            tempo++;
                        }

                        //Passo-a-passo mostrando o funcionamento do Algoritmo Segunda Chance a cada tempo
                        Console.WriteLine("\n");
                        Console.Write("Tempo {0}", tempo);
                        aux = prateleira.Inicio;
                        while (aux != null)
                        {
                            Console.Write("\n{0} - {1}: Vendas: {2} Subst.: {3}", aux.item.Codigo, aux.item.Descricao, aux.item.NumVendas, aux.item.NumSubstituido);

                            aux = aux.prox;
                        }
                    }
                }

                arq.Close();            //Fecha o arquivo.

                Console.Write("\n\nPressione <QUALQUER TECLA> para gerar relatório.");
                Console.ReadKey();

                //Mostra relatório
                Relatorio(vetProd, numFaltas, compras, tempo, metodo);
            }

            //Caso gere uma exceção na abertura do arquivo, ela será tratada
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.Write(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.Write(ex.Message);
            }
            catch (FileLoadException ex)
            {
                Console.Write(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.Write(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.Write(ex.Message);
            }
        }

        //Função que encontra o(s) Produto(s) mais e menos vendidos
        public void MaisMenosVendido(Produto[] vetProd, int qtde)
        {
            int i;
            int numMax = 0, numMin = qtde;

            for (i = 0; i < vetProd.Length; i++)
            {
                if (vetProd[i].NumVendas > numMax)
                    numMax = vetProd[i].NumVendas;
                if (vetProd[i].NumVendas < numMin)
                    numMin = vetProd[i].NumVendas;
            }

            //Se hover mais de um Produto mais ou menos vendido, será mostrado todos eles
            Console.Write("\nProduto(s) mais vendido(s) ({0} venda(s)):", numMax);
            for (i = 0; i < vetProd.Length; i++)
            {
                if (vetProd[i].NumVendas == numMax)
                    Console.Write("\n{0} - {1}", vetProd[i].Codigo, vetProd[i].Descricao);
            }

            Console.WriteLine();
            Console.Write("\nProduto(s) menos vendido(s) ({0} venda(s)):", numMin);
            for (i = 0; i < vetProd.Length; i++)
            {
                if (vetProd[i].NumVendas == numMin)
                    Console.Write("\n{0} - {1}", vetProd[i].Codigo, vetProd[i].Descricao);
            }
        }

        //Função que gera relatório sobre a prateleira e cada Produto
        public void Relatorio(Produto[] vetProd, int numFaltas, int compras, int tempo, string metodo)
        {
            int i;

            Console.Clear();
            Console.Write("\t\t\tResultados Método {0} \n", metodo);

            Console.Write("\nRelatório da Prateleira: \n");
            Console.Write("\nNúmero de faltas: {0}", numFaltas);
            Console.Write("\nIntervalo médio entre compras: {0}s", (double)tempo / compras);
            MaisMenosVendido(vetProd, registro.Length);         //Chama a função MaisMenosVendido().
            Console.WriteLine();

            Console.Write("\nRelatório dos Produtos: \n");
            for (i = 0; i < vetProd.Length; i++)
            {
                Console.Write("\nProduto: ");
                Console.Write("\nCódigo: {0}", vetProd[i].Codigo);
                Console.Write("\nDescrição: {0}", vetProd[i].Descricao);
                Console.Write("\nNº de vendas: {0}", vetProd[i].NumVendas);

                if (vetProd[i].NumVendas != 0)
                    Console.Write("\nMédia de vendas: 1 venda a cada {0}s", (double)tempo / vetProd[i].NumVendas);
                Console.Write("\nNº de vezes substituído: {0}", vetProd[i].NumSubstituido);
                Console.WriteLine();
            }
        }
    }
}
