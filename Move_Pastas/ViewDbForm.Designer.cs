
namespace Move_Pastas
{
    partial class ViewDbForm
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
            this.grvBanco = new System.Windows.Forms.DataGridView();
            this.btnCadastrarNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // grvBanco
            // 
            this.grvBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvBanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBanco.Location = new System.Drawing.Point(12, 12);
            this.grvBanco.Name = "grvBanco";
            this.grvBanco.Size = new System.Drawing.Size(487, 300);
            this.grvBanco.TabIndex = 0;
            // 
            // btnCadastrarNovo
            // 
            this.btnCadastrarNovo.Location = new System.Drawing.Point(12, 318);
            this.btnCadastrarNovo.Name = "btnCadastrarNovo";
            this.btnCadastrarNovo.Size = new System.Drawing.Size(149, 46);
            this.btnCadastrarNovo.TabIndex = 1;
            this.btnCadastrarNovo.Text = "Novo Banco";
            this.btnCadastrarNovo.UseVisualStyleBackColor = true;
            this.btnCadastrarNovo.Click += new System.EventHandler(this.btnCadastrarNovo_Click);
            // 
            // ViewDbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(511, 376);
            this.Controls.Add(this.btnCadastrarNovo);
            this.Controls.Add(this.grvBanco);
            this.Name = "ViewDbForm";
            this.Text = "Banco de Dados Cadastrados";
            ((System.ComponentModel.ISupportInitialize)(this.grvBanco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvBanco;
        private System.Windows.Forms.Button btnCadastrarNovo;
    }
}