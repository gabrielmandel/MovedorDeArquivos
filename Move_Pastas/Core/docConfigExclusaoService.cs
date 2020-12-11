using Move_Pastas.Core.functions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Pastas.Core
{
    public class docConfigExclusaoService
    {
        private string pathconfig = "configExclusao.json";
        public void adicionarItem(docConfigExclusao exclusao)
        {
            List<docConfigExclusao> exclusoes =  this.BuscarItensCadastrados();

            if(exclusoes == null)
            {
                exclusoes = new List<docConfigExclusao>();
            }

            exclusoes.Add(exclusao);

            CadastrarConfigExclusao(exclusoes);
        }


        public List<docConfigExclusao> BuscarItensCadastrados()
        {
            var arquivo = new Functions().BuscarArquivo(pathconfig);

            if (arquivo != null)
            {
                return  JsonConvert.DeserializeObject<List<docConfigExclusao>>(arquivo);
            }

            return null;
        }

        public void CadastrarConfigExclusao(List<docConfigExclusao> exclusoes)
        {
            string json = JsonConvert.SerializeObject(exclusoes);
            new Functions().EcreverArquivo(pathconfig, json);
        }
    }
}
