using Microsoft.AspNetCore.Mvc;
using Suz.Projetos.Domain.Dto;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubcategoriaController : ControllerBase
    {
        private readonly ISubcategoriaService _subcategoriaService;

        public SubcategoriaController(ISubcategoriaService subcategoriaService)
        {
            _subcategoriaService = subcategoriaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _subcategoriaService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateSubcategoriaDTO subcategoriadto)
        {
            try
            {
                await _subcategoriaService.Create(subcategoriadto);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
