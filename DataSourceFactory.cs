public class DataSourceFactory : IDataSourceFactory
{
    public IDataSource Create()
    {
        return new DataSource();
    }
}