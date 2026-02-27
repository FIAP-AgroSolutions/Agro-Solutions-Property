namespace Propriedades.Application.DTOs
{
    public class UpdateTalhaoRequest
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public int Status { get; set; }

        public decimal AreaHectares { get; set; }

        public Guid PropriedadeId { get; set; }

        public DateTime DataPlantio { get; set; }
        public DateTime? DataColheitaPrevista { get; set; }
    }
}
