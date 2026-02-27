namespace Propriedades.Application.DTOs
{
    public class SafraResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Status { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
