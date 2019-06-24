using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memória_com_Níveis
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_Facil_Click(object sender, EventArgs e)
        {
            frm_NFacil frmNF = new frm_NFacil();
            frmNF.Show();
        }

        private void frm_Medio_Click(object sender, EventArgs e)
        {
            frm_NMedio frmNM = new frm_NMedio();
            frmNM.Show();
        }

        private void btn_Dificil_Click(object sender, EventArgs e)
        {
            frm_NDificil frmND = new frm_NDificil();
            frmND.Show();
        }
    }
}
