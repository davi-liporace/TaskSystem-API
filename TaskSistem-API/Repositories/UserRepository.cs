using Microsoft.EntityFrameworkCore;
using TaskSistem_API.Data;
using TaskSistem_API.Models;
using TaskSistem_API.Repositories.Interfaces;

namespace TaskSistem_API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TaskSystemDBContext _dbContext;
        public UserRepository(TaskSystemDBContext taskSystemDBContext) {
            _dbContext = taskSystemDBContext;
        }
        public async Task<List<UserModel>> GetAll()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<UserModel> GetById(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id) ;
        }

        public async Task<UserModel> Add(UserModel user)
        {
            await _dbContext.Users.AddAsync(user);
           await _dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<UserModel> Update(UserModel user, int id)
        {
            UserModel userById = await GetById(id);
            if(userById == null)
            {
                throw new Exception($"User for ID:{id} was not found in database");

            }
            userById.Name = user.Name;
            userById.Email = user.Email;

            _dbContext.Users.Update(userById);
            await _dbContext.SaveChangesAsync();

            return userById;           
        }

        public async Task<bool> Delete(int id)
        {
            UserModel userById = await GetById(id);
            if (userById == null)
            {
                throw new Exception($"User for ID:{id} was not found in database");
            }
            _dbContext.Users.Remove(userById);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    
        
    }
}
