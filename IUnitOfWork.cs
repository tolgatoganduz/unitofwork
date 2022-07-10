public interface IUnitOfWork
{
    bool Completed { get; }

    void Complete();
}