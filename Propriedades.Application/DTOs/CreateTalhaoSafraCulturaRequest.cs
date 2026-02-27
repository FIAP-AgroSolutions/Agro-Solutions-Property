using Propriedades.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Application.DTOs
{
    public class CreateTalhaoSafraCulturaRequest
    {

        public Guid TalhaoId { get; set; }

        public Guid SafraId { get; set; }

        public Guid CulturaId { get; set; }

        public DateTime DataPlantio { get; set; }
        public DateTime? DataColheita { get; set; }

        public decimal? ProducaoTotalToneladas { get; set; }
    }
}
