 using Propriedades.Domain.Enums;

namespace Propriedades.Domain.Entities
{
    public class Safra
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public StatusSafra Status { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public ICollection<TalhaoSafraCultura> TalhoesSafra { get; set; }
    }
}
