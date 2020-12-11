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

namespace Move_Pastas
{
    public partial class frmMain : Form
    {
        public List<string> naoPermitido = new List<string>();
        public List<string> arquivosProibidos = new List<string>();
        public frmMain()
        {
            InitializeComponent();
            naoPermitido.Add("config");
            naoPermitido.Add("email");
            arquivosProibidos.Add("emailFile.txt");
            arquivosProibidos.Add("configFile.txt");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
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
                new UtilsFile().DirectoryCopy(txtOrigem.Text, txtDestino.Text, true, naoPermitido, arquivosProibidos);
                MessageBox.Show("Copiados com Sucesso!!!");
            }
            else
            {
                MessageBox.Show("Selecione uma pasta e um diretório destino");
            }
        }

        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            frmBlacklist blacklist = new frmBlacklist();
            blacklist.Show();
        }
    }
}
