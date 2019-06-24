using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_Simplex
{
    public partial class frmResultados : Form
    {
        private string[] vetCabecalho;

        public frmResultados()
        {
            InitializeComponent();
        }

        //Construtor que chama os resultados no formulário
        public frmResultados(Simplex s)
        {
            InitializeComponent();

            MostrarTabelas(s);
        }

        //Método que gera as tabelas de cada iteração do Simplex
        public void GerarTabelas(Simplex s, int x, int y)
        {
            int numLinhas, numColunas;

            TableLayoutPanel tlp;
            Label lbl;

            try
            {
                tlp = new TableLayoutPanel();

                numLinhas = s.TabelaSimplex.GetLength(0) + 1;
                numColunas = s.TabelaSimplex.GetLength(1);

                tlp.Controls.Clear();

                tlp.Size = new Size(75 * numColunas, 40 * numLinhas);
                tlp.Location = new Point(x, y);

                tlp.RowCount = numLinhas;
                tlp.ColumnCount = numColunas;

                GerarCabecalho(ref tlp, s.QtdeVariaveis, s.QtdRestricoes);

                for (int i = 0; i < numLinhas - 1; i++)
                {
                    tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / numLinhas));

                    for (int j = 0; j < numColunas; j++)
                    {
                        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / numColunas));

                        lbl = new Label() { Name = "lblX" + i + "," + j, Text = s.TabelaSimplex[i, j].ToString(), Font = new Font("Microsoft Sans Serif", 12.0f), Anchor = AnchorStyles.None };

                        tlp.Controls.Add(lbl, j, i + 1);
                    }
                }

                tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;

                this.Controls.Add(tlp);

                lbl = new Label() { Name = "lblNumIteracoes", Text = "Número de Iterações: " + s.NumIteracoes.ToString(), Font = new Font("Microsoft Sans Serif", 12.0f), AutoSize = true };
                lbl.Location = new Point(x + 75 * numColunas, y + 28 * numLinhas);

                this.Controls.Add(lbl);

                lbl = new Label() { Name = "lblUltimoEP", Text = "Último Elemento Pivô: " + s.ElementoPivo.ToString(), Font = new Font("Microsoft Sans Serif", 12.0f), AutoSize = true };
                lbl.Location = new Point(x + 75 * numColunas, y + 35 * numLinhas);

                this.Controls.Add(lbl);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Método que mostra as tabelas de cada iteração do Simplex
        public void MostrarTabelas(Simplex s)
        {
            int x, y;

            Label lbl;

            x = 1;
            y = 30;

            try
            {
                lbl = new Label() { Name = "lblInfoR", Text = "Iterações Método Simplex:", Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold), AutoSize = true };
                lbl.Location = new Point(1, 5);

                this.Controls.Add(lbl);

                GerarTabelas(s, x, y);

                while (s.VerificarNegativo())
                {
                    s.CalcularInteracao();

                    y += (50 * s.TabelaSimplex.GetLength(0) + 20);

                    GerarTabelas(s, x, y);
                }
                
                y += (50 * s.TabelaSimplex.GetLength(0) + 25);

                lbl = new Label() { Name = "lblInfoRF", Text = "Resultados Finais:", Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold), AutoSize = true };
                lbl.Location = new Point(x, y);

                this.Controls.Add(lbl);

                y += 5;

                GerarQuadroResultado(s, x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Método que gera e mostra o cabeçalho das tabelas de cada iteração do Simplex
        public void GerarCabecalho(ref TableLayoutPanel tlp, int numVariaveis, int numRestricoes)
        {
            int variavelAtual = 1;

            try
            {
                vetCabecalho = new string[tlp.ColumnCount];

                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / tlp.RowCount));

                for (int col = 0; col < tlp.ColumnCount; col++)
                {
                    if (col == 0)
                    {
                        vetCabecalho[col] = "z";
                    }
                    else if (col > 0 && col <= numVariaveis)
                    {
                        vetCabecalho[col] = "x" + variavelAtual.ToString();

                        variavelAtual++;
                    }
                    else if (col > numVariaveis && col <= tlp.ColumnCount - 2)
                    {
                        vetCabecalho[col] = "xf" + variavelAtual.ToString();

                        variavelAtual++;
                    }
                    else if (col == tlp.ColumnCount - 1)
                    {
                        vetCabecalho[col] = "b";
                    }

                    if (col == numVariaveis)
                        variavelAtual = 1;

                    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / tlp.ColumnCount));

                    Label lbl = new Label() { Name = vetCabecalho[col], Text = vetCabecalho[col], Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold), Anchor = AnchorStyles.None };

                    tlp.Controls.Add(lbl, col, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Método que mostra em um quadro o resultado final da modelagem do problema com Simplex
        public void GerarQuadroResultado(Simplex s, int x, int y)
        {
            Label lbl;

            double[] vetResultadoFinal;

            try
            {
                vetResultadoFinal = s.CalcularVariaveisFinais();

                for(int i = 1; i < vetResultadoFinal.Length; i++)
                {
                    lbl = new Label() { Name = "lbl" + vetCabecalho[i], Text = vetCabecalho[i] + " = " + vetResultadoFinal[i].ToString(), Font = new Font("Microsoft Sans Serif", 12.0f), AutoSize = true };
                    lbl.Location = new Point(x, y + i * 25);

                    this.Controls.Add(lbl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
