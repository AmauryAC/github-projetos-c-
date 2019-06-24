namespace PRJ_Jogo_da_Memória
{
    partial class frm_JogoMemoria
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_VTentativas = new System.Windows.Forms.Label();
            this.lbl_Tentativas = new System.Windows.Forms.Label();
            this.lbl_VTempo = new System.Windows.Forms.Label();
            this.lbl_Tempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(149, 142);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // lbl_VTentativas
            // 
            this.lbl_VTentativas.AutoSize = true;
            this.lbl_VTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VTentativas.Location = new System.Drawing.Point(211, 129);
            this.lbl_VTentativas.Name = "lbl_VTentativas";
            this.lbl_VTentativas.Size = new System.Drawing.Size(18, 20);
            this.lbl_VTentativas.TabIndex = 23;
            this.lbl_VTentativas.Text = "0";
            // 
            // lbl_Tentativas
            // 
            this.lbl_Tentativas.AutoSize = true;
            this.lbl_Tentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tentativas.Location = new System.Drawing.Point(211, 96);
            this.lbl_Tentativas.Name = "lbl_Tentativas";
            this.lbl_Tentativas.Size = new System.Drawing.Size(86, 20);
            this.lbl_Tentativas.TabIndex = 22;
            this.lbl_Tentativas.Text = "Tentativas:";
            // 
            // lbl_VTempo
            // 
            this.lbl_VTempo.AutoSize = true;
            this.lbl_VTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VTempo.Location = new System.Drawing.Point(211, 41);
            this.lbl_VTempo.Name = "lbl_VTempo";
            this.lbl_VTempo.Size = new System.Drawing.Size(18, 20);
            this.lbl_VTempo.TabIndex = 21;
            this.lbl_VTempo.Text = "0";
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.AutoSize = true;
            this.lbl_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tempo.Location = new System.Drawing.Point(211, 12);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(109, 20);
            this.lbl_Tempo.TabIndex = 20;
            this.lbl_Tempo.Text = "Tempo (Seg.):";
            // 
            // frm_JogoMemoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 213);
            this.Controls.Add(this.lbl_VTentativas);
            this.Controls.Add(this.lbl_Tentativas);
            this.Controls.Add(this.lbl_VTempo);
            this.Controls.Add(this.lbl_Tempo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_JogoMemoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_VTentativas;
        private System.Windows.Forms.Label lbl_Tentativas;
        private System.Windows.Forms.Label lbl_VTempo;
        private System.Windows.Forms.Label lbl_Tempo;
    }
}