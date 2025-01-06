using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.API.Models;
using Modelo.API.Persistence;
using Modelo.API.Services;
using Modelo.Core.Entities;

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
            var models = model.ToEntity();

            _context.Models.Add(models);
            _context.SaveChanges();
            
            return CreatedAtAction(nameof(GetById), new {id= 1}, model);
        }

        [HttpGet]
        public IActionResult Get(string search = "")
        {
            var models = _context.Models
                .Include(m=> m.Users)
                .Where(m => m.IsActive).ToList();

            var model = models.Select(ModelItemViewModel.FromEntity).ToList();
            
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var models =_context.Models
                .Include (m=> m.Users)
                .Include(m=> m.Comment)
                .SingleOrDefault(m => m.Id == id);


            if (models is null)
            {
                return NotFound();
            }

            var model = ModelViewModel.FromEntity(models);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateModelInputModel model)
        {
            var models = _context.Models.SingleOrDefault(m => m.Id == id);

            if (models is null)
            {
                return NotFound();
            }

            models.Update(model.FullName, model.Age);

            _context.Models.Update(models);
            _context.SaveChanges();

            return NoContent();

            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var models = _context.Models.SingleOrDefault(m => m.Id == id);

            if (models is null)
            {
                return NotFound();
            }
            
            models.SetAsDeleted();

            _context.Models.Update(models);
            _context.SaveChanges();

            return NoContent();
            
        }

        [HttpPost("{id}/comments")]

        public IActionResult PostComment(int id, CreateModelCommentInputModel model)
        {
            var models = _context.Models.SingleOrDefault(m => m.Id == id);

            if (models is null)
            {
                return NotFound();
            }

            var comment = new ModelComment(model.Content, model.IdModel, model.IdUser);

            _context.ModelComments.Add(comment);
            _context.SaveChanges();

            return Ok();

        }
    }
}
