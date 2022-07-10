public class Order
{
    public Order(int id, bool completed = false)
    {
        Id = id;
        Completed = completed;
    }

    public int Id { get; private set; }

    public bool Completed { get; private set; }

    public void Complete()
    {
        Completed = true;
    }
}