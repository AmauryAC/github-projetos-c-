using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mudança_de_Base
{
    public class Pilha
    {
        private Celula topo;

        public Celula Topo
        {
            get { return topo; }
            set { topo = value; }
        }

        public Pilha()
        {
            topo = null;
        }

        public bool Vazia()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void Esvaziar()
        {
            topo = null;
        }

        public void Empilhar(int valor)
        {
            Celula auxiliar = new Celula();

            auxiliar.item = valor;

            if (Vazia())
            {
                auxiliar.prox = null;
            }
            else
            {
                auxiliar.prox = topo;
            }
            topo = auxiliar;
        }

        public void Desempilhar(ref int valor)
        {
            if (Vazia())
            {
                Console.Write("\nPilha vazia!!!");
            }
            else
            {
                valor = topo.item;
                topo = topo.prox;
            }
        }
    }
}
