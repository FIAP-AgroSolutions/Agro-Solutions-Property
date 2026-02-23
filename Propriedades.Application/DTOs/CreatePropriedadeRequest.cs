using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Application.DTOs
{
    public class CreatePropriedadeRequest
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public string Municipio { get; set; }
        public string Estado { get; set; }
        public decimal AreaTotalHectares { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
