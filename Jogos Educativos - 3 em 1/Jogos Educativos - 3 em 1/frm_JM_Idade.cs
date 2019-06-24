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
    public partial class frm_JM_Idade : Form
    {
        frm_JM_Niveis frmNv;

        public frm_JM_Idade()
        {
            InitializeComponent();
        }

        private void frm_JM_Idade_Load(object sender, EventArgs e)
        {
            lbl_Titulo.Parent = pbx_Fundo;
            lbl_Idade.Parent = pbx_Fundo;

            lbl_Titulo.BackColor = Color.Transparent;
            lbl_Idade.BackColor = Color.Transparent;
        }

        private void btn_3Anos_Click(object sender, EventArgs e)
        {
            frmNv = new frm_JM_Niveis(0);
            frmNv.Show();

            this.Visible = false;
        }

        private void btn_4Anos_Click(object sender, EventArgs e)
        {
            frmNv = new frm_JM_Niveis(0);
            frmNv.Show();

            this.Visible = false;
        }

        private void btn_5Anos_Click(object sender, EventArgs e)
        {
            frmNv = new frm_JM_Niveis(1);
            frmNv.Show();

            this.Visible = false;
        }

        private void btn_6Anos_Click(object sender, EventArgs e)
        {
            frmNv = new frm_JM_Niveis(1);
            frmNv.Show();

            this.Visible = false;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_Menu frmMn = new frm_Menu();
            frmMn.Show();

            this.Visible = false;
        }

        private void frm_JM_Idade_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
