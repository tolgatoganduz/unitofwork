public interface IRepository<T> where T : class
{
    void Add(T entity);
    void Remove(T entity);
    void Update(T entity);
    int Count { get; }
}