using Propriedades.Application.DTOs;

namespace Propriedades.Application.Interfaces
{
    public interface ICulturaService
    {
        Task<List<CulturaResponse>> GetAllAsync();
        Task<CulturaResponse> GetByIdAsync(Guid culturaId);
        Task<CulturaResponse> AddAsync(CreateCulturaRequest request);
        Task<CulturaResponse> UpdateAsync(UpdateCulturaRequest request);
        Task DeleteAsync(Guid culturaId);
    }
}
