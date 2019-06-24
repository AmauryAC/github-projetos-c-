namespace PRJ_Distancia_entre_Cidades
{
    partial class frm_AtualizarA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AtualizarA));
            this.pnl_AtualizarA = new System.Windows.Forms.Panel();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.gbx_AtualizarA = new System.Windows.Forms.GroupBox();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.lbl_V2 = new System.Windows.Forms.Label();
            this.lbl_V1 = new System.Windows.Forms.Label();
            this.tbx_Distancia = new System.Windows.Forms.TextBox();
            this.cbx_V2 = new System.Windows.Forms.ComboBox();
            this.cbx_V1 = new System.Windows.Forms.ComboBox();
            this.btn_AtualizarA = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.pnl_AtualizarA.SuspendLayout();
            this.gbx_AtualizarA.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_AtualizarA
            // 
            this.pnl_AtualizarA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_AtualizarA.Controls.Add(this.btn_Limpar);
            this.pnl_AtualizarA.Controls.Add(this.btn_Voltar);
            this.pnl_AtualizarA.Controls.Add(this.gbx_AtualizarA);
            this.pnl_AtualizarA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_AtualizarA.Location = new System.Drawing.Point(0, 0);
            this.pnl_AtualizarA.Name = "pnl_AtualizarA";
            this.pnl_AtualizarA.Size = new System.Drawing.Size(320, 224);
            this.pnl_AtualizarA.TabIndex = 3;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(147, 189);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(228, 189);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 10;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // gbx_AtualizarA
            // 
            this.gbx_AtualizarA.Controls.Add(this.lbl_Peso);
            this.gbx_AtualizarA.Controls.Add(this.lbl_V2);
            this.gbx_AtualizarA.Controls.Add(this.lbl_V1);
            this.gbx_AtualizarA.Controls.Add(this.tbx_Distancia);
            this.gbx_AtualizarA.Controls.Add(this.cbx_V2);
            this.gbx_AtualizarA.Controls.Add(this.cbx_V1);
            this.gbx_AtualizarA.Controls.Add(this.btn_AtualizarA);
            this.gbx_AtualizarA.Controls.Add(this.lbl_ID);
            this.gbx_AtualizarA.Controls.Add(this.tbx_ID);
            this.gbx_AtualizarA.Location = new System.Drawing.Point(3, 3);
            this.gbx_AtualizarA.Name = "gbx_AtualizarA";
            this.gbx_AtualizarA.Size = new System.Drawing.Size(312, 180);
            this.gbx_AtualizarA.TabIndex = 0;
            this.gbx_AtualizarA.TabStop = false;
            this.gbx_AtualizarA.Text = "Atualizando Aresta (Distância)";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Location = new System.Drawing.Point(8, 119);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(78, 13);
            this.lbl_Peso.TabIndex = 7;
            this.lbl_Peso.Text = "Distância (Km):";
            // 
            // lbl_V2
            // 
            this.lbl_V2.AutoSize = true;
            this.lbl_V2.Location = new System.Drawing.Point(147, 69);
            this.lbl_V2.Name = "lbl_V2";
            this.lbl_V2.Size = new System.Drawing.Size(52, 13);
            this.lbl_V2.TabIndex = 5;
            this.lbl_V2.Text = "Cidade 2:";
            // 
            // lbl_V1
            // 
            this.lbl_V1.AutoSize = true;
            this.lbl_V1.Location = new System.Drawing.Point(8, 70);
            this.lbl_V1.Name = "lbl_V1";
            this.lbl_V1.Size = new System.Drawing.Size(52, 13);
            this.lbl_V1.TabIndex = 4;
            this.lbl_V1.Text = "Cidade 1:";
            // 
            // tbx_Distancia
            // 
            this.tbx_Distancia.Location = new System.Drawing.Point(9, 135);
            this.tbx_Distancia.Name = "tbx_Distancia";
            this.tbx_Distancia.Size = new System.Drawing.Size(100, 20);
            this.tbx_Distancia.TabIndex = 6;
            // 
            // cbx_V2
            // 
            this.cbx_V2.FormattingEnabled = true;
            this.cbx_V2.Location = new System.Drawing.Point(150, 85);
            this.cbx_V2.Name = "cbx_V2";
            this.cbx_V2.Size = new System.Drawing.Size(121, 21);
            this.cbx_V2.TabIndex = 3;
            this.cbx_V2.SelectedIndexChanged += new System.EventHandler(this.cbx_V1_SelectedIndexChanged);
            // 
            // cbx_V1
            // 
            this.cbx_V1.FormattingEnabled = true;
            this.cbx_V1.Location = new System.Drawing.Point(9, 85);
            this.cbx_V1.Name = "cbx_V1";
            this.cbx_V1.Size = new System.Drawing.Size(121, 21);
            this.cbx_V1.TabIndex = 2;
            this.cbx_V1.SelectedIndexChanged += new System.EventHandler(this.cbx_V1_SelectedIndexChanged);
            // 
            // btn_AtualizarA
            // 
            this.btn_AtualizarA.Location = new System.Drawing.Point(225, 149);
            this.btn_AtualizarA.Name = "btn_AtualizarA";
            this.btn_AtualizarA.Size = new System.Drawing.Size(75, 23);
            this.btn_AtualizarA.TabIndex = 8;
            this.btn_AtualizarA.Text = "Atualizar";
            this.btn_AtualizarA.UseVisualStyleBackColor = true;
            this.btn_AtualizarA.Click += new System.EventHandler(this.btn_AtualizarA_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(6, 26);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID:";
            // 
            // tbx_ID
            // 
            this.tbx_ID.Enabled = false;
            this.tbx_ID.Location = new System.Drawing.Point(9, 42);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(49, 20);
            this.tbx_ID.TabIndex = 0;
            // 
            // frm_AtualizarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 224);
            this.Controls.Add(this.pnl_AtualizarA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AtualizarA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Aresta";
            this.pnl_AtualizarA.ResumeLayout(false);
            this.gbx_AtualizarA.ResumeLayout(false);
            this.gbx_AtualizarA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AtualizarA;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.GroupBox gbx_AtualizarA;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.Label lbl_V2;
        private System.Windows.Forms.Label lbl_V1;
        private System.Windows.Forms.TextBox tbx_Distancia;
        private System.Windows.Forms.ComboBox cbx_V2;
        private System.Windows.Forms.ComboBox cbx_V1;
        private System.Windows.Forms.Button btn_AtualizarA;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tbx_ID;
    }
}