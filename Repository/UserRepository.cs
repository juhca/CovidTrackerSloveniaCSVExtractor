using IndigoLabs2.Contract;
using IndigoLabs2.Models;
using Microsoft.EntityFrameworkCore;

namespace IndigoLabs2.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private ApplicationContext ApplicationContext;

        public UserRepository(ApplicationContext _ApplicationContext) : base(_ApplicationContext) 
        {
            ApplicationContext = _ApplicationContext;
        }


        void IUserRepository.CreateUser(User user) => Create(user);

        async Task IUserRepository.DeleteAllUsers()
        {
            await ApplicationContext.Users.ForEachAsync(x => ApplicationContext.Users.Remove(x));
            await ApplicationContext.SaveChangesAsync();
        }

        async void IUserRepository.DeleteUser(User user)
        {
            ApplicationContext.Users.Remove(user);
            await ApplicationContext.SaveChangesAsync();
        }

        List<User> IUserRepository.GetAllUsers()
        {
            return ApplicationContext.Users.OrderBy(x => x.Id).ToList();
        }

        User IUserRepository.GetUser(int userId)
        {
            return ApplicationContext.Users.FirstOrDefault(x => x.Id == userId);
        }

        void IUserRepository.UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
