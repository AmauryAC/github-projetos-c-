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
    public partial class frm_InserirA : Form
    {
        public frm_InserirA()
        {
            InitializeComponent();

            tbx_ID.Text = Program.G.IDA.ToString();
            btn_InserirA.Enabled = false;
            Carregar_ComboBox();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            cbx_V1.SelectedItem = null;
            cbx_V2.SelectedItem = null;
            tbx_Distancia.Clear();
        }

        //-----Faz a verificação para saber se aresta já existe.
        private void Verifica_Aresta(Vertice v1, Vertice v2)
        {
            if (v1 == v2)
                throw new Exception("Não se pode ligar um vértice com ele mesmo!!!");

            foreach (var x in v1.ListaAdj)
            {
                if (v2 == x.VerticeAdj)
                    throw new Exception("A aresta em questão já existe!!!");
            }
        }

        private void btn_InserirA_Click(object sender, EventArgs e)
        {
            try
            {
                //-----Chama a função para verificar se aresta já existe.
                Verifica_Aresta((Vertice)cbx_V1.SelectedItem, (Vertice)cbx_V2.SelectedItem);

                //-----Chama a função de inserir aresta definida na classe grafo.
                Program.G.Inserir_Aresta((Vertice)cbx_V1.SelectedItem, (Vertice)cbx_V2.SelectedItem, Convert.ToDouble(tbx_Distancia.Text), 0);

                MessageBox.Show("Aresta inserida com sucesso no grafo!!!", "Inserir Aresta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btn_Limpar_Click(sender, e);
            tbx_ID.Text = Program.G.IDA.ToString();
        }

        private void cbx_V1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-----Só libera o botão de inserir caso as informações estarem devidamente preenchidas.
            if (cbx_V1.SelectedItem != null && cbx_V2.SelectedItem != null && tbx_Distancia.Text != "")
                btn_InserirA.Enabled = true;
            else
                btn_InserirA.Enabled = false;
        }

        private void tbx_Distancia_TextChanged(object sender, EventArgs e)
        {
            //-----Só libera o botão de inserir caso as informações estarem devidamente preenchidas.
            cbx_V1_SelectedIndexChanged(sender, e);
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
