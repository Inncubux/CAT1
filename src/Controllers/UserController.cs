using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.Data;
using api.src.DTOs;
using api.src.Interfaces;
using api.src.Models;
using Bogus.DataSets;
using api.src.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace api.src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   public class UserController : ControllerBase
    {
      private readonly iUserRepository _userRepository;
      
      public UserController(iUserRepository userRepository){
         _userRepository = userRepository;
      }

      [HttpPost]
      public async Task<ActionResult> CreateUser([FromBody]UserDtoNOID userDto){
         
         var user = await _userRepository.GetUser(userDto.RUT);
         if(user != null){
            return Conflict("El RUT ya existe.");
         }
         
         if (userDto.nombre.Length < 3 || userDto.nombre.Length > 100) {
            return BadRequest("El nombre debe tener un mínimo de 3 letras y un máximo de 100");
         }
         
         if (!isValidEmail(userDto.correo)){
            return BadRequest("La fecha de nacimiento debe ser anterior a la fecha actual.");
         }

          if(userDto.genero != "Masculino" || userDto.genero != "Femenino" || userDto.genero != "Otro" || userDto.genero != "No especificado")
         {
            return BadRequest("El género ingresado no es Femenino, Masculino, otro o no especificado");
         }

          if(userDto.fechaNac >= DateTime.Now){
            return BadRequest("La fecha de nacimiento debe ser anterior a la fecha actual");
        }

        var newUser = userDto.toUserDTONOID();
        await _userRepository.CreateUser(newUser);

        return StatusCode(201, "Usuario creado exitosamente.");
      
      }

      public async Task<IActionResult> DeleteUser([FromRoute] int id){
        // var user = await _userRepository.DeleteUser(id);
         if(user == null){
            return NotFound("Usuario no encontrado");
         }


         return Ok("Usuario eliminado correctamente");
      }
















// Método para validar el correo eléctronico
        private bool isValidEmail(string correo)
        {
            try{
               var mial = new System.Net.Mail.MailAddress(correo);
               return mial.Address == correo;
            }
            catch{
               return false;
            }
         }
      }
}