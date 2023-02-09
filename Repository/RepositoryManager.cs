using IndigoLabs2.Contract;

namespace IndigoLabs2.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private ApplicationContext _applicationContext;
        private IUserRepository _userRepository;
        private ICSVRepository _csvRepository;

        public RepositoryManager(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public IUserRepository User
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_applicationContext);

                return _userRepository;
            }
        }

        public ICSVRepository CSV
        {
            get 
            {
                if (_csvRepository == null)
                    _csvRepository = new CSVRepository(_applicationContext);

                return _csvRepository;
            }
        }

        public void Save() => _applicationContext.SaveChanges();
    }
}
