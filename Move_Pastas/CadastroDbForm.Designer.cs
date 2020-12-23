
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSite = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAcessoExt = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeSite
            // 
            this.lblNomeSite.AutoSize = true;
            this.lblNomeSite.Location = new System.Drawing.Point(18, 122);
            this.lblNomeSite.Name = "lblNomeSite";
            this.lblNomeSite.Size = new System.Drawing.Size(71, 13);
            this.lblNomeSite.TabIndex = 0;
            this.lblNomeSite.Text = "Nome do Site";
            // 
            // txtNomeSite
            // 
            this.txtNomeSite.Location = new System.Drawing.Point(21, 138);
            this.txtNomeSite.Name = "txtNomeSite";
            this.txtNomeSite.Size = new System.Drawing.Size(213, 20);
            this.txtNomeSite.TabIndex = 1;
            // 
            // txtNomeDb
            // 
            this.txtNomeDb.Location = new System.Drawing.Point(234, 32);
            this.txtNomeDb.Name = "txtNomeDb";
            this.txtNomeDb.Size = new System.Drawing.Size(213, 20);
            this.txtNomeDb.TabIndex = 3;
            // 
            // lblNomeDb
            // 
            this.lblNomeDb.AutoSize = true;
            this.lblNomeDb.Location = new System.Drawing.Point(231, 16);
            this.lblNomeDb.Name = "lblNomeDb";
            this.lblNomeDb.Size = new System.Drawing.Size(46, 13);
            this.lblNomeDb.TabIndex = 2;
            this.lblNomeDb.Text = "Schema";
            // 
            // txtNomeServidor
            // 
            this.txtNomeServidor.Location = new System.Drawing.Point(9, 32);
            this.txtNomeServidor.Name = "txtNomeServidor";
            this.txtNomeServidor.Size = new System.Drawing.Size(213, 20);
            this.txtNomeServidor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(9, 92);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(213, 20);
            this.txtLogin.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(234, 92);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(213, 20);
            this.txtSenha.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastrarDb
            // 
            this.btnCadastrarDb.Location = new System.Drawing.Point(12, 302);
            this.btnCadastrarDb.Name = "btnCadastrarDb";
            this.btnCadastrarDb.Size = new System.Drawing.Size(212, 43);
            this.btnCadastrarDb.TabIndex = 10;
            this.btnCadastrarDb.Text = "Novo Cadastro";
            this.btnCadastrarDb.UseVisualStyleBackColor = true;
            this.btnCadastrarDb.Click += new System.EventHandler(this.btnCadastrarDb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNomeDb);
            this.groupBox1.Controls.Add(this.txtNomeDb);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomeServidor);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 125);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banco de Dados";
            // 
            // cboSite
            // 
            this.cboSite.FormattingEnabled = true;
            this.cboSite.Location = new System.Drawing.Point(21, 33);
            this.cboSite.Name = "cboSite";
            this.cboSite.Size = new System.Drawing.Size(213, 21);
            this.cboSite.TabIndex = 12;
            this.cboSite.SelectedIndexChanged += new System.EventHandler(this.cboSite_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(21, 89);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sites Cadastrados";
            // 
            // chkAcessoExt
            // 
            this.chkAcessoExt.AutoSize = true;
            this.chkAcessoExt.Location = new System.Drawing.Point(264, 138);
            this.chkAcessoExt.Name = "chkAcessoExt";
            this.chkAcessoExt.Size = new System.Drawing.Size(100, 17);
            this.chkAcessoExt.TabIndex = 16;
            this.chkAcessoExt.Text = "Acesso Externo";
            this.chkAcessoExt.UseVisualStyleBackColor = true;
            // 
            // CadastroDbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(511, 376);
            this.Controls.Add(this.chkAcessoExt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cboSite);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrarDb);
            this.Controls.Add(this.txtNomeSite);
            this.Controls.Add(this.lblNomeSite);
            this.Name = "CadastroDbForm";
            this.Text = "Cadastro Banco de Dados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSite;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAcessoExt;
    }
}