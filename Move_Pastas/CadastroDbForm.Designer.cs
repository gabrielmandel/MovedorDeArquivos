
namespace Move_Pastas
{
    partial class CadastroDbForm
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
            this.lblNomeSite = new System.Windows.Forms.Label();
            this.txtNomeSite = new System.Windows.Forms.TextBox();
            this.txtNomeDb = new System.Windows.Forms.TextBox();
            this.lblNomeDb = new System.Windows.Forms.Label();
            this.txtNomeServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrarDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeSite
            // 
            this.lblNomeSite.AutoSize = true;
            this.lblNomeSite.Location = new System.Drawing.Point(12, 9);
            this.lblNomeSite.Name = "lblNomeSite";
            this.lblNomeSite.Size = new System.Drawing.Size(71, 13);
            this.lblNomeSite.TabIndex = 0;
            this.lblNomeSite.Text = "Nome do Site";
            // 
            // txtNomeSite
            // 
            this.txtNomeSite.Location = new System.Drawing.Point(15, 25);
            this.txtNomeSite.Name = "txtNomeSite";
            this.txtNomeSite.Size = new System.Drawing.Size(213, 20);
            this.txtNomeSite.TabIndex = 1;
            // 
            // txtNomeDb
            // 
            this.txtNomeDb.Location = new System.Drawing.Point(15, 78);
            this.txtNomeDb.Name = "txtNomeDb";
            this.txtNomeDb.Size = new System.Drawing.Size(213, 20);
            this.txtNomeDb.TabIndex = 3;
            // 
            // lblNomeDb
            // 
            this.lblNomeDb.AutoSize = true;
            this.lblNomeDb.Location = new System.Drawing.Point(12, 62);
            this.lblNomeDb.Name = "lblNomeDb";
            this.lblNomeDb.Size = new System.Drawing.Size(133, 13);
            this.lblNomeDb.TabIndex = 2;
            this.lblNomeDb.Text = "Nome do Banco de Dados";
            // 
            // txtNomeServidor
            // 
            this.txtNomeServidor.Location = new System.Drawing.Point(15, 129);
            this.txtNomeServidor.Name = "txtNomeServidor";
            this.txtNomeServidor.Size = new System.Drawing.Size(213, 20);
            this.txtNomeServidor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Servidor";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(15, 177);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(213, 20);
            this.txtLogin.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(15, 227);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(213, 20);
            this.txtSenha.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastrarDb
            // 
            this.btnCadastrarDb.Location = new System.Drawing.Point(16, 262);
            this.btnCadastrarDb.Name = "btnCadastrarDb";
            this.btnCadastrarDb.Size = new System.Drawing.Size(212, 43);
            this.btnCadastrarDb.TabIndex = 10;
            this.btnCadastrarDb.Text = "Cadastrar";
            this.btnCadastrarDb.UseVisualStyleBackColor = true;
            this.btnCadastrarDb.Click += new System.EventHandler(this.btnCadastrarDb_Click);
            // 
            // CadastroDbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(478, 345);
            this.Controls.Add(this.btnCadastrarDb);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeServidor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeDb);
            this.Controls.Add(this.lblNomeDb);
            this.Controls.Add(this.txtNomeSite);
            this.Controls.Add(this.lblNomeSite);
            this.Name = "CadastroDbForm";
            this.Text = "Cadastro Banco de Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeSite;
        private System.Windows.Forms.TextBox txtNomeSite;
        private System.Windows.Forms.TextBox txtNomeDb;
        private System.Windows.Forms.Label lblNomeDb;
        private System.Windows.Forms.TextBox txtNomeServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrarDb;
    }
}