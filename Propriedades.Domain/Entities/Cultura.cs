using Propriedades.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Domain.Entities
{
    public class Cultura
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public TipoCultura Tipo { get; set; }
        public int CicloDias { get; set; }

        public ICollection<TalhaoSafraCultura> TalhoesSafra { get; set; }
    }
}
