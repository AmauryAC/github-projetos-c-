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
    public partial class frm_ExcluirA : Form
    {
        public frm_ExcluirA()
        {
            InitializeComponent();

            btn_ExcluirA.Enabled = false;
            Carregar_ComboBox();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tbx_ID.Clear();
            cbx_V1.SelectedItem = null;
            cbx_V2.SelectedItem = null;
            Carregar_ComboBox();
        }

        private void btn_ExcluirA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir essa Aresta?", "Excluir Aresta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //-----Chama a função de excluir aresta, definida na classe grafo.
                    Program.G.Remover_Aresta((Vertice)cbx_V1.SelectedItem, (Vertice)cbx_V2.SelectedItem, 0);

                    MessageBox.Show("Aresta removida com sucesso no grafo!!!", "Excluir Aresta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btn_Limpar_Click(sender, e);
        }

        //-----Só libera o botão de excluir caso as informações estarem devidamente preenchidas.
        private void cbx_V1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-----O combobox é "carregado" de acordo com os vértices adjacentes do vértice escolhido.
            if (cbx_V1.SelectedItem != null && cbx_V2.SelectedItem == null)
            {
                Vertice v;

                v = (Vertice)cbx_V1.SelectedItem;

                cbx_V2.Items.Clear();
                foreach (var item in v.ListaAdj)
                {
                    cbx_V2.Items.Add(item.VerticeAdj);
                }
            }

            if (cbx_V2.SelectedItem != null && cbx_V1.SelectedItem == null)
            {
                Vertice v;

                v = (Vertice)cbx_V2.SelectedItem;

                cbx_V1.Items.Clear();
                foreach (var item in v.ListaAdj)
                {
                    cbx_V1.Items.Add(item.VerticeAdj);
                }
            }

            if (cbx_V1.SelectedItem != null && cbx_V2.SelectedItem != null)
            {
                Aresta a;

                foreach (var x in Program.G.ListaV)
                {
                    if (x == cbx_V1.SelectedItem)
                    {
                        foreach (var y in x.ListaAdj)
                        {
                            if (y.VerticeAdj == cbx_V2.SelectedItem)
                            {
                                a = y;
                                tbx_ID.Text = a.ID.ToString();
                                break;
                            }
                        }
                    }
                }

                btn_ExcluirA.Enabled = true;
            }
            else
                btn_ExcluirA.Enabled = false;
        }

        private void Carregar_ComboBox()
        {
            cbx_V1.Items.Clear();
            cbx_V2.Items.Clear();

            foreach (var item in Program.G.ListaV)
            {
                cbx_V1.Items.Add(item);
                cbx_V2.Items.Add(item);
            }
            cbx_V1.DisplayMember = "Nome";
            cbx_V2.DisplayMember = "Nome";
        }
    }
}
