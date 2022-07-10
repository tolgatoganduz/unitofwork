public class UnitOfWorkAlreadyCompletedException : Exception
{
    public UnitOfWorkAlreadyCompletedException() : base("This unit of work is already completed")
    {
    }
}