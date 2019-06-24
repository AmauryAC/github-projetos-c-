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
    public partial class frm_NDificil : Form
    {
        int lin = 5, col = 6;

        Objeto obj;

        public frm_NDificil()
        {
            InitializeComponent();

            obj = new Objeto();

            obj.clique1 = new PictureBox();
            obj.clique2 = new PictureBox();

            obj.clique1 = null;
            obj.clique2 = null;

            obj.Carregar_Lista(lin, col);
            obj.Carregar_Cartas(this);

            timer2.Start();
        }

        private void PB_Click(object sender, EventArgs e)
        {
            bool aux = false;

            PictureBox carta_clicada = (PictureBox)sender;

            obj.Verificar_CartaClicada(this, carta_clicada, ref aux);

            if (aux == true)
                timer1.Start();
            else
            {
                if (obj.Verificar_Vitoria(this))
                {
                    timer2.Stop();
                    lbl_VTentativas.Text = obj.tentativas.ToString();

                    MessageBox.Show("Você venceu a partida!!! \n\nTempo: " + obj.tempo.ToString() + "s \nTentativas: " + obj.tentativas.ToString(), "Parabéns");
                    Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            obj.clique1.Image = Properties.Resources.interrogação;
            obj.clique2.Image = Properties.Resources.interrogação;

            obj.clique1 = null;
            obj.clique2 = null;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            obj.tempo += 1;

            lbl_VTempo.Text = obj.tempo.ToString();
            lbl_VTentativas.Text = obj.tentativas.ToString();
        }
    }
}
