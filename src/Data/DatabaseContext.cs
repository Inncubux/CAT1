using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.Models;
using Microsoft.EntityFrameworkCore;

namespace api.src.Data
{
    public class DatabaseContext (DbContextOptions<DatabaseContext> options) : DbContext(options)
    {
        public DbSet<User> Users {get;set;}
    }
}