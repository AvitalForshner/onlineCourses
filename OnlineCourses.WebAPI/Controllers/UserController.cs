using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineCourses.Core.DTO;
using OnlineCourses.Core.Entities;
using OnlineCourses.Core.Services;
using OnlineCourses.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: api/<UsersController>
        [HttpGet]
        [Authorize]
        public IEnumerable<UserDTO> Get()
        {
            return _userService.GetList();
        }

        // GET api/<UsersController>/5
        //[HttpGet("{id}")]
        //public User Get(int id)
        //{
        //    return _context.Users.Find(user => user.Id == id);
        //}

        //// POST api/<UsersController>
        //[HttpPost]
        //public void Post([FromBody] User user)
        //{
        //    _context.Users.Add(user);
        //}

        //// PUT api/<UsersController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] User updated)
        //{
        //    User u = _context.Users.Find(user => user.Id == id);
        //    if (u != null)
        //    {
        //        u.Name = updated.Name;
        //        u.Email = updated.Email;
        //        u.Role = updated.Role;
        //    }
        //}

        //// DELETE api/<UsersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    User u = _context.Users.Find(user => user.Id == id);
        //    if (u != null)
        //        _context.Users.Remove(u);
        //}
    }
}
