using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IndigoLabs2.Models
{
    public class CSVRegionCases
    {
        [Key]
        public DateTime Date { get; set; }
        //public string Region { get; set; }
        //public int RegionCasesActive { get; set; }
        ////public int RegionCasesConfirmed { get; set; }
        //public int RegionDeceasedToDate { get; set; }
        //public int RegionVaccinatedFirstToDate { get; set; }
        //public int RegionVaccinatedSecondToDate { get; set; }
        ////public int RegionVaccinatedThirdToDate { get; set; }
         
        public int Region_ce_cases_active { get; set; }
        public int Region_ce_cases_confirmed_todate { get; set; }
        public int Region_ce_deceased_todate { get; set; }
        public int Region_ce_vaccinated_1st_todate { get; set; }
        public int Region_ce_vaccinated_2nd_todate { get; set; }
        public int Region_ce_vaccinated_3rd_todate { get; set; }
         
        public int Region_foreign_cases_active { get; set; }
        public int Region_foreign_cases_confirmed_todate { get; set; }
        public int Region_foreign_deceased_todate { get; set; }
         
        public int Region_kk_cases_active { get; set; }
        public int Region_kk_cases_confirmed_todate { get; set; }
        public int Region_kk_deceased_todate { get; set; }
        public int Region_kk_vaccinated_1st_todate { get; set; }
        public int Region_kk_vaccinated_2nd_todate { get; set; }
        public int Region_kk_vaccinated_3rd_todate { get; set; }
         
        public int Region_kp_cases_active { get; set; }
        public int Region_kp_cases_confirmed_todate { get; set; }
        public int Region_kp_deceased_todate { get; set; }
        public int Region_kp_vaccinated_1st_todate { get; set; }
        public int Region_kp_vaccinated_2nd_todate { get; set; }
        public int Region_kp_vaccinated_3rd_todate { get; set; }
          
        public int Region_kr_cases_active { get; set; }
        public int Region_kr_cases_confirmed_todate { get; set; }
        public int Region_kr_deceased_todate { get; set; }
        public int Region_kr_vaccinated_1st_todate { get; set; }
        public int Region_kr_vaccinated_2nd_todate { get; set; }
        public int Region_kr_vaccinated_3rd_todate { get; set; }
          
        public int Region_lj_cases_active { get; set; }
        public int Region_lj_cases_confirmed_todate { get; set; }
        public int Region_lj_deceased_todate { get; set; }
        public int Region_lj_vaccinated_1st_todate { get; set; }
        public int Region_lj_vaccinated_2nd_todate { get; set; }
        public int Region_lj_vaccinated_3rd_todate { get; set; }
          
        public int Region_mb_cases_active { get; set; }
        public int Region_mb_cases_confirmed_todate { get; set; }
        public int Region_mb_deceased_todate { get; set; }
        public int Region_mb_vaccinated_1st_todate { get; set; }
        public int Region_mb_vaccinated_2nd_todate { get; set; }
        public int Region_mb_vaccinated_3rd_todate { get; set; }
          
        public int Region_ms_cases_active { get; set; }
        public int Region_ms_cases_confirmed_todate { get; set; }
        public int Region_ms_deceased_todate { get; set; }
        public int Region_ms_vaccinated_1st_todate { get; set; }
        public int Region_ms_vaccinated_2nd_todate { get; set; }
        public int Region_ms_vaccinated_3rd_todate { get; set; }
          
        public int Region_ng_cases_active { get; set; }
        public int Region_ng_cases_confirmed_todate { get; set; }
        public int Region_ng_deceased_todate { get; set; }
        public int Region_ng_vaccinated_1st_todate { get; set; }
        public int Region_ng_vaccinated_2nd_todate { get; set; }
        public int Region_ng_vaccinated_3rd_todate { get; set; }
          
        public int Region_nm_cases_active { get; set; }
        public int Region_nm_cases_confirmed_todate { get; set; }
        public int Region_nm_deceased_todate { get; set; }
        public int Region_nm_vaccinated_1st_todate { get; set; }
        public int Region_nm_vaccinated_2nd_todate { get; set; }
        public int Region_nm_vaccinated_3rd_todate { get; set; }
          
        public int Region_po_cases_active { get; set; }
        public int Region_po_cases_confirmed_todate { get; set; }
        public int Region_po_deceased_todate { get; set; }
        public int Region_po_vaccinated_1st_todate { get; set; }
        public int Region_po_vaccinated_2nd_todate { get; set; }
        public int Region_po_vaccinated_3rd_todate { get; set; }
          
        public int Region_sg_cases_active { get; set; }
        public int Region_sg_cases_confirmed_todate { get; set; }
        public int Region_sg_deceased_todate { get; set; }
        public int Region_sg_vaccinated_1st_todate { get; set; }
        public int Region_sg_vaccinated_2nd_todate { get; set; }
        public int Region_sg_vaccinated_3rd_todate { get; set; }
          
        public int Region_unknown_cases_active { get; set; }
        public int Region_unknown_cases_confirmed_todate { get; set; }
        public int Region_unknown_deceased_todate { get; set; }
          
        public int Region_za_cases_active { get; set; }
        public int Region_za_cases_confirmed_todate { get; set; }
        public int Region_za_deceased_todate { get; set; }
        public int Region_za_vaccinated_1st_todate { get; set; }
        public int Region_za_vaccinated_2nd_todate { get; set; }
        public int Region_za_vaccinated_3rd_todate { get; set; }

    }
}
