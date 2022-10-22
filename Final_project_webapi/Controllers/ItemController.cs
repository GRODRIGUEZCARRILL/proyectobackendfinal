using Final_project_webapi.Models;
using Final_project_webapi.Services.UserService;

namespace Final_project_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ItemController : ControllerBase
    {
        private readonly IItemService itemService;

        public ItemController(IItemService itemService)
        {
            this.itemService = itemService;
        }

   
        [HttpGet("getAll")]
        public async Task<ActionResult<List<Item>>> GetAll()
        {
            return Ok(await itemService.GetAll());
        }


        [HttpPost("add")]
        public async Task<ActionResult<Item>> Add(Item item)
        {
            return Ok(await itemService.Add(item));
        }

     
        [HttpGet("getItem/{id}")]
        public async Task<ActionResult<ServiceResponse<Item>>> GetItemById(int id)
        {
            return Ok(await itemService.GetItemById(id));
        }

   
        [HttpPut("updateItem")]
        public async Task<ActionResult<ServiceResponse<Item>>> UpdateItem(Item item)

        {
            return Ok(await itemService.UpdateItem(item));
        }

        [HttpDelete("deleteItem/{id}")]
        public async Task<ActionResult<ServiceResponse<List<Item>>>> DeleteItem(int id)
        {
            return Ok(await itemService.DeleteItem(id));
        }

       
        [HttpGet("itemByUser/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<Item>>>> GetItemByUser(int userId)
        {
            return Ok(await itemService.GetItemByUser(userId));
        }


        [HttpGet("itemByFlavor/{Flavor}")]
        public async Task<ActionResult<ServiceResponse<List<Item>>>> ItemByFlavor(Flavor FlavorType)
        {
            return Ok(await itemService.ItemByFlavor(FlavorType));
        }
    }
}
