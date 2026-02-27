using Propriedades.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Application.Interfaces
{
    public interface ISafraService
    {
        Task<List<SafraResponse>> GetAllAsync();
        Task<SafraResponse> GetByIdAsync(Guid propriedadeId);
        Task<SafraResponse> AddAsync(CreateSafraRequest request);
        Task<SafraResponse> UpdateAsync(UpdateSafraRequest request);
        Task DeleteAsync(Guid propriedadeId);
    }
}
