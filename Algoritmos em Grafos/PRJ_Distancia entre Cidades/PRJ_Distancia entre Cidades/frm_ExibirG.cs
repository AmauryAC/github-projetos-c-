using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_Distancia_entre_Cidades
{
    public partial class frm_ExibirG : Form
    {
        public frm_ExibirG()
        {
            InitializeComponent();
        }

        //-----Função que exibe todos os vértices e arestas do grafo, além de sua classificação.
        private void frm_ExibirG_Load(object sender, EventArgs e)
        {
            if (Program.G.NumVertices == 0)
            {
                lbx_Exibir.Items.Clear();
                lbx_Exibir.Items.Add("Grafo Nulo:");
                lbx_Exibir.Items.Add("Não há nenhum vértice inserido.");
            }
            else
            {
                lbx_Exibir.Items.Add("\tGrafo (Distância entre Cidades)");
                lbx_Exibir.Items.Add("");

                foreach (var x in Program.G.ListaV)
                {
                    lbx_Exibir.Items.Add("Vértice(Cidade): " + x.Nome + " (Grau = " + x.Grau + "):");

                    foreach (var y in x.ListaAdj)
                    {
                        lbx_Exibir.Items.Add(x.Nome + " ----- " + y.VerticeAdj.Nome + " ----> " + y.Peso + " km");
                    }
                    lbx_Exibir.Items.Add("");
                }

                //-----Escreve em labels o número de vértices e arestas.
                lbl_NV.Text = Program.G.NumVertices.ToString();
                lbl_NA.Text = Program.G.NumArestas.ToString();

                //-----"Marca" todas as características do grafo.
                if (Program.G.Grafo_Simples())
                    clb_TG.SetItemChecked(0, true);
                if (Program.G.Grafo_Trivial())
                    clb_TG.SetItemChecked(1, true);
                if (Program.G.Grafo_Regular())
                    clb_TG.SetItemChecked(2, true);
                if (Program.G.Grafo_Completo())
                    clb_TG.SetItemChecked(3, true);
                if (Program.G.Grafo_TDesconexo())
                    clb_TG.SetItemChecked(4, true);
                if (Program.G.Grafo_Euleriano())
                    clb_TG.SetItemChecked(5, true);
            }
        }
    }
}
