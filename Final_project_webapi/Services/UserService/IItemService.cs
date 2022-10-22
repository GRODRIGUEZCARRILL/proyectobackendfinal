using Final_project_webapi.Models;

namespace Final_project_webapi.Services.UserService
{
    public interface IItemService
    {
        Task<ServiceResponse<List<Item>>> GetAll();


        Task<ServiceResponse<Item>> GetItemById(int id);


        Task<ServiceResponse<Item>> Add(Item item);


        Task<ServiceResponse<Item>> UpdateItem(Item item);

        Task<ServiceResponse<List<Item>>> DeleteItem(int id);

        Task<ServiceResponse<Item>> GetItemByUser(int id);


        Task<ServiceResponse<List<Item>>> ItemByFlavor(Flavor FlavorType);

    }
}

