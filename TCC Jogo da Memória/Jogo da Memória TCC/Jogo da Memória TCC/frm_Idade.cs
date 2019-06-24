using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memória_TCC
{
    public partial class frm_Idade : Form
    {
        public frm_Idade()
        {
            InitializeComponent();

            label1.Parent = pbx_Fundo;
            label1.BackColor = Color.Transparent;

            label2.Parent = pbx_Fundo;
            label2.BackColor = Color.Transparent;
        }

        private void btn_3Anos_Click(object sender, EventArgs e)
        {
            Program.jogoMem.faixaEtaria = 0;

            frm_Niveis frmNv = new frm_Niveis();
            frmNv.Show();

            this.Visible = false;
        }

        private void btn_4Anos_Click(object sender, EventArgs e)
        {
            Program.jogoMem.faixaEtaria = 0;

            frm_Niveis frmNv = new frm_Niveis();
            frmNv.Show();

            this.Visible = false;
        }

        private void btn_5Anos_Click(object sender, EventArgs e)
        {
            Program.jogoMem.faixaEtaria = 1;

            frm_Niveis frmNv = new frm_Niveis();
            frmNv.Show();

            this.Visible = false;
        }

        private void btn_6Anos_Click(object sender, EventArgs e)
        {
            Program.jogoMem.faixaEtaria = 1;

            frm_Niveis frmNv = new frm_Niveis();
            frmNv.Show();

            this.Visible = false;
        }
    }
}
