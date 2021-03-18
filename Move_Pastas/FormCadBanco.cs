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
    public partial class FormCadBanco : Form
    {
        public bool Carregando;
        public docCadastroDbService cadastroService;

        public FormCadBanco()
        {
            cadastroService = new docCadastroDbService();
            InitializeComponent();

            CarregarTela();
        }

        private void CarregarTela()
        {
            Carregando = true;
            var items = cadastroService.BuscarItensCadastrados().ToList();

            items.Add(new docCadastroDb("Selecione", 0));

            cboSite.DataSource = items;
            cboSite.DisplayMember = "NomeSite";
            cboSite.ValueMember = "id";
            cboSite.SelectedValue = 0;

            Carregando = false;
        }

        private void btnCadastrarDb_Click(object sender, EventArgs e)
        {
            docCadastroDb itensDb = new docCadastroDb();
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                itensDb.id = Convert.ToInt32(txtId.Text);
            }

            itensDb.NomeSite = txtNomeSite.Text;
            itensDb.NomeBancoDados = txtNomeDb.Text;
            itensDb.NomeServidor = txtNomeServidor.Text;
            itensDb.Login = txtLogin.Text;
            itensDb.Senha = txtSenha.Text;
            itensDb.AcessoExterno = chkAcessoExt.Checked == true ? 1 : 0;

            cadastroService.AdicionarItem(itensDb);

            if (btnCadastrarDb.Text == "Atualizar Existente")
            {
                MessageBox.Show("Atualizado com Sucesso!");
            }
            else
            {
            MessageBox.Show("Cadastro Realizado com Sucesso!");
            }
            CarregarTela();
        }

        private void cboSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Carregando)
            {

                int id = (int)cboSite.SelectedValue;
                var cadastroDb = cadastroService.ObterCadastroDb(id);

                if (id != 0)
                {

                    if (cadastroDb != null)
                    {
                        txtId.Text = cadastroDb.id.ToString();
                        txtNomeSite.Text = cadastroDb.NomeSite;
                        txtNomeDb.Text = cadastroDb.NomeBancoDados;
                        txtNomeServidor.Text = cadastroDb.NomeServidor;
                        txtLogin.Text = cadastroDb.Login;
                        txtSenha.Text = cadastroDb.Senha;
                        chkAcessoExt.Checked = cadastroDb.AcessoExterno == 1;
                        btnCadastrarDb.Text = "Atualizar Existente";
                    }
                }
                else
                {

                    //limpar os campos
                    txtId.Text = null;
                    txtNomeSite.Text = null;
                    txtNomeDb.Text = null;
                    txtNomeServidor.Text = null;
                    txtLogin.Text = null;
                    txtSenha.Text = null;
                    chkAcessoExt.Checked = false;
                    btnCadastrarDb.Text = "Novo Cadastro"; 
                }
            }
        }
    }
}
