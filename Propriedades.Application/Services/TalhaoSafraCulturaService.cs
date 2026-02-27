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
    public class TalhaoSafraCulturaService : ITalhaoSafraCulturaService
    {
        private readonly ILogger<TalhaoSafraCulturaService> _logger;
        private readonly ITalhaoSafraCulturaRepository _talhaoSafraCulturaRepository;

        public TalhaoSafraCulturaService(ILogger<TalhaoSafraCulturaService> logger,
            ITalhaoSafraCulturaRepository talhaoSafraCulturaRepository)
        {
            _logger = logger;
            _talhaoSafraCulturaRepository = talhaoSafraCulturaRepository;
        }

        public async Task<List<TalhaoSafraCulturaResponse>> GetAllAsync()
        {
            var talhaoSafraCultura = await _talhaoSafraCulturaRepository.GetAllAsync();

            return talhaoSafraCultura.Select(x => x.ToTalhaoSafraCulturaResponse()).ToList();
        }

        public async Task<TalhaoSafraCulturaResponse> GetByIdAsync(Guid talhaoSafraCulturaId)
        {
            var talhaoSafraCultura = await _talhaoSafraCulturaRepository.GetByIdAsync(talhaoSafraCulturaId);

            return talhaoSafraCultura.ToTalhaoSafraCulturaResponse();
        }

        public async Task<TalhaoSafraCulturaResponse> AddAsync(CreateTalhaoSafraCulturaRequest request)
        {
            var talhaoSafraCultura = request.ToTalhaoSafraCultura();

            var result = await _talhaoSafraCulturaRepository.CreateAsync(talhaoSafraCultura);
            return result.ToTalhaoSafraCulturaResponse();
        }


        public async Task<TalhaoSafraCulturaResponse> UpdateAsync(UpdateTalhaoSafraCulturaRequest request)
        {
            var talhaoSafraCultura = request.ToTalhaoSafraCultura();

            var result = await _talhaoSafraCulturaRepository.UpdateAsync(talhaoSafraCultura);
            return result.ToTalhaoSafraCulturaResponse();
        }

        public async Task DeleteAsync(Guid talhaoSafraCulturaResponseId)
        {
            await _talhaoSafraCulturaRepository.DeleteAsync(talhaoSafraCulturaResponseId);
        }
    }
}
