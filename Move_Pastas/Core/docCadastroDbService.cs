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

            itensDb.Add(cadastro);

            CadastrarItens(itensDb);
        }

        public List<docCadastroDb> BuscarItensCadastrados()
        {
            var arquivo = new Functions().BuscarArquivo(pathconfig);

            if(arquivo != null)
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
