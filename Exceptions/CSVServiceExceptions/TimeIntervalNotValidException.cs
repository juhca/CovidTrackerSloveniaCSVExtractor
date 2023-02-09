namespace IndigoLabs2.Exceptions.CSVServiceExceptions
{
    public sealed class TimeIntervalNotValidException : ArgumentNullException
    {
        public TimeIntervalNotValidException() 
            : base("Specified time interval is not valid/supported.") { }
    }
}
