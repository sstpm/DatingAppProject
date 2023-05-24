using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // GET (localhost)/api/users
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context; // Convention: private fields are prefixed with '_'

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        // Wrapping inside ActionResult allows for returning HTTP codes as well as our data
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        // {id} is a kind of variable marker
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }
    }
}