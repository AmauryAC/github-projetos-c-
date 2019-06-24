using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Memória_TCC
{
    public class Jogo
    {
        public int faixaEtaria;
        public int nivel;

        public int tempo;
        public int jogadas;

        public int linhas;
        public int colunas;

        public Jogo()
        {
            faixaEtaria = 0;
            nivel = 0;

            tempo = 0;
            jogadas = 0;

            linhas = 0;
            colunas = 0;
        }
    }
}
