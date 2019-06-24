namespace PRJ_Distancia_entre_Cidades
{
    partial class frm_InserirV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InserirV));
            this.pnl_InserirV = new System.Windows.Forms.Panel();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.gbx_InserirV = new System.Windows.Forms.GroupBox();
            this.btn_InserirV = new System.Windows.Forms.Button();
            this.lbl_NomeCid = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tbx_Nome = new System.Windows.Forms.TextBox();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.pnl_InserirV.SuspendLayout();
            this.gbx_InserirV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_InserirV
            // 
            this.pnl_InserirV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_InserirV.Controls.Add(this.btn_Limpar);
            this.pnl_InserirV.Controls.Add(this.btn_Voltar);
            this.pnl_InserirV.Controls.Add(this.gbx_InserirV);
            this.pnl_InserirV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_InserirV.Location = new System.Drawing.Point(0, 0);
            this.pnl_InserirV.Name = "pnl_InserirV";
            this.pnl_InserirV.Size = new System.Drawing.Size(320, 152);
            this.pnl_InserirV.TabIndex = 1;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(147, 121);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 5;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(228, 121);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 6;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // gbx_InserirV
            // 
            this.gbx_InserirV.Controls.Add(this.btn_InserirV);
            this.gbx_InserirV.Controls.Add(this.lbl_NomeCid);
            this.gbx_InserirV.Controls.Add(this.lbl_ID);
            this.gbx_InserirV.Controls.Add(this.tbx_Nome);
            this.gbx_InserirV.Controls.Add(this.tbx_ID);
            this.gbx_InserirV.Location = new System.Drawing.Point(3, 3);
            this.gbx_InserirV.Name = "gbx_InserirV";
            this.gbx_InserirV.Size = new System.Drawing.Size(312, 112);
            this.gbx_InserirV.TabIndex = 0;
            this.gbx_InserirV.TabStop = false;
            this.gbx_InserirV.Text = "Inserindo Vértice (Cidade)";
            // 
            // btn_InserirV
            // 
            this.btn_InserirV.Location = new System.Drawing.Point(225, 81);
            this.btn_InserirV.Name = "btn_InserirV";
            this.btn_InserirV.Size = new System.Drawing.Size(75, 23);
            this.btn_InserirV.TabIndex = 4;
            this.btn_InserirV.Text = "Inserir";
            this.btn_InserirV.UseVisualStyleBackColor = true;
            this.btn_InserirV.Click += new System.EventHandler(this.btn_InserirV_Click);
            // 
            // lbl_NomeCid
            // 
            this.lbl_NomeCid.AutoSize = true;
            this.lbl_NomeCid.Location = new System.Drawing.Point(73, 26);
            this.lbl_NomeCid.Name = "lbl_NomeCid";
            this.lbl_NomeCid.Size = new System.Drawing.Size(89, 13);
            this.lbl_NomeCid.TabIndex = 3;
            this.lbl_NomeCid.Text = "Nome da Cidade:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(6, 26);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "ID:";
            // 
            // tbx_Nome
            // 
            this.tbx_Nome.Location = new System.Drawing.Point(76, 42);
            this.tbx_Nome.Name = "tbx_Nome";
            this.tbx_Nome.Size = new System.Drawing.Size(224, 20);
            this.tbx_Nome.TabIndex = 1;
            this.tbx_Nome.TextChanged += new System.EventHandler(this.tbx_Nome_TextChanged);
            // 
            // tbx_ID
            // 
            this.tbx_ID.Enabled = false;
            this.tbx_ID.Location = new System.Drawing.Point(9, 42);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(49, 20);
            this.tbx_ID.TabIndex = 0;
            // 
            // frm_InserirV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 152);
            this.Controls.Add(this.pnl_InserirV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_InserirV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Vértice";
            this.pnl_InserirV.ResumeLayout(false);
            this.gbx_InserirV.ResumeLayout(false);
            this.gbx_InserirV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_InserirV;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.GroupBox gbx_InserirV;
        private System.Windows.Forms.Button btn_InserirV;
        private System.Windows.Forms.Label lbl_NomeCid;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tbx_Nome;
        private System.Windows.Forms.TextBox tbx_ID;
    }
}