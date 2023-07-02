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
        public Task<List<UserModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<UserModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> Add(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

    
        public Task<UserModel> Update(UserModel user, int id)
        {
            throw new NotImplementedException();
        }
    }
}
