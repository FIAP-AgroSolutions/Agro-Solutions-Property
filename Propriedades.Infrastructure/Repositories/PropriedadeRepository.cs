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
    public class PropriedadeRepository : BaseRepository<Propriedade>, IPropriedadeRepository
    {
        public PropriedadeRepository(PropriedadesDbContext context,
            ILogger<BaseRepository<Propriedade>> logger)
            : base(context, logger)
        {
        }
    }
}
