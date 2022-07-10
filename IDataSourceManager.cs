public interface IDataSourceManager
{
    IDataSource Create();

    IDataSource Current { get; }
}