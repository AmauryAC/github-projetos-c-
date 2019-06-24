using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_UserDataSet.Cadastro_de_Usuários' table. You can move, or remove it, as needed.
            this.cadastro_de_UsuáriosTableAdapter.Fill(this.dB_UserDataSet.Cadastro_de_Usuários);

        }

        private void CliquedoBotão(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroDeUsuáriosBindingSource.EndEdit();
            this.cadastro_de_UsuáriosTableAdapter.Update(this.dB_UserDataSet);
        }
    }
}
