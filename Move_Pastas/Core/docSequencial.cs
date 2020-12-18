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

        public void GerarId()
        {            
            List<docConfigExclusao> listaExclusao = new docConfigExclusaoService().BuscarItensCadastrados();
            id = 0;
            foreach (var item in listaExclusao)
            {                
                 id = id + 1;
                 
            }

        }
    }
}

