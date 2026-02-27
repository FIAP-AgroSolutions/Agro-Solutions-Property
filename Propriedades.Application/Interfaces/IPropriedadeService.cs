using Propriedades.Application.DTOs;

namespace Propriedades.Application.Interfaces
{
    public interface IPropriedadeService
    {
        Task<List<PropriedadeResponse>> GetAllAsync();
        Task<PropriedadeResponse> GetByIdAsync(Guid propriedadeId);
        Task<PropriedadeResponse> AddAsync(CreatePropriedadeRequest request);
        Task<PropriedadeResponse> UpdateAsync(UpdatePropriedadeRequest request);
        Task DeleteAsync(Guid propriedadeId);
        Task<PropriedadeResponse> AddTalhaoAsync(Guid talhaoId);
        Task DeleteTalhaoAsync(Guid talhaoId);

    }
}
