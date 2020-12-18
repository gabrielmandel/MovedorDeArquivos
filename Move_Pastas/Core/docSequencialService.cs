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
