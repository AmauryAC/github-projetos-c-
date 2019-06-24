using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class frm_Calculadora : Form
    {
        int op, cont, aux;

        public Calculadora calc = new Calculadora();

        public frm_Calculadora()
        {
            InitializeComponent();
        }

        private void btn_ONeC_Click(object sender, EventArgs e)
        {
            calc.LigarZerarDesligar(1);

            tbx_Visor.Text = "0";
            tbx_Visor.Enabled = true;

            cont = 0;
            aux = 0;
        }

        private void btn_OFF_Click(object sender, EventArgs e)
        {
            calc.LigarZerarDesligar(0);

            tbx_Visor.Text = null;
            tbx_Visor.Enabled = false;
        }

        private void btn_Num_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;

            if (calc.Ligada == true)
            {
                if (aux != 0)
                {
                    tbx_Visor.Clear();
                    aux = 0;
                }

                if (botao.Text == "." && cont == 0)
                {
                    tbx_Visor.Text = tbx_Visor.Text + ",";
                    cont++;
                }

                else if (tbx_Visor.Text == "0")
                    tbx_Visor.Text = botao.Text;
                else if (botao.Text != ".")
                    tbx_Visor.Text = tbx_Visor.Text + botao.Text;
            }
        }

        private void btn_Op_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;

            if (calc.Ligada == true)
            {
                if (botao.Text == "+")
                    op = 1;
                else if (botao.Text == "-")
                    op = 2;
                else if (botao.Text == "x")
                    op = 3;
                else if (botao.Text == "/")
                    op = 4;
                else if (botao.Text == "r")
                    op = 5;
                else if (botao.Text == "%")
                    op = 6;

                calc.Operacao(op, Convert.ToDouble(tbx_Visor.Text));
                tbx_Visor.Text = calc.VetOp[0].ToString();

                aux++;
                cont = 0;
            }
        }
    }
}
