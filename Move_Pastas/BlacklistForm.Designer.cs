
namespace Move_Pastas
{
    partial class frmFolderBlacklist
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
            this.addFolderBlacklist = new System.Windows.Forms.Button();
            this.txtBlacklist = new System.Windows.Forms.TextBox();
            this.lblNomeExcluido = new System.Windows.Forms.Label();
            this.grvListaExcluidos = new System.Windows.Forms.DataGridView();
            this.rbPasta = new System.Windows.Forms.RadioButton();
            this.rbArquivo = new System.Windows.Forms.RadioButton();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvListaExcluidos)).BeginInit();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // addFolderBlacklist
            // 
            this.addFolderBlacklist.Location = new System.Drawing.Point(432, 155);
            this.addFolderBlacklist.Name = "addFolderBlacklist";
            this.addFolderBlacklist.Size = new System.Drawing.Size(135, 48);
            this.addFolderBlacklist.TabIndex = 1;
            this.addFolderBlacklist.Text = "Adicionar";
            this.addFolderBlacklist.UseVisualStyleBackColor = true;
            this.addFolderBlacklist.Click += new System.EventHandler(this.addFolderBlacklist_Click);
            // 
            // txtBlacklist
            // 
            this.txtBlacklist.Location = new System.Drawing.Point(15, 171);
            this.txtBlacklist.Name = "txtBlacklist";
            this.txtBlacklist.Size = new System.Drawing.Size(128, 20);
            this.txtBlacklist.TabIndex = 3;
            // 
            // lblNomeExcluido
            // 
            this.lblNomeExcluido.AutoSize = true;
            this.lblNomeExcluido.Location = new System.Drawing.Point(12, 155);
            this.lblNomeExcluido.Name = "lblNomeExcluido";
            this.lblNomeExcluido.Size = new System.Drawing.Size(38, 13);
            this.lblNomeExcluido.TabIndex = 4;
            this.lblNomeExcluido.Text = "Nome ";
            // 
            // grvListaExcluidos
            // 
            this.grvListaExcluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvListaExcluidos.Location = new System.Drawing.Point(15, 9);
            this.grvListaExcluidos.Name = "grvListaExcluidos";
            this.grvListaExcluidos.Size = new System.Drawing.Size(552, 131);
            this.grvListaExcluidos.TabIndex = 5;
            // 
            // rbPasta
            // 
            this.rbPasta.AutoSize = true;
            this.rbPasta.Location = new System.Drawing.Point(12, 20);
            this.rbPasta.Name = "rbPasta";
            this.rbPasta.Size = new System.Drawing.Size(52, 17);
            this.rbPasta.TabIndex = 6;
            this.rbPasta.TabStop = true;
            this.rbPasta.Text = "Pasta";
            this.rbPasta.UseVisualStyleBackColor = true;
            // 
            // rbArquivo
            // 
            this.rbArquivo.AutoSize = true;
            this.rbArquivo.Location = new System.Drawing.Point(103, 20);
            this.rbArquivo.Name = "rbArquivo";
            this.rbArquivo.Size = new System.Drawing.Size(61, 17);
            this.rbArquivo.TabIndex = 7;
            this.rbArquivo.TabStop = true;
            this.rbArquivo.Text = "Arquivo";
            this.rbArquivo.UseVisualStyleBackColor = true;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbPasta);
            this.gbTipo.Controls.Add(this.rbArquivo);
            this.gbTipo.Location = new System.Drawing.Point(156, 155);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(178, 48);
            this.gbTipo.TabIndex = 8;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // frmFolderBlacklist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(579, 215);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.grvListaExcluidos);
            this.Controls.Add(this.lblNomeExcluido);
            this.Controls.Add(this.txtBlacklist);
            this.Controls.Add(this.addFolderBlacklist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFolderBlacklist";
            this.Text = "Lista Negra Pastas";
            ((System.ComponentModel.ISupportInitialize)(this.grvListaExcluidos)).EndInit();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addFolderBlacklist;
        private System.Windows.Forms.TextBox txtBlacklist;
        private System.Windows.Forms.Label lblNomeExcluido;
        private System.Windows.Forms.DataGridView grvListaExcluidos;
        private System.Windows.Forms.RadioButton rbPasta;
        private System.Windows.Forms.RadioButton rbArquivo;
        private System.Windows.Forms.GroupBox gbTipo;
    }
}