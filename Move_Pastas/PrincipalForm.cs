using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Pastas
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            frmMain blacklist = new frmMain();
            blacklist.Show();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmFolderBlacklist blacklist = new frmFolderBlacklist();
            blacklist.Show();
        }
    }
}
