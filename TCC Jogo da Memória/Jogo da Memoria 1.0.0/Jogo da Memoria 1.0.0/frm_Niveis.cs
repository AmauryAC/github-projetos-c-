﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memoria_1._0._0
{
    public partial class frm_Niveis : Form
    {
        public frm_Niveis()
        {
            InitializeComponent();

            label1.Parent = pbx_Fundo;
            label1.BackColor = Color.Transparent;

            label2.Parent = pbx_Fundo;
            label2.BackColor = Color.Transparent;
        }

        private void btn_Facil_Click(object sender, EventArgs e)
        {
            Program.jogoMem.nivel = 0;

            if (Program.jogoMem.faixaEtaria == 0)
            {
                Program.jogoMem.linhas = 2;
                Program.jogoMem.colunas = 4;
            }
            else if (Program.jogoMem.faixaEtaria == 1)
            {
                Program.jogoMem.linhas = 3;
                Program.jogoMem.colunas = 4;
            }

            frm_Jogo_da_Memoria frmJM = new frm_Jogo_da_Memoria(Program.jogoMem.nivel, Program.jogoMem.linhas, Program.jogoMem.colunas);
            frmJM.Show();

            this.Visible = false;
        }

        private void btn_Medio_Click(object sender, EventArgs e)
        {
            Program.jogoMem.nivel = 1;

            if (Program.jogoMem.faixaEtaria == 0)
            {
                Program.jogoMem.linhas = 3;
                Program.jogoMem.colunas = 4;
            }
            else if (Program.jogoMem.faixaEtaria == 1)
            {
                Program.jogoMem.linhas = 4;
                Program.jogoMem.colunas = 4;
            }

            frm_Jogo_da_Memoria frmJM = new frm_Jogo_da_Memoria(Program.jogoMem.nivel, Program.jogoMem.linhas, Program.jogoMem.colunas);
            frmJM.Show();

            this.Visible = false;
        }

        private void btn_Dificil_Click(object sender, EventArgs e)
        {
            Program.jogoMem.nivel = 2;

            if (Program.jogoMem.faixaEtaria == 0)
            {
                Program.jogoMem.linhas = 4;
                Program.jogoMem.colunas = 4;
            }
            else if (Program.jogoMem.faixaEtaria == 1)
            {
                Program.jogoMem.linhas = 4;
                Program.jogoMem.colunas = 6;
            }

            frm_Jogo_da_Memoria frmJM = new frm_Jogo_da_Memoria(Program.jogoMem.nivel, Program.jogoMem.linhas, Program.jogoMem.colunas);
            frmJM.Show();

            this.Visible = false;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_Idade frmId = new frm_Idade();
            frmId.Show();

            this.Visible = false;
        }

        private void frm_Niveis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
