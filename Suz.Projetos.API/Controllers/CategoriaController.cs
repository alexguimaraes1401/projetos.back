using Microsoft.AspNetCore.Mvc;
using Suz.Projetos.Domain.Dto;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaRepository categoriaRepository, ICategoriaService categoriaService)
        {
            _categoriaRepository = categoriaRepository;
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _categoriaRepository.GetAllAsync();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCategoriaDTO categoriadto)
        {
            try
            {
                await _categoriaService.Create(categoriadto);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
