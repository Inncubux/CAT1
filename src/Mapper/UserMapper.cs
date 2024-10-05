using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.DTOs;
using api.src.Models;

namespace api.src.Mapper
{
    public static class UserMapper
    {
        public static UserDto convertToUserDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                RUT = user.RUT,
                nombre = user.nombre,
                correo = user.correo,
                genero = user.genero,
                fechaNac = user.fechaNac
            };
        }

        public static User toUserDTONOID (this UserDtoNOID userDtoNOID)
        {
            return new User
            {
                RUT = userDtoNOID.RUT,
                nombre = userDtoNOID.nombre,
                correo = userDtoNOID.correo,
                genero = userDtoNOID.genero,
                fechaNac = userDtoNOID.fechaNac,
            };
        }

    }
}