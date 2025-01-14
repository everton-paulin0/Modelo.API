using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.API.Models;
using Modelo.API.Persistence;
using Modelo.Core.Entities;
using System;
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
        public IActionResult Post(CreateUserInputModel users)
        {
            var user = new User(users.UserName, users.EmailAddress);

            _context.Users.Add(user);
            _context.SaveChanges();

            
            return NoContent();
        }

        [HttpGet]
        public IActionResult Get(string search = "")
        {
            var users = _context.Users
                .Include(p => p.OwnedPeople)
               .Where(p => !p.IsDeleted).ToList();

            var model = users.Select(UserItemViemModel.FromEntity).ToList();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id ==id);

            if (user is null)
            {
                return NotFound();
            }

            var model =UserItemViemModel.FromEntity(user);

            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateUserInputModel model)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);

            if (user is null)
            {
                return NotFound();
            }

            user.Update(user.UserName, user.EmailAddress);

            _context.Users.Update(user);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);

            if (user is null)
            {
                return NotFound();
            }
            user.SetAsDeleted();
            _context.Users.Update(user);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
