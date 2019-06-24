namespace Mudança_de_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.pnl_Principal = new System.Windows.Forms.Panel();
            this.gpb_Up = new System.Windows.Forms.GroupBox();
            this.gpb_Down = new System.Windows.Forms.GroupBox();
            this.cmb_De = new System.Windows.Forms.ComboBox();
            this.cmb_Para = new System.Windows.Forms.ComboBox();
            this.lbl_De = new System.Windows.Forms.Label();
            this.lbl_Para = new System.Windows.Forms.Label();
            this.tbx_BaseOriginal = new System.Windows.Forms.TextBox();
            this.lbl_BaseOriginal = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.tbx_Resultado = new System.Windows.Forms.TextBox();
            this.btn_Converter = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.pnl_Principal.SuspendLayout();
            this.gpb_Up.SuspendLayout();
            this.gpb_Down.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.Controls.Add(this.btn_Limpar);
            this.pnl_Principal.Controls.Add(this.btn_Sair);
            this.pnl_Principal.Controls.Add(this.gpb_Down);
            this.pnl_Principal.Controls.Add(this.gpb_Up);
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(338, 256);
            this.pnl_Principal.TabIndex = 0;
            // 
            // gpb_Up
            // 
            this.gpb_Up.Controls.Add(this.btn_Converter);
            this.gpb_Up.Controls.Add(this.lbl_BaseOriginal);
            this.gpb_Up.Controls.Add(this.tbx_BaseOriginal);
            this.gpb_Up.Controls.Add(this.lbl_Para);
            this.gpb_Up.Controls.Add(this.lbl_De);
            this.gpb_Up.Controls.Add(this.cmb_Para);
            this.gpb_Up.Controls.Add(this.cmb_De);
            this.gpb_Up.Location = new System.Drawing.Point(5, 5);
            this.gpb_Up.Name = "gpb_Up";
            this.gpb_Up.Size = new System.Drawing.Size(327, 134);
            this.gpb_Up.TabIndex = 0;
            this.gpb_Up.TabStop = false;
            this.gpb_Up.Text = "Mudança de Base";
            // 
            // gpb_Down
            // 
            this.gpb_Down.Controls.Add(this.lbl_Resultado);
            this.gpb_Down.Controls.Add(this.tbx_Resultado);
            this.gpb_Down.Location = new System.Drawing.Point(5, 141);
            this.gpb_Down.Name = "gpb_Down";
            this.gpb_Down.Size = new System.Drawing.Size(327, 76);
            this.gpb_Down.TabIndex = 1;
            this.gpb_Down.TabStop = false;
            this.gpb_Down.Text = "Resultado";
            // 
            // cmb_De
            // 
            this.cmb_De.FormattingEnabled = true;
            this.cmb_De.Items.AddRange(new object[] {
            "Binário",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.cmb_De.Location = new System.Drawing.Point(16, 47);
            this.cmb_De.Name = "cmb_De";
            this.cmb_De.Size = new System.Drawing.Size(121, 21);
            this.cmb_De.TabIndex = 0;
            this.cmb_De.SelectedIndexChanged += new System.EventHandler(this.cmb_De_SelectedIndexChanged);
            // 
            // cmb_Para
            // 
            this.cmb_Para.FormattingEnabled = true;
            this.cmb_Para.Items.AddRange(new object[] {
            "Binário",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.cmb_Para.Location = new System.Drawing.Point(187, 47);
            this.cmb_Para.Name = "cmb_Para";
            this.cmb_Para.Size = new System.Drawing.Size(121, 21);
            this.cmb_Para.TabIndex = 1;
            this.cmb_Para.SelectedIndexChanged += new System.EventHandler(this.cmb_Para_SelectedIndexChanged);
            // 
            // lbl_De
            // 
            this.lbl_De.AutoSize = true;
            this.lbl_De.Location = new System.Drawing.Point(13, 28);
            this.lbl_De.Name = "lbl_De";
            this.lbl_De.Size = new System.Drawing.Size(24, 13);
            this.lbl_De.TabIndex = 2;
            this.lbl_De.Text = "De:";
            // 
            // lbl_Para
            // 
            this.lbl_Para.AutoSize = true;
            this.lbl_Para.Location = new System.Drawing.Point(184, 28);
            this.lbl_Para.Name = "lbl_Para";
            this.lbl_Para.Size = new System.Drawing.Size(32, 13);
            this.lbl_Para.TabIndex = 3;
            this.lbl_Para.Text = "Para:";
            // 
            // tbx_BaseOriginal
            // 
            this.tbx_BaseOriginal.Enabled = false;
            this.tbx_BaseOriginal.Location = new System.Drawing.Point(16, 98);
            this.tbx_BaseOriginal.Name = "tbx_BaseOriginal";
            this.tbx_BaseOriginal.Size = new System.Drawing.Size(121, 20);
            this.tbx_BaseOriginal.TabIndex = 4;
            // 
            // lbl_BaseOriginal
            // 
            this.lbl_BaseOriginal.AutoSize = true;
            this.lbl_BaseOriginal.Location = new System.Drawing.Point(13, 82);
            this.lbl_BaseOriginal.Name = "lbl_BaseOriginal";
            this.lbl_BaseOriginal.Size = new System.Drawing.Size(72, 13);
            this.lbl_BaseOriginal.TabIndex = 5;
            this.lbl_BaseOriginal.Text = "Base Original:";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(13, 26);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(58, 13);
            this.lbl_Resultado.TabIndex = 7;
            this.lbl_Resultado.Text = "Resultado:";
            // 
            // tbx_Resultado
            // 
            this.tbx_Resultado.Enabled = false;
            this.tbx_Resultado.Location = new System.Drawing.Point(16, 42);
            this.tbx_Resultado.Name = "tbx_Resultado";
            this.tbx_Resultado.Size = new System.Drawing.Size(176, 20);
            this.tbx_Resultado.TabIndex = 6;
            // 
            // btn_Converter
            // 
            this.btn_Converter.Location = new System.Drawing.Point(216, 95);
            this.btn_Converter.Name = "btn_Converter";
            this.btn_Converter.Size = new System.Drawing.Size(92, 23);
            this.btn_Converter.TabIndex = 6;
            this.btn_Converter.Text = "Converter Base";
            this.btn_Converter.UseVisualStyleBackColor = true;
            this.btn_Converter.Click += new System.EventHandler(this.btn_Converter_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(176, 223);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 7;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(257, 223);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 256);
            this.Controls.Add(this.pnl_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mudança de base";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Principal_FormClosing);
            this.pnl_Principal.ResumeLayout(false);
            this.gpb_Up.ResumeLayout(false);
            this.gpb_Up.PerformLayout();
            this.gpb_Down.ResumeLayout(false);
            this.gpb_Down.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Principal;
        private System.Windows.Forms.GroupBox gpb_Down;
        private System.Windows.Forms.GroupBox gpb_Up;
        private System.Windows.Forms.Label lbl_BaseOriginal;
        private System.Windows.Forms.TextBox tbx_BaseOriginal;
        private System.Windows.Forms.Label lbl_Para;
        private System.Windows.Forms.Label lbl_De;
        private System.Windows.Forms.ComboBox cmb_Para;
        private System.Windows.Forms.ComboBox cmb_De;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox tbx_Resultado;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Converter;
    }
}

