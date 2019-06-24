namespace Enviar_EMail
{
    partial class frm_TelaEnvio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TelaEnvio));
            this.pnl_TelaEnvio = new System.Windows.Forms.Panel();
            this.gbx_DePara = new System.Windows.Forms.GroupBox();
            this.gbx_Mensagem = new System.Windows.Forms.GroupBox();
            this.gbx_Anexos = new System.Windows.Forms.GroupBox();
            this.lbl_De = new System.Windows.Forms.Label();
            this.lbl_Para = new System.Windows.Forms.Label();
            this.lbl_Cc = new System.Windows.Forms.Label();
            this.lbl_Cco = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Assunto = new System.Windows.Forms.Label();
            this.gbx_Autenticação = new System.Windows.Forms.GroupBox();
            this.tbx_De = new System.Windows.Forms.TextBox();
            this.tbx_Para = new System.Windows.Forms.TextBox();
            this.tbx_Cc = new System.Windows.Forms.TextBox();
            this.tbx_Cco = new System.Windows.Forms.TextBox();
            this.tbx_Assunto = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_EmailDe = new System.Windows.Forms.Label();
            this.tbx_Mensagem = new System.Windows.Forms.TextBox();
            this.tbx_Anexos = new System.Windows.Forms.TextBox();
            this.tbx_Senha = new System.Windows.Forms.TextBox();
            this.btn_Anexar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.pgb_EnviandoEmail = new System.Windows.Forms.ProgressBar();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.pnl_TelaEnvio.SuspendLayout();
            this.gbx_DePara.SuspendLayout();
            this.gbx_Mensagem.SuspendLayout();
            this.gbx_Anexos.SuspendLayout();
            this.gbx_Autenticação.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TelaEnvio
            // 
            this.pnl_TelaEnvio.Controls.Add(this.lbl_Status);
            this.pnl_TelaEnvio.Controls.Add(this.pgb_EnviandoEmail);
            this.pnl_TelaEnvio.Controls.Add(this.btn_Sair);
            this.pnl_TelaEnvio.Controls.Add(this.btn_Enviar);
            this.pnl_TelaEnvio.Controls.Add(this.gbx_Autenticação);
            this.pnl_TelaEnvio.Controls.Add(this.gbx_Anexos);
            this.pnl_TelaEnvio.Controls.Add(this.gbx_Mensagem);
            this.pnl_TelaEnvio.Controls.Add(this.gbx_DePara);
            this.pnl_TelaEnvio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_TelaEnvio.Location = new System.Drawing.Point(0, 0);
            this.pnl_TelaEnvio.Name = "pnl_TelaEnvio";
            this.pnl_TelaEnvio.Size = new System.Drawing.Size(519, 523);
            this.pnl_TelaEnvio.TabIndex = 0;
            // 
            // gbx_DePara
            // 
            this.gbx_DePara.Controls.Add(this.tbx_Assunto);
            this.gbx_DePara.Controls.Add(this.tbx_Cco);
            this.gbx_DePara.Controls.Add(this.tbx_Cc);
            this.gbx_DePara.Controls.Add(this.tbx_Para);
            this.gbx_DePara.Controls.Add(this.tbx_De);
            this.gbx_DePara.Controls.Add(this.lbl_Assunto);
            this.gbx_DePara.Controls.Add(this.lbl_Cco);
            this.gbx_DePara.Controls.Add(this.lbl_Cc);
            this.gbx_DePara.Controls.Add(this.lbl_Para);
            this.gbx_DePara.Controls.Add(this.lbl_De);
            this.gbx_DePara.Location = new System.Drawing.Point(12, 12);
            this.gbx_DePara.Name = "gbx_DePara";
            this.gbx_DePara.Size = new System.Drawing.Size(496, 170);
            this.gbx_DePara.TabIndex = 0;
            this.gbx_DePara.TabStop = false;
            this.gbx_DePara.Text = "De: Para";
            // 
            // gbx_Mensagem
            // 
            this.gbx_Mensagem.Controls.Add(this.tbx_Mensagem);
            this.gbx_Mensagem.Location = new System.Drawing.Point(12, 188);
            this.gbx_Mensagem.Name = "gbx_Mensagem";
            this.gbx_Mensagem.Size = new System.Drawing.Size(495, 182);
            this.gbx_Mensagem.TabIndex = 0;
            this.gbx_Mensagem.TabStop = false;
            this.gbx_Mensagem.Text = "Mensagem";
            // 
            // gbx_Anexos
            // 
            this.gbx_Anexos.Controls.Add(this.btn_Anexar);
            this.gbx_Anexos.Controls.Add(this.tbx_Anexos);
            this.gbx_Anexos.Location = new System.Drawing.Point(12, 376);
            this.gbx_Anexos.Name = "gbx_Anexos";
            this.gbx_Anexos.Size = new System.Drawing.Size(496, 49);
            this.gbx_Anexos.TabIndex = 0;
            this.gbx_Anexos.TabStop = false;
            this.gbx_Anexos.Text = "Anexos";
            // 
            // lbl_De
            // 
            this.lbl_De.AutoSize = true;
            this.lbl_De.Location = new System.Drawing.Point(38, 25);
            this.lbl_De.Name = "lbl_De";
            this.lbl_De.Size = new System.Drawing.Size(24, 13);
            this.lbl_De.TabIndex = 0;
            this.lbl_De.Text = "De:";
            // 
            // lbl_Para
            // 
            this.lbl_Para.AutoSize = true;
            this.lbl_Para.Location = new System.Drawing.Point(30, 53);
            this.lbl_Para.Name = "lbl_Para";
            this.lbl_Para.Size = new System.Drawing.Size(32, 13);
            this.lbl_Para.TabIndex = 0;
            this.lbl_Para.Text = "Para:";
            // 
            // lbl_Cc
            // 
            this.lbl_Cc.AutoSize = true;
            this.lbl_Cc.Location = new System.Drawing.Point(39, 81);
            this.lbl_Cc.Name = "lbl_Cc";
            this.lbl_Cc.Size = new System.Drawing.Size(23, 13);
            this.lbl_Cc.TabIndex = 0;
            this.lbl_Cc.Text = "Cc:";
            // 
            // lbl_Cco
            // 
            this.lbl_Cco.AutoSize = true;
            this.lbl_Cco.Location = new System.Drawing.Point(33, 110);
            this.lbl_Cco.Name = "lbl_Cco";
            this.lbl_Cco.Size = new System.Drawing.Size(29, 13);
            this.lbl_Cco.TabIndex = 0;
            this.lbl_Cco.Text = "Cco:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(227, 16);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(41, 13);
            this.lbl_Senha.TabIndex = 0;
            this.lbl_Senha.Text = "Senha:";
            // 
            // lbl_Assunto
            // 
            this.lbl_Assunto.AutoSize = true;
            this.lbl_Assunto.Location = new System.Drawing.Point(15, 138);
            this.lbl_Assunto.Name = "lbl_Assunto";
            this.lbl_Assunto.Size = new System.Drawing.Size(48, 13);
            this.lbl_Assunto.TabIndex = 0;
            this.lbl_Assunto.Text = "Assunto:";
            // 
            // gbx_Autenticação
            // 
            this.gbx_Autenticação.Controls.Add(this.tbx_Senha);
            this.gbx_Autenticação.Controls.Add(this.lbl_EmailDe);
            this.gbx_Autenticação.Controls.Add(this.lbl_Email);
            this.gbx_Autenticação.Controls.Add(this.lbl_Senha);
            this.gbx_Autenticação.Location = new System.Drawing.Point(12, 433);
            this.gbx_Autenticação.Name = "gbx_Autenticação";
            this.gbx_Autenticação.Size = new System.Drawing.Size(496, 44);
            this.gbx_Autenticação.TabIndex = 0;
            this.gbx_Autenticação.TabStop = false;
            this.gbx_Autenticação.Text = "Autenticação de Envio";
            // 
            // tbx_De
            // 
            this.tbx_De.Location = new System.Drawing.Point(68, 22);
            this.tbx_De.Name = "tbx_De";
            this.tbx_De.Size = new System.Drawing.Size(411, 20);
            this.tbx_De.TabIndex = 1;
            this.tbx_De.TextChanged += new System.EventHandler(this.tbx_De_TextChanged);
            // 
            // tbx_Para
            // 
            this.tbx_Para.Location = new System.Drawing.Point(68, 50);
            this.tbx_Para.Name = "tbx_Para";
            this.tbx_Para.Size = new System.Drawing.Size(411, 20);
            this.tbx_Para.TabIndex = 2;
            // 
            // tbx_Cc
            // 
            this.tbx_Cc.Location = new System.Drawing.Point(68, 78);
            this.tbx_Cc.Name = "tbx_Cc";
            this.tbx_Cc.Size = new System.Drawing.Size(411, 20);
            this.tbx_Cc.TabIndex = 3;
            // 
            // tbx_Cco
            // 
            this.tbx_Cco.Location = new System.Drawing.Point(68, 107);
            this.tbx_Cco.Name = "tbx_Cco";
            this.tbx_Cco.Size = new System.Drawing.Size(411, 20);
            this.tbx_Cco.TabIndex = 4;
            // 
            // tbx_Assunto
            // 
            this.tbx_Assunto.Location = new System.Drawing.Point(68, 135);
            this.tbx_Assunto.Name = "tbx_Assunto";
            this.tbx_Assunto.Size = new System.Drawing.Size(411, 20);
            this.tbx_Assunto.TabIndex = 5;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(8, 16);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(35, 13);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_EmailDe
            // 
            this.lbl_EmailDe.AutoSize = true;
            this.lbl_EmailDe.Location = new System.Drawing.Point(43, 16);
            this.lbl_EmailDe.Name = "lbl_EmailDe";
            this.lbl_EmailDe.Size = new System.Drawing.Size(11, 13);
            this.lbl_EmailDe.TabIndex = 0;
            this.lbl_EmailDe.Text = "*";
            // 
            // tbx_Mensagem
            // 
            this.tbx_Mensagem.Location = new System.Drawing.Point(16, 19);
            this.tbx_Mensagem.Multiline = true;
            this.tbx_Mensagem.Name = "tbx_Mensagem";
            this.tbx_Mensagem.Size = new System.Drawing.Size(463, 150);
            this.tbx_Mensagem.TabIndex = 6;
            // 
            // tbx_Anexos
            // 
            this.tbx_Anexos.Location = new System.Drawing.Point(16, 17);
            this.tbx_Anexos.Multiline = true;
            this.tbx_Anexos.Name = "tbx_Anexos";
            this.tbx_Anexos.Size = new System.Drawing.Size(378, 20);
            this.tbx_Anexos.TabIndex = 7;
            // 
            // tbx_Senha
            // 
            this.tbx_Senha.Location = new System.Drawing.Point(270, 13);
            this.tbx_Senha.Name = "tbx_Senha";
            this.tbx_Senha.Size = new System.Drawing.Size(209, 20);
            this.tbx_Senha.TabIndex = 9;
            this.tbx_Senha.UseSystemPasswordChar = true;
            // 
            // btn_Anexar
            // 
            this.btn_Anexar.Location = new System.Drawing.Point(404, 15);
            this.btn_Anexar.Name = "btn_Anexar";
            this.btn_Anexar.Size = new System.Drawing.Size(75, 23);
            this.btn_Anexar.TabIndex = 8;
            this.btn_Anexar.Text = "Anexar";
            this.btn_Anexar.UseVisualStyleBackColor = true;
            this.btn_Anexar.Click += new System.EventHandler(this.btn_Anexar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(331, 489);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 10;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(416, 489);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_Enviar.TabIndex = 11;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // pgb_EnviandoEmail
            // 
            this.pgb_EnviandoEmail.Location = new System.Drawing.Point(12, 485);
            this.pgb_EnviandoEmail.Name = "pgb_EnviandoEmail";
            this.pgb_EnviandoEmail.Size = new System.Drawing.Size(280, 15);
            this.pgb_EnviandoEmail.TabIndex = 7;
            this.pgb_EnviandoEmail.Visible = false;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(9, 503);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 13);
            this.lbl_Status.TabIndex = 12;
            this.lbl_Status.Visible = false;
            // 
            // frm_TelaEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 523);
            this.Controls.Add(this.pnl_TelaEnvio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_TelaEnvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviando E-Mails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TelaEnvio_FormClosing);
            this.pnl_TelaEnvio.ResumeLayout(false);
            this.pnl_TelaEnvio.PerformLayout();
            this.gbx_DePara.ResumeLayout(false);
            this.gbx_DePara.PerformLayout();
            this.gbx_Mensagem.ResumeLayout(false);
            this.gbx_Mensagem.PerformLayout();
            this.gbx_Anexos.ResumeLayout(false);
            this.gbx_Anexos.PerformLayout();
            this.gbx_Autenticação.ResumeLayout(false);
            this.gbx_Autenticação.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TelaEnvio;
        private System.Windows.Forms.GroupBox gbx_Anexos;
        private System.Windows.Forms.GroupBox gbx_Mensagem;
        private System.Windows.Forms.GroupBox gbx_DePara;
        private System.Windows.Forms.GroupBox gbx_Autenticação;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox tbx_Assunto;
        private System.Windows.Forms.TextBox tbx_Cco;
        private System.Windows.Forms.TextBox tbx_Cc;
        private System.Windows.Forms.TextBox tbx_Para;
        private System.Windows.Forms.TextBox tbx_De;
        private System.Windows.Forms.Label lbl_Assunto;
        private System.Windows.Forms.Label lbl_Cco;
        private System.Windows.Forms.Label lbl_Cc;
        private System.Windows.Forms.Label lbl_Para;
        private System.Windows.Forms.Label lbl_De;
        private System.Windows.Forms.TextBox tbx_Senha;
        private System.Windows.Forms.Label lbl_EmailDe;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tbx_Anexos;
        private System.Windows.Forms.TextBox tbx_Mensagem;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Button btn_Anexar;
        private System.Windows.Forms.ProgressBar pgb_EnviandoEmail;
        private System.Windows.Forms.Label lbl_Status;
    }
}

