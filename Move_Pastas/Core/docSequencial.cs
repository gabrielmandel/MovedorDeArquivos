using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Pastas.Core
{
    public class docSequencial
    {

        public int id
        {
            get { return this.id; }
            private set
            {
                this.id = value;
            }
        }

        public void GerarId<T>()
        {            
            List<docConfigExclusao> listaExclusao = new docConfigExclusaoService().BuscarItensCadastrados();
            
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

