using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskSistem_API.Models;

namespace TaskSistem_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UserModel>> GetAllUser()
        {
            return Ok();
        }
    }
}
