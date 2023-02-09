using IndigoLabs2.Models;

namespace IndigoLabs2.Contract
{
    public interface ICSVRepository
    {
        Task<CSVRegionCases> CreateCSVDailyCase(CSVRegionCases regCases);
        Task<bool> DailyRecordExists(DateTime recordDate);
        Task<CSVRegionCases> GetLastRecord();
        Task<List<CSVRegionCases>> GetLastSevenRecords();
        Task<List<CSVRegionCases>> GetRecordsByDate(DateTime dateTo, DateTime dateFrom);
    }
}