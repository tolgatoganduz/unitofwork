public class OrderRepository : Repository<Order>, IOrderRepository
{
    public OrderRepository(IDataSourceProvider dataSourceProvider) : base(dataSourceProvider)
    {
    }
}