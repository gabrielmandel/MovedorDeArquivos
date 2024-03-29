﻿using System;
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

namespace Move_Pastas
{
    public partial class frmMain : Form
    {
        public List<string> naoPermitido = new List<string>();
        public List<docConfigExclusao> arquivosProibidos;
        public docCadastroDbService cadastroService;


        public frmMain()
        {
            cadastroService = new docCadastroDbService();
            arquivosProibidos = new docConfigExclusaoService().BuscarItensCadastrados();
            
            InitializeComponent();
            CarregarTela();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOrigem.Text) && !string.IsNullOrEmpty(txtDestino.Text))
            {
                new UtilsFile().DirectoryCopy(txtOrigem.Text, txtDestino.Text, true, arquivosProibidos);
                MessageBox.Show("Copiados com Sucesso!!!");

                //compacta a versao gerada no directorio de destino
                ZipFile.CreateFromDirectory(txtDestino.Text, txtOrigem.Text + "\\versaoCompactada.zip");
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
        private void cboBancos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
