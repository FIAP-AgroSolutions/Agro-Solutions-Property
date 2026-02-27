using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;

namespace Propriedades.Application.Extensions
{
    public static class UpdateTalhaoRequestExtension
    {
        public static Talhao ToTalhao(this UpdateTalhaoRequest talhao)
            {
                return new Talhao
                {
                    Id = talhao.Id,
                    Nome = talhao.Nome,
                    Codigo = talhao.Codigo,
                    Status = (Domain.Enums.StatusTalhao)talhao.Status,
                    AreaHectares = talhao.AreaHectares,
                    PropriedadeId = talhao.PropriedadeId,
                    DataPlantio = talhao.DataPlantio,
                    DataColheitaPrevista = talhao.DataColheitaPrevista
                };
        }
    }
}
