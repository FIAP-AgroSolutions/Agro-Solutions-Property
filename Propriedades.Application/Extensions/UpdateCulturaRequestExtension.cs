using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;

namespace Propriedades.Application.Extensions
{
    public static class UpdateCulturaRequestExtension
    {
        public static Cultura ToCultura(this UpdateCulturaRequest request)
        {
            return new Cultura
            {
                Id = request.Id,
                Nome = request.Nome,
                Tipo = request.Tipo,
                CicloDias = request.CicloDias
            };
        }
    }
}
