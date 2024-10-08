using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Bogus.DataSets;

namespace api.src.Models
{
    public class User
    {
        public int Id {get;set;}
        public string RUT {get;set;} = string.Empty;
        [StringLength(100, MinimumLength = 3)]
        public required string nombre {get;set;} = string.Empty;
        public string correo {get;set;} = string.Empty;
        [RegularExpression(@"Masculino|Femenino|prefiero no decirlo")]
        public required string genero {get;set;} = string.Empty;
        public DateTime fechaNac {get;set;}

    }
}