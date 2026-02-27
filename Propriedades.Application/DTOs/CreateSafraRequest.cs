using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Application.DTOs
{
    public class CreateSafraRequest
    {
        public string Nome { get; set; }
        public int Status { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
