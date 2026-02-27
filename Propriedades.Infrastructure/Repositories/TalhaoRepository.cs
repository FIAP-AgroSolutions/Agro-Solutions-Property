using Microsoft.Extensions.Logging;
using Propriedades.Domain.Entities;
using Propriedades.Domain.Interfaces;
using Propriedades.Infrastructure.Data;

namespace Propriedades.Infrastructure.Repositories
{
    public class TalhaoRepository : BaseRepository<Talhao>, ITalhaoRepository
    {
        public TalhaoRepository(PropriedadesDbContext context,
            ILogger<BaseRepository<Talhao>> logger)
            : base(context, logger)
        {
        }
    }
}
