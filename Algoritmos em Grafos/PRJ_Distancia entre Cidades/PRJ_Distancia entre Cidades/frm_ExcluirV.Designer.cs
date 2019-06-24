namespace PRJ_Distancia_entre_Cidades
{
    partial class frm_ExcluirV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ExcluirV));
            this.pnl_ExcluirV = new System.Windows.Forms.Panel();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.gbx_ExcluirV = new System.Windows.Forms.GroupBox();
            this.cbx_V = new System.Windows.Forms.ComboBox();
            this.btn_ExcluirV = new System.Windows.Forms.Button();
            this.lbl_NomeCid = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.pnl_ExcluirV.SuspendLayout();
            this.gbx_ExcluirV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ExcluirV
            // 
            this.pnl_ExcluirV.Controls.Add(this.btn_Limpar);
            this.pnl_ExcluirV.Controls.Add(this.btn_Voltar);
            this.pnl_ExcluirV.Controls.Add(this.gbx_ExcluirV);
            this.pnl_ExcluirV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ExcluirV.Location = new System.Drawing.Point(0, 0);
            this.pnl_ExcluirV.Name = "pnl_ExcluirV";
            this.pnl_ExcluirV.Size = new System.Drawing.Size(318, 153);
            this.pnl_ExcluirV.TabIndex = 0;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(147, 122);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(228, 122);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 10;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // gbx_ExcluirV
            // 
            this.gbx_ExcluirV.Controls.Add(this.cbx_V);
            this.gbx_ExcluirV.Controls.Add(this.btn_ExcluirV);
            this.gbx_ExcluirV.Controls.Add(this.lbl_NomeCid);
            this.gbx_ExcluirV.Controls.Add(this.lbl_ID);
            this.gbx_ExcluirV.Controls.Add(this.tbx_ID);
            this.gbx_ExcluirV.Location = new System.Drawing.Point(3, 3);
            this.gbx_ExcluirV.Name = "gbx_ExcluirV";
            this.gbx_ExcluirV.Size = new System.Drawing.Size(312, 112);
            this.gbx_ExcluirV.TabIndex = 8;
            this.gbx_ExcluirV.TabStop = false;
            this.gbx_ExcluirV.Text = "Excluindo Vértice (Cidade)";
            // 
            // cbx_V
            // 
            this.cbx_V.FormattingEnabled = true;
            this.cbx_V.Location = new System.Drawing.Point(76, 42);
            this.cbx_V.Name = "cbx_V";
            this.cbx_V.Size = new System.Drawing.Size(224, 21);
            this.cbx_V.TabIndex = 6;
            this.cbx_V.SelectedIndexChanged += new System.EventHandler(this.cbx_V_SelectedIndexChanged);
            // 
            // btn_ExcluirV
            // 
            this.btn_ExcluirV.Location = new System.Drawing.Point(225, 81);
            this.btn_ExcluirV.Name = "btn_ExcluirV";
            this.btn_ExcluirV.Size = new System.Drawing.Size(75, 23);
            this.btn_ExcluirV.TabIndex = 4;
            this.btn_ExcluirV.Text = "Excluir";
            this.btn_ExcluirV.UseVisualStyleBackColor = true;
            this.btn_ExcluirV.Click += new System.EventHandler(this.btn_ExcluirV_Click);
            // 
            // lbl_NomeCid
            // 
            this.lbl_NomeCid.AutoSize = true;
            this.lbl_NomeCid.Location = new System.Drawing.Point(73, 26);
            this.lbl_NomeCid.Name = "lbl_NomeCid";
            this.lbl_NomeCid.Size = new System.Drawing.Size(131, 13);
            this.lbl_NomeCid.TabIndex = 3;
            this.lbl_NomeCid.Text = "Nome da Cidade (Vértice):";
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
            // tbx_ID
            // 
            this.tbx_ID.Enabled = false;
            this.tbx_ID.Location = new System.Drawing.Point(9, 42);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(49, 20);
            this.tbx_ID.TabIndex = 0;
            // 
            // frm_ExcluirV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 153);
            this.Controls.Add(this.pnl_ExcluirV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ExcluirV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Vértice";
            this.pnl_ExcluirV.ResumeLayout(false);
            this.gbx_ExcluirV.ResumeLayout(false);
            this.gbx_ExcluirV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ExcluirV;
        private System.Windows.Forms.GroupBox gbx_ExcluirV;
        private System.Windows.Forms.ComboBox cbx_V;
        private System.Windows.Forms.Button btn_ExcluirV;
        private System.Windows.Forms.Label lbl_NomeCid;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Voltar;
    }
}