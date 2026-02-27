using Propriedades.Domain.Enums;

namespace Propriedades.Application.DTOs
{
    public class UpdateCulturaRequest
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public TipoCultura Tipo { get; set; }
        public int CicloDias { get; set; }
    }
}
