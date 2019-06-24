using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_Distancia_entre_Cidades
{
    public class Aresta                 //-----Classe que representa as variáveis de um aresta num grafo.
    {
        //-----Definição de propriedades e métodos.
        private int _ID;
        private Vertice verticeAdj;
        private double peso;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public Vertice VerticeAdj
        {
            get { return verticeAdj; }
            set { verticeAdj = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public Aresta()                 //-----Construtor para inicializar as variáveis.
        {
            _ID = -1;
            verticeAdj = null;
            peso = 0.0;
        }
    }
}
