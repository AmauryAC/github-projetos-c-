using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_Simplex
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Aciona o formulário de variáveis e restrições do problema
            frmVariaveis frmV = new frmVariaveis();
            frmV.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmSobre frmS = new frmSobre();
            frmS.Show();
        }
    }
}
