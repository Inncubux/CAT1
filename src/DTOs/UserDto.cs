using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.src.DTOs
{
    public class UserDto
    {
        public required int Id {get;set;}
        public required string RUT {get;set;} = string.Empty;
        [StringLength(100, MinimumLength = 3)]
        public required string nombre {get;set;} = string.Empty;
        public required string correo {get;set;} = string.Empty;
        [RegularExpression(@"Masculino|Femenino|prefiero no decirlo")]
        public required string genero {get;set;} = string.Empty;
        public required DateTime fechaNac {get;set;}
    }
}