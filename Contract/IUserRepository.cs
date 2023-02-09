using IndigoLabs2.Models;

namespace IndigoLabs2.Contract
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUser(int userId);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        Task DeleteAllUsers();
    }
}
