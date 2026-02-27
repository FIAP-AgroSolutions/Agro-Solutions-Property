using Microsoft.Extensions.Logging;
using Propriedades.Application.DTOs;
using Propriedades.Application.Extensions;
using Propriedades.Application.Interfaces;
using Propriedades.Domain.Entities;
using Propriedades.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Application.Services
{
    public class TalhaoService : ITalhaoService
    {
        private readonly ILogger<TalhaoService> _logger;
        private readonly ITalhaoRepository _talhaoRepository;

        public TalhaoService(ILogger<TalhaoService> logger, ITalhaoRepository talhaoRepository)
        {
            _logger = logger;
            _talhaoRepository = talhaoRepository;
        }

        public async Task<List<TalhaoResponse>> GetAllAsync()
        {
            var talhoes = await _talhaoRepository.GetAllAsync();

            return talhoes.Select(x => x.ToTalhaoResponse()).ToList();
        }

        public async Task<TalhaoResponse> GetByIdAsync(Guid talhaoId)
        {
            var talhao = await _talhaoRepository.GetByIdAsync(talhaoId);

            return talhao.ToTalhaoResponse();
        }

        public async Task<TalhaoResponse> AddAsync(CreateTalhaoRequest request)
        {
            var talhao = request.ToTalhao();

            var result = await _talhaoRepository.CreateAsync(talhao);
            return result.ToTalhaoResponse();
        }

        public async Task<TalhaoResponse> UpdateAsync(UpdateTalhaoRequest request)
        {
            var talhao = request.ToTalhao();

            var result = await _talhaoRepository.UpdateAsync(talhao);
            return result.ToTalhaoResponse();
        }

        public async Task DeleteAsync(Guid talhaoId)
        {
            await _talhaoRepository.DeleteAsync(talhaoId);
        }

        public async Task<DeleteResponse> AddCulturaSafraAsync(Guid talhaoId)
        {
            throw new NotImplementedException();
        }

        public async Task<DeleteResponse> DeleteCulturaSafraAsync(Guid culturaSafraId)
        {
            throw new NotImplementedException();
        }

        public async Task<DeleteResponse> UpdateCulturaSafraAsync(Guid talhaoId)
        {
            throw new NotImplementedException();
        }
    }
}
