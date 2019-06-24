namespace PRJ_Distancia_entre_Cidades
{
    partial class frm_ExibirG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ExibirG));
            this.pnl_Exibir = new System.Windows.Forms.Panel();
            this.lblNomeGrafo = new System.Windows.Forms.Label();
            this.clb_TG = new System.Windows.Forms.CheckedListBox();
            this.lbl_TipoG = new System.Windows.Forms.Label();
            this.lbl_NA = new System.Windows.Forms.Label();
            this.lbl_TituloNA = new System.Windows.Forms.Label();
            this.lbl_NV = new System.Windows.Forms.Label();
            this.lbl_TituloNV = new System.Windows.Forms.Label();
            this.lbx_Exibir = new System.Windows.Forms.ListBox();
            this.pnl_Exibir.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Exibir
            // 
            this.pnl_Exibir.Controls.Add(this.lblNomeGrafo);
            this.pnl_Exibir.Controls.Add(this.clb_TG);
            this.pnl_Exibir.Controls.Add(this.lbl_TipoG);
            this.pnl_Exibir.Controls.Add(this.lbl_NA);
            this.pnl_Exibir.Controls.Add(this.lbl_TituloNA);
            this.pnl_Exibir.Controls.Add(this.lbl_NV);
            this.pnl_Exibir.Controls.Add(this.lbl_TituloNV);
            this.pnl_Exibir.Controls.Add(this.lbx_Exibir);
            this.pnl_Exibir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Exibir.Location = new System.Drawing.Point(0, 0);
            this.pnl_Exibir.Name = "pnl_Exibir";
            this.pnl_Exibir.Size = new System.Drawing.Size(363, 276);
            this.pnl_Exibir.TabIndex = 0;
            // 
            // lblNomeGrafo
            // 
            this.lblNomeGrafo.AutoSize = true;
            this.lblNomeGrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrafo.Location = new System.Drawing.Point(260, 9);
            this.lblNomeGrafo.Name = "lblNomeGrafo";
            this.lblNomeGrafo.Size = new System.Drawing.Size(89, 13);
            this.lblNomeGrafo.TabIndex = 16;
            this.lblNomeGrafo.Text = "Grafo de Cidades";
            // 
            // clb_TG
            // 
            this.clb_TG.Enabled = false;
            this.clb_TG.FormattingEnabled = true;
            this.clb_TG.Items.AddRange(new object[] {
            "Simples",
            "Trivial",
            "Regular",
            "Completo",
            "T. desconexo",
            "Euleriano"});
            this.clb_TG.Location = new System.Drawing.Point(263, 136);
            this.clb_TG.MultiColumn = true;
            this.clb_TG.Name = "clb_TG";
            this.clb_TG.Size = new System.Drawing.Size(94, 94);
            this.clb_TG.TabIndex = 15;
            // 
            // lbl_TipoG
            // 
            this.lbl_TipoG.AutoSize = true;
            this.lbl_TipoG.Location = new System.Drawing.Point(260, 120);
            this.lbl_TipoG.Name = "lbl_TipoG";
            this.lbl_TipoG.Size = new System.Drawing.Size(75, 13);
            this.lbl_TipoG.TabIndex = 14;
            this.lbl_TipoG.Text = "Tipo do Grafo:";
            // 
            // lbl_NA
            // 
            this.lbl_NA.AutoSize = true;
            this.lbl_NA.Location = new System.Drawing.Point(260, 90);
            this.lbl_NA.Name = "lbl_NA";
            this.lbl_NA.Size = new System.Drawing.Size(13, 13);
            this.lbl_NA.TabIndex = 13;
            this.lbl_NA.Text = "0";
            // 
            // lbl_TituloNA
            // 
            this.lbl_TituloNA.AutoSize = true;
            this.lbl_TituloNA.Location = new System.Drawing.Point(260, 75);
            this.lbl_TituloNA.Name = "lbl_TituloNA";
            this.lbl_TituloNA.Size = new System.Drawing.Size(100, 13);
            this.lbl_TituloNA.TabIndex = 12;
            this.lbl_TituloNA.Text = "Número de Arestas:";
            // 
            // lbl_NV
            // 
            this.lbl_NV.AutoSize = true;
            this.lbl_NV.Location = new System.Drawing.Point(260, 51);
            this.lbl_NV.Name = "lbl_NV";
            this.lbl_NV.Size = new System.Drawing.Size(13, 13);
            this.lbl_NV.TabIndex = 11;
            this.lbl_NV.Text = "0";
            // 
            // lbl_TituloNV
            // 
            this.lbl_TituloNV.AutoSize = true;
            this.lbl_TituloNV.Location = new System.Drawing.Point(260, 36);
            this.lbl_TituloNV.Name = "lbl_TituloNV";
            this.lbl_TituloNV.Size = new System.Drawing.Size(100, 13);
            this.lbl_TituloNV.TabIndex = 10;
            this.lbl_TituloNV.Text = "Número de Vérices:";
            // 
            // lbx_Exibir
            // 
            this.lbx_Exibir.FormattingEnabled = true;
            this.lbx_Exibir.Location = new System.Drawing.Point(4, 4);
            this.lbx_Exibir.Name = "lbx_Exibir";
            this.lbx_Exibir.Size = new System.Drawing.Size(250, 264);
            this.lbx_Exibir.TabIndex = 8;
            // 
            // frm_ExibirG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 276);
            this.Controls.Add(this.pnl_Exibir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ExibirG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exibir Grafo";
            this.Load += new System.EventHandler(this.frm_ExibirG_Load);
            this.pnl_Exibir.ResumeLayout(false);
            this.pnl_Exibir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Exibir;
        private System.Windows.Forms.CheckedListBox clb_TG;
        private System.Windows.Forms.Label lbl_TipoG;
        private System.Windows.Forms.Label lbl_NA;
        private System.Windows.Forms.Label lbl_TituloNA;
        private System.Windows.Forms.Label lbl_NV;
        private System.Windows.Forms.Label lbl_TituloNV;
        private System.Windows.Forms.ListBox lbx_Exibir;
        private System.Windows.Forms.Label lblNomeGrafo;
    }
}