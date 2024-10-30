namespace NETCore.DependencyInjector.Services
{
    public class SalesService : IPOSService
    {
        public string GetSalesAmount()
        {
            return "500 tk";
        }
    }
}
