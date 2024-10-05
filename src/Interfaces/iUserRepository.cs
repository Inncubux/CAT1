using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.DTOs;
using api.src.Models;

namespace api.src.Interfaces
{
    public interface iUserRepository
    {
        
        Task<User> CreateUser(User user);

        Task<List<User>> GetAllUser();

        Task<User> GetUser(string rut);

        Task<User> EditUser(int id, UserDtoNOID userDtoNOID);

        Task<User> DeleteUser(int Id, UserDtoNOID userDtoNOID);
        Task DeleteUser(int id);
    }
}