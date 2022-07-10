public class DataSourceProvider : IDataSourceProvider
{
    private readonly IDataSourceManager dataSourceManager;

    public DataSourceProvider(IDataSourceManager dataSourceManager)
    {
        this.dataSourceManager = dataSourceManager;
    }

    public IDataSource Current => dataSourceManager.Current;
}