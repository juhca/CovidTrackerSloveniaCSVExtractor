namespace IndigoLabs2.Contract
{
    public interface IRepositoryManager
    {
        ICSVRepository CSV { get; }
        void Save();
    }
}
