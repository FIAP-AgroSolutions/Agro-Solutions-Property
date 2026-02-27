using Microsoft.Extensions.Logging;
using Propriedades.Domain.Entities;
using Propriedades.Domain.Interfaces;
using Propriedades.Infrastructure.Data;

namespace Propriedades.Infrastructure.Repositories
{
    public class SafraRepository : BaseRepository<Safra>, ISafraRepository
    {
        public SafraRepository(PropriedadesDbContext context,
            ILogger<BaseRepository<Safra>> logger)
            : base(context, logger)
        {
        }
    }
}
