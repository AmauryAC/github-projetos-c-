using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_Gerência_de_Supermercado
{
    //Definindo a Classe Fila
    public class Fila
    {
        //Define o início e o final da Fila
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
        public Fila()
        {
            inicio = null;
            fim = null;
            tamanho = 0;
        }

        //Função que verifica se a Fila está vazia
        public bool Vazia()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        //Função que enfileira um dado na Fila
        public void Enfileirar(Produto xProd)
        {
            Celula auxiliar = new Celula();

            auxiliar.item = xProd;
            auxiliar.prox = null;

            if (Vazia())
            {
                inicio = auxiliar;
                fim = auxiliar;
                auxiliar.prox = null;
            }
            else
            {
                fim.prox = auxiliar;
                fim = auxiliar;
            }
            tamanho++;
        }

        //Função que desenfileira um dado da Fila
        public void Desenfileirar(ref Produto xProd)
        {
            if (Vazia())
            {
                Console.Write("\nFila Vazia!!!");
            }
            else
            {
                xProd = inicio.item;
                inicio = inicio.prox;
            }
            tamanho--;
        }
    }
}
