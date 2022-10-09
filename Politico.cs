using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urna
{
    public class Politico
    {
        private string nome;
        private string numero;

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }
        public string Numero {
            get { return numero; } 
            set { numero = value; } 
        }
    }
}
