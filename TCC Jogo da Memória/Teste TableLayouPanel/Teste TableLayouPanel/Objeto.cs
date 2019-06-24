using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_TableLayouPanel
{
    public class Objeto
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public int tipo { get; set; }
        public Image imagem { get; set; }

        int randNum;
        Random r = new Random();

        public List<Objeto> listaObj;
        public List<Objeto> lista;
        public Objeto[,] matObj;

        public PictureBox clique1;
        public PictureBox clique2;

        public int tempo = 0;
        public int tentativas = 0;

        public Objeto()
        {
            listaObj = new List<Objeto>()
            {
                new Objeto(1, "Abacaxi", 0, Properties.Resources.abacaxi),
                new Objeto(2, "Banana", 0, Properties.Resources.banana),
                new Objeto(3, "Bode", 1, Properties.Resources.bode),
                new Objeto(4, "Burro", 1, Properties.Resources.burro),
                new Objeto(5, "Cereja", 0, Properties.Resources.cereja),
                new Objeto(6, "Elefante", 1, Properties.Resources.elefante),
                new Objeto(7, "Girafa", 1, Properties.Resources.girafa),
                new Objeto(8, "Hipopótamo", 1, Properties.Resources.hipopótamo),
                new Objeto(9, "Laranja", 0, Properties.Resources.laranja),
                new Objeto(10, "Maça", 0, Properties.Resources.maçã),
                new Objeto(11, "Melancia", 0, Properties.Resources.melancia),
                new Objeto(12, "Morango", 0, Properties.Resources.morango),
                new Objeto(13, "Porco", 1, Properties.Resources.porco),
                new Objeto(14, "Uva", 0, Properties.Resources.uva),
                new Objeto(15, "Vaca", 1, Properties.Resources.vaca),
                new Objeto(16, "Zebra", 1, Properties.Resources.zebra)
            };
        }

        public Objeto(int _ID, string n, int t, Image img)
        {
            ID = _ID;
            nome = n;
            tipo = t;
            imagem = img;
        }

        public void Carregar_Lista(int lin, int col)
        {
            lista = new List<Objeto>();

            for (int i = 0; i < (lin * col) / 2; i++)
            {
                randNum = r.Next(listaObj.Count);

                lista.Add(listaObj[randNum]);
                lista.Add(listaObj[randNum]);

                listaObj.RemoveAt(randNum);
            }

            matObj = new Objeto[lin, col];

            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    randNum = r.Next(lista.Count);

                    matObj[i, j] = lista[randNum];

                    lista.RemoveAt(randNum);
                }
            }
        }

        public void Carregar_Cartas(Form frm, int lin, int col)
        {
            int i = lin-1, j = col-1;
            PictureBox carta;

            foreach (Control control in frm.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    foreach (Control pcb in control.Controls)
                    {
                        if (pcb is PictureBox)
                        {
                            carta = (PictureBox)pcb;

                            carta.Image = Properties.Resources.interrogação;
                            carta.Tag = matObj[i, j].imagem;

                            if (j > 0)
                                j--;
                            else
                            {
                                j = col - 1;
                                if (i > 0)
                                    i--;
                            }
                        }
                    }
                }
            }
        }

        public bool Comparar_Imagens(Bitmap img1, Bitmap img2)
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

        public void Verificar_CartaClicada(Form frm, TableLayoutPanel tlp, ref int r, ref int c, ref string nome_obj, PictureBox carta_clicada, ref bool aux)
        {
            if (carta_clicada != null)
            {
                r = tlp.GetRow(carta_clicada);
                c = tlp.GetColumn(carta_clicada);

                nome_obj = matObj[r, c].nome;

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

                    aux = true;
                    tentativas++;
                }

                /*if (Comparar_Imagens((Bitmap)clique1.Image, (Bitmap)clique2.Image))
                {
                    clique1 = null;
                    clique2 = null;

                    aux = false;

                    return;
                }*/

                if (matObj[tlp.GetRow(clique1), tlp.GetColumn(clique1)].ID == matObj[tlp.GetRow(clique2), tlp.GetColumn(clique2)].ID)
                {
                    clique1 = null;
                    clique2 = null;

                    aux = false;

                    return;
                }
            }
        }

        public bool Verificar_Vitoria(Form frm)
        {
            bool venceu = false;

            PictureBox carta;

            foreach (Control control in frm.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    foreach (Control pcb in control.Controls)
                    {
                        if (pcb is PictureBox)
                        {
                            carta = (PictureBox)pcb;

                            if (carta != null)
                            {
                                if (carta.Image != carta.Tag)
                                    return venceu;
                            }
                        }
                    }
                }
            }
            venceu = true;

            return venceu;
        }
    }
}
