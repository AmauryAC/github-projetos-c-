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
    public partial class frm_InserirV : Form
    {
        public frm_InserirV()
        {
            InitializeComponent();

            tbx_ID.Text = Program.G.IDV.ToString();
            btn_InserirV.Enabled = false;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tbx_Nome.Clear();
        }

        private void btn_InserirV_Click(object sender, EventArgs e)
        {
            try
            {
                //-----Chama a função de inserir vértice, definida na classe grafo.
                Program.G.Inserir_Vertice(tbx_Nome.Text);

                MessageBox.Show("Vértice(Cidade) inserido com sucesso no grafo!!!", "Inserir Vértice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btn_Limpar_Click(sender, e);
            tbx_ID.Text = Program.G.IDV.ToString();
        }

        private void tbx_Nome_TextChanged(object sender, EventArgs e)
        {
            //-----Só libera o botão de inserir caso estiver com todas as informações preenchidas.
            if (tbx_Nome.Text != "")
                btn_InserirV.Enabled = true;
            else
                btn_InserirV.Enabled = false;
        }
    }
}
