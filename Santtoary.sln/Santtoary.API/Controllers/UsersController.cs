using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Santtoary.API.DATA;
using Santtoary.Shared.DTOs;
using Santtoary.Shared.Entidades;

namespace Santtoary.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] // Protege los controladores existentes
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public UsersController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Obtener todos los usuarios para la tabla principal
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        // IMPORTANTE: Obtener un usuario por ID (necesario para EDITAR)
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // Crear un nuevo usuario desde el panel
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserDTO model)
        {
            User user = new User
            {
                UserName = model.UserName, 
                Email = model.Email,
                Rol = model.Rol,
                Photo = model.Photo
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return Ok(user);
            }

            var errorMessages = result.Errors.Select(e => e.Description).ToList();
            return BadRequest(errorMessages);
        }
        // Validar el Login
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginDTO model)
        {
            
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return BadRequest("Usuario o contraseña incorrectos."); 
            }

         
            var isPasswordValid = await _userManager.CheckPasswordAsync(user, model.Password);
            if (isPasswordValid)
            {
                return Ok(); 
            }

        
            return BadRequest("Usuario o contraseña incorrectos.");
        }

        // Actualizar un usuario existente
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            var userDb = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (userDb == null)
            {
                return NotFound();
            }

            
            userDb.UserName = user.UserName;
            userDb.Email = user.Email;
            userDb.Rol = user.Rol;
            userDb.Photo = user.Photo;

            await _context.SaveChangesAsync();
            return Ok(userDb);
        }

        // Eliminar un usuario
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}