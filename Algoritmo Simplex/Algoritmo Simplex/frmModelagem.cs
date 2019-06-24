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
    public partial class frmModelagem : Form
    {
        private int qtdVariaveis, qtdRestricoes;

        private int numLinhas, numColunas;
        private int variavelAtual;

        public frmModelagem()
        {
            InitializeComponent();
        }

        //Construtor para gerar os formulários de modelagem do problema
        public frmModelagem(int qtdVD, int qtdRestr)
        {
            InitializeComponent();

            qtdVariaveis = qtdVD;
            qtdRestricoes = qtdRestr;

            GerarFormularioFuncaoObjetivo();
            GerarFormularioRestricoes();
            GerarOutrosComponentes();
        }

        //Método para gerar o formulário da função objetivo
        public void GerarFormularioFuncaoObjetivo()
        {
            try
            {
                TableLayoutPanel tlp = new TableLayoutPanel() { Name = "tlpFuncaoObjetivo" };

                ComboBox cbx;
                TextBox txt;
                Label lbl;

                numColunas = qtdVariaveis * 2;

                tlp.Controls.Clear();

                tlp.Size = new Size(60 * numColunas + 100, 35);
                tlp.Location = new Point(1, 30);

                tlp.RowCount = 1;
                tlp.ColumnCount = numColunas + 1;

                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));

                cbx = new ComboBox() { Name = "cbxMaxMin", Items = { "MAX" }, SelectedItem = "MAX", MaximumSize = new Size(65, 35), Font = new Font("Microsoft Sans Serif", 12.0f), Tag = 0 };

                tlp.Controls.Add(cbx, 0, 0);

                variavelAtual = 1;

                for (int i = 1; i < numColunas; i += 2)
                {
                    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100 - 1 / (numColunas + 1)) / numColunas));

                    txt = new TextBox() { Name = "txtX1," + variavelAtual, Text = "0", Font = new Font("Microsoft Sans Serif", 12.0f), Anchor = AnchorStyles.None };

                    txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);

                    tlp.Controls.Add(txt, i, 0);

                    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100 - 1 / (numColunas + 1)) / numColunas));

                    lbl = new Label() { Name = "lblX1," + variavelAtual, Text = "x" + variavelAtual, Font = new Font("Microsoft Sans Serif", 12.0f), Anchor = AnchorStyles.None };

                    if (i + 1 != numColunas)
                        lbl.Text += " +";

                    tlp.Controls.Add(lbl, i + 1, 0);

                    variavelAtual++;
                }

                lbl = new Label() { Name = "lblInfoFO", Text = "Função objetivo:", Font = new Font("Microsoft Sans Serif", 12.0f), AutoSize = true, Location = new Point(1, 5) };

                this.Controls.Add(lbl);
                this.Controls.Add(tlp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Método para gerar o formulário das restrições técnicas
        public void GerarFormularioRestricoes()
        {
            try
            {
                TableLayoutPanel tlp = new TableLayoutPanel() { Name = "tlpRestricoes" };

                ComboBox cbx;
                TextBox txt;
                Label lbl;

                numLinhas = qtdRestricoes;
                numColunas = qtdVariaveis * 2 + 2;

                tlp.Controls.Clear();

                tlp.Size = new Size(60 * numColunas, 35 * numLinhas);
                tlp.Location = new Point(1, 110);

                tlp.RowCount = numLinhas;
                tlp.ColumnCount = numColunas;

                for (int i = 0; i < numLinhas; i++)
                {
                    tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / numLinhas));

                    variavelAtual = 1;

                    for (int j = 0; j < numColunas - 2; j += 2)
                    {
                        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / numColunas));

                        txt = new TextBox() { Name = "txtX" + (i + 1) + "," + variavelAtual, Text = "0", Font = new Font("Microsoft Sans Serif", 12.0f), Anchor = AnchorStyles.None };

                        txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);

                        tlp.Controls.Add(txt, j, i);

                        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / numColunas));

                        lbl = new Label() { Name = "lblX" + (i + 1) + "," + variavelAtual, Text = "x" + variavelAtual, Font = new Font("Microsoft Sans Serif", 12.0f), Anchor = AnchorStyles.None };

                        if (j + 1 != numColunas - 3)
                            lbl.Text += " +";

                        tlp.Controls.Add(lbl, j + 1, i);

                        variavelAtual++;
                    }

                    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / numColunas));

                    cbx = new ComboBox() { Name = "cbxMMI", Items = { "<=" }, SelectedItem = "<=", MaximumSize = new Size(60, 35), Font = new Font("Microsoft Sans Serif", 12.0f), Tag = 0 };

                    tlp.Controls.Add(cbx, numColunas - 2, i);

                    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / numColunas));

                    txt = new TextBox() { Name = "txtB" + (i + 1), Text = "0", Font = new Font("Microsoft Sans Serif", 12.0f), Anchor = AnchorStyles.None };

                    txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);

                    tlp.Controls.Add(txt, numColunas - 1, i);
                }

                lbl = new Label() { Name = "lblInfoR", Text = "Sujeito à:", Font = new Font("Microsoft Sans Serif", 12.0f), AutoSize = true, Location = new Point(1, 85) };

                this.Controls.Add(lbl);
                this.Controls.Add(tlp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Método para gerar os outros componentes da tela (buttons)
        public void GerarOutrosComponentes()
        {
            try
            {
                Button btn = new Button() { Name = "btnCalcular", Text = "Calcular", Font = new Font("Microsoft Sans Serif", 12.0f), Size = new Size(75, 30), Location = new Point((60 * numColunas) - 75, 125 + (35 * numLinhas)) };

                btn.Click += new EventHandler(btnCalcular_Click);

                this.Controls.Add(btn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //public void ValidarTextBox() { }

        //Método que envia os valores digitados da função objetivo para a classe de cálculo do Simplex
        public double[] RetornarFuncaoObjetivo()
        {
            int i = 0;

            double[] vetFuncaoObjetivo = new double[qtdVariaveis + 1];

            try
            {
                foreach (Control tlp in this.Controls)
                {
                    if (tlp is TableLayoutPanel && tlp.Name == "tlpFuncaoObjetivo")
                    {
                        foreach (Control c in tlp.Controls)
                        {
                            if (c is ComboBox && c.Name == "cbxMaxMin")
                            {
                                vetFuncaoObjetivo[i] = Convert.ToDouble(c.Tag);

                                i++;
                            }
                            else if (c is TextBox)
                            {
                                vetFuncaoObjetivo[i] = Convert.ToDouble(c.Text);

                                i++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return vetFuncaoObjetivo;
        }

        //Método que envia os valores digitados das restrições técnicas para a classe de cálculo do Simplex
        public double[,] RetornarRestricoes()
        {
            int i = 0, j = 0;

            double[,] matRetricoes = new double[qtdRestricoes, qtdVariaveis + 2];

            try
            {
                foreach (Control tlp in this.Controls)
                {
                    if (tlp is TableLayoutPanel && tlp.Name == "tlpRestricoes")
                    {
                        foreach (Control c in tlp.Controls)
                        {
                            if (c is TextBox)
                            {
                                matRetricoes[i, j] = Convert.ToDouble(c.Text);

                                if (j == qtdVariaveis + 1)
                                {
                                    j = 0;
                                    i++;
                                }
                                else
                                {
                                    j++;
                                }
                            }
                            else if (c is ComboBox && c.Name == "cbxMMI")
                            {
                                matRetricoes[i, j] = Convert.ToDouble(c.Tag);

                                if (j == qtdVariaveis + 1)
                                {
                                    j = 0;
                                    i++;
                                }
                                else
                                {
                                    j++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return matRetricoes;
        }

        //Aciona o formulário de resultados do problema
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Simplex simplex = new Simplex(qtdVariaveis, qtdRestricoes, RetornarFuncaoObjetivo(), RetornarRestricoes());

                frmResultados frmR = new frmResultados(simplex);
                frmR.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Método que valida os valores digitados nos textbox
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-') && !(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
                if((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == '-') && ((sender as TextBox).SelectionStart != 0))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
