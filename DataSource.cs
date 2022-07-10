public class DataSource : IDataSource
{
    private List<object> objectList = new List<object>();

    public DataSource()
    {
        Completed = false;
    }

    public int Count => objectList.Count;

    public bool Completed { get; private set; }

    public void Add(object entity)
    {
        objectList.Add(entity);
    }

    public void Complete()
    {
        ThrowCompleted();

        Completed = true;
    }

    public void Remove(object entity)
    {
        ThrowCompleted();

        objectList.Remove(entity);
    }

    public void Update(object entity)
    {
        ThrowCompleted();

        Remove(entity);

        Add(entity);
    }

    private void ThrowCompleted()
    {
        if (Completed)
        {
            throw new DataSourceAlreadyCompletedException();
        }
    }
}