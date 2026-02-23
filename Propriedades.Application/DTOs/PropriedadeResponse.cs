namespace Propriedades.Application.DTOs
{
    public class PropriedadeResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public decimal AreaTotalHectares { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
