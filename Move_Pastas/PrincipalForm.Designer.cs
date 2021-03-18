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
            this.brnCadastrarDb = new FontAwesome.Sharp.IconButton();
            this.btnConfigurar = new FontAwesome.Sharp.IconButton();
            this.btnPublicar = new FontAwesome.Sharp.IconButton();
            this.panelBody = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnDummy = new FontAwesome.Sharp.IconButton();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // brnCadastrarDb
            // 
            this.brnCadastrarDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnCadastrarDb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCadastrarDb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.brnCadastrarDb.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.brnCadastrarDb.IconColor = System.Drawing.Color.White;
            this.brnCadastrarDb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.brnCadastrarDb.IconSize = 22;
            this.brnCadastrarDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnCadastrarDb.Location = new System.Drawing.Point(472, 165);
            this.brnCadastrarDb.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.brnCadastrarDb.Name = "brnCadastrarDb";
            this.brnCadastrarDb.Size = new System.Drawing.Size(148, 40);
            this.brnCadastrarDb.TabIndex = 5;
            this.brnCadastrarDb.Text = "Database";
            this.brnCadastrarDb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnCadastrarDb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnCadastrarDb.UseVisualStyleBackColor = true;
            this.brnCadastrarDb.Click += new System.EventHandler(this.brnCadastrarDb_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfigurar.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnConfigurar.IconColor = System.Drawing.Color.White;
            this.btnConfigurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigurar.IconSize = 22;
            this.btnConfigurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurar.Location = new System.Drawing.Point(643, 165);
            this.btnConfigurar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(148, 40);
            this.btnConfigurar.TabIndex = 4;
            this.btnConfigurar.Text = "Dummy Button";
            this.btnConfigurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPublicar.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnPublicar.IconColor = System.Drawing.Color.White;
            this.btnPublicar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPublicar.IconSize = 22;
            this.btnPublicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublicar.Location = new System.Drawing.Point(302, 165);
            this.btnPublicar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(148, 40);
            this.btnPublicar.TabIndex = 3;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(146)))), ((int)(((byte)(157)))));
            this.panelBody.Controls.Add(this.iconButton1);
            this.panelBody.Controls.Add(this.btnDummy);
            this.panelBody.Controls.Add(this.brnCadastrarDb);
            this.panelBody.Controls.Add(this.btnPublicar);
            this.panelBody.Controls.Add(this.btnConfigurar);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1254, 681);
            this.panelBody.TabIndex = 5;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cut;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 22;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(980, 165);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(148, 40);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "Dummy Button";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnDummy
            // 
            this.btnDummy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDummy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDummy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDummy.IconChar = FontAwesome.Sharp.IconChar.Deezer;
            this.btnDummy.IconColor = System.Drawing.Color.White;
            this.btnDummy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDummy.IconSize = 22;
            this.btnDummy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDummy.Location = new System.Drawing.Point(812, 165);
            this.btnDummy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnDummy.Name = "btnDummy";
            this.btnDummy.Size = new System.Drawing.Size(148, 40);
            this.btnDummy.TabIndex = 8;
            this.btnDummy.Text = "Dummy Button";
            this.btnDummy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDummy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDummy.UseVisualStyleBackColor = true;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrincipalForm";
            this.Text = "Movedor de Arquivos";
            this.TransparencyKey = System.Drawing.Color.SlateGray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private FontAwesome.Sharp.IconButton btnPublicar;
        private FontAwesome.Sharp.IconButton btnConfigurar;
        private FontAwesome.Sharp.IconButton brnCadastrarDb;
        private FontAwesome.Sharp.IconButton btnDummy;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}