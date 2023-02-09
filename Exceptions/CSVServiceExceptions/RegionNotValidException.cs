namespace IndigoLabs2.Exceptions.CSVServiceExceptions
{
    public sealed class RegionNotValidException : ArgumentNullException
    {
        public RegionNotValidException(string region) 
            : base("Specified region " + "(" + region + ")"+ "is not valid/supported.") { }
    }
}
