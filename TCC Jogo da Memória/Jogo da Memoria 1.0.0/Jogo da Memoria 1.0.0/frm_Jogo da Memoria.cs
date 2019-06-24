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

namespace Jogo_da_Memoria_1._0._0
{
    public partial class frm_Jogo_da_Memoria : Form
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

        SoundPlayer aplausos = new SoundPlayer(Properties.Resources.aplausos);

        public frm_Jogo_da_Memoria(int n, int l, int c)
        {
            InitializeComponent();

            label1.Parent = pbx_Fundo;
            label1.BackColor = Color.Transparent;
            label2.Parent = pbx_Fundo;
            label2.BackColor = Color.Transparent;
            label3.Parent = pbx_Fundo;
            label3.BackColor = Color.Transparent;

            lbl_Tempo.Parent = pbx_Fundo;
            lbl_Tempo.BackColor = Color.Transparent;
            lbl_Jogadas.Parent = pbx_Fundo;
            lbl_Jogadas.BackColor = Color.Transparent;

            nivel = n;
            lin = l;
            col = c;

            clique1 = null;
            clique2 = null;

            Inicializar_ComponentesJogo();
        }

        public void Inicializar_ComponentesJogo()
        {
            try
            {
                this.tableLayoutPanel1.RowStyles.Clear();
                this.tableLayoutPanel1.ColumnStyles.Clear();

                this.tableLayoutPanel1.ColumnCount = 0;

                if (nivel == 0)
                {
                    if (Program.jogoMem.faixaEtaria == 0)
                    {
                        this.tableLayoutPanel1.Size = new Size(575, 300);
                        this.tableLayoutPanel1.Location = new Point(395, 125);
                    }
                    else if (Program.jogoMem.faixaEtaria == 1)
                    {
                        this.tableLayoutPanel1.Size = new Size(575, 425);
                        this.tableLayoutPanel1.Location = new Point(395, 125);
                    }
                }
                else if (nivel == 1)
                {
                    if (Program.jogoMem.faixaEtaria == 0)
                    {
                        this.tableLayoutPanel1.Size = new Size(575, 425);
                        this.tableLayoutPanel1.Location = new Point(395, 125);
                    }
                    else if (Program.jogoMem.faixaEtaria == 1)
                    {
                        this.tableLayoutPanel1.Size = new Size(550, 570);
                        this.tableLayoutPanel1.Location = new Point(400, 125);
                    }
                }
                else if (nivel == 2)
                {
                    if (Program.jogoMem.faixaEtaria == 0)
                    {
                        this.tableLayoutPanel1.Size = new Size(550, 570);
                        this.tableLayoutPanel1.Location = new Point(400, 125);
                    }
                    else if (Program.jogoMem.faixaEtaria == 1)
                    {
                        this.tableLayoutPanel1.Size = new Size(800, 570);
                        this.tableLayoutPanel1.Location = new Point(275, 125);
                    }
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

                        Label lbl = new Label() { Font = new Font("Showcard Gothic", 12.0f), MaximumSize = new Size(100, 0), AutoSize = true };
                        pbx.Controls.Add(lbl);

                        this.tableLayoutPanel1.Controls.Add(pbx);
                    }
                }

                Carregar_Matriz();
                Carregar_Cartas();

                timer2.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        public void Carregar_Matriz()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        public void Verificar_CartaClicada(object sender, EventArgs e)
        {
            try
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

                        obj.jogadas++;

                        lbl_Jogadas.Text = obj.jogadas.ToString();
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

                            aplausos.Play();

                            obj.listaObj.Clear();
                            lista.Clear();
                            GC.Collect();

                            DialogResult result = MessageBox.Show("Parabéns, você conseguiu!!! \n\nSeu tempo foi de " + lbl_Tempo.Text + " segundos. \nVocê fez " + lbl_Jogadas.Text + " jogadas. \n\nDeseja jogar novamente?", "Parabéns", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                frm_Jogo_da_Memoria frmJM = new frm_Jogo_da_Memoria(nivel, lin, col);
                                frmJM.Show();

                                this.Visible = false;
                            }
                            //Close();
                        }

                        return;
                    }

                    timer1.Start();
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

            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

            return venceu;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                obj.tempo += 1;

                lbl_Tempo.Text = obj.tempo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_Niveis frnNv = new frm_Niveis();
            frnNv.Show();

            this.Visible = false;
        }

        private void frm_Jogo_da_Memoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
