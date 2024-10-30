namespace NETCore.DependencyInjector.Services
{
    public class POSFactory : IPOSFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public POSFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPOSService Create(string creatureType)
        {
            return creatureType switch
            {
                "Product" => _serviceProvider.GetRequiredService<ProductService>(),
                "Report" => _serviceProvider.GetRequiredService<ReportService>(),
                "Sales" => _serviceProvider.GetRequiredService<SalesService>(),
               _ => throw new NotImplementedException("Unknown creature type")
            };
        }
    }
}
