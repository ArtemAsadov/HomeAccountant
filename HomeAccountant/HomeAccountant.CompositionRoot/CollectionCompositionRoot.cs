using HomeAccountant.BL;
using HomeAccountant.DA;
using HomeAccountant.DA.Interface;
using HomeAccountant.BL.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAccountant.CompositionRoot;

public class CollectionCompositionRoot
{
    public static void RegisterMockLayers(IServiceCollection services)
    {
        services.AddTransient<ICustomerService, MockCustomerService>();
        services.AddTransient<IDataRepository, MockRepository>();
    }
    public static void RegisterLayers(IServiceCollection services)
    {
        services.AddTransient<ICustomerService, CustomerService>();
        services.AddTransient<IDataRepository, MySQLRepository>();
    }
}