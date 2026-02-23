using Propriedades.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Domain.Entities
{
    public class Talhao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public StatusTalhao Status { get; set; }

        public decimal AreaHectares { get; set; }

        public Guid PropriedadeId { get; set; }
        public Propriedade Propriedade { get; set; }

        public DateTime DataPlantio { get; set; }
        public DateTime? DataColheitaPrevista { get; set; }

        public ICollection<TalhaoSafraCultura> TalhoesSafra { get; set; }
    }
}
