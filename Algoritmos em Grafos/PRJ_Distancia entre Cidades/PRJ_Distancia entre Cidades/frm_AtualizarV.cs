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
    public partial class frm_AtualizarV : Form
    {
        public frm_AtualizarV()
        {
            InitializeComponent();

            btn_AtualizarV.Enabled = false;
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
            tbx_Nome.Clear();
            Carregar_ComboBox();
        }

        private void btn_AtualizarV_Click(object sender, EventArgs e)
        {
            try
            {
                //-----Chama a função de atualizar vértice, definida na classe grafo.
                Program.G.Atualizar_Vertice((Vertice)cbx_V.SelectedItem, tbx_Nome.Text);

                MessageBox.Show("Vértice(Cidade) atualizado com sucesso no grafo!!!", "Atualizar Vértice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btn_Limpar_Click(sender, e);
        }

        //-----Só libera o botão de atualizar caso as informações estarem devidamente preenchidas.
        private void cbx_V_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_V.SelectedItem != null)
            {
                Vertice v;

                v = (Vertice)cbx_V.SelectedItem;
                tbx_ID.Text = v.ID.ToString();
                tbx_Nome.Text = v.Nome;
                btn_AtualizarV.Enabled = true;
            }
            else
                btn_AtualizarV.Enabled = false;
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
