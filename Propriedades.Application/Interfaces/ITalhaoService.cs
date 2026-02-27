using Propriedades.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Application.Interfaces
{
    public interface ITalhaoService
    {
        Task<List<TalhaoResponse>> GetAllAsync();
        Task<TalhaoResponse> GetByIdAsync(Guid talhaoId);
        Task<TalhaoResponse> AddAsync(CreateTalhaoRequest request);
        Task<TalhaoResponse> UpdateAsync(UpdateTalhaoRequest request);
        Task DeleteAsync(Guid talhaoId);
        Task<DeleteResponse> AddCulturaSafraAsync(Guid talhaoId);
        Task<DeleteResponse> UpdateCulturaSafraAsync(Guid talhaoId);
        Task<DeleteResponse> DeleteCulturaSafraAsync(Guid culturaSafraId);
    }
}
