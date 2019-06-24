using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_Distancia_entre_Cidades
{
    public class Grafo                  //-----Classe que representa as variáveis de um grafo.
    {
        //-----Definição de propriedades e métodos de manipulação do grafo.
        
        //-----Características do grafo.
        private int _IDV;
        private int _IDA;

        private Vertice V;
        private Aresta A;

        private int numVertices;
        private int numArestas;

        private bool eSimples;
        private bool eTrivial;
        private bool eRegular;
        private bool eCompleto;
        private bool eTDesconexo;
        private bool eEuleriano;

        public int IDV
        {
            get { return _IDV; }
            set { _IDV = value; }
        }

        public int IDA
        {
            get { return _IDA; }
            set { _IDA = value; }
        }

        public int NumVertices
        {
            get { return numVertices; }
            set { numVertices = value; }
        }

        public int NumArestas
        {
            get { return numArestas; }
            set { numArestas = value; }
        }

        //-----Lista de vértices num grafo.
        public List<Vertice> ListaV;

        public Grafo()                  //-----Construtor para inicializar as variáveis.
        {
            _IDV = 1;
            _IDA = 1;
            numVertices = 0;
            numArestas = 0;

            eSimples = false;
            eTrivial = false;
            eRegular = false;
            eCompleto = false;
            eTDesconexo = false;
            eCompleto = false;

            ListaV = new List<Vertice>();
        }

        //-----Função que insere um vértice no grafo.
        public void Inserir_Vertice(string nomeCidade)                  
        {
            V = new Vertice();

            V.ID = _IDV;
            V.Nome = nomeCidade;

            //-----Adicionando vértice na lista de vértices do grafo.
            ListaV.Add(V);                  

            _IDV++;
            numVertices++;
        }

        //-----Função que insere uma aresta no grafo.
        public void Inserir_Aresta(Vertice cidade, Vertice cidadeAdj, double distancia, int aux)
        {
            A = new Aresta();

            A.ID = _IDA;
            A.VerticeAdj = cidadeAdj;
            A.Peso = distancia;

            //-----Adicionando aresta na lista de adjacências de dois vértices (Grafo não direcionado).
            cidade.ListaAdj.Add(A);
            cidade.Grau++;
            aux++;

            //-----Já que o grafo é não direcionado, é necessário inserir a aresta na lista de adjacências dos dois vértices.
            if (aux < 2)                    
                Inserir_Aresta(cidadeAdj, cidade, distancia, aux);
            else
            {
                _IDA++;
                numArestas++;
            }
        }

        //-----Função que remove um vértice do grafo.
        public void Remover_Vertice(Vertice cidade)
        {
            if (numVertices > 0)
            {
                //-----É necessário que se remova todas as arestas relacionadas ao vértice primeiro, para depois excluir o vértice.
                while (cidade.ListaAdj.Count > 0)
                {
                    Remover_Aresta(cidade, cidade.ListaAdj[0].VerticeAdj, 0);
                }

                //-----Excluindo o vértice do grafo.
                Program.G.ListaV.Remove(cidade);
                numVertices--;
            }
        }

        //-----Função que remove uma aresta do grafo.
        public void Remover_Aresta(Vertice cidade, Vertice cidadeAdj, int aux)
        {
            if (numArestas > 0)
            {
                A = new Aresta();

                //-----Percorrendo a lista de adjacências dos vértices para exluir as arestas.
                foreach (var x in cidade.ListaAdj)
                {
                    if (x.VerticeAdj == cidadeAdj)
                    {
                        A = x;
                        break;
                    }

                }

                //-----Removendo a aresta da lista de adjacências do vértice.
                cidade.ListaAdj.Remove(A);
                cidade.Grau--;
                aux++;

                //-----Já que o grafo é não direcionado, é necessário excluir a aresta na lista de adjacências dos dois vértices.
                if (aux < 2)
                    Remover_Aresta(cidadeAdj, cidade, aux);
                else
                    numArestas--;
            }
        }

        //-----Função que atualiza um vértice do grafo.
        public void Atualizar_Vertice(Vertice cidade, string nome)
        {
            //-----É necessário atualizar o vértice em todas as listas de adjacências.
            foreach (var x in cidade.ListaAdj)
            {
                for (int i = 0; i < x.VerticeAdj.ListaAdj.Count; i++)
                {
                    if (x.VerticeAdj.ListaAdj[i].VerticeAdj == cidade)
                    {
                        x.VerticeAdj.ListaAdj[i].VerticeAdj.Nome = nome;
                        break;
                    }
                }
            }

            cidade.Nome = nome;
        }

        //-----Função que atualiza uma aresta do grafo.
        public void Atualizar_Aresta(Vertice cidade, Vertice cidadeAdj, double distancia, int aux)
        {
            //-----Percorrendo a lista de adjacências dos vértices para atualizar as arestas.
            foreach (var x in cidade.ListaAdj)
            {
                if (x.VerticeAdj == cidadeAdj)
                {
                    x.Peso = distancia;
                    break;
                }
            }

            aux++;

            //-----Já que o grafo é não direcionado, é necessário atualizar a aresta na lista de adjacências dos dois vértices.
            if (aux < 2)
                Atualizar_Aresta(cidadeAdj, cidade, distancia, aux);
        }

        //-----Função que reinicia o grafo, removendo todos os seus vértices e arestas.
        public void Reiniciar_Grafo()
        {
            ListaV.Clear();

            numVertices = 0;
            numArestas = 0;
        }

        //-----Função que verifica se o grafo é simples.
        public bool Grafo_Simples()
        {
            if (numVertices > 0)
            {
                eSimples = true;

                foreach (var x in ListaV)
                {
                    foreach (var y in x.ListaAdj)
                    {
                        if (x == y.VerticeAdj)
                        {
                            eSimples = false;
                            break;
                        }
                    }
                }
            }
            else
                eSimples = false;
            return eSimples;
        }

        //-----Função que verifica se o grafo é trivial.
        public bool Grafo_Trivial()
        {
            if (numVertices == 1 && numArestas == 0)
                eTrivial = true;
            else
                eTrivial = false;
            return eTrivial;
        }

        //-----Função que verifica se o grafo é regular.
        public bool Grafo_Regular()
        {
            int aux;

            if (numVertices > 0)
            {
                eRegular = true;
                aux = ListaV[0].Grau;

                foreach (var item in ListaV)
                {
                    if (item.Grau != aux)
                    {
                        eRegular = false;
                        break;
                    }
                }
            }
            else
                eRegular = false;
            return eRegular;
        }

        //-----Função que verifica se o grafo é completo.
        public bool Grafo_Completo()
        {
            if ((numArestas == ((numVertices * (numVertices - 1)) / 2)) && numArestas != 0 && numVertices != 0)
                eCompleto = true;
            else
                eCompleto = false;
            return eCompleto;
        }

        //-----Função que verifica se o grafo é totalmente desconexo.
        public bool Grafo_TDesconexo()
        {
            if (numArestas == 0 && numVertices != 0)
                eTDesconexo = true;
            else
                eTDesconexo = false;
            return eTDesconexo;
        }

        //-----Função que verifica se o grafo é euleriano.
        public bool Grafo_Euleriano()
        {
            if (numVertices > 0)
            {
                eEuleriano = true;

                foreach (var item in ListaV)
                {
                    if (item.Grau % 2 != 0 || item.Grau == 0)
                    {
                        eEuleriano = false;
                        break;
                    }
                }
            }
            else
                eEuleriano = false;
            return eEuleriano;
        }

        //-----Função que atribui uma "cor" a cada vértice do grafo, através de uma heurística.
        public void Heuristica_Coloracao()
        {
            int i, cor;
            int TAM = ListaV.Count;

            int[] vetCores = new int[TAM];          //-----Vetor de "cores" indisponíveis.

            //-----"Zera as cores" de cada vértice.
            for (i = 0; i < TAM; i++)
            {
                vetCores[i] = -1;
                ListaV[i].Cor = -1;
            }

            //-----Percorre cada vértice do Grafo.
            for (i = 0; i < TAM; i++)
            {
                //-----Para cada vértice adjacente, verifica se ele já tem uma "cor".
                foreach (var x in ListaV[i].ListaAdj)
                {
                    if (x.VerticeAdj.Cor != -1)
                        vetCores[x.VerticeAdj.Cor-1] = i; 
                }
                cor = 1;          //-----A variável 'cor' representa a "cor" em si.

                //-----Enquanto o vértice é não colorido, procura-se atribuí-lo uma "cor" que não está no vetor de cores indisponíveis.
                while (ListaV[i].Cor == -1)
                {
                    if (vetCores[cor-1] != i)
                        ListaV[i].Cor = cor;
                    else
                        cor = cor + 1;
                }
            }
        }
    }
}
