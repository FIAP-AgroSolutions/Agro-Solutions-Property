using Microsoft.AspNetCore.Mvc;
using Propriedades.Application.DTOs;
using Propriedades.Application.Interfaces;
using Propriedades.Application.Services;

namespace Propriedades.Api.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class TalhaoSafraCulturaController : BaseController
    {
        private readonly ITalhaoSafraCulturaService _talhaoSafraCulturaService;
        private readonly ILogger<TalhaoSafraCulturaController> _logger;

        public TalhaoSafraCulturaController(ITalhaoSafraCulturaService propriedadeService,
            ILogger<TalhaoSafraCulturaController> logger)
        {
            _talhaoSafraCulturaService = propriedadeService;
            _logger = logger;
        }


        [HttpPost]
        public async Task<ActionResult<PropriedadeResponse>> Add([FromBody] CreateTalhaoSafraCulturaRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _talhaoSafraCulturaService.AddAsync(request);

                if (result is not null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing propriedade add.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

    }
}
