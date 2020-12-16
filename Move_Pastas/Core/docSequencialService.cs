using Move_Pastas.Core.functions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Pastas.Core
{
    public class docSequencialService
    {
        

        private string pathconfig = "configId.json";
        public void adicionarItem(docSequencial id)
        {
            List<docSequencial> ids = this.BuscarIdsCadastrados();

            if (ids == null)
            {
                ids = new List<docSequencial>();
            }

            List<docConfigExclusao> lista = new docConfigExclusaoService().BuscarItensCadastrados();

            foreach (var item in lista)
            {
                ids.Add(id);
            }
            

            CadastrarConfigExclusao(ids);
        }

        public List<docSequencial> BuscarIdsCadastrados()
        {
            var arquivo = new Functions().BuscarArquivo(pathconfig);

            if (arquivo != null)
            {
                return JsonConvert.DeserializeObject<List<docSequencial>>(arquivo);
            }

            return null;
        }

        public void CadastrarConfigExclusao(List<docSequencial> ids)
        {
            string json = JsonConvert.SerializeObject(ids);
            new Functions().EcreverArquivo(pathconfig, json);
        }
    }
}
