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
    public partial class frm_ExibirC : Form
    {
        public frm_ExibirC()
        {
            InitializeComponent();
        }

        private void frm_ExibirC_Load(object sender, EventArgs e)
        {
            int numCores = 0;

            if (Program.G.NumVertices == 0)
            {
                lbx_Exibir.Items.Clear();
                lbx_Exibir.Items.Add("Grafo Nulo:");
                lbx_Exibir.Items.Add("Não há nenhum vértice inserido.");
            }
            else
            {
                Program.G.Heuristica_Coloracao();

                lbx_Exibir.Items.Add("\t\tHeurística da Coloração");
                lbx_Exibir.Items.Add("");

                foreach (var x in Program.G.ListaV)
                {
                    lbx_Exibir.Items.Add("Vértice(Cidade): " + x.Nome + " -------> Cor = " + x.Cor);

                    if (x.Cor > numCores)
                        numCores = x.Cor;
                }

                lbx_Exibir.Items.Add("");
                lbx_Exibir.Items.Add("Cores usadas: " + numCores);
            }
        }
    }
}
