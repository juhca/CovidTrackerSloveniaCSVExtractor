using IndigoLabs2.Models;

namespace IndigoLabs2.Contract
{
    public interface ICSVService
    {
        Task<List<CSVCase>> GetRegionsCases(string region, DateTime dateFrom, DateTime dateTo);
        Task<List<CSVCase>> GetRegionsCasesDB(string region, DateTime dateFrom, DateTime dateTo);
        Task<List<CSVRegionLastWeek>> GetRegionLastWeek();
        Task<List<CSVRegionLastWeek>> GetRegionLastWeekDB();
    }
}
