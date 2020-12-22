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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.brnCadastrarDb = new FontAwesome.Sharp.IconButton();
            this.btnConfigurar = new FontAwesome.Sharp.IconButton();
            this.btnPublicar = new FontAwesome.Sharp.IconButton();
            this.paneLogo = new System.Windows.Forms.Panel();
            this.boxLogo = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTituloHeader = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.paneLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(146)))), ((int)(((byte)(157)))));
            this.panelMenu.Controls.Add(this.brnCadastrarDb);
            this.panelMenu.Controls.Add(this.btnConfigurar);
            this.panelMenu.Controls.Add(this.btnPublicar);
            this.panelMenu.Controls.Add(this.paneLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(147, 388);
            this.panelMenu.TabIndex = 3;
            // 
            // brnCadastrarDb
            // 
            this.brnCadastrarDb.Dock = System.Windows.Forms.DockStyle.Top;
            this.brnCadastrarDb.FlatAppearance.BorderSize = 0;
            this.brnCadastrarDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnCadastrarDb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCadastrarDb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.brnCadastrarDb.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.brnCadastrarDb.IconColor = System.Drawing.Color.White;
            this.brnCadastrarDb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.brnCadastrarDb.IconSize = 28;
            this.brnCadastrarDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnCadastrarDb.Location = new System.Drawing.Point(0, 150);
            this.brnCadastrarDb.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.brnCadastrarDb.Name = "brnCadastrarDb";
            this.brnCadastrarDb.Size = new System.Drawing.Size(147, 40);
            this.brnCadastrarDb.TabIndex = 5;
            this.brnCadastrarDb.Text = "Cadastrar DB";
            this.brnCadastrarDb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnCadastrarDb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnCadastrarDb.UseVisualStyleBackColor = true;
            this.brnCadastrarDb.Click += new System.EventHandler(this.brnCadastrarDb_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfigurar.FlatAppearance.BorderSize = 0;
            this.btnConfigurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfigurar.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnConfigurar.IconColor = System.Drawing.Color.White;
            this.btnConfigurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigurar.IconSize = 28;
            this.btnConfigurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurar.Location = new System.Drawing.Point(0, 110);
            this.btnConfigurar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(147, 40);
            this.btnConfigurar.TabIndex = 4;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPublicar.FlatAppearance.BorderSize = 0;
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPublicar.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnPublicar.IconColor = System.Drawing.Color.White;
            this.btnPublicar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPublicar.IconSize = 28;
            this.btnPublicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublicar.Location = new System.Drawing.Point(0, 70);
            this.btnPublicar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(147, 40);
            this.btnPublicar.TabIndex = 3;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // paneLogo
            // 
            this.paneLogo.Controls.Add(this.boxLogo);
            this.paneLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneLogo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.paneLogo.Location = new System.Drawing.Point(0, 0);
            this.paneLogo.Name = "paneLogo";
            this.paneLogo.Size = new System.Drawing.Size(147, 70);
            this.paneLogo.TabIndex = 0;
            // 
            // boxLogo
            // 
            this.boxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxLogo.Image = ((System.Drawing.Image)(resources.GetObject("boxLogo.Image")));
            this.boxLogo.Location = new System.Drawing.Point(0, 0);
            this.boxLogo.Name = "boxLogo";
            this.boxLogo.Size = new System.Drawing.Size(147, 70);
            this.boxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxLogo.TabIndex = 0;
            this.boxLogo.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(146)))), ((int)(((byte)(157)))));
            this.panelHeader.Controls.Add(this.lblTituloHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(147, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(666, 70);
            this.panelHeader.TabIndex = 4;
            // 
            // lblTituloHeader
            // 
            this.lblTituloHeader.AutoSize = true;
            this.lblTituloHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloHeader.Location = new System.Drawing.Point(54, 26);
            this.lblTituloHeader.Name = "lblTituloHeader";
            this.lblTituloHeader.Size = new System.Drawing.Size(50, 19);
            this.lblTituloHeader.TabIndex = 0;
            this.lblTituloHeader.Text = "Home";
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(147, 70);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(666, 318);
            this.panelBody.TabIndex = 5;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 388);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Name = "PrincipalForm";
            this.Text = "Movedor de Arquivos";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panelMenu.ResumeLayout(false);
            this.paneLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel paneLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label lblTituloHeader;
        private FontAwesome.Sharp.IconButton btnPublicar;
        private FontAwesome.Sharp.IconButton btnConfigurar;
        private FontAwesome.Sharp.IconButton brnCadastrarDb;
        private System.Windows.Forms.PictureBox boxLogo;
    }
}