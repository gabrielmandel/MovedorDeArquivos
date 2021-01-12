using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Move_Pastas.Views;

namespace Move_Pastas
{
    public partial class PrincipalForm : Form
    {
        ViewsService views = new ViewsService();
        Panel menuButton = new Panel();
        

        public PrincipalForm()
        {
            InitializeComponent();
            menuButton.Size = new Size(7, 40);
            panelMenu.Controls.Add(menuButton);
        }
       
        private void btnPublicar_Click(object sender, EventArgs e)
        {
            frmMain publicar = new frmMain();
            views.AtivarBtn(sender, menuButton);
            views.AbrirSubForm(publicar, panelBody);
            lblTituloHeader.Text = publicar.Text;
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmFolderBlacklist blacklist = new frmFolderBlacklist();
            views.AtivarBtn(sender, menuButton);
            views.AbrirSubForm(blacklist, panelBody);
            lblTituloHeader.Text = blacklist.Text;
        }

        private void brnCadastrarDb_Click(object sender, EventArgs e)
        {
            ViewDbForm viewDb = new ViewDbForm();
            views.AtivarBtn(sender, menuButton);
            views.AbrirSubForm(viewDb, panelBody);
            lblTituloHeader.Text = viewDb.Text;
            //CadastroDbForm cadastroDb = new CadastroDbForm();
            //views.AtivarBtn(sender, menuButton);
            //views.AbrirSubForm(cadastroDb, panelBody);
            //lblTituloHeader.Text = cadastroDb.Text;
        }
    }
}
