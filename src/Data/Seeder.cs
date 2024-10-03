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
            await context.Users.AddAsync(new User
                {
                    Id = 1,
                    RUT = "12345678-9",
                    nombre = "Juan Pérez",
                    correo = "juan.perez@mail.com",
                    genero = "Masculino",
                    fechaNac = new DateTime(1980, 1, 1)
                });

                await context.Users.AddAsync(new User
                {
                    Id = 2,
                    RUT = "98765432-1",
                    nombre = "Ana Gómez",
                    correo = "ana.gomez@mail.com",
                    genero = "Femenino",
                    fechaNac = new DateTime(1990, 2, 15)
                });

                await context.Users.AddAsync(new User
                {
                    Id = 3,
                    RUT = "11223344-5",
                    nombre = "Carlos Ramírez",
                    correo = "carlos.ramirez@mail.com",
                    genero = "Masculino",
                    fechaNac = new DateTime(1975, 3, 10)
                });

                await context.Users.AddAsync(new User
                {
                    Id = 4,
                    RUT = "55667788-9",
                    nombre = "María López",
                    correo = "maria.lopez@mail.com",
                    genero = "Femenino",
                    fechaNac = new DateTime(1985, 4, 22)
                });

                await context.Users.AddAsync(new User
                {
                    Id = 5,
                    RUT = "66778899-0",
                    nombre = "Pedro González",
                    correo = "pedro.gonzalez@mail.com",
                    genero = "Masculino",
                    fechaNac = new DateTime(1993, 5, 30)
                });

                await context.Users.AddAsync(new User
                {
                    Id = 6,
                    RUT = "77889900-1",
                    nombre = "Laura Fernández",
                    correo = "laura.fernandez@mail.com",
                    genero = "Femenino",
                    fechaNac = new DateTime(1992, 6, 18)
                });

                await context.Users.AddAsync(new User
                {
                    Id = 7,
                    RUT = "88990011-2",
                    nombre = "Sofía Vargas",
                    correo = "sofia.vargas@mail.com",
                    genero = "Femenino",
                    fechaNac = new DateTime(1988, 7, 25)
                });

                await context.Users.AddAsync(new User
                {
                    Id = 8,
                    RUT = "99001122-3",
                    nombre = "Ricardo Castillo",
                    correo = "ricardo.castillo@mail.com",
                    genero = "Masculino",
                    fechaNac = new DateTime(1979, 8, 30)
                });

                await context.Users.AddAsync(new User
                {
                    Id = 9,
                    RUT = "00112233-4",
                    nombre = "Daniela Espinoza",
                    correo = "daniela.espinoza@mail.com",
                    genero = "Femenino",
                    fechaNac = new DateTime(1986, 9, 14)
                });

                await context.Users.AddAsync(new User
                {
                    Id = 10,
                    RUT = "11223344-6",
                    nombre = "Felipe Martínez",
                    correo = "felipe.martinez@mail.com",
                    genero = "Masculino",
                    fechaNac = new DateTime(1995, 10, 5)
                });

                // Guardar cambios en la base de datos
                await context.SaveChangesAsync();
            }
        }
    }
}