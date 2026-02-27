using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;

namespace Propriedades.Application.Extensions
{
    public static class CulturaExtension
    {
        public static CulturaResponse ToCulturaResponse(this Cultura cultura)
        {
            return new CulturaResponse
            {
                Id = cultura.Id,
                Nome = cultura.Nome,
                Tipo = cultura.Tipo,
                CicloDias = cultura.CicloDias
            };
        }
    }
}
