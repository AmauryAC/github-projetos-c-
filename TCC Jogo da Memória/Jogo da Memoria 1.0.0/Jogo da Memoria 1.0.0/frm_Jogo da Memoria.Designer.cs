namespace Jogo_da_Memoria_1._0._0
{
    partial class frm_Jogo_da_Memoria
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Jogadas = new System.Windows.Forms.Label();
            this.lbl_Tempo = new System.Windows.Forms.Label();
            this.pbx_Fundo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(93, 132);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(149, 142);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 119);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jogo da Memória";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_Jogadas
            // 
            this.lbl_Jogadas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Jogadas.AutoSize = true;
            this.lbl_Jogadas.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jogadas.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Jogadas.Location = new System.Drawing.Point(760, 357);
            this.lbl_Jogadas.Name = "lbl_Jogadas";
            this.lbl_Jogadas.Size = new System.Drawing.Size(42, 46);
            this.lbl_Jogadas.TabIndex = 18;
            this.lbl_Jogadas.Text = "0";
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Tempo.AutoSize = true;
            this.lbl_Tempo.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tempo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Tempo.Location = new System.Drawing.Point(760, 225);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(42, 46);
            this.lbl_Tempo.TabIndex = 19;
            this.lbl_Tempo.Text = "0";
            // 
            // pbx_Fundo
            // 
            this.pbx_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_Fundo.Image = global::Jogo_da_Memoria_1._0._0.Properties.Resources.fundo_tela;
            this.pbx_Fundo.Location = new System.Drawing.Point(0, 0);
            this.pbx_Fundo.Name = "pbx_Fundo";
            this.pbx_Fundo.Size = new System.Drawing.Size(984, 711);
            this.pbx_Fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Fundo.TabIndex = 5;
            this.pbx_Fundo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(760, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 46);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tempo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(760, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 46);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jogadas:";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sair.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(854, 631);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(118, 65);
            this.btn_Sair.TabIndex = 22;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Voltar.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Location = new System.Drawing.Point(854, 560);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(118, 65);
            this.btn_Voltar.TabIndex = 23;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // frm_Jogo_da_Memoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Tempo);
            this.Controls.Add(this.lbl_Jogadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbx_Fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Jogo_da_Memoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Jogo_da_Memoria_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Fundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_Jogadas;
        private System.Windows.Forms.Label lbl_Tempo;
        private System.Windows.Forms.PictureBox pbx_Fundo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Voltar;
    }
}