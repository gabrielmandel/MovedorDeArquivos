using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Pastas.Core
{
    public class docCadastroDb
    {
        public int? id { get; set; }
        public string NomeSite { get; set; }
        public string NomeBancoDados { get; set; }
        public string NomeServidor { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int AcessoExterno { get; set; }
        public docCadastroDb(string nomeSite, int id)
        {
            this.id = id;
            this.NomeSite = nomeSite;
        }
        public docCadastroDb()
        {
              
        }
        public void GerarId()
        {
            List<docCadastroDb> listaExclusao = new docCadastroDbService().BuscarItensCadastrados();

            if (listaExclusao != null)
            {
                this.id = listaExclusao.Count + 1;
            }
            else
            {
                this.id = 1;
            }
        }
    }

}
