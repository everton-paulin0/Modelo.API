using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.API.Models;
using Modelo.API.Persistence;
using Modelo.Core.Entities;
using System.Runtime.InteropServices;

namespace Modelo.API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ModelDbContext _context;
        public UsersController(ModelDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {
            var user = new User(model.UserName, model.EmailAddress, model.Level, model.IsActive);

            _context.Users.Add(user);

            
            return NoContent();
        }

        [HttpGet]
        public IActionResult Get(string search)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id ==id);

            if (user is null)
            {
                return NotFound();
            }

            var model =UserViemModel.FromEntity(user);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateModelInputModel model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
