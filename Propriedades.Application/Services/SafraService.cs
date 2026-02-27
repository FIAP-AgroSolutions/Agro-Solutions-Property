using Microsoft.Extensions.Logging;
using Propriedades.Application.DTOs;
using Propriedades.Application.Extensions;
using Propriedades.Application.Interfaces;
using Propriedades.Domain.Interfaces;

namespace Propriedades.Application.Services
{
    public class SafraService : ISafraService
    {
        private readonly ILogger<SafraService> _logger;
        private readonly ISafraRepository _safraRepository;

        public SafraService(ILogger<SafraService> logger, ISafraRepository safraRepository)
        {
            _logger = logger;
            _safraRepository = safraRepository;
        }

        public async Task<List<SafraResponse>> GetAllAsync()
        {
            var safra = await _safraRepository.GetAllAsync();

            return safra.Select(x => x.ToSafraResponse()).ToList();
        }

        public async Task<SafraResponse> GetByIdAsync(Guid safraId)
        {
            var safra = await _safraRepository.GetByIdAsync(safraId);

            return safra.ToSafraResponse();
        }

        public async Task<SafraResponse> AddAsync(CreateSafraRequest request)
        {
            var safra = request.ToSafra();

            var result = await _safraRepository.CreateAsync(safra);
            return result.ToSafraResponse();
        }

        public async Task<SafraResponse> UpdateAsync(UpdateSafraRequest request)
        {
            var safra = request.ToSafra();

            var result = await _safraRepository.UpdateAsync(safra);
            return result.ToSafraResponse();
        }

        public async Task DeleteAsync(Guid safraId)
        {
            await _safraRepository.DeleteAsync(safraId);
        }
    }
}
