using Microsoft.AspNetCore.Mvc;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;
using Suz.Projetos.Domain.Dto;
using Suz.Projetos.Service;
using Suz.Projetos.Respository;

namespace Suz.Projetos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjetosController : ControllerBase
    {
        private readonly IProjetoRepository _projetoRepository;
        private readonly IProjetoService _projetoService;

        public ProjetosController(IProjetoRepository projetoRepository, IProjetoService projetoService)
        {
            _projetoRepository = projetoRepository;
            _projetoService = projetoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _projetoService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProjetoDTO projetoDto)
        {
            try
            {
                await _projetoService.Create(projetoDto);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("filter")]
        public async Task<IActionResult> FiltrarProjetos([FromQuery] int? categoriaId, [FromQuery] int? subcategoriaId)
        {
            var projetos = await _projetoService.FiltrarProjetosAsync(categoriaId, subcategoriaId);
            return Ok(projetos);
        }

    }
}
