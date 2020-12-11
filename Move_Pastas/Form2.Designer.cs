
namespace Move_Pastas
{
    partial class frmBlacklist
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
            this.listBlacklist = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listBlacklist
            // 
            this.listBlacklist.HideSelection = false;
            this.listBlacklist.Location = new System.Drawing.Point(12, 12);
            this.listBlacklist.Name = "listBlacklist";
            this.listBlacklist.Size = new System.Drawing.Size(149, 268);
            this.listBlacklist.TabIndex = 0;
            this.listBlacklist.UseCompatibleStateImageBehavior = false;
            this.listBlacklist.View = System.Windows.Forms.View.List;
            // 
            // frmBlacklist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(293, 292);
            this.Controls.Add(this.listBlacklist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBlacklist";
            this.Text = "Lista Negra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listBlacklist;
    }
}