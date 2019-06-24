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
    public partial class frm_Splash : Form
    {
        public frm_Splash()
        {
            InitializeComponent();

            label1.Parent = pbx_Fundo;
            label1.BackColor = Color.Transparent;
        }

        private void btn_Jogar_Click(object sender, EventArgs e)
        {
            Program.jogoMem = new Jogo();

            frm_Idade frmId = new frm_Idade();
            frmId.Show();

            this.Visible = false;
        }
    }
}
