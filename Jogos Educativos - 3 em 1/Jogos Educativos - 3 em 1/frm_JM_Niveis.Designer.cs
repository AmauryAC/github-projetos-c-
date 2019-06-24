namespace Jogos_Educativos___3_em_1
{
    partial class frm_JM_Niveis
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
            this.lbl_Nivel = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Dificil = new System.Windows.Forms.Button();
            this.btn_Medio = new System.Windows.Forms.Button();
            this.btn_Facil = new System.Windows.Forms.Button();
            this.pbx_Fundo = new System.Windows.Forms.PictureBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nivel
            // 
            this.lbl_Nivel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Nivel.AutoSize = true;
            this.lbl_Nivel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nivel.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nivel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Nivel.Location = new System.Drawing.Point(63, 206);
            this.lbl_Nivel.Name = "lbl_Nivel";
            this.lbl_Nivel.Size = new System.Drawing.Size(862, 60);
            this.lbl_Nivel.TabIndex = 14;
            this.lbl_Nivel.Text = "Selecione o Nível de dificuldade:";
            this.lbl_Nivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Titulo.Location = new System.Drawing.Point(44, 67);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(896, 119);
            this.lbl_Titulo.TabIndex = 13;
            this.lbl_Titulo.Text = "Jogo da Memória";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Dificil
            // 
            this.btn_Dificil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Dificil.BackColor = System.Drawing.Color.White;
            this.btn_Dificil.BackgroundImage = global::Jogos_Educativos___3_em_1.Properties.Resources._3_estrelas;
            this.btn_Dificil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Dificil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dificil.Font = new System.Drawing.Font("Showcard Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dificil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Dificil.Location = new System.Drawing.Point(374, 478);
            this.btn_Dificil.Name = "btn_Dificil";
            this.btn_Dificil.Size = new System.Drawing.Size(228, 82);
            this.btn_Dificil.TabIndex = 17;
            this.btn_Dificil.UseVisualStyleBackColor = false;
            this.btn_Dificil.Click += new System.EventHandler(this.btn_Dificil_Click);
            // 
            // btn_Medio
            // 
            this.btn_Medio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Medio.BackColor = System.Drawing.Color.White;
            this.btn_Medio.BackgroundImage = global::Jogos_Educativos___3_em_1.Properties.Resources._2_estrelas;
            this.btn_Medio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Medio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Medio.Font = new System.Drawing.Font("Showcard Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Medio.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Medio.Location = new System.Drawing.Point(374, 390);
            this.btn_Medio.Name = "btn_Medio";
            this.btn_Medio.Size = new System.Drawing.Size(228, 82);
            this.btn_Medio.TabIndex = 16;
            this.btn_Medio.UseVisualStyleBackColor = false;
            this.btn_Medio.Click += new System.EventHandler(this.btn_Medio_Click);
            // 
            // btn_Facil
            // 
            this.btn_Facil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Facil.BackColor = System.Drawing.Color.White;
            this.btn_Facil.BackgroundImage = global::Jogos_Educativos___3_em_1.Properties.Resources._1_estrela;
            this.btn_Facil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Facil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facil.Font = new System.Drawing.Font("Showcard Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Facil.Location = new System.Drawing.Point(374, 302);
            this.btn_Facil.Name = "btn_Facil";
            this.btn_Facil.Size = new System.Drawing.Size(228, 82);
            this.btn_Facil.TabIndex = 15;
            this.btn_Facil.UseVisualStyleBackColor = false;
            this.btn_Facil.Click += new System.EventHandler(this.btn_Facil_Click);
            // 
            // pbx_Fundo
            // 
            this.pbx_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_Fundo.Image = global::Jogos_Educativos___3_em_1.Properties.Resources.fundo_tela;
            this.pbx_Fundo.Location = new System.Drawing.Point(0, 0);
            this.pbx_Fundo.Name = "pbx_Fundo";
            this.pbx_Fundo.Size = new System.Drawing.Size(984, 711);
            this.pbx_Fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Fundo.TabIndex = 12;
            this.pbx_Fundo.TabStop = false;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Voltar.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Location = new System.Drawing.Point(854, 559);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(118, 65);
            this.btn_Voltar.TabIndex = 30;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sair.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(854, 634);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(118, 65);
            this.btn_Sair.TabIndex = 29;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frm_JM_Niveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Dificil);
            this.Controls.Add(this.btn_Medio);
            this.Controls.Add(this.btn_Facil);
            this.Controls.Add(this.lbl_Nivel);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pbx_Fundo);
            this.Name = "frm_JM_Niveis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_JM_Niveis_FormClosed);
            this.Load += new System.EventHandler(this.frm_JM_Niveis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nivel;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pbx_Fundo;
        private System.Windows.Forms.Button btn_Dificil;
        private System.Windows.Forms.Button btn_Medio;
        private System.Windows.Forms.Button btn_Facil;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Sair;
    }
}