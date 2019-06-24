/*
 * Classe Simplex para resolução de problemas de programação linear, utilizando o algoritmo.
 * Desenvolvedores: Amaury A. Costa
 *                  Shayane O. Santos
 * Otimização de Sistemas Computacionais
 * Data de Entrega: 02/06/2017
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Simplex
{
    public class Simplex
    {
        private int numLinhas, numColunas;  //Número de linhas e colunas da tabela do Simplex

        //Tabela do Simplex
        private double[,] tabelaSimplex;

        public double[,] TabelaSimplex
        {
            get { return tabelaSimplex; }
            set { tabelaSimplex = value; }
        }

        //Quantidade de variáveis de decisão do problema
        private int qtdVariaveis;

        public int QtdeVariaveis
        {
            get { return qtdVariaveis; }
            set { qtdVariaveis = value; }
        }

        //Quantidade de restrições técnicas do problema
        private int qtdRestricoes;

        public int QtdRestricoes
        {
            get { return qtdRestricoes; }
            set { qtdRestricoes = value; }
        }

        //Índice da coluna que entra da tabela
        private int indiceColunaEntra;

        public int IndiceColunaEntra
        {
            get { return indiceColunaEntra; }
            set { indiceColunaEntra = value; }
        }

        //Índice da linha que sai da tabela
        private int indiceLinhaSai;

        public int IndiceLinhaSai
        {
            get { return indiceLinhaSai; }
            set { indiceLinhaSai = value; }
        }

        //Elemento pivô da tabela
        private double elementoPivo;

        public double ElementoPivo
        {
            get { return elementoPivo; }
            set { elementoPivo = value; }
        }

        //Vetor com a nova linha pivô da tabela
        private double[] novaLinhaPivo;

        public double[] NovaLinhaPivo
        {
            get { return novaLinhaPivo; }
            set { novaLinhaPivo = value; }
        }

        //Número de iterações do problema
        private int numIteracoes;

        public int NumIteracoes
        {
            get { return numIteracoes; }
            set { numIteracoes = value; }
        }

        public Simplex()
        {
            //---
        }

        //Construtor para cálculo do Simplex
        public Simplex(int qtdVar, int qtdRestr, double[] vetFuncaoObjetivo, double[,] matRestricoes)
        {
            try
            {
                qtdVariaveis = qtdVar;
                qtdRestricoes = qtdRestr;

                numLinhas = qtdRestr + 1;
                numColunas = qtdVar + qtdRestr + 2;

                tabelaSimplex = new double[numLinhas, numColunas];

                ZerarTabela();
                PreencherTabela(vetFuncaoObjetivo, matRestricoes);

                numIteracoes = 0;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao iniciar o Simplex: " + ex.Message);
            }
        }

        //Método para zerar a tabela do Simplex
        public void ZerarTabela()
        {
            try
            {
                for (int i = 0; i < numLinhas; i++)
                {
                    for (int j = 0; j < numColunas; j++)
                    {
                        tabelaSimplex[i, j] = 0;
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao zerar a tabela: " + ex.Message);
            }
        }

        //Método para preencher a tabela do Simplex, que recebe os dados digitados pelo usuário
        public void PreencherTabela(double[] vetFuncObj, double[,] matRestr)
        {
            int indiceFolga;

            try
            {
                indiceFolga = qtdVariaveis + 1;

                if (vetFuncObj[0] == 0) //Tag que representa que a função objetivo é de maximização
                {
                    tabelaSimplex[0, 0] = 1;    //Preenchendo o valor de z, na funçao objetivo

                    for (int i = 1; i < vetFuncObj.Length; i++)
                    {
                        tabelaSimplex[0, i] = vetFuncObj[i] * (-1);
                    }
                }

                for (int i = 0; i < matRestr.GetLength(0); i++)
                {
                    tabelaSimplex[i + 1, 0] = 0;

                    for (int j = 0; j < matRestr.GetLength(1) - 2; j++)
                    {
                        tabelaSimplex[i + 1, j + 1] = matRestr[i, j];
                    }

                    if (matRestr[i, matRestr.GetLength(1) - 2] == 0) //Tag que representa que a restrição tem o sinal de <=
                    {
                        tabelaSimplex[i + 1, indiceFolga] = 1;
                        tabelaSimplex[i + 1, numColunas - 1] = matRestr[i, matRestr.GetLength(1) - 1];

                        indiceFolga++;
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao preencher a tabela: " + ex.Message);
            }
        }

        //Método para verificar se há um coeficiente negativo na primeira linha da tabela
        public bool VerificarNegativo()
        {
            try
            {
                for (int col = 0; col < numColunas; col++)
                {
                    if (tabelaSimplex[0, col] < 0)
                        return true;
                }

                return false;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao verificar se há coeficiente negativo na função objetivo: " + ex.Message);
            }
        }

        //Método para calcular a coluna que entra
        public void CalcularColunaQueEntra()
        {
            double menor;

            try
            {
                menor = 0;

                for (int col = 1; col < numColunas - 1; col++)
                {
                    if (tabelaSimplex[0, col] < menor)
                    {
                        menor = tabelaSimplex[0, col];
                        indiceColunaEntra = col;
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao calcular coluna que entra: " + ex.Message);
            }
        }

        //Método para calcular a linha que sai
        public void CalcularLinhaQueSai()
        {
            double menor;
            double divisao;

            try
            {
                divisao = tabelaSimplex[1, numColunas - 1] / tabelaSimplex[1, indiceColunaEntra];

                menor = divisao;
                indiceLinhaSai = 1;

                for (int lin = 2; lin < numLinhas; lin++)
                {
                    try
                    {
                        divisao = tabelaSimplex[lin, numColunas - 1] / tabelaSimplex[lin, indiceColunaEntra];
                    }
                    catch (DivideByZeroException)
                    {
                        divisao = 0;
                    }

                    if (divisao > 0 && divisao < menor)
                    {
                        menor = divisao;
                        indiceLinhaSai = lin;
                    }
                }

                elementoPivo = tabelaSimplex[indiceLinhaSai, indiceColunaEntra];
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao calcular linha que sai: " + ex.Message);
            }
        }

        //Método para calcular a nova linha pivô, pelo elemento pivô
        public void CalcularNovaLinhaPivo()
        {
            try
            {
                novaLinhaPivo = new double[numColunas];

                for (int col = 0; col < numColunas; col++)
                {
                    novaLinhaPivo[col] = tabelaSimplex[indiceLinhaSai, col] / elementoPivo;

                    tabelaSimplex[indiceLinhaSai, col] = novaLinhaPivo[col];
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao calcular nova linha pivô: " + ex.Message);
            }
        }

        //Método para calcular as novas linhas da tabela
        public void CalcularNovasLinhas()
        {
            double multiplicador;

            try
            {
                for (int lin = 0; lin < numLinhas; lin++)
                {
                    if (lin != indiceLinhaSai)
                    {
                        multiplicador = tabelaSimplex[lin, indiceColunaEntra] * (-1);

                        for (int col = 0; col < numColunas; col++)
                        {
                            tabelaSimplex[lin, col] += (novaLinhaPivo[col] * multiplicador);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao calcular nova linha: " + ex.Message);
            }
        }

        //Método para executar cada iteração do Simplex
        public void CalcularInteracao()
        {
            try
            {
                CalcularColunaQueEntra();
                CalcularLinhaQueSai();
                CalcularNovaLinhaPivo();
                CalcularNovasLinhas();

                numIteracoes++;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao calcular o Simplex: " + ex.Message);
            }
        }

        //Método para executar todas as iterações do Simplex
        public void CalcularResultado()
        {
            try
            {
                while (VerificarNegativo())
                {
                    CalcularInteracao();
                }

                CalcularVariaveisFinais();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao calcular o Simplex: " + ex.Message);
            }
        }

        //Método para retornar um vetor com os resultados de cada variável
        public double[] CalcularVariaveisFinais()
        {
            int qtdNumeroUm;

            double[] vetResultadoFinal = new double[numColunas];

            try
            {
                for(int j = 1; j < numColunas - 1; j++)
                {
                    qtdNumeroUm = 0;

                    for (int i = 1; i < numLinhas; i++)
                    {
                        if (tabelaSimplex[i, j] != 0 && tabelaSimplex[i, j] != 1)
                        {
                            vetResultadoFinal[j] = 0;

                            break;
                        }
                        else if (tabelaSimplex[i, j] == 1 && qtdNumeroUm == 0)
                        {
                            qtdNumeroUm++;

                            vetResultadoFinal[j] = tabelaSimplex[i, numColunas - 1];
                        }
                        else if (tabelaSimplex[i, j] == 1 && qtdNumeroUm > 0)
                        {
                            vetResultadoFinal[j] = 0;

                            break;
                        }
                    }

                    vetResultadoFinal[numColunas - 1] = tabelaSimplex[0, numColunas - 1];
                }

                return vetResultadoFinal;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao calcular as variáveis finais do Simplex: " + ex.Message);
            }
        }

        //---
    }
}
