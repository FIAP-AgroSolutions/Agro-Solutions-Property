using Propriedades.Application.DTOs;
using Propriedades.Domain.Entities;

namespace Propriedades.Application.Extensions
{
    public static class CreatePropriedadeRequestExtension
    {
        public static Propriedade ToPropriedade(this CreatePropriedadeRequest propriedade)
        {
            return new Propriedade {
                Id = Guid.NewGuid(),
                Nome = propriedade.Nome,
                Codigo = propriedade.Codigo,
                Municipio = propriedade.Municipio,
                Estado = propriedade.Estado,
                AreaTotalHectares = propriedade.AreaTotalHectares,
                DataCadastro = DateTime.Now
            };
        }
    }
}
