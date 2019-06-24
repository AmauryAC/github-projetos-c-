using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Usuário
{
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_UserDataSet.Cadastro_de_Usuários' table. You can move, or remove it, as needed.
            this.cadastro_de_UsuáriosTableAdapter.Fill(this.dB_UserDataSet.Cadastro_de_Usuários);
        }

        private void frmCadUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair da aplicação?", "Sair da Aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void save_Data()
        {
            this.Validate();
            this.cadastroDeUsuáriosBindingSource.EndEdit();
            this.cadastro_de_UsuáriosTableAdapter.Update(this.dB_UserDataSet);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.save_Data();

                MessageBox.Show("Registro Salvo com Sucesso!!!", "Registro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar todos os Registros?", "Limpar BD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //this.dB_UserDataSet.Cadastro_de_Usuários.Clear();
                    this.dB_UserDataSet.Cadastro_de_Usuários.Rows.Clear();
                    this.save_Data();

                    MessageBox.Show("Todos os Registros foram Apagados com Sucesso!!!", "BD Limpo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.cadastro_de_UsuáriosTableAdapter.Fill(this.dB_UserDataSet.Cadastro_de_Usuários);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.dgvCadUsuarios.Rows.Remove(dgvCadUsuarios.CurrentRow);
                    this.save_Data();

                    MessageBox.Show("Registro Excluído com Sucesso!!!", "Registro Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.cadastro_de_UsuáriosTableAdapter.Fill(this.dB_UserDataSet.Cadastro_de_Usuários);
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.dB_UserDataSet.Cadastro_de_Usuários.Rows.Add();              
                this.save_Data();

                //MessageBox.Show("Registro Salvo com Sucesso!!!", "Registro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCadUsuarios_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            this.tsbDelete_Click(sender, e);
        }
    }
}
