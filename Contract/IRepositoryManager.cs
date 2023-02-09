namespace IndigoLabs2.Contract
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        ICSVRepository CSV { get; }
        void Save();
    }
}
