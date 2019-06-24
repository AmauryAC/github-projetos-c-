using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogos_Educativos___3_em_1
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            //Botões Arrendondados
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, 200, 150);

            btn_JogoMemoria.Region = new Region(forma);
            btn_JogoSoma.Region = new Region(forma);
            btn_JogoEncaixar.Region = new Region(forma);

            //Labels transparentes
            lbl_Titulo.Parent = pbx_Fundo;
            lbl_3em1.Parent = pbx_Fundo;
            lbl_JM.Parent = pbx_Fundo;
            lbl_JS.Parent = pbx_Fundo;
            lbl_JE.Parent = pbx_Fundo;

            lbl_Titulo.BackColor = Color.Transparent;
            lbl_3em1.BackColor = Color.Transparent;
            lbl_JM.BackColor = Color.Transparent;
            lbl_JS.BackColor = Color.Transparent;
            lbl_JE.BackColor = Color.Transparent;
        }

        private void btn_JogoMemoria_Click(object sender, EventArgs e)
        {
            frm_JM_Idade frmId = new frm_JM_Idade();
            frmId.Show();

            this.Visible = false;
        }

        private void frm_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
