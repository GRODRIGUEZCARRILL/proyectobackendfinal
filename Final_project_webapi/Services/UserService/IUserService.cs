using Final_project_webapi.Models;

namespace Final_project_webapi.Services.UserService
{

    public interface IUserService
    {
    
        Task<ServiceResponse<List<User>>> GetAll();

    
        Task<ServiceResponse<User>> GetById(int id);


        Task<ServiceResponse<User>> Add(User usuario);

      
        Task<ServiceResponse<User>> UpdateUser(User usuario);

    
        Task<ServiceResponse<int>> GetCount();

   
        Task<ServiceResponse<List<User>>> DeleteUser(int id);

    }
}
