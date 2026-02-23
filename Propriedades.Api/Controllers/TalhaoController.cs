using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Propriedades.Application.DTOs;
using Propriedades.Application.Interfaces;

namespace Propriedades.Api.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class TalhaoController : Controller
    {
        private readonly ITalhaoService _talhaoService;
        private readonly ILogger<PropriedadeController> _logger;

        public TalhaoController(ITalhaoService talhaoService, ILogger<PropriedadeController> logger)
        {
            _talhaoService = talhaoService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<TalhaoResponse>> Add([FromBody] TalhaoRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _talhaoService.AddAsync(request);

                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing talhão add.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }
    }
}
