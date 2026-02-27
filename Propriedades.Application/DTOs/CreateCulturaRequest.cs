using Propriedades.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Application.DTOs
{
    public class CreateCulturaRequest
    {
        public string Nome { get; set; }
        public TipoCultura Tipo { get; set; }
        public int CicloDias { get; set; }
    }
}
