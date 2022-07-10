// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

IDataSourceFactory dataSourceFactory = new DataSourceFactory();

IDataSourceManager dataSourceManager = new DataSourceManager(dataSourceFactory);

IDataSourceProvider dataSourceProvider = new DataSourceProvider(dataSourceManager);

IOrderRepository orderRepository = new OrderRepository(dataSourceProvider);

IUnitOfWorkManager unitOfWorkManager = new UnitOfWorkManager(dataSourceManager);

var uow1 = unitOfWorkManager.Create();

orderRepository.Add(new Order(1));
orderRepository.Add(new Order(2));
orderRepository.Add(new Order(3));

var uow2 = unitOfWorkManager.Create();

uow2.Complete();

Console.WriteLine($"Repo count is {orderRepository.Count}");




orderRepository.Add(new Order(4));
orderRepository.Add(new Order(5));

Console.WriteLine($"Repo count is {orderRepository.Count}");

uow1.Complete();

Console.WriteLine($"Repo count is {orderRepository.Count}");

orderRepository.Add(new Order(6));

Console.WriteLine($"Repo count is {orderRepository.Count}");
