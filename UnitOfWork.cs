public class UnitOfWork : IUnitOfWork
{
    private readonly IDataSource dataSource;

    public UnitOfWork(IDataSource dataSource)
    {
        this.dataSource = dataSource;
    }

    public bool Completed => dataSource.Completed;

    public void Complete() => dataSource.Complete();   
}