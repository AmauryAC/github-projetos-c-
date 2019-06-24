namespace Teste
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_UserDataSet = new Teste.DB_UserDataSet();
            this.cadastroDeUsuáriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastro_de_UsuáriosTableAdapter = new Teste.DB_UserDataSetTableAdapters.Cadastro_de_UsuáriosTableAdapter();
            this.códigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UserDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDeUsuáriosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 318);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.bloqueadoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.cadastroDeUsuáriosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // dB_UserDataSet
            // 
            this.dB_UserDataSet.DataSetName = "DB_UserDataSet";
            this.dB_UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroDeUsuáriosBindingSource
            // 
            this.cadastroDeUsuáriosBindingSource.DataMember = "Cadastro de Usuários";
            this.cadastroDeUsuáriosBindingSource.DataSource = this.dB_UserDataSet;
            // 
            // cadastro_de_UsuáriosTableAdapter
            // 
            this.cadastro_de_UsuáriosTableAdapter.ClearBeforeFill = true;
            // 
            // códigoDataGridViewTextBoxColumn
            // 
            this.códigoDataGridViewTextBoxColumn.DataPropertyName = "Código";
            this.códigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.códigoDataGridViewTextBoxColumn.Name = "códigoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // bloqueadoDataGridViewCheckBoxColumn
            // 
            this.bloqueadoDataGridViewCheckBoxColumn.DataPropertyName = "Bloqueado";
            this.bloqueadoDataGridViewCheckBoxColumn.HeaderText = "Bloqueado";
            this.bloqueadoDataGridViewCheckBoxColumn.Name = "bloqueadoDataGridViewCheckBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CliquedoBotão);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 318);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UserDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDeUsuáriosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_UserDataSet dB_UserDataSet;
        private System.Windows.Forms.BindingSource cadastroDeUsuáriosBindingSource;
        private DB_UserDataSetTableAdapters.Cadastro_de_UsuáriosTableAdapter cadastro_de_UsuáriosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bloqueadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

