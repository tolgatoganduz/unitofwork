public interface IDataSource
{
    void Add(object entity);
    void Remove(object entity);
    void Update(object entity);
    int Count { get; }
    void Complete();
    bool Completed { get; }    
}