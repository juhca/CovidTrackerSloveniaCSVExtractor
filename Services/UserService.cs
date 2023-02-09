using IndigoLabs2.Contract;
using IndigoLabs2.Models;

namespace IndigoLabs2.Services
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        public UserService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        List<User> IUserService.GetAllUsers()
        {
            return _repositoryManager.User.GetAllUsers();
        }
    }
}
