using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Domain.Entities
{
    public class TalhaoSafraCultura
    {
        public Guid Id { get; set; }

        public Guid TalhaoId { get; set; }
        public Talhao Talhao { get; set; }

        public Guid SafraId { get; set; }
        public Safra Safra { get; set; }

        public Guid CulturaId { get; set; }
        public Cultura Cultura { get; set; }

        public DateTime DataPlantio { get; set; }
        public DateTime? DataColheita { get; set; }

        public decimal? ProducaoTotalToneladas { get; set; }
    }
}
