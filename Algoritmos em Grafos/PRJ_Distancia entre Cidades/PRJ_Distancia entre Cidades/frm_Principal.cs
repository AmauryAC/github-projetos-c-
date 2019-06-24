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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair da aplicação?", "Sair da Aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        //-----Rotinas que abrem um formulário ou executam alguma ação, caso seja clicado um botão do Menu Principal.
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmr_Principal_Tick(object sender, EventArgs e)
        {
            tssl_Data.Text = DateTime.Now.ToLongDateString();
            tssl_Hora.Text = DateTime.Now.ToShortTimeString();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-----Ao clicar em Novo, será instanciado um grafo, para que possa ser manipulado.
            Program.G = new Grafo();

            //-----Habilita botões de edição.
            editarToolStripMenuItem.Enabled = true;
            exibirToolStripMenuItem.Enabled = true;
            heurísticaDaColoraçãoToolStripMenuItem.Enabled = true;

            tsb_IV.Enabled = true;
            tsb_IA.Enabled = true;
            tsb_EV.Enabled = true;
            tsb_EA.Enabled = true;
            tsb_AV.Enabled = true;
            tsb_AA.Enabled = true;
            tsb_RG.Enabled = true;
            tsb_EG.Enabled = true;

            novoToolStripMenuItem.Enabled = false;
            tsb_Novo.Enabled = false;
        }

        private void vérticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_InserirV frmIV = new frm_InserirV();
            frmIV.Show();
        }

        private void arestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_InserirA frmIA = new frm_InserirA();
            frmIA.Show();
        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ExibirG frmEG = new frm_ExibirG();
            frmEG.Show();
        }

        private void vérticeCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ExcluirV frmEV = new frm_ExcluirV();
            frmEV.Show();
        }

        private void arestaDistânciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ExcluirA frmEA = new frm_ExcluirA();
            frmEA.Show();
        }

        private void vérticeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_AtualizarV frmAV = new frm_AtualizarV();
            frmAV.Show();
        }

        private void arestaPesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AtualizarA frmAA = new frm_AtualizarA();
            frmAA.Show();
        }

        private void reiniciarGrafonãoImplementadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente apagar todos os componentes do Grafo?", "Reiniciar Grafo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Program.G.Reiniciar_Grafo();

                    MessageBox.Show("Grafo reiniciado com sucesso!!!", "Reiniciar Grafo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void heurísticaDaColoraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ExibirC frmEC = new frm_ExibirC();
            frmEC.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aplicacao = Application.StartupPath;
            string caminho = aplicacao + @"\Manual do Usuário.pdf";

            System.Diagnostics.Process.Start(caminho);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sobre frmS = new frm_Sobre();
            frmS.Show();
        }

        private void tsb_Novo_Click(object sender, EventArgs e)
        {
            novoToolStripMenuItem_Click(sender, e);
        }

        private void tsb_IV_Click(object sender, EventArgs e)
        {
            vérticeToolStripMenuItem_Click(sender, e);
        }

        private void tsb_IA_Click(object sender, EventArgs e)
        {
            arestaToolStripMenuItem_Click(sender, e);
        }

        private void tsb_EV_Click(object sender, EventArgs e)
        {
            vérticeCidadeToolStripMenuItem_Click(sender, e);
        }

        private void tsb_EA_Click(object sender, EventArgs e)
        {
            arestaDistânciaToolStripMenuItem_Click(sender, e);
        }

        private void tsb_AV_Click(object sender, EventArgs e)
        {
            vérticeToolStripMenuItem1_Click(sender, e);
        }

        private void tsb_AA_Click(object sender, EventArgs e)
        {
            arestaPesoToolStripMenuItem_Click(sender, e);
        }

        private void tsb_RG_Click(object sender, EventArgs e)
        {
            reiniciarGrafonãoImplementadoToolStripMenuItem_Click(sender, e);
        }

        private void tsb_EG_Click(object sender, EventArgs e)
        {
            exibirToolStripMenuItem_Click(sender, e);
        }

        private void tsb_Ajuda_Click(object sender, EventArgs e)
        {
            ajudaToolStripMenuItem_Click(sender, e);
        }

        private void tsb_Sobre_Click(object sender, EventArgs e)
        {
            sobreToolStripMenuItem_Click(sender, e);
        }

        private void tsb_Sair_Click(object sender, EventArgs e)
        {
            sairToolStripMenuItem_Click(sender, e);
        }
    }
}
