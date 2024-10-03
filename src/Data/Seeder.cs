using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.Models;
using Bogus.Extensions.UnitedKingdom;
using Microsoft.OpenApi.Writers;
using static System.Formats.Asn1.AsnWriter;

namespace api.src.Data
{
    public static class Seeder
    {
        public static async Task SeedAsync(ApplicationDBcontext context){
        

            if (!context.Users.Any()){
        
                context.Users.AddRange(
            
                    new User
                    {
                        Id = 1,
                        RUT = "12345678-9",
                        nombre = "Juan Pérez",
                        correo = "juan.perez@mail.com",
                        genero = "Masculino",
                        fechaNac = "1980-01-01"
                    },
                    new User
                    {
                        Id = 2,
                        RUT = "98765432-1",
                        nombre = "Ana Gómez",
                        correo = "ana.gomez@mail.com",
                        genero = "Femenino",
                        fechaNac = "1990-02-15"
                    },
                    new User
                    {
                        Id = 3,
                        RUT = "11223344-5",
                        nombre = "Carlos Ramírez",
                        correo = "carlos.ramirez@mail.com",
                        genero = "Masculino",
                        fechaNac = "1975-03-10"
                    },
                    new User
                    {
                        Id = 4,
                        RUT = "55667788-9",
                        nombre = "María López",
                        correo = "maria.lopez@mail.com",
                        genero = "Femenino",
                        fechaNac = "1985-04-22"
                    },
                    new User
                    {
                        Id = 5,
                        RUT = "66778899-0",
                        nombre = "Pedro González",
                        correo = "pedro.gonzalez@mail.com",
                        genero = "Masculino",
                        fechaNac = "1993-05-30"
                    },
                    new User
                    {
                        Id = 6,
                        RUT = "77889900-1",
                        nombre = "Laura Fernández",
                        correo = "laura.fernandez@mail.com",
                        genero = "Femenino",
                        fechaNac = "1992-06-18"
                    },
                    new User
                    {
                        Id = 7,
                        RUT = "88990011-2",
                        nombre = "Sofía Vargas",
                        correo = "sofia.vargas@mail.com",
                        genero = "Femenino",
                        fechaNac = "1988-07-25"
                    },
                    new User
                    {
                        Id = 8,
                        RUT = "99001122-3",
                        nombre = "Ricardo Castillo",
                        correo = "ricardo.castillo@mail.com",
                        genero = "Masculino",
                        fechaNac = "1979-08-30"
                    },
                    new User
                    {
                        Id = 9,
                        RUT = "00112233-4",
                        nombre = "Daniela Espinoza",
                        correo = "daniela.espinoza@mail.com",
                        genero = "Femenino",
                        fechaNac = "1986-09-14"
                    },
                    new User
                    {
                        Id = 10,
                        RUT = "11223344-6",
                        nombre = "Felipe Martínez",
                        correo = "felipe.martinez@mail.com",
                        genero = "Masculino",
                        fechaNac = "1995-10-05"
                    }
                );
                await context.SaveChangesAsync();
            }
        }
    }
}