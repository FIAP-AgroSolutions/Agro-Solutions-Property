using Propriedades.Domain.Enums;

namespace Propriedades.Application.DTOs
{
    public class CulturaResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public TipoCultura Tipo { get; set; }
        public int CicloDias { get; set; }
    }
}
