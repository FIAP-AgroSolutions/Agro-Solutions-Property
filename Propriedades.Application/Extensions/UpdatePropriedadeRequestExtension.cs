using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Application.Extensions
{
    public static class UpdatePropriedadeRequestExtension
    {
        public static Propriedade ToPropriedade(this UpdatePropriedadeRequest propriedade)
        {
            return new Propriedade
            {
                Id = Guid.Parse(propriedade.Id),
                Nome = propriedade.Nome,
                Codigo = propriedade.Codigo,
                Municipio = propriedade.Municipio,
                Estado = propriedade.Estado,
                AreaTotalHectares = propriedade.AreaTotalHectares
            };
        }
    }
}
