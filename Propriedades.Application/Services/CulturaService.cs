using Microsoft.Extensions.Logging;
using Propriedades.Application.DTOs;
using Propriedades.Application.Extensions;
using Propriedades.Application.Interfaces;
using Propriedades.Domain.Entities;
using Propriedades.Domain.Interfaces;

namespace Propriedades.Application.Services
{
    public class CulturaService : ICulturaService
    {
        private readonly ILogger<PropriedadeService> _logger;
        private readonly ICulturaRepository _culturaRepository;

        public CulturaService(ILogger<PropriedadeService> logger, ICulturaRepository culturaRepository)
        {
            _logger = logger;
            _culturaRepository = culturaRepository;
        }

        public async Task<List<CulturaResponse>> GetAllAsync()
        {
            var culturas = await _culturaRepository.GetAllAsync();

            return culturas.Select(x => x.ToCulturaResponse()).ToList();
        }

        public async Task<CulturaResponse> GetByIdAsync(Guid culturaId)
        {
            var cultura = await _culturaRepository.GetByIdAsync(culturaId);

            return cultura.ToCulturaResponse();
        }

        public async Task<CulturaResponse> AddAsync(CreateCulturaRequest request)
        {
            var cultura = request.ToCultura();

            var result = await _culturaRepository.CreateAsync(cultura);
            return result.ToCulturaResponse();
        }

        public async Task<CulturaResponse> UpdateAsync(UpdateCulturaRequest request)
        {
            var cultura = request.ToCultura();

            var result = await _culturaRepository.UpdateAsync(cultura);
            return result.ToCulturaResponse();
        }

        public async Task DeleteAsync(Guid culturaId)
        {
            await _culturaRepository.DeleteAsync(culturaId);
        }
    }
}
