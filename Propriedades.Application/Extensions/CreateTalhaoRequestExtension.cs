using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;
using Propriedades.Domain.Enums;

namespace Propriedades.Application.Extensions
{
    public static class CreateTalhaoRequestExtension
    {
            public static Talhao ToTalhao(this CreateTalhaoRequest request)
            {
                return new Talhao
                {
                    Id = Guid.NewGuid(),
                    Nome = request.Nome,
                    Codigo = request.Codigo,
                    Status = (StatusTalhao)request.Status,
                    AreaHectares = request.AreaHectares,
                    PropriedadeId = request.PropriedadeId,
                    DataPlantio = request.DataPlantio,
                    DataColheitaPrevista = request.DataColheitaPrevista
                };
        }
    }
}
