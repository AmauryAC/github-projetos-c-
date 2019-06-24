using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_Gerência_de_Supermercado
{
    //Definindo a Classe Célula
    public class Celula
    {
        public Produto item;
        public Celula prox;         //Ponteiro que aponta para a próxima posição da Lista ou Fila.

        //Inicializador de dados (Construtor)
        public Celula()
        {
            item = new Produto();
            prox = null;
        }
    }
}
