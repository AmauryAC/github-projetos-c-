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
    public partial class frmVariaveis : Form
    {
        public frmVariaveis()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                //Aciona o formulário de modelagem do problema
                frmModelagem frmM = new frmModelagem(Convert.ToInt16(this.numQtdVD.Value), Convert.ToInt16(this.numQtdRT.Value));
                frmM.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
