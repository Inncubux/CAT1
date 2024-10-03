using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.Models;

namespace api.src.Data
{
    public static class Seeder
    {
        public static async Task Seed(DatabaseContext context){
            if (context.Users.Any())
            return;

            //var nombre = new string[];
        }
    }
}