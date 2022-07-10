public class Repository<T> : IRepository<T> where T : class
{
    private readonly IDataSourceProvider dataSourceProvider;

    public Repository(IDataSourceProvider dataSourceProvider)
    {
        this.dataSourceProvider = dataSourceProvider;
    }
    public void Add(T entity)
    {
        DataSource.Add(entity);
    }

    public int Count => DataSource.Count;

    public void Remove(T entity)
    {
        DataSource.Remove(entity);
    }

    public void Update(T entity)
    {
        DataSource.Update(entity);
    }

    private IDataSource DataSource => dataSourceProvider.Current;
}