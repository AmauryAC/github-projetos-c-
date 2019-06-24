using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_Jogo_da_Memória
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_Facil_Click(object sender, EventArgs e)
        {
            frm_JogoMemoria frmJM = new frm_JogoMemoria(0, 2, 4);
            frmJM.Show();
        }

        private void frm_Medio_Click(object sender, EventArgs e)
        {
            frm_JogoMemoria frmJM = new frm_JogoMemoria(1, 4, 4);
            frmJM.Show();
        }

        private void btn_Dificil_Click(object sender, EventArgs e)
        {
            frm_JogoMemoria frmJM = new frm_JogoMemoria(2, 4, 8);
            frmJM.Show();
        }
    }
}
