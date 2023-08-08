using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskSistem_API.Models;
using TaskSistem_API.Repositories;
using TaskSistem_API.Repositories.Interfaces;

namespace TaskSistem_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController( IUserRepository userRepository) {
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task <ActionResult<List<UserModel>>> GetAllUser()
        {
          List<UserModel> users =  await _userRepository.GetAll();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> GetById(int id)
        {
            UserModel user = await _userRepository.GetById(id);
            return Ok(user);
        }
        [HttpPost]
        public async Task <ActionResult<UserModel>> Add([FromBody] UserModel userModel)
        {
           UserModel user = await _userRepository.Add(userModel);

            return Ok(user);
        }
    }
}
