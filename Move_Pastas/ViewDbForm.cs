using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Move_Pastas.Core;
using Move_Pastas.Views;

namespace Move_Pastas
{
    public partial class ViewDbForm : Form
    {
        docCadastroDbService viewDb = new docCadastroDbService();
        FormCadBanco cadastroDb = new FormCadBanco();
        ViewsService views = new ViewsService();

        public ViewDbForm()
        {
            InitializeComponent();
            CarregaTela();
            Form menu = new FormMenu(this);
            views.AbrirSubForm(menu, panelMenu);
        }
        private void CarregaTela()
        {
            grvBanco.DataSource = viewDb.BuscarItensCadastrados();
            grvBanco.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void btnCadastrarNovo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovoBanco_Click(object sender, EventArgs e)
        {
            cadastroDb.Show();
        }
    }
}
