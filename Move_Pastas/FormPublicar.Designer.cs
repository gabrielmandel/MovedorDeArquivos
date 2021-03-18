
using System.Collections.Generic;

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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboBancos = new System.Windows.Forms.ComboBox();
            this.btnSelecionaDestino = new System.Windows.Forms.Button();
            this.btnSelecionaOrigem = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConteudo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(269, 642);
            this.panelMenu.TabIndex = 10;
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(146)))), ((int)(((byte)(157)))));
            this.panelConteudo.Controls.Add(this.iconButton1);
            this.panelConteudo.Controls.Add(this.groupBox1);
            this.panelConteudo.Controls.Add(this.btnSelecionaDestino);
            this.panelConteudo.Controls.Add(this.btnSelecionaOrigem);
            this.panelConteudo.Controls.Add(this.txtDestino);
            this.panelConteudo.Controls.Add(this.txtOrigem);
            this.panelConteudo.Controls.Add(this.label2);
            this.panelConteudo.Controls.Add(this.label1);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(269, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(999, 642);
            this.panelConteudo.TabIndex = 11;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(35, 207);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(226, 44);
            this.iconButton1.TabIndex = 17;
            this.iconButton1.Text = "Executar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboBancos);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(35, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 57);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atualização de Banco";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(371, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Publicar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboBancos
            // 
            this.cboBancos.BackColor = System.Drawing.SystemColors.Control;
            this.cboBancos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboBancos.FormattingEnabled = true;
            this.cboBancos.Location = new System.Drawing.Point(6, 19);
            this.cboBancos.Name = "cboBancos";
            this.cboBancos.Size = new System.Drawing.Size(220, 21);
            this.cboBancos.TabIndex = 7;
            // 
            // btnSelecionaDestino
            // 
            this.btnSelecionaDestino.Location = new System.Drawing.Point(486, 170);
            this.btnSelecionaDestino.Name = "btnSelecionaDestino";
            this.btnSelecionaDestino.Size = new System.Drawing.Size(43, 21);
            this.btnSelecionaDestino.TabIndex = 15;
            this.btnSelecionaDestino.Text = "...";
            this.btnSelecionaDestino.UseVisualStyleBackColor = true;
            // 
            // btnSelecionaOrigem
            // 
            this.btnSelecionaOrigem.Location = new System.Drawing.Point(486, 119);
            this.btnSelecionaOrigem.Name = "btnSelecionaOrigem";
            this.btnSelecionaOrigem.Size = new System.Drawing.Size(43, 20);
            this.btnSelecionaOrigem.TabIndex = 14;
            this.btnSelecionaOrigem.Text = "...";
            this.btnSelecionaOrigem.UseVisualStyleBackColor = true;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(35, 171);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(445, 20);
            this.txtDestino.TabIndex = 13;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(35, 119);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(445, 20);
            this.txtOrigem.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(32, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Selecione a pasta destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione a pasta origem";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1268, 642);
            this.ControlBox = false;
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Publicar";
            this.TransparencyKey = System.Drawing.Color.SlateGray;
            this.panelConteudo.ResumeLayout(false);
            this.panelConteudo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelConteudo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboBancos;
        private System.Windows.Forms.Button btnSelecionaDestino;
        private System.Windows.Forms.Button btnSelecionaOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

