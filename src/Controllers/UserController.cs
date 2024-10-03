using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.src.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController; ControllerBase
    {
      //  private readonly IUserRepository _userRepository;
      
    [HttpPost("")]
    public async Task<IResult> CreateUser(CreateUserDto createProductDto){
        
    }
}