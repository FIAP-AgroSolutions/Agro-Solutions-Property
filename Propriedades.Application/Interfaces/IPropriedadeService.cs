using Propriedades.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Application.Interfaces
{
    public interface IPropriedadeService
    {
        Task<PropriedadeResponse> GetByIdAsync(Guid propriedadeId);
        Task<PropriedadeResponse> AddAsync(CreatePropriedadeRequest request);
        Task<PropriedadeResponse> UpdateAsync(UpdatePropriedadeRequest request);
        Task DeleteAsync(Guid propriedadeId);
        Task<PropriedadeResponse> AddTalhaoAsync(Guid talhaoId);
        Task DeleteTalhaoAsync(Guid talhaoId);

    }
}
