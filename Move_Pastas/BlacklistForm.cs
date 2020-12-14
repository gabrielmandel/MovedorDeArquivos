using Move_Pastas.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Move_Pastas
{
    public partial class frmFolderBlacklist : Form
    {
        public frmFolderBlacklist()
        {
            InitializeComponent();

            CarregaTela();
         
        }

        private void CarregaTela()
        {
            grvListaExcluidos.DataSource = new docConfigExclusaoService().BuscarItensCadastrados();
            rbPasta.Checked = true;
        }

        private void addFolderBlacklist_Click(object sender, EventArgs e)
        {

            var tipoArqauivo = rbArquivo.Checked ? MoverEnums.indTipoArquivo.File : MoverEnums.indTipoArquivo.Directory;
            docConfigExclusao doc = new docConfigExclusao();

            doc.tipo = tipoArqauivo.ToString();
            doc.NomeExclusao = txtBlacklist.Text;

            new docConfigExclusaoService().adicionarItem(doc);

            MessageBox.Show("Item adicionado com sucesso:");
            CarregaTela();
        }

    }
}
