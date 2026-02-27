using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;

namespace Propriedades.Application.Extensions
{
    public static class CreateCulturaRequestExtension
    {
        public static Cultura ToCultura(this CreateCulturaRequest request)
        {
            return new Domain.Entities.Cultura
            {
                Id = Guid.NewGuid(),
                Nome = request.Nome,
                Tipo = request.Tipo,
                CicloDias = request.CicloDias
            };
        }
    }
}
