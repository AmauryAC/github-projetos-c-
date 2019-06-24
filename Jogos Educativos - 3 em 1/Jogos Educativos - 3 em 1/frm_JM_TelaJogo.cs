using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogos_Educativos___3_em_1
{
    public partial class frm_JM_TelaJogo : Form
    {
        int randNum;
        Random r = new Random();

        int faixaEtaria, nivel;
        int linhas, colunas;

        public Memoria jogo = new Memoria();
        public List<Memoria> listaJogo;
        public Memoria[,] mat;

        public List<int> listaNum;

        PictureBox clique1 = new PictureBox();
        PictureBox clique2 = new PictureBox();

        Thread t1;

        public frm_JM_TelaJogo()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");

                frm_Menu frmMn = new frm_Menu();
                frmMn.Show();

                this.Visible = false;
            }
        }

        public frm_JM_TelaJogo(int fe, int n, int l, int c)
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");

                frm_Menu frmMn = new frm_Menu();
                frmMn.Show();

                this.Visible = false;
            }

            faixaEtaria = fe;
            nivel = n;
            linhas = l;
            colunas = c;

            clique1 = null;
            clique2 = null;
        }

        private void frm_JM_TelaJogo_Load(object sender, EventArgs e)
        {
            try
            {
                t1 = new Thread(Carregar_Matriz);
                t1.Start();

                lbl_Titulo.Parent = pbx_Fundo;
                lbl_Tempo.Parent = pbx_Fundo;
                lbl_VTempo.Parent = pbx_Fundo;
                lbl_Jogadas.Parent = pbx_Fundo;
                lbl_VJogadas.Parent = pbx_Fundo;

                lbl_Titulo.BackColor = Color.Transparent;
                lbl_Tempo.BackColor = Color.Transparent;
                lbl_VTempo.BackColor = Color.Transparent;
                lbl_Jogadas.BackColor = Color.Transparent;
                lbl_VJogadas.BackColor = Color.Transparent;

                this.tlp_Tabuleiro.RowStyles.Clear();
                this.tlp_Tabuleiro.ColumnStyles.Clear();

                this.tlp_Tabuleiro.ColumnCount = 0;

                if (nivel == 0)
                {
                    if (faixaEtaria == 0)
                    {
                        this.tlp_Tabuleiro.Size = new Size(575, 300);
                        this.tlp_Tabuleiro.Location = new Point(395, 125);
                    }
                    else if (faixaEtaria == 1)
                    {
                        this.tlp_Tabuleiro.Size = new Size(575, 425);
                        this.tlp_Tabuleiro.Location = new Point(395, 125);
                    }
                }
                else if (nivel == 1)
                {
                    if (faixaEtaria == 0)
                    {
                        this.tlp_Tabuleiro.Size = new Size(575, 425);
                        this.tlp_Tabuleiro.Location = new Point(395, 125);
                    }
                    else if (faixaEtaria == 1)
                    {
                        this.tlp_Tabuleiro.Size = new Size(550, 570);
                        this.tlp_Tabuleiro.Location = new Point(400, 125);
                    }
                }
                else if (nivel == 2)
                {
                    if (faixaEtaria == 0)
                    {
                        this.tlp_Tabuleiro.Size = new Size(550, 570);
                        this.tlp_Tabuleiro.Location = new Point(400, 125);
                    }
                    else if (faixaEtaria == 1)
                    {
                        this.tlp_Tabuleiro.Size = new Size(800, 570);
                        this.tlp_Tabuleiro.Location = new Point(275, 125);
                    }
                }

                this.tlp_Tabuleiro.RowCount = linhas;
                this.tlp_Tabuleiro.ColumnCount = colunas;

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        this.tlp_Tabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / linhas));
                        this.tlp_Tabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / colunas));

                        PictureBox pbx = new PictureBox() { Dock = DockStyle.Fill, Image = Properties.Resources.interrogação, SizeMode = PictureBoxSizeMode.StretchImage };
                        pbx.Click += this.Verificar_CartaClicada;

                        Label lbl = new Label() { Font = new Font("Showcard Gothic", 12.0f), MaximumSize = new Size(100, 0), AutoSize = true };
                        pbx.Controls.Add(lbl);

                        this.tlp_Tabuleiro.Controls.Add(pbx);

                        lbl.Parent = pbx;
                        lbl.BackColor = Color.Transparent;
                    }
                }

                //Carregar_Matriz();
                Carregar_Cartas();

                tmr_Tempo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        public void Carregar_Matriz()
        {
            listaNum = new List<int>();
            listaJogo = new List<Memoria>();

            try
            {
                for (int i = 0; i < jogo.listaImagens.Count; i++)
                {
                    listaNum.Add(i);
                }

                for (int i = 0; i < (linhas * colunas) / 2; i++)
                {
                    if (nivel == 0)
                    {
                        do
                        {
                            randNum = r.Next(listaNum.Count);
                        } while (jogo.listaImagens[randNum].tipo == 1);
                    }
                    else if (nivel == 1)
                    {
                        do
                        {
                            randNum = r.Next(listaNum.Count);
                        } while (jogo.listaImagens[randNum].tipo == 0);
                    }
                    else
                        randNum = r.Next(listaNum.Count);

                    listaJogo.Add(jogo.listaImagens[randNum]);
                    listaJogo.Add(jogo.listaImagens[randNum]);

                    listaNum.RemoveAt(randNum);
                }

                mat = new Memoria[linhas, colunas];

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        randNum = r.Next(listaJogo.Count);

                        mat[i, j] = listaJogo[randNum];

                        listaJogo.RemoveAt(randNum);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        public void Carregar_Cartas()
        {
            int i = 0, j = 0;

            PictureBox carta;

            try
            {
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

                                foreach (Control lbl in pcb.Controls)
                                {
                                    if (lbl is Label)
                                    {
                                        lbl.Text = mat[i, j].nome;
                                        lbl.Visible = false;
                                    }
                                }

                                if (j < colunas - 1)
                                    j++;
                                else
                                {
                                    j = 0;
                                    if (i < linhas - 1)
                                        i++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        public void Verificar_CartaClicada(object sender, EventArgs e)
        {
            PictureBox carta_clicada = (PictureBox)sender;

            try
            {
                if (carta_clicada != null)
                {
                    if (carta_clicada.Image == carta_clicada.Tag)
                        return;

                    if (clique1 == null)
                    {
                        clique1 = carta_clicada;
                        clique1.Image = (Image)carta_clicada.Tag;

                        foreach (Control lbl in carta_clicada.Controls)
                        {
                            if (lbl is Label)
                            {
                                lbl.Visible = true;
                            }
                        }

                        return;
                    }
                    if (clique2 == null)
                    {
                        clique2 = carta_clicada;
                        clique2.Image = (Image)carta_clicada.Tag;

                        foreach (Control lbl in carta_clicada.Controls)
                        {
                            if (lbl is Label)
                            {
                                lbl.Visible = true;
                            }
                        }

                        jogo.jogadas++;

                        lbl_VJogadas.Text = jogo.jogadas.ToString();
                    }

                    var row1 = tlp_Tabuleiro.GetPositionFromControl(clique1);
                    var row2 = tlp_Tabuleiro.GetPositionFromControl(clique2);

                    if (mat[row1.Row, row1.Column].ID == mat[row2.Row, row2.Column].ID)
                    {
                        clique1 = null;
                        clique2 = null;

                        if (Verificar_Vitoria())
                        {
                            tmr_Tempo.Stop();

                            DialogResult result = MessageBox.Show("Parabéns, você conseguiu!!! \n\nSeu tempo foi de " + lbl_VTempo.Text + " segundos. \nVocê fez " + lbl_VJogadas.Text + " jogadas. \n\nDeseja jogar novamente?", "Parabéns", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                frm_JM_TelaJogo frmTJ = new frm_JM_TelaJogo(faixaEtaria, nivel, linhas, colunas);
                                frmTJ.Show();

                                this.Visible = false;
                            }
                            //Close();
                        }

                        return;
                    }

                    tmr_Intervalo.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
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

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_JM_Niveis frnNv = new frm_JM_Niveis();
            frnNv.Show();

            this.Visible = false;
        }

        private void frm_JM_TelaJogo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmr_Intervalo_Tick(object sender, EventArgs e)
        {
            tmr_Intervalo.Stop();

            foreach (Control lbl in clique1.Controls)
            {
                if (lbl is Label)
                {
                    lbl.Visible = false;
                }
            }

            foreach (Control lbl in clique2.Controls)
            {
                if (lbl is Label)
                {
                    lbl.Visible = false;
                }
            }

            clique1.Image = Properties.Resources.interrogação;
            clique2.Image = Properties.Resources.interrogação;

            clique1 = null;
            clique2 = null;
        }

        private void tmr_Tempo_Tick(object sender, EventArgs e)
        {
            jogo.tempo += 1;

            lbl_VTempo.Text = jogo.tempo.ToString();
        }
    }
}
