
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
            this.label1 = new System.Windows.Forms.Label();
            this.listFolderBlacklist = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // addFolderBlacklist
            // 
            this.addFolderBlacklist.Location = new System.Drawing.Point(15, 204);
            this.addFolderBlacklist.Name = "addFolderBlacklist";
            this.addFolderBlacklist.Size = new System.Drawing.Size(192, 23);
            this.addFolderBlacklist.TabIndex = 1;
            this.addFolderBlacklist.Text = "Adicionar";
            this.addFolderBlacklist.UseVisualStyleBackColor = true;
            this.addFolderBlacklist.Click += new System.EventHandler(this.addFolderBlacklist_Click);
            // 
            // txtBlacklist
            // 
            this.txtBlacklist.Location = new System.Drawing.Point(15, 178);
            this.txtBlacklist.Name = "txtBlacklist";
            this.txtBlacklist.Size = new System.Drawing.Size(192, 20);
            this.txtBlacklist.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insira o nome da pasta a ser adicionada";
            // 
            // listFolderBlacklist
            // 
            this.listFolderBlacklist.HideSelection = false;
            this.listFolderBlacklist.Location = new System.Drawing.Point(15, 13);
            this.listFolderBlacklist.Name = "listFolderBlacklist";
            this.listFolderBlacklist.Size = new System.Drawing.Size(192, 131);
            this.listFolderBlacklist.TabIndex = 5;
            this.listFolderBlacklist.UseCompatibleStateImageBehavior = false;
            // 
            // frmFolderBlacklist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(242, 267);
            this.Controls.Add(this.listFolderBlacklist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBlacklist);
            this.Controls.Add(this.addFolderBlacklist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFolderBlacklist";
            this.Text = "Lista Negra Pastas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addFolderBlacklist;
        private System.Windows.Forms.TextBox txtBlacklist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listFolderBlacklist;
    }
}