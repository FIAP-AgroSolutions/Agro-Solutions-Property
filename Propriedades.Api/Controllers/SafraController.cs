using Microsoft.AspNetCore.Mvc;
using Propriedades.Application.DTOs;
using Propriedades.Application.Interfaces;

namespace Propriedades.Api.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class SafraController : BaseController
    {
        private readonly ISafraService _safraService;
        private readonly ILogger<SafraController> _logger;

        public SafraController(ISafraService safraService, ILogger<SafraController> logger)
        {
            _safraService = safraService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<SafraResponse>>> GetAll()
        {
            try
            {
                var result = await _safraService.GetAllAsync();

                if (result is not null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching safra.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [HttpGet("{propriedadeId}")]
        public async Task<ActionResult<List<SafraResponse>>> GetById(Guid propriedadeId)
        {
            try
            {
                var result = await _safraService.GetByIdAsync(propriedadeId);

                if (result is not null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching safra.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [HttpPost]
        public async Task<ActionResult<SafraResponse>> Add([FromBody] CreateSafraRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _safraService.AddAsync(request);

                if (result is not null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing safra add.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [HttpPut]
        public async Task<ActionResult<SafraResponse>> Update([FromBody] UpdateSafraRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _safraService.UpdateAsync(request);

                if (result is not null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing safra update.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [HttpDelete("{propriedadeId}")]
        public async Task<ActionResult> Delete(Guid propriedadeId)
        {
            try
            {
                await _safraService.DeleteAsync(propriedadeId);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing safra delete.");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }
    }
}
