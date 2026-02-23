using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Propriedades.Application.DTOs;
using Propriedades.Application.Interfaces;

namespace Propriedades.Api.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class PropriedadeController : BaseController
    {
        private readonly IPropriedadeService _propriedadeService;
        private readonly ILogger<PropriedadeController> _logger;

        public PropriedadeController(IPropriedadeService propriedadeService, ILogger<PropriedadeController> _logger)
        {
            _propriedadeService = propriedadeService;
            _propriedadeService = propriedadeService;
        }

        [HttpGet("{propriedadeId}")]
        public async Task<ActionResult<List<PropriedadeResponse>>> GetById(Guid propriedadeId)
        {
            try
            {
                var result = await _propriedadeService.GetByIdAsync(propriedadeId);

                if (result is not null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching propriedade.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [HttpPost]
        public async Task<ActionResult<PropriedadeResponse>> Add([FromBody] CreatePropriedadeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _propriedadeService.AddAsync(request);

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

        [HttpPut]
        public async Task<ActionResult<PropriedadeResponse>> Update([FromBody] UpdatePropriedadeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _propriedadeService.UpdateAsync(request);

                if (result is not null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing propriedade update.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [HttpDelete("{propriedadeId}")]
        public async Task<ActionResult> Delete(Guid propriedadeId)
        {
            try
            {
                await _propriedadeService.DeleteAsync(propriedadeId);
                
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing propriedade delete.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }
    }
}
