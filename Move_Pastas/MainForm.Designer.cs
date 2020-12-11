
namespace Move_Pastas
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnSelecionaOrigem = new System.Windows.Forms.Button();
            this.btnSelecionaDestino = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a pasta origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione a pasta destino";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(15, 25);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(445, 20);
            this.txtOrigem.TabIndex = 2;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(15, 77);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(445, 20);
            this.txtDestino.TabIndex = 3;
            // 
            // btnSelecionaOrigem
            // 
            this.btnSelecionaOrigem.Location = new System.Drawing.Point(466, 25);
            this.btnSelecionaOrigem.Name = "btnSelecionaOrigem";
            this.btnSelecionaOrigem.Size = new System.Drawing.Size(43, 20);
            this.btnSelecionaOrigem.TabIndex = 4;
            this.btnSelecionaOrigem.Text = "...";
            this.btnSelecionaOrigem.UseVisualStyleBackColor = true;
            this.btnSelecionaOrigem.Click += new System.EventHandler(this.btnSelecionaOrigem_Click);
            // 
            // btnSelecionaDestino
            // 
            this.btnSelecionaDestino.Location = new System.Drawing.Point(466, 76);
            this.btnSelecionaDestino.Name = "btnSelecionaDestino";
            this.btnSelecionaDestino.Size = new System.Drawing.Size(43, 21);
            this.btnSelecionaDestino.TabIndex = 5;
            this.btnSelecionaDestino.Text = "...";
            this.btnSelecionaDestino.UseVisualStyleBackColor = true;
            this.btnSelecionaDestino.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(12, 151);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(235, 57);
            this.btnExecutar.TabIndex = 6;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(274, 151);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(235, 57);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 220);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnSelecionaDestino);
            this.Controls.Add(this.btnSelecionaOrigem);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Movedor de pastas PRO 2077";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnSelecionaOrigem;
        private System.Windows.Forms.Button btnSelecionaDestino;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnSair;
    }
}

