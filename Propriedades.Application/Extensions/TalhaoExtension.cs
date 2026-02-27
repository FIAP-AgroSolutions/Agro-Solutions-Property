using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Application.Extensions
{
    public static class TalhaoExtension
    {
        public static TalhaoResponse ToTalhaoResponse(this Talhao talhao)
        {
            return new TalhaoResponse
            {
                Id = talhao.Id,
                Nome = talhao.Nome,
                Codigo = talhao.Codigo,
                Status = (int)talhao.Status,
                AreaHectares = talhao.AreaHectares,
                PropriedadeId = talhao.PropriedadeId,
                DataPlantio = talhao.DataPlantio,
                DataColheitaPrevista = talhao.DataColheitaPrevista
            };
        }
    }
}
