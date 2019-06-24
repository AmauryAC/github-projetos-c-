using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogos_Educativos___3_em_1
{
    public partial class frm_JM_Niveis : Form
    {
        public int faixaEtaria;

        frm_JM_TelaJogo frmTJ;

        public frm_JM_Niveis()
        {
            InitializeComponent();
        }

        public frm_JM_Niveis(int fe)
        {
            InitializeComponent();

            faixaEtaria = fe;
        }

        private void frm_JM_Niveis_Load(object sender, EventArgs e)
        {
            lbl_Titulo.Parent = pbx_Fundo;
            lbl_Nivel.Parent = pbx_Fundo;

            lbl_Titulo.BackColor = Color.Transparent;
            lbl_Nivel.BackColor = Color.Transparent;
        }

        private void btn_Facil_Click(object sender, EventArgs e)
        {
            if (faixaEtaria == 0)
            {
                frmTJ = new frm_JM_TelaJogo(faixaEtaria, 0, 2, 4);
                frmTJ.Show();
            }
            else if (faixaEtaria == 1)
            {
                frmTJ = new frm_JM_TelaJogo(faixaEtaria, 0, 3, 4);
                frmTJ.Show();
            }

            this.Visible = false;
        }

        private void btn_Medio_Click(object sender, EventArgs e)
        {
            if (faixaEtaria == 0)
            {
                frmTJ = new frm_JM_TelaJogo(faixaEtaria, 1, 3, 4);
                frmTJ.Show();
            }
            else if (faixaEtaria == 1)
            {
                frmTJ = new frm_JM_TelaJogo(faixaEtaria, 1, 4, 4);
                frmTJ.Show();
            }

            this.Visible = false;
        }

        private void btn_Dificil_Click(object sender, EventArgs e)
        {
            if (faixaEtaria == 0)
            {
                frmTJ = new frm_JM_TelaJogo(faixaEtaria, 2, 4, 4);
                frmTJ.Show();
            }
            else if (faixaEtaria == 1)
            {
                frmTJ = new frm_JM_TelaJogo(faixaEtaria, 2, 4, 6);
                frmTJ.Show();
            }

            this.Visible = false;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_JM_Idade frmId = new frm_JM_Idade();
            frmId.Show();

            this.Visible = false;
        }

        private void frm_JM_Niveis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
