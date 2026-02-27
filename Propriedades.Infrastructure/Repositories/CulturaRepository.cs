using Microsoft.Extensions.Logging;
using Propriedades.Domain.Entities;
using Propriedades.Domain.Interfaces;
using Propriedades.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Infrastructure.Repositories
{
    public class CulturaRepository : BaseRepository<Cultura>, ICulturaRepository
    {
        public CulturaRepository(PropriedadesDbContext context,
            ILogger<BaseRepository<Cultura>> logger)
            : base(context, logger)
        {
        }
    }
}
