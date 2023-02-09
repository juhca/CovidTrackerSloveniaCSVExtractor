using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IndigoLabs2.Enums
{
    public class RegionsEnums
    {
        public enum Regions
        {
            [Display(Name = "Celje")]
            CE = 1,
            [Display(Name = "Krško")]
            KK = 10,
            [Display(Name = "Koper")]
            KP = 16,
            [Display(Name = "Kranj")]
            KR = 22,
            [Display(Name = "Ljubljana")]
            LJ = 28,
            [Display(Name = "Maribor")]
            MB = 34,
            [Display(Name = "Murska Sobota")]
            MS = 40,
            [Display(Name = "Nova Gorica")]
            NG = 46,
            [Display(Name = "Novo Mesto")]
            NM = 52,
            [Display(Name = "Postojna")]
            PO = 58,
            [Display(Name = "Slovenj Gradec")]
            SG = 64,
            [Display(Name = "Zagorje")]
            ZA = 73
        }

        //public static class RegionsString
        //{
        //    public static readonly string CE = "Celje";
        //    public static readonly string KK = "Krško";
        //    public static readonly string KP = "Koper";
        //    public static readonly string KR = "Kranj";
        //    public static readonly string LJ = "Ljubljana";
        //    public static readonly string MB = "Maribor";
        //    public static readonly string MS = "Murska Sobota";
        //    public static readonly string NG = "Nova Gorica";
        //    public static readonly string NM = "Novo Mesto";
        //    public static readonly string PO = "Postojna";
        //    public static readonly string SG = "Slovenj Gradec";
        //    public static readonly string ZA = "Zagorje";
        //}

    }
}
