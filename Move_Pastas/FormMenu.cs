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
    public partial class FormMenu : Form
    {
        public Form frmAtual;
        public FormMenu()
        {
            InitializeComponent();
        }

        public FormMenu(Form frmAtual)
        {
            InitializeComponent();
            this.frmAtual = frmAtual;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmAtual.Close();
        }
    }
}
