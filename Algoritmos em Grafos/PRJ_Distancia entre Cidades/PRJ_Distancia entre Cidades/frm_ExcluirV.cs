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
    public partial class frm_ExcluirV : Form
    {
        public frm_ExcluirV()
        {
            InitializeComponent();

            btn_ExcluirV.Enabled = false;
            Carregar_ComboBox();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tbx_ID.Clear();
            cbx_V.SelectedItem = null;
            Carregar_ComboBox();
        }

        private void btn_ExcluirV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse Vértice?", "Excluir Vértice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //-----Chama a função de excluir vértice, definida na classe grafo.
                    Program.G.Remover_Vertice((Vertice)cbx_V.SelectedItem);

                    MessageBox.Show("Vértice(Cidade) removido com sucesso no grafo!!!", "Excluir Vértice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btn_Limpar_Click(sender, e);
        }

        //-----Só libera o botão de excluir caso as informações estarem devidamente preenchidas.
        private void cbx_V_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_V.SelectedItem != null)
            {
                Vertice v;

                v = (Vertice)cbx_V.SelectedItem;
                tbx_ID.Text = v.ID.ToString();
                btn_ExcluirV.Enabled = true;
            }
            else
                btn_ExcluirV.Enabled = false;
        }

        private void Carregar_ComboBox()
        {
            cbx_V.Items.Clear();

            foreach (var item in Program.G.ListaV)
            {
                cbx_V.Items.Add(item);
            }
            cbx_V.DisplayMember = "Nome";
        }
    }
}
