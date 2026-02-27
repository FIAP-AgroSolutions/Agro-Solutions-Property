using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;
using Propriedades.Domain.Enums;

namespace Propriedades.Application.Extensions
{
    public static class CreateSafraRequestExtension
    {
        public static Safra ToSafra(this CreateSafraRequest request)
        {
            return new Safra
            {
                Id = Guid.NewGuid(),
                Nome = request.Nome,
                Status = (StatusSafra)request.Status,
                DataInicio = request.DataInicio,
                DataFim = request.DataFim
            };
        }
    }
}
