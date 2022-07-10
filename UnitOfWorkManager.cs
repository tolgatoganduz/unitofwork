public class UnitOfWorkManager : IUnitOfWorkManager
{
    private readonly IDataSourceManager dataSourceManager;

    public UnitOfWorkManager(IDataSourceManager dataSourceManager)
    {
        this.dataSourceManager = dataSourceManager;
    }

    public IUnitOfWork Create()
    {
        return new UnitOfWork(dataSourceManager.Create());
    }
}