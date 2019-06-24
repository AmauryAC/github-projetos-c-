namespace Cadastro_de_Usuário
{
    partial class frmCadUsuario
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvCadUsuarios = new System.Windows.Forms.DataGridView();
            this.dB_UserDataSet = new Cadastro_de_Usuário.DB_UserDataSet();
            this.cadastroDeUsuáriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastro_de_UsuáriosTableAdapter = new Cadastro_de_Usuário.DB_UserDataSetTableAdapters.Cadastro_de_UsuáriosTableAdapter();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.códigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UserDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDeUsuáriosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDelete,
            this.tsbClear,
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvCadUsuarios
            // 
            this.dgvCadUsuarios.AutoGenerateColumns = false;
            this.dgvCadUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.bloqueadoDataGridViewCheckBoxColumn});
            this.dgvCadUsuarios.DataSource = this.cadastroDeUsuáriosBindingSource;
            this.dgvCadUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCadUsuarios.Location = new System.Drawing.Point(0, 25);
            this.dgvCadUsuarios.Name = "dgvCadUsuarios";
            this.dgvCadUsuarios.Size = new System.Drawing.Size(745, 332);
            this.dgvCadUsuarios.TabIndex = 1;
            this.dgvCadUsuarios.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvCadUsuarios_UserDeletingRow);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::Cadastro_de_Usuário.Properties.Resources.plus;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::Cadastro_de_Usuário.Properties.Resources.button_cancel;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbClear
            // 
            this.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClear.Image = global::Cadastro_de_Usuário.Properties.Resources.edit_clear;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(23, 22);
            this.tsbClear.Text = "Clear";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::Cadastro_de_Usuário.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = global::Cadastro_de_Usuário.Properties.Resources.application_exit;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Text = "Exit";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // códigoDataGridViewTextBoxColumn
            // 
            this.códigoDataGridViewTextBoxColumn.DataPropertyName = "Código";
            this.códigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.códigoDataGridViewTextBoxColumn.Name = "códigoDataGridViewTextBoxColumn";
            this.códigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 150;
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
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // bloqueadoDataGridViewCheckBoxColumn
            // 
            this.bloqueadoDataGridViewCheckBoxColumn.DataPropertyName = "Bloqueado";
            this.bloqueadoDataGridViewCheckBoxColumn.HeaderText = "Bloqueado";
            this.bloqueadoDataGridViewCheckBoxColumn.Name = "bloqueadoDataGridViewCheckBoxColumn";
            this.bloqueadoDataGridViewCheckBoxColumn.Width = 75;
            // 
            // frmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 357);
            this.Controls.Add(this.dgvCadUsuarios);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmCadUsuario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UserDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDeUsuáriosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.DataGridView dgvCadUsuarios;
        private DB_UserDataSet dB_UserDataSet;
        private System.Windows.Forms.BindingSource cadastroDeUsuáriosBindingSource;
        private DB_UserDataSetTableAdapters.Cadastro_de_UsuáriosTableAdapter cadastro_de_UsuáriosTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bloqueadoDataGridViewCheckBoxColumn;
    }
}

