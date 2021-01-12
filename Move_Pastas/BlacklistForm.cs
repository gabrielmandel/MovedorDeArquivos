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
        public docConfigExclusao cellEdit;
        public List<docConfigExclusao> lista;
        public docConfigExclusaoService exclusaoService;
      
        public docCadastroDbService cadastroService;
        public frmFolderBlacklist()
        {
            exclusaoService = new docConfigExclusaoService();
            lista = exclusaoService.BuscarItensCadastrados();
            cadastroService = new docCadastroDbService();

            InitializeComponent();
            CarregaTela();                    

        }

        private void CarregaTela()
        {                      
            grvListaExcluidos.DataSource = exclusaoService.BuscarItensCadastrados();         
            rbPasta.Checked = true;
        }

        private void addFolderBlacklist_Click(object sender, EventArgs e)
        {
            var tipoArqauivo = rbArquivo.Checked ? MoverEnums.indTipoArquivo.File : MoverEnums.indTipoArquivo.Directory;
            docConfigExclusao doc = new docConfigExclusao();

            doc.tipo = tipoArqauivo.ToString();
            doc.NomeExclusao = txtBlacklist.Text;

            exclusaoService.adicionarItem(doc);

            MessageBox.Show("Item adicionado com sucesso:");
            CarregaTela();
        }

        private void grvListaExcluidos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var NomeExclusao = grvListaExcluidos.CurrentCell.Value.ToString();
            var local = grvListaExcluidos.CurrentRow.Cells["tipo"].Value;
            cellEdit = new docConfigExclusao();
            cellEdit.NomeExclusao = NomeExclusao;
            cellEdit.tipo = local.ToString();

        }

        private void grvListaExcluidos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            docConfigExclusao exclusaoNovo = new docConfigExclusao();
            lista = exclusaoService.BuscarItensCadastrados();

            var NomeAtualizado= grvListaExcluidos.CurrentCell.Value.ToString();

            exclusaoNovo.NomeExclusao = NomeAtualizado;
            exclusaoNovo.tipo = cellEdit.tipo;


            var listaatualiza = lista.Where(o => o.NomeExclusao != cellEdit.NomeExclusao
                                                    && o.tipo != cellEdit.tipo).ToList();


            listaatualiza.Add(exclusaoNovo);

            ///Chama o metodo para salvar a lista.
            exclusaoService.CadastrarConfigExclusao(listaatualiza);
            MessageBox.Show("Item editado com sucesso:");
            CarregaTela();
        }

        private void grvListaExcluidos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var NomeExclusao = grvListaExcluidos.CurrentCell.Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(cellEdit != null)
            {

            docConfigExclusao excluirLinha = new docConfigExclusao();
            lista = exclusaoService.BuscarItensCadastrados();


            var listaAtualizada = lista.Where(o => o.NomeExclusao != cellEdit.NomeExclusao
                                                    && o.tipo != cellEdit.tipo).ToList();

            listaAtualizada.Remove(excluirLinha);
            MessageBox.Show("Item Excluído");
            exclusaoService.CadastrarConfigExclusao(listaAtualizada);
            CarregaTela();
            }
            else
            {

            MessageBox.Show("Por favor, selecione uma linha!");
            }
        }

        private void grvListaExcluidos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var NomeExclusao = grvListaExcluidos.CurrentRow.Cells["NomeExclusao"].Value.ToString();
            //var local = grvListaExcluidos.CurrentRow.Cells["tipo"].Value;
            cellEdit = new docConfigExclusao();

            cellEdit.NomeExclusao = NomeExclusao;
            //cellEdit.tipo = local.ToString();
        }
    }
}
