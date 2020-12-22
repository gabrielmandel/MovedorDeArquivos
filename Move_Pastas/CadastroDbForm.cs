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
    public partial class CadastroDbForm : Form
    {
        public docCadastroDbService cadastroService;

        public CadastroDbForm()
        {
            cadastroService = new docCadastroDbService();
            InitializeComponent();
        }

        private void btnCadastrarDb_Click(object sender, EventArgs e)
        {
            docCadastroDb itensDb = new docCadastroDb();

            itensDb.NomeSite = txtNomeSite.Text;
            itensDb.NomeBancoDados = txtNomeDb.Text;
            itensDb.NomeServidor = txtNomeServidor.Text;
            itensDb.Login = txtLogin.Text;
            itensDb.Senha = txtSenha.Text;

            cadastroService.AdicionarItem(itensDb);

            MessageBox.Show("Cadastro Realizado com Sucesso!");

        }
    }
}
