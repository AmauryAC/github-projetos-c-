using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_Gerência_de_Supermercado
{
    //Definindo a Classe Lista
    public class Lista
    {
        //Define o início e o final da Lista
        private Celula inicio;
        private Celula fim;

        private int tamanho;

        //Propriedades
        public Celula Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }

        public Celula Fim
        {
            get { return fim; }
            set { fim = value; }
        }

        public int Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        //Inicializador de dados (Construtor)
        public Lista()
        {
            inicio = null;
            fim = null;
            tamanho = 0;
        }

        //Função que verifica se a Lista está vazia
        public bool Vazia()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        //Função que busca a posição ordenada um dado na Lista
        public void BuscaPosição(int valor, ref Celula anterior, ref bool achou)
        {
            Celula auxiliar;
            bool fimBusca = false;

            achou = false;
            auxiliar = inicio;
            anterior = null;

            while (auxiliar != null && !fimBusca)
            {
                //Ordenação feita pelo tempo de acesso
                if (valor > Convert.ToInt16(auxiliar.item.UltimoAcesso))
                {
                    anterior = auxiliar;
                    auxiliar = auxiliar.prox;
                }
                else
                {
                    if (valor == Convert.ToInt16(auxiliar.item.UltimoAcesso))
                        achou = true;
                    fimBusca = true;
                }
            }
        }

        //Função que insere ordenadamente um dado na Lista
        public void InserirOrdenado(Produto xProd, Celula anterior)
        {
            Celula auxiliar = new Celula();

            auxiliar.item = xProd;

            if (anterior != null)
            {
                auxiliar.prox = anterior.prox;
                anterior.prox = auxiliar;
            }
            else
            {
                auxiliar.prox = inicio;
                inicio = auxiliar;
            }
            tamanho++;
        }

        //Função que retira um dado da Lista
        public void Retirar(Produto xProd)
        {
            Celula anterior;
            Celula auxiliar;

            if (Vazia())
            {
                Console.Write("\nLista vazia...");
            }
            else
            {
                anterior = null;
                auxiliar = inicio;
                int achou = 0;

                while (auxiliar != null)
                {
                    if (auxiliar.item == xProd)
                    {
                        achou++;
                        if (auxiliar == inicio)
                        {
                            inicio = auxiliar.prox;
                            auxiliar = inicio;
                        }
                        else if (auxiliar == fim)
                        {
                            fim = anterior;
                            fim.prox = null;
                        }
                        else
                        {
                            anterior.prox = auxiliar.prox;
                            auxiliar = auxiliar.prox;
                        }
                    }
                    else
                    {
                        anterior = auxiliar;
                        auxiliar = auxiliar.prox;
                    }
                }
                tamanho = tamanho - achou;
            }
        }
    }
}
