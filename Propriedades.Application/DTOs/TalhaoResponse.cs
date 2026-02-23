using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Application.DTOs
{
    public class TalhaoResponse
    {
        public bool Success { get; set; }

        public string Nome { get; set; }
        public string Codigo { get; set; }
        public int Status { get; set; }

        public decimal AreaHectares { get; set; }

        public Guid PropriedadeId { get; set; }

        public DateTime DataPlantio { get; set; }
        public DateTime? DataColheitaPrevista { get; set; }

        public List<string> Errors { get; set; } = new();
    }
}
