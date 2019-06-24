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
    public partial class Form1 : Form
    {
        int lin = 4, col = 4;

        Objeto obj;

        public Form1()
        {
            InitializeComponent();

            obj = new Objeto();

            obj.clique1 = new PictureBox();
            obj.clique2 = new PictureBox();

            obj.clique1 = null;
            obj.clique2 = null;

            obj.Carregar_Lista(lin, col);
            obj.Carregar_Cartas(this, lin, col);

            //this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 4);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.ColumnCount = 6;

            this.tableLayoutPanel1.Size = new Size(600, 600);

            for (int i = 0; i < lin * col; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / 6));
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / 6));
            }

            timer2.Start();
        }

        private void PB_Click(object sender, EventArgs e)
        {
            int r = 0, c = 0;
            string nome_obj = null;

            bool aux = false;

            PictureBox carta_clicada = (PictureBox)sender;

            obj.Verificar_CartaClicada(this, this.tableLayoutPanel1, ref r, ref c, ref nome_obj, carta_clicada, ref aux);

            label1.Text = r.ToString() + c.ToString() + nome_obj;

            if (aux == true)
                timer1.Start();
            else
            {
                if (obj.Verificar_Vitoria(this))
                {
                    timer2.Stop();

                    MessageBox.Show("Você venceu a partida!!!" , "Parabéns");
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
        }
    }
}
