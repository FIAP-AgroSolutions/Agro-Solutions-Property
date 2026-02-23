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
        Task<TalhaoResponse> GetByIdAsync(string talhaoId);
        Task<TalhaoResponse> AddAsync(TalhaoRequest request);
        Task<TalhaoResponse> UpdateAsync(TalhaoRequest request);
        Task<DeleteResponse> DeleteAsync(string talhaoId);
        Task<DeleteResponse> AddCulturaSafraAsync(string talhaoId);
        Task<DeleteResponse> UpdateCulturaSafraAsync(string talhaoId);
        Task<DeleteResponse> DeleteCulturaSafraAsync(string culturaSafraId);
    }
}
