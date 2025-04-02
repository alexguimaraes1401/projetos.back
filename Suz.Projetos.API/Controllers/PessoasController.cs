using Microsoft.AspNetCore.Mvc;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoasController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _pessoaRepository.GetAllAsync();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Pessoa pessoa)
        {
            try
            {
                await _pessoaRepository.SaveAsync(pessoa);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
