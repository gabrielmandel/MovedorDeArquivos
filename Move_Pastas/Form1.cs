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

namespace Move_Pastas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
                //try catch 1
                try
                {
                    string origem = txtOrigem.Text;
                    string diretorio = Path.GetDirectoryName(origem);
                    string destino = Path.Combine(txtDestino.Text, diretorio);
                    
                    if (rdbCopiar.Checked)
                    {
                        Directory.GetFiles(origem, destino);
                        MessageBox.Show($"{origem} copiado com sucesso para {destino} ");
                    }
                    if (rdbMover.Checked)
                    {
                        Directory.Move(origem, destino);
                        MessageBox.Show($"{origem} movido com sucesso para {destino}");
                    }
                }
                //try catch 1
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma pasta e um diretório destino");
            }
        }
    }
}
