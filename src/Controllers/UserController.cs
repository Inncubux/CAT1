using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.Data;
using api.src.DTOs;
using api.src.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.src.Controllers
{
    [Route("api/user")]
    [ApiController]
   public class UserController : ControllerBase
    {
      private readonly ApplicationDBcontext _context;

      public UserController(ApplicationDBcontext context){
         _context = context;
      }

      [HttpPost("")]
      public async Task<IActionResult> CrearUsuario(CreateUserDto userDto){
        if (userDto.fechaNac >= DateTime.Now){
         return BadRequest("La fecha de nacimiento debe ser anterior a la fecha actual.");
        }

        if (_context.Users.Any(u => u.RUT == userDto.RUT))
         {
            return Conflict("El RUT ya esta registrado.");
         }

         var user = new User
         {
            RUT = userDto.RUT,
            nombre = userDto.nombre,
            correo = userDto.correo,
            genero = userDto.genero,
            fechaNac = userDto.fechaNac
         };
         await _context.Users.AddAsync(user);
         await _context.SaveChangesAsync();
         return CreatedAtAction(nameof(CrearUsuario), new { id = user.Id }, user);
      }
   }
}