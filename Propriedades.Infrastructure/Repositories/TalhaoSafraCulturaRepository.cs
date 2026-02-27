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
    public class TalhaoSafraCulturaRepository : BaseRepository<TalhaoSafraCultura>, ITalhaoSafraCulturaRepository
    {
        public TalhaoSafraCulturaRepository(PropriedadesDbContext context,
            ILogger<BaseRepository<TalhaoSafraCultura>> logger)
            : base(context, logger)
        {
        }
    }
}
