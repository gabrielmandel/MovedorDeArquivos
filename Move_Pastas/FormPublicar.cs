using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Move_Pastas.Core;
using Move_Pastas.Views;

namespace Move_Pastas
{
    public partial class frmMain : Form
    {
        public List<string> naoPermitido = new List<string>();
        public List<docConfigExclusao> arquivosProibidos;
        public docCadastroDbService cadastroService;
        ViewsService views = new ViewsService();

        //Form menu configurar parametro de construção para controles
        public frmMain()
        {
            cadastroService = new docCadastroDbService();
            arquivosProibidos = new docConfigExclusaoService().BuscarItensCadastrados();
            InitializeComponent();
            CarregarTela();
            Form menu = new FormMenu(this);
            views.AbrirSubForm(menu,panelMenu);
           
        }
        
        private void btnSelecionaOrigem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog origem = new FolderBrowserDialog();

            origem.Description = "Selecione a pasta de origem";
            origem.RootFolder = Environment.SpecialFolder.MyComputer;
            origem.ShowNewFolderButton = false;
            if (origem.ShowDialog() == DialogResult.OK)
            {
                txtOrigem.Text = origem.SelectedPath;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog destino = new FolderBrowserDialog();

            destino.Description = "Selecione a paste destino";
            destino.RootFolder = Environment.SpecialFolder.MyComputer;
            destino.ShowNewFolderButton = true;
            if (destino.ShowDialog() == DialogResult.OK)
            {
                txtDestino.Text = destino.SelectedPath;
            }
        }
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOrigem.Text) && !string.IsNullOrEmpty(txtDestino.Text))
            {
                string destinoCompac = txtDestino.Text + "compacto";
                string arquivoZip = txtDestino.Text + "\\versaoCompactada.zip";

                new UtilsFile().DirectoryCopy(txtOrigem.Text, destinoCompac, true, arquivosProibidos);

                if (File.Exists(arquivoZip))
                {
                    MessageBox.Show("O arquivo já existe no destino");
                }
                else
                {
                    //compacta a versao gerada no directorio de destino
                    ZipFile.CreateFromDirectory(destinoCompac, arquivoZip);
                    Directory.Delete(destinoCompac, true);
                    MessageBox.Show("Publicado com Sucesso!!!");
                }

            }
            else
            {
                MessageBox.Show("Selecione uma pasta e um diretório destino");
            }
        }
                     
        private void CarregarTela()
        {         
            var items = cadastroService.BuscarItensCadastrados().ToList();

            items.Add(new docCadastroDb("Selecione", 0));

            cboBancos.DataSource = items;
            cboBancos.DisplayMember = "NomeSite";
            cboBancos.ValueMember = "id";
            cboBancos.SelectedValue = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            Form config = new frmFolderBlacklist();
            config.ShowDialog();
        }
    }
}
