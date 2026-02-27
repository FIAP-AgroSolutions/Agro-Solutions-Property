using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;
using Propriedades.Domain.Enums;

namespace Propriedades.Application.Extensions
{
    public static class UpdateSafraRequestExtension
    {
        public static Safra ToSafra(this UpdateSafraRequest request)
        {
            return new Safra
            {
                Id = request.Id,
                Nome = request.Nome,
                Status = (StatusSafra)request.Status,
                DataInicio = request.DataInicio,
                DataFim = request.DataFim,
            };
        }
    }
}
