using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Pastas.Core.functions
{
   public class Functions
    {
        private string _dirProjeto { get; set; }

        public Functions()
        {
            _dirProjeto = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
        }

        public string BuscarArquivo(string path)
        {
            string capPath = (new Uri( _dirProjeto + path)).LocalPath;
            if (File.Exists(capPath))
            {
                return File.ReadAllText(capPath);
            }

            return null;
        }

        public string EcreverArquivo(string path, string json)
        {
            string capPath = new Uri(_dirProjeto + path).LocalPath;
            if (!File.Exists(capPath))
            {
                using (File.Create(capPath))
                {
                };
            }

            File.WriteAllText(capPath, json);

            return null;
        }
        public string EscreverArquivoId(string path, string json)
        {
            string capPath = new Uri(_dirProjeto + path).LocalPath;
            if (!File.Exists(capPath))
            {
                using (File.Create(capPath))
                {

                };
            }

            return null;
        }
    }
}
