using Microsoft.AspNetCore.Mvc;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjetosController : ControllerBase
    {
        private readonly IProjetoRepository _projetoRepository;

        public ProjetosController(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _projetoRepository.GetAllAsync();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Projeto projeto)
        {
            try
            {
                await _projetoRepository.SaveAsync(projeto);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
