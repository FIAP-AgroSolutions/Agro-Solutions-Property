using Propriedades.Application.DTOs;

namespace Propriedades.Application.Interfaces
{
    public interface ITalhaoSafraCulturaService
    {
        Task<List<TalhaoSafraCulturaResponse>> GetAllAsync();
        Task<TalhaoSafraCulturaResponse> GetByIdAsync(Guid propriedadeId);
        Task<TalhaoSafraCulturaResponse> AddAsync(CreateTalhaoSafraCulturaRequest request);
        Task<TalhaoSafraCulturaResponse> UpdateAsync(UpdateTalhaoSafraCulturaRequest request);
        Task DeleteAsync(Guid talhaoSafraCulturaResponseId);
    }
}
