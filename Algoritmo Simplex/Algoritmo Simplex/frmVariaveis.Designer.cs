namespace Algoritmo_Simplex
{
    partial class frmVariaveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVariaveis));
            this.numQtdRT = new System.Windows.Forms.NumericUpDown();
            this.numQtdVD = new System.Windows.Forms.NumericUpDown();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblQtdRT = new System.Windows.Forms.Label();
            this.lblQtdVD = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdVD)).BeginInit();
            this.SuspendLayout();
            // 
            // numQtdRT
            // 
            this.numQtdRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQtdRT.Location = new System.Drawing.Point(225, 98);
            this.numQtdRT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdRT.Name = "numQtdRT";
            this.numQtdRT.Size = new System.Drawing.Size(100, 26);
            this.numQtdRT.TabIndex = 13;
            this.numQtdRT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numQtdVD
            // 
            this.numQtdVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQtdVD.Location = new System.Drawing.Point(225, 59);
            this.numQtdVD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdVD.Name = "numQtdVD";
            this.numQtdVD.Size = new System.Drawing.Size(100, 26);
            this.numQtdVD.TabIndex = 12;
            this.numQtdVD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(250, 138);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 30);
            this.btnIniciar.TabIndex = 11;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblQtdRT
            // 
            this.lblQtdRT.AutoSize = true;
            this.lblQtdRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdRT.Location = new System.Drawing.Point(15, 100);
            this.lblQtdRT.Name = "lblQtdRT";
            this.lblQtdRT.Size = new System.Drawing.Size(199, 20);
            this.lblQtdRT.TabIndex = 10;
            this.lblQtdRT.Text = "Nº de Restrições Técnicas:";
            // 
            // lblQtdVD
            // 
            this.lblQtdVD.AutoSize = true;
            this.lblQtdVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdVD.Location = new System.Drawing.Point(15, 61);
            this.lblQtdVD.Name = "lblQtdVD";
            this.lblQtdVD.Size = new System.Drawing.Size(204, 20);
            this.lblQtdVD.TabIndex = 9;
            this.lblQtdVD.Text = "Nº de Variáveis de Decisão:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(15, 24);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(299, 20);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Introduza a magnitude do problema:";
            // 
            // frmVariaveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 191);
            this.Controls.Add(this.numQtdRT);
            this.Controls.Add(this.numQtdVD);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblQtdRT);
            this.Controls.Add(this.lblQtdVD);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVariaveis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmo Simplex";
            ((System.ComponentModel.ISupportInitialize)(this.numQtdRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdVD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numQtdRT;
        private System.Windows.Forms.NumericUpDown numQtdVD;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblQtdRT;
        private System.Windows.Forms.Label lblQtdVD;
        private System.Windows.Forms.Label lblInfo;
    }
}