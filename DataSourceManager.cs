public class DataSourceManager : IDataSourceManager 
{
    private readonly IDataSourceFactory dataSourceFactory;
    private Stack<IDataSource> dataSources = new Stack<IDataSource>();


    public DataSourceManager(IDataSourceFactory dataSourceFactory)
    {
        this.dataSourceFactory = dataSourceFactory;
    }

    public IDataSource Current
    {
        get
        {
            while (dataSources.Count > 0 && dataSources.Peek().Completed)
            {
                dataSources.Pop();
            }

            if (dataSources.Count == 0)
            {
                Create();
            }

            return dataSources.Peek();
        }
    }

    public IDataSource Create()
    {
        var dataSource = dataSourceFactory.Create();

        dataSources.Push(dataSource);

        return dataSource;
    }
}