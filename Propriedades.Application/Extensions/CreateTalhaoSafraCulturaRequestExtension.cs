using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;

namespace Propriedades.Application.Extensions
{
    public static class CreateTalhaoSafraCulturaRequestExtension
    {
        public static TalhaoSafraCultura ToTalhaoSafraCultura(this CreateTalhaoSafraCulturaRequest request)
        {
            if (request == null) return null;
            return new TalhaoSafraCultura
            {
                Id = Guid.NewGuid(),
                TalhaoId = request.TalhaoId,
                SafraId = request.SafraId,
                CulturaId = request.CulturaId,
                DataPlantio = request.DataPlantio,
                DataColheita = request.DataColheita,
                ProducaoTotalToneladas = request.ProducaoTotalToneladas
            };
        }
    }
}
