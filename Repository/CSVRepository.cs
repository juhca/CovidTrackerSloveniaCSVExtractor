using IndigoLabs2.Contract;
using IndigoLabs2.Models;
using Microsoft.EntityFrameworkCore;

namespace IndigoLabs2.Repository
{
    public class CSVRepository : RepositoryBase<CSVRegionCases>, ICSVRepository
    {
        private ApplicationContext ApplicationContext;

        public CSVRepository(ApplicationContext _ApplicationContext) : base(_ApplicationContext) 
        {
            ApplicationContext = _ApplicationContext;
        }

        async Task<CSVRegionCases> ICSVRepository.CreateCSVDailyCase(CSVRegionCases regCases)
        {
            ApplicationContext.CSVRegions.Add(regCases);
            await ApplicationContext.SaveChangesAsync();

            return regCases;
        }

        async Task<bool> ICSVRepository.DailyRecordExists(DateTime recordDate)
        {
            return ApplicationContext.CSVRegions.Any(x => x.Date == recordDate);
        }

        async Task<CSVRegionCases> ICSVRepository.GetLastRecord()
        {
            return ApplicationContext.CSVRegions.Last();
        }

        async Task<List<CSVRegionCases>> ICSVRepository.GetLastSevenRecords()
        {
            return await ApplicationContext.CSVRegions.OrderByDescending(x => x.Date).Take(7).ToListAsync();
        }

        async Task<List<CSVRegionCases>> ICSVRepository.GetRecordsByDate(DateTime dateTo, DateTime dateFrom)
        {
            List<CSVRegionCases> records = await ApplicationContext.CSVRegions
                .Where(x => x.Date >= dateFrom && x.Date <= dateTo)
                .ToListAsync();
            return records;
        }  
    }
}
