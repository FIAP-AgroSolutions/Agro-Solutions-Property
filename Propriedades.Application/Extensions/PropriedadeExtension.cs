using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;

namespace Propriedades.Application.Extensions
{
    public static class PropriedadeExtension
    {
        public static PropriedadeResponse ToPropriedadeResponse(this Propriedade propriedade)
        {
            return new PropriedadeResponse 
            {
                Id = propriedade.Id,
                Nome = propriedade.Nome,
                Codigo = propriedade.Codigo,
                Municipio = propriedade.Municipio,
                Estado = propriedade.Estado,
                AreaTotalHectares = propriedade.AreaTotalHectares,
                DataCadastro = propriedade.DataCadastro
            };
        }
    }
}
