using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.API.Models;
using Modelo.API.Persistence;
using Modelo.API.Services;

namespace Modelo.API.Controllers
{
    [Route("api/modelo")]
    [ApiController]
    public class ModelosController : ControllerBase
    {
        private readonly IConfigService _configService;
        private readonly ModelDbContext _context;

        public ModelosController(IConfigService configService , ModelDbContext context)
        {
            _configService = configService;
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(CreateModeloInputModel model)
        {
            return CreatedAtAction(nameof(GetById), new {id= 1}, model);
        }

        [HttpGet]
        public IActionResult Get(string search)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            throw new Exception();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateModelInputModel model)
        {
            return NoContent ();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
