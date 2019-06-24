using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas
{
    public partial class frmCadCliente : Form
    {
        ClienteBLL cliBLL = new ClienteBLL();
        ClienteDTO cliDTO = new ClienteDTO();

        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            cliDTO.Nome = txtNome.Text;
            cliDTO.Email = txtEmail.Text;

            if (txtID.Text == "")
            {
                cliBLL.Inserir(cliDTO);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cliDTO.Id = int.Parse(txtID.Text);

                cliBLL.Atualizar(cliDTO);

                MessageBox.Show("Cliente atualizado com sucesso!", "Atualização com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimparCampos();
            CarregarGrid();
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
        }

        private void CarregarGrid()
        {
            dgvClientes.DataSource = cliBLL.SelecionaTodosClientes();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                var result = MessageBox.Show("Deseja realmente excluir o registro selecionado?", "Exclusão de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    cliBLL.Excluir(txtID.Text);

                    MessageBox.Show("Cliente excluído com sucesso!", "Exclusão com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimparCampos();
                CarregarGrid();
            }
        }
    }
}
