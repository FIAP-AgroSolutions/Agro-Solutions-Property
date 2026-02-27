using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;

namespace Propriedades.Application.Extensions
{
    public static class UpdateTalhaoSafraCulturaRequestExtension
    {
        public static TalhaoSafraCultura ToTalhaoSafraCultura(this UpdateTalhaoSafraCulturaRequest request)
        {
            if (request == null) return null;
            return new Domain.Entities.TalhaoSafraCultura
            {
                Id = request.Id,
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
