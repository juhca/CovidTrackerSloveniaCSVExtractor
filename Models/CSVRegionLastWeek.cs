using Microsoft.EntityFrameworkCore;

namespace IndigoLabs2.Models
{
    [Keyless]
    public class CSVRegionLastWeek
    {
        public string RegionName { get; set; }
        public double AvgDailyCases { get; set; }
        public int NumAllCases { get; set; }
        /*
        public CSVRegionLastWeek(string regionName, double avgDailyCases, int numAllCases)
        {
            this.RegionName = regionName;
            this.AvgDailyCases = avgDailyCases;
            this.NumAllCases = numAllCases;
        }*/
    }
}
