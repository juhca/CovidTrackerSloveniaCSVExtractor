using IndigoLabs2.Contract;
using IndigoLabs2.Enums;
using IndigoLabs2.Exceptions.CSVServiceExceptions;
using IndigoLabs2.Models;
using System.Dynamic;
using System.Reflection;

namespace IndigoLabs2.Services
{
    public class CSVService : ICSVService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly string csvUrl = "https://raw.githubusercontent.com/sledilnik/data/master/csv/region-cases.csv";
        public CSVService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        async Task<List<CSVCase>> ICSVService.GetRegionsCases(string region, DateTime dateFrom, DateTime dateTo)
        {
            if (string.IsNullOrEmpty(region))
            {
                throw new RegionNotSpecifiedException();
            }

            if (dateTo > DateTime.Now || dateTo == DateTime.MinValue) dateTo = DateTime.Now;

            if ((dateFrom > dateTo) || (dateFrom > DateTime.Now))
            {
                throw new TimeIntervalNotValidException();
            }

            RegionsEnums.Regions csvColumnIndex;
            if (!Enum.TryParse(region, true, out csvColumnIndex))
            {
                throw new RegionNotValidException(region);
            }

            string csv = await DownloadCSVAsync(false);
            var splitList = csv.Trim().Split('\n');
            var columns = splitList[0].Replace('.', '_').Split(',');
            List<dynamic> output = new List<dynamic>();


            for (int i = 1; i < splitList.Length; i++)
            {
                var dynamicObject = new ExpandoObject() as IDictionary<string, object>;
                var splitRow = splitList[i].Split(",");

                for (int j = 0; j < splitRow.Length; j++)
                {
                    dynamicObject.Add(columns[j], splitRow[j]);
                }
                output.Add(dynamicObject);
            }
            var tmp = output.Where(x => DateTime.Parse(((IDictionary<string, object>)x)["date"].ToString()) >= dateFrom 
                && DateTime.Parse(((IDictionary<string, object>)x)["date"].ToString()) <= dateTo)
                .ToList();

            List<CSVCase> finalResult = new List<CSVCase>();

            string regionFulName = ((System.ComponentModel.DataAnnotations.DisplayAttribute)csvColumnIndex.GetType().GetMember(csvColumnIndex.ToString()).First().GetCustomAttributes(true).First()).Name + " (" + csvColumnIndex + ")";
            region = region.ToLower();

            foreach (var record in tmp)
            {
                finalResult.Add(new CSVCase()
                {
                    Date = DateTime.Parse(((IDictionary<string, object>)record)["date"].ToString()),
                    Region = regionFulName,
                    RegionCasesActive = TryParse(((IDictionary<string, object>)record)["region_" + region + "_cases_active"].ToString()),
                    RegionDeceasedToDate = TryParse(((IDictionary<string, object>)record)["region_" + region + "_deceased_todate"].ToString()),
                    RegionVaccinatedFirstToDate = TryParse(((IDictionary<string, object>)record)["region_" + region + "_vaccinated_1st_todate"].ToString()),
                    RegionVaccinatedSecondToDate = TryParse(((IDictionary<string, object>)record)["region_" + region + "_vaccinated_2nd_todate"].ToString())

                });
            }

            return finalResult;
        }

        async Task<List<CSVCase>> ICSVService.GetRegionsCasesDB(string region, DateTime dateFrom, DateTime dateTo)
        {
            if (string.IsNullOrEmpty(region))
            {
                throw new RegionNotSpecifiedException();
            }

            if (dateTo > DateTime.Now || dateTo == DateTime.MinValue) dateTo = DateTime.Now;

            if ((dateFrom > dateTo) || (dateFrom > DateTime.Now))
            {
                throw new TimeIntervalNotValidException();
            }

            RegionsEnums.Regions csvColumnIndex;
            if (!Enum.TryParse(region, true, out csvColumnIndex))
            {
                throw new RegionNotValidException(region);
            }
            string regionFulName = ((System.ComponentModel.DataAnnotations.DisplayAttribute)csvColumnIndex.GetType().GetMember(csvColumnIndex.ToString()).First().GetCustomAttributes(true).First()).Name + " (" + csvColumnIndex + ")";

            List<CSVCase> finalResult = new List<CSVCase>();
            string csv = await DownloadCSVAsync(true);
            List<CSVRegionCases> regionsCases = await _repositoryManager.CSV.GetRecordsByDate(dateTo, dateFrom);           

            foreach (var dailyCase in regionsCases)
            {
                string columnName = "Region_" + csvColumnIndex.ToString().ToLower();

                finalResult.Add(new CSVCase
                {
                    Date = dailyCase.Date,
                    Region = regionFulName,
                    RegionCasesActive = (int)dailyCase.GetType().GetProperty(columnName + "_cases_active").GetValue(dailyCase, null),
                    RegionDeceasedToDate = (int)dailyCase.GetType().GetProperty(columnName + "_deceased_todate").GetValue(dailyCase, null),
                    RegionVaccinatedFirstToDate = (int)dailyCase.GetType().GetProperty(columnName + "_vaccinated_1st_todate").GetValue(dailyCase, null),
                    RegionVaccinatedSecondToDate = (int)dailyCase.GetType().GetProperty(columnName + "_vaccinated_2nd_todate").GetValue(dailyCase, null)
                });
            }                              

            return finalResult;
        }

        async Task<List<CSVRegionLastWeek>> ICSVService.GetRegionLastWeek()
        {
            string csv = await DownloadCSVAsync(false);

            string[] splitList = csv.Trim().Split('\n');

            List<CSVRegionLastWeek> output = new List<CSVRegionLastWeek>();

            int numDays = 7;
            if (splitList.Length < 7) numDays = splitList.Length;
            int startIndex = splitList.Length - numDays;

            string[] lastRow = splitList[splitList.Length - 1].Split(',');
            string[] firstRow = splitList[startIndex].Split(',');

            foreach (int i in Enum.GetValues(typeof(RegionsEnums.Regions)))
            {
                int numAllCases = int.Parse(lastRow[i + 1]) - int.Parse(firstRow[i + 1]);
                double avg = numAllCases / numDays;

                RegionsEnums.Regions csvColumnIndex = (RegionsEnums.Regions)i;
                string regionFulName = ((System.ComponentModel.DataAnnotations.DisplayAttribute)csvColumnIndex
                    .GetType()
                    .GetMember(csvColumnIndex.ToString())
                    .First()
                    .GetCustomAttributes(true)
                    .First()).Name + " (" + csvColumnIndex + ")";

                output.Add(new CSVRegionLastWeek
                {
                    RegionName = regionFulName,
                    AvgDailyCases = avg,
                    NumAllCases = numAllCases
                });
            }

            return output.OrderByDescending(x => x.AvgDailyCases).ToList();
        }

        async Task<List<CSVRegionLastWeek>> ICSVService.GetRegionLastWeekDB()
        {
            // zafilaj bazo
            string csv = await DownloadCSVAsync(true);
            List<CSVRegionLastWeek> output = new List<CSVRegionLastWeek>();

            List<CSVRegionCases> lastSevenRecords = await _repositoryManager.CSV.GetLastSevenRecords();
            int days = lastSevenRecords.Count;
            CSVRegionCases lastRecord = lastSevenRecords[0];
            CSVRegionCases firstRecord = lastSevenRecords[days-1];

            foreach (int i in Enum.GetValues(typeof(RegionsEnums.Regions)))
            {
                RegionsEnums.Regions csvColumnIndex = (RegionsEnums.Regions)i;
                string regionFulName = ((System.ComponentModel.DataAnnotations.DisplayAttribute)csvColumnIndex
                    .GetType()
                    .GetMember(csvColumnIndex.ToString())
                    .First()
                    .GetCustomAttributes(true)
                    .First()).Name + " (" + csvColumnIndex + ")";

                string columnName = "Region_" + csvColumnIndex.ToString().ToLower() + "_cases_confirmed_todate";
                int firstRecordValue = (int)firstRecord.GetType().GetProperty(columnName).GetValue(firstRecord, null);
                int lastRecordValue = (int)lastRecord.GetType().GetProperty(columnName).GetValue(lastRecord, null);
                                
                int numAllCases = lastRecordValue - firstRecordValue;
                double avg = numAllCases / days;

                output.Add(new CSVRegionLastWeek
                {
                    RegionName = regionFulName,
                    AvgDailyCases = avg,
                    NumAllCases = numAllCases
                });
            }

            return output.OrderByDescending(x => x.AvgDailyCases).ToList();
        }

        public async Task<string> DownloadCSVAsync(bool saveToDb)
        {
            using var client = new HttpClient();
            var response = await client.GetStringAsync(csvUrl);

            if(!saveToDb) 
                return response.ToString();

            string[] csv = response.ToString().Trim().Split('\n');
            for(int i = 1; i < csv.Length; i++)
            {
                string[] dailyCaseRow = csv[i].Split(",");

                // poglej ce za ta dan ze obstaja zapis v bazi
                DateTime recordDate = DateTime.Parse(dailyCaseRow[0]);
                if (await _repositoryManager.CSV.DailyRecordExists(recordDate))
                    continue;
                
                CSVRegionCases csvDailyCase = new CSVRegionCases();
                PropertyInfo[] properties = typeof(CSVRegionCases).GetProperties();
                for(int j = 0; j < properties.Length; j++)
                {
                    properties[j].SetValue(csvDailyCase, (j == 0) ? recordDate : TryParse(dailyCaseRow[j]));
                }
                await _repositoryManager.CSV.CreateCSVDailyCase(csvDailyCase);
            }

            return response.ToString();
        }

        public static int TryParse(string value)
        {
            int result;
            return Int32.TryParse(value, out result) ? result : 0;
        }
    }
}
