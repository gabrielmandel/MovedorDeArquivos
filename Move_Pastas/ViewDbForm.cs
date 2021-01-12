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

namespace Move_Pastas
{
    public partial class ViewDbForm : Form
    {
        docCadastroDbService viewDb = new docCadastroDbService();
        CadastroDbForm cadastroDb = new CadastroDbForm();
        public ViewDbForm()
        {
            InitializeComponent();
            CarregaTela();
        }
        private void CarregaTela()
        {
            grvBanco.DataSource = viewDb.BuscarItensCadastrados();
            grvBanco.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void btnCadastrarNovo_Click(object sender, EventArgs e)
        {
            cadastroDb.Show();
        }
    }
}
