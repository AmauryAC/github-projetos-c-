using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_Distancia_entre_Cidades
{
    public partial class frm_Entrada : Form
    {
        public frm_Entrada()
        {
            InitializeComponent();
        }

        private void tmr_Entrada_Tick(object sender, EventArgs e)
        {
            if (pgb_Entrada.Value < 100)
            {
                pgb_Entrada.Value += 4;
            }
            else
            {
                tmr_Entrada.Enabled = false;
                this.Visible = false;

                frm_Principal frmp = new frm_Principal();
                frmp.Show();
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
