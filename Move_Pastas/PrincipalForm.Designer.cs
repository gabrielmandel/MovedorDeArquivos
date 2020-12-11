namespace Move_Pastas
{
    partial class PrincipalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publicação de Site";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(34, 88);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(149, 126);
            this.btnConfigurar.TabIndex = 1;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(295, 88);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(149, 126);
            this.btnPublicar.TabIndex = 2;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 264);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.label1);
            this.Name = "PrincipalForm";
            this.Text = "PrincipalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnPublicar;
    }
}