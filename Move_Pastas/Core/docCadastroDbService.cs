using Move_Pastas.Core.functions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Pastas.Core
{
    public class docCadastroDbService
    {
        private string pathconfig = "cadastroDb.json";

        public void AdicionarItem(docCadastroDb cadastro)
        {
            List<docCadastroDb> itensDb = this.BuscarItensCadastrados();

            if (itensDb == null)
            {
                itensDb = new List<docCadastroDb>();
            }

            if (cadastro.id == null)
            {
                cadastro.GerarId();
            }
            else
            {
                itensDb = itensDb.Where(o => o.id != cadastro.id).ToList();
            }

            itensDb.Add(cadastro);

            CadastrarItens(itensDb);
        }

        public docCadastroDb ObterCadastroDb(int id)
        {
            var lista = this.BuscarItensCadastrados();
            if (lista.Count > 0)
            {
                return lista.Where(o => o.id == id).FirstOrDefault();
            }

            return null;
        }

        public List<docCadastroDb> BuscarItensCadastrados()
        {
            var arquivo = new Functions().BuscarArquivo(pathconfig);

            if (arquivo != null)
            {
                return JsonConvert.DeserializeObject<List<docCadastroDb>>(arquivo);
            }

            return null;
        }

        public void CadastrarItens(List<docCadastroDb> cadastro)
        {
            string json = JsonConvert.SerializeObject(cadastro);
            new Functions().EcreverArquivo(pathconfig, json);
        }

    }
}
