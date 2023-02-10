using IndigoLabs2.Contract;

namespace IndigoLabs2.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private ApplicationContext _applicationContext;
        private ICSVRepository _csvRepository;

        public RepositoryManager(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
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
