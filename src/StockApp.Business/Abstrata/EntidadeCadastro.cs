using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Business.Abstrata
{
    public class EntidadeCadastro : EntidadeBase
    {
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}
