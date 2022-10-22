using Final_project_webapi.Models;
using Final_project_webapi.Services.UserService;

namespace Final_project_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        
        [HttpGet("getAll")]
        public async Task<ActionResult<ServiceResponse<List<User>>>> GetAll()
        {
            return Ok(await userService.GetAll());
        }

        [HttpPost("add")]
        public async Task<ActionResult<ServiceResponse<User>>> Add(User usuario)
        {
            return Ok(await userService.Add(usuario));
        }

        
        [HttpGet("get/{id}")]
        public async Task<ActionResult<ServiceResponse<User>>> GetById(int id)
        {
            return await userService.GetById(id);
        }

       
        [HttpPut("update")]
        public async Task<ActionResult<ServiceResponse<User>>> UpdateUser(User usuario)
        {
            return Ok(await userService.UpdateUser(usuario));
        }

     
        [HttpGet("getCount")]
        public async Task<ActionResult<ServiceResponse<int>>> GetCount()
        {
            return Ok(await userService.GetCount());
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<ServiceResponse<List<User>>>> DeleteUser(int id)
        {
            return await userService.DeleteUser(id);
        }

    }
}
