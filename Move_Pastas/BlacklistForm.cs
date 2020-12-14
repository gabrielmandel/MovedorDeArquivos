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
        public docConfigExclusao docExcluido;

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

        private void grvListaExcluidos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var NomeExclusao = grvListaExcluidos.CurrentCell.Value.ToString();
            var tipoArquivo = grvListaExcluidos.CurrentCell;
            docExcluido = new docConfigExclusao();
            docExcluido.NomeExclusao = NomeExclusao;
           docExcluido.tipo = tipoArquivo.ToString();

        }

        private void grvListaExcluidos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            new docConfigExclusaoService().BuscarItensCadastrados();

            docExcluido.NomeExclusao = grvListaExcluidos.CurrentCell.Value.ToString();

            MessageBox.Show("Item editado com sucesso:");
            CarregaTela();
        }

        private void grvListaExcluidos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var NomeExclusao = grvListaExcluidos.CurrentCell.Value.ToString();
        }
    }
}
