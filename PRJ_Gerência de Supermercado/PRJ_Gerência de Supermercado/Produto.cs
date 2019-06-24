using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_Gerência_de_Supermercado
{
    //Definindo a Classe Produto
    public class Produto
    {
        private int codigo;
        private string descricao;
        private int numVendas;
        private int numSubstituido;         //Nº de vezes que o Produto foi substituído na prateleira.

        private int ultimoAcesso;           //Momento que o Produto foi ultimamente acessado, referenciado.
        private int bitR;                   //Indica se o Produto foi recentemente referenciado (bitR = 1) ou não (bitR = 0).

        //Propriedades
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int NumVendas
        {
            get { return numVendas; }
            set { numVendas = value; }
        }

        public int NumSubstituido
        {
            get { return numSubstituido; }
            set { numSubstituido = value; }
        }

        public int UltimoAcesso
        {
            get { return ultimoAcesso; }
            set { ultimoAcesso = value; }
        }

        public int BitR
        {
            get { return bitR; }
            set { bitR = value; }
        }

        //Inicializador de dados (Construtor)
        public Produto()
        {
            codigo = 0;
            descricao = null;
            numVendas = 0;
            numSubstituido = 0;
            ultimoAcesso = 0;
            bitR = 0;
        }
    }
}
