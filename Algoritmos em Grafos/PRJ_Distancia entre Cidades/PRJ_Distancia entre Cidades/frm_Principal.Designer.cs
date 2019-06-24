namespace PRJ_Distancia_entre_Cidades
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.msp_Principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vérticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vérticeCidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arestaDistânciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarPesoDaArestanãoImplementadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vérticeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arestaPesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarGrafonãoImplementadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heurísticaDaColoraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssp_Principal = new System.Windows.Forms.StatusStrip();
            this.tssl_Mensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr_Principal = new System.Windows.Forms.Timer(this.components);
            this.tsp_Principal = new System.Windows.Forms.ToolStrip();
            this.tsb_Novo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_IV = new System.Windows.Forms.ToolStripButton();
            this.tsb_IA = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_EV = new System.Windows.Forms.ToolStripButton();
            this.tsb_EA = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_AV = new System.Windows.Forms.ToolStripButton();
            this.tsb_AA = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_RG = new System.Windows.Forms.ToolStripButton();
            this.tsb_EG = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Ajuda = new System.Windows.Forms.ToolStripButton();
            this.tsb_Sobre = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Sair = new System.Windows.Forms.ToolStripButton();
            this.msp_Principal.SuspendLayout();
            this.ssp_Principal.SuspendLayout();
            this.tsp_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msp_Principal
            // 
            this.msp_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.heurísticaDaColoraçãoToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.msp_Principal.Location = new System.Drawing.Point(0, 0);
            this.msp_Principal.Name = "msp_Principal";
            this.msp_Principal.Size = new System.Drawing.Size(572, 24);
            this.msp_Principal.TabIndex = 0;
            this.msp_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.novoToolStripMenuItem.Text = "Novo ";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(103, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.alterarPesoDaArestanãoImplementadoToolStripMenuItem,
            this.reiniciarGrafonãoImplementadoToolStripMenuItem});
            this.editarToolStripMenuItem.Enabled = false;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vérticeToolStripMenuItem,
            this.arestaToolStripMenuItem});
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.inserirToolStripMenuItem.Text = "Inserir";
            // 
            // vérticeToolStripMenuItem
            // 
            this.vérticeToolStripMenuItem.Name = "vérticeToolStripMenuItem";
            this.vérticeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.vérticeToolStripMenuItem.Text = "Vértice (Cidade)";
            this.vérticeToolStripMenuItem.Click += new System.EventHandler(this.vérticeToolStripMenuItem_Click);
            // 
            // arestaToolStripMenuItem
            // 
            this.arestaToolStripMenuItem.Name = "arestaToolStripMenuItem";
            this.arestaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.arestaToolStripMenuItem.Text = "Aresta (Distância)";
            this.arestaToolStripMenuItem.Click += new System.EventHandler(this.arestaToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vérticeCidadeToolStripMenuItem,
            this.arestaDistânciaToolStripMenuItem});
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // vérticeCidadeToolStripMenuItem
            // 
            this.vérticeCidadeToolStripMenuItem.Name = "vérticeCidadeToolStripMenuItem";
            this.vérticeCidadeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.vérticeCidadeToolStripMenuItem.Text = "Vértice (Cidade)";
            this.vérticeCidadeToolStripMenuItem.Click += new System.EventHandler(this.vérticeCidadeToolStripMenuItem_Click);
            // 
            // arestaDistânciaToolStripMenuItem
            // 
            this.arestaDistânciaToolStripMenuItem.Name = "arestaDistânciaToolStripMenuItem";
            this.arestaDistânciaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.arestaDistânciaToolStripMenuItem.Text = "Aresta (Distância)";
            this.arestaDistânciaToolStripMenuItem.Click += new System.EventHandler(this.arestaDistânciaToolStripMenuItem_Click);
            // 
            // alterarPesoDaArestanãoImplementadoToolStripMenuItem
            // 
            this.alterarPesoDaArestanãoImplementadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vérticeToolStripMenuItem1,
            this.arestaPesoToolStripMenuItem});
            this.alterarPesoDaArestanãoImplementadoToolStripMenuItem.Name = "alterarPesoDaArestanãoImplementadoToolStripMenuItem";
            this.alterarPesoDaArestanãoImplementadoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.alterarPesoDaArestanãoImplementadoToolStripMenuItem.Text = "Alterar ";
            // 
            // vérticeToolStripMenuItem1
            // 
            this.vérticeToolStripMenuItem1.Name = "vérticeToolStripMenuItem1";
            this.vérticeToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.vérticeToolStripMenuItem1.Text = "Vértice (Nome)";
            this.vérticeToolStripMenuItem1.Click += new System.EventHandler(this.vérticeToolStripMenuItem1_Click);
            // 
            // arestaPesoToolStripMenuItem
            // 
            this.arestaPesoToolStripMenuItem.Name = "arestaPesoToolStripMenuItem";
            this.arestaPesoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.arestaPesoToolStripMenuItem.Text = "Aresta (Peso)";
            this.arestaPesoToolStripMenuItem.Click += new System.EventHandler(this.arestaPesoToolStripMenuItem_Click);
            // 
            // reiniciarGrafonãoImplementadoToolStripMenuItem
            // 
            this.reiniciarGrafonãoImplementadoToolStripMenuItem.Name = "reiniciarGrafonãoImplementadoToolStripMenuItem";
            this.reiniciarGrafonãoImplementadoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.reiniciarGrafonãoImplementadoToolStripMenuItem.Text = "Reiniciar Grafo ";
            this.reiniciarGrafonãoImplementadoToolStripMenuItem.Click += new System.EventHandler(this.reiniciarGrafonãoImplementadoToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.Enabled = false;
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.exibirToolStripMenuItem.Text = "Exibir Grafo";
            this.exibirToolStripMenuItem.Click += new System.EventHandler(this.exibirToolStripMenuItem_Click);
            // 
            // heurísticaDaColoraçãoToolStripMenuItem
            // 
            this.heurísticaDaColoraçãoToolStripMenuItem.Enabled = false;
            this.heurísticaDaColoraçãoToolStripMenuItem.Name = "heurísticaDaColoraçãoToolStripMenuItem";
            this.heurísticaDaColoraçãoToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.heurísticaDaColoraçãoToolStripMenuItem.Text = "Heurística da Coloração";
            this.heurísticaDaColoraçãoToolStripMenuItem.Click += new System.EventHandler(this.heurísticaDaColoraçãoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // ssp_Principal
            // 
            this.ssp_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Mensagem,
            this.tssl_Data,
            this.tssl_Hora});
            this.ssp_Principal.Location = new System.Drawing.Point(0, 296);
            this.ssp_Principal.Name = "ssp_Principal";
            this.ssp_Principal.Size = new System.Drawing.Size(572, 22);
            this.ssp_Principal.TabIndex = 3;
            this.ssp_Principal.Text = "statusStrip1";
            // 
            // tssl_Mensagem
            // 
            this.tssl_Mensagem.Name = "tssl_Mensagem";
            this.tssl_Mensagem.Size = new System.Drawing.Size(131, 17);
            this.tssl_Mensagem.Text = "Bem vindo à Aplicação!";
            // 
            // tssl_Data
            // 
            this.tssl_Data.Name = "tssl_Data";
            this.tssl_Data.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tssl_Data.Size = new System.Drawing.Size(92, 17);
            this.tssl_Data.Text = "Data do Sistema";
            // 
            // tssl_Hora
            // 
            this.tssl_Hora.Name = "tssl_Hora";
            this.tssl_Hora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tssl_Hora.Size = new System.Drawing.Size(94, 17);
            this.tssl_Hora.Text = "Hora do Sistema";
            // 
            // tmr_Principal
            // 
            this.tmr_Principal.Enabled = true;
            this.tmr_Principal.Tick += new System.EventHandler(this.tmr_Principal_Tick);
            // 
            // tsp_Principal
            // 
            this.tsp_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Novo,
            this.toolStripSeparator2,
            this.tsb_IV,
            this.tsb_IA,
            this.toolStripSeparator3,
            this.tsb_EV,
            this.tsb_EA,
            this.toolStripSeparator4,
            this.tsb_AV,
            this.tsb_AA,
            this.toolStripSeparator5,
            this.tsb_RG,
            this.tsb_EG,
            this.toolStripSeparator6,
            this.tsb_Ajuda,
            this.tsb_Sobre,
            this.toolStripSeparator7,
            this.tsb_Sair});
            this.tsp_Principal.Location = new System.Drawing.Point(0, 24);
            this.tsp_Principal.Name = "tsp_Principal";
            this.tsp_Principal.Size = new System.Drawing.Size(572, 25);
            this.tsp_Principal.TabIndex = 4;
            this.tsp_Principal.Text = "tsp_Principal";
            // 
            // tsb_Novo
            // 
            this.tsb_Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Novo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Novo.Image")));
            this.tsb_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Novo.Name = "tsb_Novo";
            this.tsb_Novo.Size = new System.Drawing.Size(23, 22);
            this.tsb_Novo.Text = "Novo ";
            this.tsb_Novo.Click += new System.EventHandler(this.tsb_Novo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_IV
            // 
            this.tsb_IV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_IV.Enabled = false;
            this.tsb_IV.Image = ((System.Drawing.Image)(resources.GetObject("tsb_IV.Image")));
            this.tsb_IV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_IV.Name = "tsb_IV";
            this.tsb_IV.Size = new System.Drawing.Size(23, 22);
            this.tsb_IV.Text = "Inserir Vértice";
            this.tsb_IV.Click += new System.EventHandler(this.tsb_IV_Click);
            // 
            // tsb_IA
            // 
            this.tsb_IA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_IA.Enabled = false;
            this.tsb_IA.Image = ((System.Drawing.Image)(resources.GetObject("tsb_IA.Image")));
            this.tsb_IA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_IA.Name = "tsb_IA";
            this.tsb_IA.Size = new System.Drawing.Size(23, 22);
            this.tsb_IA.Text = "Inserir Aresta";
            this.tsb_IA.Click += new System.EventHandler(this.tsb_IA_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_EV
            // 
            this.tsb_EV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EV.Enabled = false;
            this.tsb_EV.Image = ((System.Drawing.Image)(resources.GetObject("tsb_EV.Image")));
            this.tsb_EV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_EV.Name = "tsb_EV";
            this.tsb_EV.Size = new System.Drawing.Size(23, 22);
            this.tsb_EV.Text = "Excluir Vértice";
            this.tsb_EV.Click += new System.EventHandler(this.tsb_EV_Click);
            // 
            // tsb_EA
            // 
            this.tsb_EA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EA.Enabled = false;
            this.tsb_EA.Image = ((System.Drawing.Image)(resources.GetObject("tsb_EA.Image")));
            this.tsb_EA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_EA.Name = "tsb_EA";
            this.tsb_EA.Size = new System.Drawing.Size(23, 22);
            this.tsb_EA.Text = "Excluir Aresta";
            this.tsb_EA.Click += new System.EventHandler(this.tsb_EA_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_AV
            // 
            this.tsb_AV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AV.Enabled = false;
            this.tsb_AV.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AV.Image")));
            this.tsb_AV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AV.Name = "tsb_AV";
            this.tsb_AV.Size = new System.Drawing.Size(23, 22);
            this.tsb_AV.Text = "Atualizar Vértice";
            this.tsb_AV.Click += new System.EventHandler(this.tsb_AV_Click);
            // 
            // tsb_AA
            // 
            this.tsb_AA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AA.Enabled = false;
            this.tsb_AA.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AA.Image")));
            this.tsb_AA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AA.Name = "tsb_AA";
            this.tsb_AA.Size = new System.Drawing.Size(23, 22);
            this.tsb_AA.Text = "Atualizar Aresta";
            this.tsb_AA.Click += new System.EventHandler(this.tsb_AA_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_RG
            // 
            this.tsb_RG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_RG.Enabled = false;
            this.tsb_RG.Image = ((System.Drawing.Image)(resources.GetObject("tsb_RG.Image")));
            this.tsb_RG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_RG.Name = "tsb_RG";
            this.tsb_RG.Size = new System.Drawing.Size(23, 22);
            this.tsb_RG.Text = "Reiniciar Grafo";
            this.tsb_RG.Click += new System.EventHandler(this.tsb_RG_Click);
            // 
            // tsb_EG
            // 
            this.tsb_EG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EG.Enabled = false;
            this.tsb_EG.Image = ((System.Drawing.Image)(resources.GetObject("tsb_EG.Image")));
            this.tsb_EG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_EG.Name = "tsb_EG";
            this.tsb_EG.Size = new System.Drawing.Size(23, 22);
            this.tsb_EG.Text = "Exibir Grafo";
            this.tsb_EG.Click += new System.EventHandler(this.tsb_EG_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_Ajuda
            // 
            this.tsb_Ajuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Ajuda.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Ajuda.Image")));
            this.tsb_Ajuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Ajuda.Name = "tsb_Ajuda";
            this.tsb_Ajuda.Size = new System.Drawing.Size(23, 22);
            this.tsb_Ajuda.Text = "Ajuda";
            this.tsb_Ajuda.Click += new System.EventHandler(this.tsb_Ajuda_Click);
            // 
            // tsb_Sobre
            // 
            this.tsb_Sobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Sobre.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Sobre.Image")));
            this.tsb_Sobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Sobre.Name = "tsb_Sobre";
            this.tsb_Sobre.Size = new System.Drawing.Size(23, 22);
            this.tsb_Sobre.Text = "Sobre";
            this.tsb_Sobre.Click += new System.EventHandler(this.tsb_Sobre_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_Sair
            // 
            this.tsb_Sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Sair.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Sair.Image")));
            this.tsb_Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Sair.Name = "tsb_Sair";
            this.tsb_Sair.Size = new System.Drawing.Size(23, 22);
            this.tsb_Sair.Text = "Sair";
            this.tsb_Sair.Click += new System.EventHandler(this.tsb_Sair_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 318);
            this.Controls.Add(this.tsp_Principal);
            this.Controls.Add(this.ssp_Principal);
            this.Controls.Add(this.msp_Principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msp_Principal;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distância entre Cidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Principal_FormClosing);
            this.msp_Principal.ResumeLayout(false);
            this.msp_Principal.PerformLayout();
            this.ssp_Principal.ResumeLayout(false);
            this.ssp_Principal.PerformLayout();
            this.tsp_Principal.ResumeLayout(false);
            this.tsp_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msp_Principal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vérticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssp_Principal;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Mensagem;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Data;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Hora;
        private System.Windows.Forms.Timer tmr_Principal;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vérticeCidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arestaDistânciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarPesoDaArestanãoImplementadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarGrafonãoImplementadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vérticeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arestaPesoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsp_Principal;
        private System.Windows.Forms.ToolStripButton tsb_Novo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_IV;
        private System.Windows.Forms.ToolStripButton tsb_IA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_EV;
        private System.Windows.Forms.ToolStripButton tsb_EA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsb_AV;
        private System.Windows.Forms.ToolStripButton tsb_AA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsb_EG;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsb_Ajuda;
        private System.Windows.Forms.ToolStripButton tsb_Sobre;
        private System.Windows.Forms.ToolStripButton tsb_RG;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsb_Sair;
        private System.Windows.Forms.ToolStripMenuItem heurísticaDaColoraçãoToolStripMenuItem;
    }
}