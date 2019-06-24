using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mudança_de_Base
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();

            cmb_De.SelectedIndex = 2;
            cmb_De.Enabled = false;
        }

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair da aplicação?", "Sair da Aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            //cmb_De.SelectedItem = null;
            cmb_Para.SelectedItem = null;

            tbx_BaseOriginal.Text = null;
            tbx_Resultado.Text = null;

            lbl_Resultado.Text = "Resultado:";

            tbx_BaseOriginal.Enabled = false;
            tbx_Resultado.Enabled = false;
        }

        private void btn_Converter_Click(object sender, EventArgs e)
        {
            int num;
            int _base = 0;

            tbx_Resultado.Text = null;

            try
            {
                num = Convert.ToInt32(tbx_BaseOriginal.Text);

                if (num < 0)
                    throw new Exception("A Aplicação não tem suporte para converter valores negativos.");

                if (cmb_Para.SelectedIndex == 0)
                    _base = 2;
                else if (cmb_Para.SelectedIndex == 1)
                    _base = 8;
                else if (cmb_Para.SelectedIndex == 2)
                    _base = 10;
                else if (cmb_Para.SelectedIndex == 3)
                    _base = 16;

                Muda_Base(num, _base);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Habilita()
        {
            if ((cmb_De.SelectedIndex >= 0 && cmb_De.SelectedIndex < cmb_De.ItemHeight) && (cmb_Para.SelectedIndex >= 0 && cmb_Para.SelectedIndex < cmb_De.ItemHeight))
            {
                tbx_BaseOriginal.Enabled = true;
            }
        }

        private void cmb_De_SelectedIndexChanged(object sender, EventArgs e)
        {
            Habilita();
        }

        private void cmb_Para_SelectedIndexChanged(object sender, EventArgs e)
        {
            Habilita();
        }

        public void Muda_Base(int num, int _base)
        {
            Pilha p = new Pilha();

            int aux = num;
            int resto;

            while (num != 0)
            {
                resto = num % _base;
                p.Empilhar(resto);
                num = num / _base;
            }

            lbl_Resultado.Text = aux + "  na base " + _base + " = ";

            while (!p.Vazia())
            {
                p.Desempilhar(ref num);

                if (num > 9)
                    tbx_Resultado.Text = tbx_Resultado.Text + (char)(num + 55);
                else
                    tbx_Resultado.Text = tbx_Resultado.Text + num;
            }
        }
    }
}
