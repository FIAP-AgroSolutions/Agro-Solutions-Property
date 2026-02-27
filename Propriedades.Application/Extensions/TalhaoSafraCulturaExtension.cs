using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;

namespace Propriedades.Application.Extensions
{
    public static class TalhaoSafraCulturaExtension
    {
        public static TalhaoSafraCulturaResponse ToTalhaoSafraCulturaResponse(this TalhaoSafraCultura talhaoSafraCultura)
        {
            if (talhaoSafraCultura == null) return null;
            return new TalhaoSafraCulturaResponse
            {
                Id = talhaoSafraCultura.Id,
                TalhaoId = talhaoSafraCultura.TalhaoId,
                SafraId = talhaoSafraCultura.SafraId,
                CulturaId = talhaoSafraCultura.CulturaId,
                DataPlantio = talhaoSafraCultura.DataPlantio,
                DataColheita = talhaoSafraCultura.DataColheita,
                ProducaoTotalToneladas = talhaoSafraCultura.ProducaoTotalToneladas
    };
        }
    }
}
