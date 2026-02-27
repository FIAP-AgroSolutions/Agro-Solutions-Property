using Microsoft.AspNetCore.Mvc;
using Propriedades.Application.DTOs;
using Propriedades.Application.Interfaces;
using Propriedades.Application.Services;

namespace Propriedades.Api.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class CulturaController : BaseController
    {
        private readonly ICulturaService _culturaService;
        private readonly ILogger<CulturaController> _logger;

        public CulturaController(ICulturaService culturaService, ILogger<CulturaController> logger)
        {
            _culturaService = culturaService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<CulturaResponse>>> GetAll()
        {
            try
            {
                var result = await _culturaService.GetAllAsync();

                if (result is not null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching cultura.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [HttpGet("{propriedadeId}")]
        public async Task<ActionResult<List<CulturaResponse>>> GetById(Guid propriedadeId)
        {
            try
            {
                var result = await _culturaService.GetByIdAsync(propriedadeId);

                if (result is not null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching cultura.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [HttpPost]
        public async Task<ActionResult<CulturaResponse>> Add([FromBody] CreateCulturaRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _culturaService.AddAsync(request);

                if (result is not null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing cultura add.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [HttpPut]
        public async Task<ActionResult<CulturaResponse>> Update([FromBody] UpdateCulturaRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _culturaService.UpdateAsync(request);

                if (result is not null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing cultura update.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [HttpDelete("{propriedadeId}")]
        public async Task<ActionResult> Delete(Guid propriedadeId)
        {
            try
            {
                await _culturaService.DeleteAsync(propriedadeId);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing cultura delete.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }
    }
}
