namespace Jogos_Educativos___3_em_1
{
    partial class frm_JM_TelaJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Jogadas = new System.Windows.Forms.Label();
            this.lbl_Tempo = new System.Windows.Forms.Label();
            this.lbl_VTempo = new System.Windows.Forms.Label();
            this.lbl_VJogadas = new System.Windows.Forms.Label();
            this.tlp_Tabuleiro = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.pbx_Fundo = new System.Windows.Forms.PictureBox();
            this.tmr_Intervalo = new System.Windows.Forms.Timer(this.components);
            this.tmr_Tempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Titulo.Location = new System.Drawing.Point(44, 8);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(896, 119);
            this.lbl_Titulo.TabIndex = 15;
            this.lbl_Titulo.Text = "Jogo da Memória";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Jogadas
            // 
            this.lbl_Jogadas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Jogadas.AutoSize = true;
            this.lbl_Jogadas.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jogadas.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Jogadas.Location = new System.Drawing.Point(781, 302);
            this.lbl_Jogadas.Name = "lbl_Jogadas";
            this.lbl_Jogadas.Size = new System.Drawing.Size(192, 46);
            this.lbl_Jogadas.TabIndex = 25;
            this.lbl_Jogadas.Text = "Jogadas:";
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Tempo.AutoSize = true;
            this.lbl_Tempo.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tempo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Tempo.Location = new System.Drawing.Point(781, 171);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(159, 46);
            this.lbl_Tempo.TabIndex = 24;
            this.lbl_Tempo.Text = "Tempo:";
            // 
            // lbl_VTempo
            // 
            this.lbl_VTempo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_VTempo.AutoSize = true;
            this.lbl_VTempo.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VTempo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_VTempo.Location = new System.Drawing.Point(781, 226);
            this.lbl_VTempo.Name = "lbl_VTempo";
            this.lbl_VTempo.Size = new System.Drawing.Size(42, 46);
            this.lbl_VTempo.TabIndex = 23;
            this.lbl_VTempo.Text = "0";
            // 
            // lbl_VJogadas
            // 
            this.lbl_VJogadas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_VJogadas.AutoSize = true;
            this.lbl_VJogadas.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VJogadas.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_VJogadas.Location = new System.Drawing.Point(781, 358);
            this.lbl_VJogadas.Name = "lbl_VJogadas";
            this.lbl_VJogadas.Size = new System.Drawing.Size(42, 46);
            this.lbl_VJogadas.TabIndex = 22;
            this.lbl_VJogadas.Text = "0";
            // 
            // tlp_Tabuleiro
            // 
            this.tlp_Tabuleiro.BackColor = System.Drawing.Color.White;
            this.tlp_Tabuleiro.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlp_Tabuleiro.ColumnCount = 1;
            this.tlp_Tabuleiro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Tabuleiro.Location = new System.Drawing.Point(64, 142);
            this.tlp_Tabuleiro.Name = "tlp_Tabuleiro";
            this.tlp_Tabuleiro.RowCount = 1;
            this.tlp_Tabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Tabuleiro.Size = new System.Drawing.Size(149, 142);
            this.tlp_Tabuleiro.TabIndex = 26;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Voltar.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Location = new System.Drawing.Point(855, 559);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(118, 65);
            this.btn_Voltar.TabIndex = 32;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sair.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(855, 634);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(118, 65);
            this.btn_Sair.TabIndex = 31;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // pbx_Fundo
            // 
            this.pbx_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_Fundo.Image = global::Jogos_Educativos___3_em_1.Properties.Resources.fundo_tela;
            this.pbx_Fundo.Location = new System.Drawing.Point(0, 0);
            this.pbx_Fundo.Name = "pbx_Fundo";
            this.pbx_Fundo.Size = new System.Drawing.Size(984, 711);
            this.pbx_Fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Fundo.TabIndex = 14;
            this.pbx_Fundo.TabStop = false;
            // 
            // tmr_Intervalo
            // 
            this.tmr_Intervalo.Interval = 750;
            this.tmr_Intervalo.Tick += new System.EventHandler(this.tmr_Intervalo_Tick);
            // 
            // tmr_Tempo
            // 
            this.tmr_Tempo.Interval = 1000;
            this.tmr_Tempo.Tick += new System.EventHandler(this.tmr_Tempo_Tick);
            // 
            // frm_JM_TelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.tlp_Tabuleiro);
            this.Controls.Add(this.lbl_Jogadas);
            this.Controls.Add(this.lbl_Tempo);
            this.Controls.Add(this.lbl_VTempo);
            this.Controls.Add(this.lbl_VJogadas);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pbx_Fundo);
            this.Name = "frm_JM_TelaJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_JM_TelaJogo_FormClosed);
            this.Load += new System.EventHandler(this.frm_JM_TelaJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pbx_Fundo;
        private System.Windows.Forms.Label lbl_Jogadas;
        private System.Windows.Forms.Label lbl_Tempo;
        private System.Windows.Forms.Label lbl_VTempo;
        private System.Windows.Forms.Label lbl_VJogadas;
        private System.Windows.Forms.TableLayoutPanel tlp_Tabuleiro;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Timer tmr_Intervalo;
        private System.Windows.Forms.Timer tmr_Tempo;
    }
}