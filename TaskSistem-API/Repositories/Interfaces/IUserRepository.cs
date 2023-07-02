using TaskSistem_API.Models;

namespace TaskSistem_API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> GetAll();

        Task<UserModel> GetById(int id);

        Task<UserModel> Add(UserModel user);

        Task<UserModel> Update(UserModel user, int id);

        Task<bool> Delete(int id);
    }
}
