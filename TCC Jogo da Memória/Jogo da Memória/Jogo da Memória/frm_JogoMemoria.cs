using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memória
{
    public partial class frm_JogoMemoria : Form
    {
        Random r = new Random();

        List<Image> imagens = new List<Image>()
        {
            Properties.Resources.abacaxi,
            Properties.Resources.banana,
            Properties.Resources.cereja,
            Properties.Resources.laranja,
            Properties.Resources.maçã,
            Properties.Resources.melancia,
            Properties.Resources.morango,
            Properties.Resources.uva,

            Properties.Resources.abacaxi,
            Properties.Resources.banana,
            Properties.Resources.cereja,
            Properties.Resources.laranja,
            Properties.Resources.maçã,
            Properties.Resources.melancia,
            Properties.Resources.morango,
            Properties.Resources.uva
        };

        PictureBox clique1 = new PictureBox();
        PictureBox clique2 = new PictureBox();

        public frm_JogoMemoria()
        {
            InitializeComponent();

            clique1 = null;
            clique2 = null;

            Carregar_Cartas();
            timer2.Start();
        }

        private void Carregar_Cartas()
        {
            int randNum;

            PictureBox carta;

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    carta = (PictureBox)control;

                    randNum = r.Next(imagens.Count);
                    carta.Image = Properties.Resources.interrogação;
                    carta.Tag = imagens[randNum];

                    imagens.RemoveAt(randNum);
                }
            }
        }

        private void PB_Click(object sender, EventArgs e)
        {
            PictureBox carta_clicada = (PictureBox)sender;

            if (carta_clicada != null)
            {
                if (carta_clicada.Image == carta_clicada.Tag)
                    return;

                if (clique1 == null)
                {
                    clique1 = carta_clicada;
                    clique1.Image = (Image)carta_clicada.Tag;

                    return;
                }
                if (clique2 == null)
                {
                    clique2 = carta_clicada;
                    clique2.Image = (Image)carta_clicada.Tag;

                    lbl_VTentativas.Text = (Convert.ToInt32(lbl_VTentativas.Text) + 1).ToString();
                }

                if (Comparar_Imagens((Bitmap)clique1.Image, (Bitmap)clique2.Image))
                {
                    clique1 = null;
                    clique2 = null;

                    if (Verificar_Vitoria())
                    {
                        timer2.Stop();

                        MessageBox.Show("Você venceu a partida!!! \n\nTempo: " + lbl_VTempo.Text + "s \nTentativas: " + lbl_VTentativas.Text, "Parabéns");
                        Close();
                    }

                    return;
                }

                timer1.Start();
            }
        }

        private bool Comparar_Imagens(Bitmap img1, Bitmap img2)
        {
            bool iguais = false;

            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        if (img1.GetPixel(i, j) != img2.GetPixel(i, j))
                            break;
                    }
                }
                iguais = true;
            }
            return iguais;
        }

        private bool Verificar_Vitoria()
        {
            bool venceu = false;

            PictureBox carta;

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    carta = (PictureBox)control;

                    if (carta != null)
                    {
                        if (carta.Image != carta.Tag)
                            return venceu;
                    }
                }
            }
            venceu = true;

            return venceu;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            clique1.Image = Properties.Resources.interrogação;
            clique2.Image = Properties.Resources.interrogação;

            clique1 = null;
            clique2 = null;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl_VTempo.Text = (Convert.ToInt32(lbl_VTempo.Text) + 1).ToString();
        }

        private void btn_Desistir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
