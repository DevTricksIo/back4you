using Fakester.NET.Application;
using Scrutor;

namespace Fakester.NET.API.Setup;

public static class SetupDI
{
    public static void ResolveApplicationServices(this IServiceCollection services)
    {
        services.Scan(scan => scan.FromAssemblies(typeof(ApplicationGlobalUsing).Assembly).AddClasses().UsingRegistrationStrategy(RegistrationStrategy.Skip).AsMatchingInterface().WithScopedLifetime());
    }
}
