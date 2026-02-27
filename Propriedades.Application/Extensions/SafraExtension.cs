using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;

namespace Propriedades.Application.Extensions
{
    public static class SafraExtension
    {
        public static SafraResponse ToSafraResponse(this Safra safra)
        {
            if (safra is null) return null;

            return new SafraResponse
            {
                Id = safra.Id,
                Nome = safra.Nome,
                Status = (int)safra.Status,
                DataInicio = safra.DataInicio,
                DataFim = safra.DataFim
            };
        }
    }
}
