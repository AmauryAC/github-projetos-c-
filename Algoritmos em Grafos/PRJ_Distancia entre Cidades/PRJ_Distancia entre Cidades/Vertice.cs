using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_Distancia_entre_Cidades
{
    public class Vertice                    //-----Classe que representa as variáveis de um vértice num grafo. 
    {
        //-----Definição de propriedades e métodos.
        private int _ID;
        private string nome;
        private int grau;
        private int cor;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Grau
        {
            get { return grau; }
            set { grau = value; }
        }

        public int Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        //-----Lista de adjacências de cada vértice.
        public List<Aresta> ListaAdj;

        public Vertice()                    //-----Construtor para inicializar as variáveis.
        {
            _ID = -1;
            nome = null;
            grau = 0;
            //cor = 0;

            ListaAdj = new List<Aresta>();
        }
    }
}
