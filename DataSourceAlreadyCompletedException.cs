public class DataSourceAlreadyCompletedException : Exception
{
    public DataSourceAlreadyCompletedException() : base("This data source is already completed")
    {
    }
}