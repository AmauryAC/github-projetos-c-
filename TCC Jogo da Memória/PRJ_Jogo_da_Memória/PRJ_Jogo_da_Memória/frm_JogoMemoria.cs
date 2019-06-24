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
    public partial class frm_JogoMemoria : Form
    {
        int randNum;
        Random r = new Random();

        int nivel;
        int lin, col;

        public Objeto obj = new Objeto();
        public List<Objeto> lista;
        public Objeto[,] mat;

        PictureBox clique1 = new PictureBox();
        PictureBox clique2 = new PictureBox();

        SoundPlayer somIntro = new SoundPlayer(Properties.Resources.Musica_instrumental_alegre_divertido___fundo_musical_musica_de_fundo_para_vídeos_infantil_crianças__online_audio_converter_com_);

        public frm_JogoMemoria(int n, int l, int c)
        {
            InitializeComponent();

            nivel = n;
            lin = l;
            col = c;

            clique1 = null;
            clique2 = null;

            Inicializar_ComponentesJogo();
            somIntro.Play();
        }

        public void Inicializar_ComponentesJogo()
        {
            this.tableLayoutPanel1.RowStyles.Clear();
            this.tableLayoutPanel1.ColumnStyles.Clear();

            this.tableLayoutPanel1.ColumnCount = 0;

            if (nivel == 0)
            {
                this.Size = new Size(720, 365);
                this.tableLayoutPanel1.Size = new Size(560, 305);

                this.lbl_Tempo.Location = new Point(580, 12);
                this.lbl_VTempo.Location = new Point(580, 41);
                this.lbl_Tentativas.Location = new Point(580, 96);
                this.lbl_VTentativas.Location = new Point(580, 129);
            }
            else if (nivel == 1)
            {
                this.Size = new Size(720, 660);
                this.tableLayoutPanel1.Size = new Size(560, 600);

                this.lbl_Tempo.Location = new Point(580, 12);
                this.lbl_VTempo.Location = new Point(580, 41);
                this.lbl_Tentativas.Location = new Point(580, 96);
                this.lbl_VTentativas.Location = new Point(580, 129);
            }
            else if (nivel == 2)
            {
                this.Size = new Size(1320, 700);
                this.tableLayoutPanel1.Size = new Size(1160, 640);

                this.lbl_Tempo.Location = new Point(1180, 12);
                this.lbl_VTempo.Location = new Point(1180, 41);
                this.lbl_Tentativas.Location = new Point(1180, 96);
                this.lbl_VTentativas.Location = new Point(1180, 129);
            }

            this.tableLayoutPanel1.RowCount = lin;
            this.tableLayoutPanel1.ColumnCount = col;

            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / lin));
                    this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / col));

                    PictureBox pbx = new PictureBox() { Dock = DockStyle.Fill, Image = Properties.Resources.interrogação, SizeMode = PictureBoxSizeMode.StretchImage };
                    pbx.Click += this.Verificar_CartaClicada;

                    this.tableLayoutPanel1.Controls.Add(pbx);
                }
            }

            Carregar_Matriz();
            Carregar_Cartas();

            timer2.Start();
        }

        public void Carregar_Matriz()
        {
            lista = new List<Objeto>();

            for (int i = 0; i < (lin * col) / 2; i++)
            {
                if (nivel == 0)
                {
                    do
                    {
                        randNum = r.Next(obj.listaObj.Count);
                    } while (obj.listaObj[randNum].tipo == 1);
                }
                else if (nivel == 1)
                {
                    do
                    {
                        randNum = r.Next(obj.listaObj.Count);
                    } while (obj.listaObj[randNum].tipo == 0);
                }
                else
                    randNum = r.Next(obj.listaObj.Count);

                lista.Add(obj.listaObj[randNum]);
                lista.Add(obj.listaObj[randNum]);

                obj.listaObj.RemoveAt(randNum);
            }

            mat = new Objeto[lin, col];

            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    randNum = r.Next(lista.Count);

                    mat[i, j] = lista[randNum];

                    lista.RemoveAt(randNum);
                }
            }
        }

        public void Carregar_Cartas()
        {
            int i = 0, j = 0;
            PictureBox carta;

            foreach (Control control in this.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    foreach (Control pcb in control.Controls)
                    {
                        if (pcb is PictureBox)
                        {
                            carta = (PictureBox)pcb;

                            carta.Image = Properties.Resources.interrogação;
                            carta.Tag = mat[i, j].imagem;

                            if (j < col - 1)
                                j++;
                            else
                            {
                                j = 0;
                                if (i < lin - 1)
                                    i++;
                            }
                        }
                    }
                }
            }
        }

        public void Verificar_CartaClicada(object sender, EventArgs e)
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

                    obj.tentativas++;

                    lbl_VTentativas.Text = obj.tentativas.ToString();
                }

                var row1 = tableLayoutPanel1.GetPositionFromControl(clique1);
                var row2 = tableLayoutPanel1.GetPositionFromControl(clique2);

                if (mat[row1.Row, row1.Column].ID == mat[row2.Row, row2.Column].ID)
                {
                    clique1 = null;
                    clique2 = null;

                    if (Verificar_Vitoria())
                    {
                        timer2.Stop();

                        MessageBox.Show("\aVocê venceu a partida!!! \n\nTempo: " + lbl_VTempo.Text + "s \nTentativas: " + lbl_VTentativas.Text, "Parabéns");
                        somIntro.Stop();
                        Close();
                    }

                    return;
                }

                timer1.Start();
            }
        }

        private bool Verificar_Vitoria()
        {
            bool venceu = false;

            PictureBox carta;

            foreach (Control control in this.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    foreach (Control Tcontrol in control.Controls)
                    {
                        if (Tcontrol is PictureBox)
                        {
                            carta = (PictureBox)Tcontrol;

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
            obj.tempo += 1;

            lbl_VTempo.Text = obj.tempo.ToString();
        }
    }
}
