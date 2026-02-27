using Microsoft.Extensions.Logging;
using Propriedades.Application.DTOs;
using Propriedades.Application.Extensions;
using Propriedades.Application.Interfaces;
using Propriedades.Domain.Interfaces;

namespace Propriedades.Application.Services
{
    public class PropriedadeService : IPropriedadeService
    {
        private readonly ILogger<PropriedadeService> _logger;
        private readonly IPropriedadeRepository _propriedadeRepository;

        public PropriedadeService(ILogger<PropriedadeService> logger, IPropriedadeRepository propriedadeRepository)
        {
            _logger = logger;
            _propriedadeRepository = propriedadeRepository;
        }

        public async Task<List<PropriedadeResponse>> GetAllAsync()
        {
            var propriedades = await _propriedadeRepository.GetAllAsync();
            
            return propriedades.Select(x => x.ToPropriedadeResponse()).ToList();
        }

        public async Task<PropriedadeResponse> GetByIdAsync(Guid propriedadeId)
        {
            var propriedade = await _propriedadeRepository.GetByIdAsync(propriedadeId);

            return propriedade.ToPropriedadeResponse();
        }

        public async Task<PropriedadeResponse> AddAsync(CreatePropriedadeRequest request)
        {
            var propriedade = request.ToPropriedade();

            var result = await _propriedadeRepository.CreateAsync(propriedade);
            return result.ToPropriedadeResponse();
        }

        public async Task<PropriedadeResponse> UpdateAsync(UpdatePropriedadeRequest request)
        {
            var propriedade = request.ToPropriedade();

            var result = await _propriedadeRepository.UpdateAsync(propriedade);
            return result.ToPropriedadeResponse();
        }

        public async Task DeleteAsync(Guid propriedadeId)
        {
            await _propriedadeRepository.DeleteAsync(propriedadeId);
        }

        public async Task<PropriedadeResponse> AddTalhaoAsync(Guid talhaoId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteTalhaoAsync(Guid talhaoId)
        {
            throw new NotImplementedException();
        }

    }
}
