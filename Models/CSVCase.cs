namespace IndigoLabs2.Models
{
    public class CSVCase
    {
        public DateTime Date { get; set; }
        public string Region { get; set; }
        public int RegionCasesActive { get; set; }
        //public int RegionCasesConfirmed { get; set; }
        public int RegionDeceasedToDate { get; set; }
        public int RegionVaccinatedFirstToDate { get; set; }
        public int RegionVaccinatedSecondToDate { get; set; }
        //public int RegionVaccinatedThirdToDate { get; set; }
    }
}
