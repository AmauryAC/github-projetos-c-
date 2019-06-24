using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memória_TCC
{
    public partial class frm_Jogo_da_Memoria : Form
    {
        int nivel;
        int lin, col;

        public frm_Jogo_da_Memoria(int n, int l, int c)
        {
            InitializeComponent();

            nivel = n;
            lin = l;
            col = c;
        }
    }
}
