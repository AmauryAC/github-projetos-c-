namespace Jogo_da_Memoria_1._0._0
{
    partial class frm_Niveis
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Dificil = new System.Windows.Forms.Button();
            this.btn_Medio = new System.Windows.Forms.Button();
            this.btn_Facil = new System.Windows.Forms.Button();
            this.pbx_Fundo = new System.Windows.Forms.PictureBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(267, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 60);
            this.label2.TabIndex = 11;
            this.label2.Text = "Selecione o Nível:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(44, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 119);
            this.label1.TabIndex = 10;
            this.label1.Text = "Jogo da Memória";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Dificil
            // 
            this.btn_Dificil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Dificil.BackColor = System.Drawing.Color.White;
            this.btn_Dificil.Font = new System.Drawing.Font("Showcard Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dificil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Dificil.Image = global::Jogo_da_Memoria_1._0._0.Properties.Resources._3_estrelas;
            this.btn_Dificil.Location = new System.Drawing.Point(385, 527);
            this.btn_Dificil.Name = "btn_Dificil";
            this.btn_Dificil.Size = new System.Drawing.Size(228, 82);
            this.btn_Dificil.TabIndex = 14;
            this.btn_Dificil.UseVisualStyleBackColor = false;
            this.btn_Dificil.Click += new System.EventHandler(this.btn_Dificil_Click);
            // 
            // btn_Medio
            // 
            this.btn_Medio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Medio.BackColor = System.Drawing.Color.White;
            this.btn_Medio.Font = new System.Drawing.Font("Showcard Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Medio.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Medio.Image = global::Jogo_da_Memoria_1._0._0.Properties.Resources._2_estrelas;
            this.btn_Medio.Location = new System.Drawing.Point(385, 439);
            this.btn_Medio.Name = "btn_Medio";
            this.btn_Medio.Size = new System.Drawing.Size(228, 82);
            this.btn_Medio.TabIndex = 13;
            this.btn_Medio.UseVisualStyleBackColor = false;
            this.btn_Medio.Click += new System.EventHandler(this.btn_Medio_Click);
            // 
            // btn_Facil
            // 
            this.btn_Facil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Facil.BackColor = System.Drawing.Color.White;
            this.btn_Facil.Font = new System.Drawing.Font("Showcard Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Facil.Image = global::Jogo_da_Memoria_1._0._0.Properties.Resources._1_estrela;
            this.btn_Facil.Location = new System.Drawing.Point(385, 351);
            this.btn_Facil.Name = "btn_Facil";
            this.btn_Facil.Size = new System.Drawing.Size(228, 82);
            this.btn_Facil.TabIndex = 12;
            this.btn_Facil.UseVisualStyleBackColor = false;
            this.btn_Facil.Click += new System.EventHandler(this.btn_Facil_Click);
            // 
            // pbx_Fundo
            // 
            this.pbx_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_Fundo.Image = global::Jogo_da_Memoria_1._0._0.Properties.Resources.fundo_tela;
            this.pbx_Fundo.Location = new System.Drawing.Point(0, 0);
            this.pbx_Fundo.Name = "pbx_Fundo";
            this.pbx_Fundo.Size = new System.Drawing.Size(984, 711);
            this.pbx_Fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Fundo.TabIndex = 2;
            this.pbx_Fundo.TabStop = false;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Voltar.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Location = new System.Drawing.Point(854, 562);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(118, 65);
            this.btn_Voltar.TabIndex = 25;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sair.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(854, 633);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(118, 65);
            this.btn_Sair.TabIndex = 24;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frm_Niveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Dificil);
            this.Controls.Add(this.btn_Medio);
            this.Controls.Add(this.btn_Facil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbx_Fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Niveis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Niveis_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Fundo;
        private System.Windows.Forms.Button btn_Dificil;
        private System.Windows.Forms.Button btn_Medio;
        private System.Windows.Forms.Button btn_Facil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Sair;
    }
}