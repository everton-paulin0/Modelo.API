using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.API.Models;
using Modelo.API.Persistence;
using Modelo.Core.Entities;

namespace Modelo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ModelDbContext _context;
        public PersonController(ModelDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(CreatePersonInputModel people)
        {
            //var person = people.ToEntity();
            var person = new Person(people.FullName, people.DocumentNumber, people.BirthDate, people.UserId);

            _context.People.Add(person);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet]
        public IActionResult Get(string search = "")
        {
            var people = _context.People
                .Include(p => p.User)
                .Where(p => !p.IsDeleted).ToList();

            var model = people.Select(PersonItemViewModel.FromEntity).ToList();

            return Ok(people);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var people =_context.People
                .Include (p => p.User)
                .Include(p => p.Comments)
                .SingleOrDefault(p=> p.Id ==id);

            var model = PersonItemViewModel.FromEntity(people);


            return Ok(people);
        }

        [HttpPut]
        public IActionResult Put(int id, UpdatePersonInputModel people)
        {
            var person = _context.People.SingleOrDefault(p => p.Id == id);

            if (person is null)
            {
                return NotFound();
            }

            person.Update(people.FullName, people.DocumentNumber, people.BirthDate);

            _context.People.Update(person);
            _context.SaveChanges();
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var person = _context.People.SingleOrDefault(p => p.Id == id);

            if (person is null)
            {
                return NotFound();
            }

            person.SetAsDeleted();
            _context.People.Update(person);
            _context.SaveChanges();

            return NoContent();

        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, CreateModelCommentInputModel model)
        {
            var person = _context.People.SingleOrDefault(p=> p.Id == id);

            if (person is null)
            {
                return NotFound();
            }

            var comment = new ModelComment(model.Content, model.PersonId, model.UserId);

            _context.ModelComments.Add(comment);
            _context.SaveChanges();

            return Ok();

        }
    }
}
