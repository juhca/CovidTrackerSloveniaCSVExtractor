namespace IndigoLabs2.Exceptions.CSVServiceExceptions
{
    public sealed class RegionNotSpecifiedException : ArgumentNullException
    {
        public RegionNotSpecifiedException() 
            : base("Region was not specified.") { }
    }
}
