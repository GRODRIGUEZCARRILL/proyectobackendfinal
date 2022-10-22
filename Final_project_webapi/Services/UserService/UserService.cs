using Final_project_webapi.Data;
using Final_project_webapi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Final_project_webapi.Services.UserService
{
    public class UserService : IUserService
    {  
        
        private readonly DataContext context;

        public UserService(DataContext context)
        {
            this.context = context;
        }

        
        public async Task<ServiceResponse<User>> Add(User usuario)
        {
            ServiceResponse <User> serviceResponse = new ServiceResponse<User>();
            try
            {
                //usuario.UserId = 1 + usersList.Count();
                context.Users.Add(usuario);
                context.SaveChanges();
               
                serviceResponse.Data = usuario;
            }
            catch (Exception ex)
            {

                serviceResponse.Success = false;
                serviceResponse.Error = ex.Message;
            }
            

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<User>>> DeleteUser(int id)
        {
            ServiceResponse<List<User>> serviceResponse = new ServiceResponse<List<User>>();

            try
            {
                var user = context.Users.First(user => user.UserId == id);
                context.Users.Remove(user);
                context.SaveChanges();
                serviceResponse.Data = context.Users.ToList();

            }
            catch (Exception Ex)
            {

                serviceResponse.Success = false;
                serviceResponse.Error = Ex.Message;
            }

            return serviceResponse;

        }

        
        public async Task<ServiceResponse<List<User>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<User>>();
            try
            {

                serviceResponse.Data = context.Users.ToList();

            }
            catch (Exception Ex)
            {

                serviceResponse.Success = false;
                serviceResponse.Error = Ex.Message;
            }

            return serviceResponse;

        }
     
        public async Task<ServiceResponse<User>> GetById(int id)
        {
            ServiceResponse<User> serviceResponse = new ServiceResponse<User>();
            
            try
            {
                var user = context.Users.First(user => user.UserId == id);
                serviceResponse.Data = user;
            }
            catch (Exception Ex)
            {

                serviceResponse.Success = false;
                serviceResponse.Error = Ex.Message;
            }

            return serviceResponse;

        }

        
        public async Task<ServiceResponse<int>> GetCount()
        {
            ServiceResponse<int> serviceResponse = new ServiceResponse<int>();
            try
            {
                var usersCount = context.Users.Count();
                serviceResponse.Data = usersCount;
            }
            catch (Exception ex)
            {

                serviceResponse.Success = false;
                serviceResponse.Error = ex.Message;
            }

            return serviceResponse;
        }

       
        public async Task<ServiceResponse<User>> UpdateUser(User usuario)
        {
            ServiceResponse<User> serviceResponse = new ServiceResponse<User>();
            try
            {
                User user = context.Users.First(user => user.UserId == usuario.UserId);

                user.UserType = usuario.UserType;
                user.FName = usuario.FName;
                user.LName = usuario.LName;
                user.Phone = usuario.Phone;
                user.Email = usuario.Email;

                serviceResponse.Data = usuario;
            }
            catch (Exception ex)
            {

                serviceResponse.Success = false;
                serviceResponse.Error = ex.Message;
            }


            return serviceResponse;
        }
    }
}
