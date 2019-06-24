using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_Algoritmo_Shell_Sort
{
    public class Registro
    {
        private int codigo;
        private string nome;
        private string telefoneCel;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefoneCel; }
            set { telefoneCel = value; }
        }
    }
}
