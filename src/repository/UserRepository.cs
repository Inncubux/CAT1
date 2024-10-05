using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.Data;
using api.src.DTOs;
using api.src.Interfaces;
using api.src.Models;
using Microsoft.EntityFrameworkCore;

namespace api.src.repository
{
    public class UserRepository : iUserRepository
    {
        private readonly ApplicationDBcontext _context;

        public UserRepository(ApplicationDBcontext context){
            _context = context;
        }
        public async Task<User> CreateUser(User user)
        {
           await _context.Users.AddAsync(user);
           await _context.SaveChangesAsync();
           return user;
        }

        public async Task<List<User>> GetAllUser()
        {

            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUser(string rut)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.RUT == rut);
        }

        public Task<User> EditUser(int id, UserDtoNOID userDtoNOID)
        {
            return null;
        }

        async Task iUserRepository.DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                throw new KeyNotFoundException($"Usuario no encontrado");
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return;
        }

        public Task<User> DeleteUser(int Id, UserDtoNOID userDtoNOID)
        {
            throw new NotImplementedException();
        }
    }
}