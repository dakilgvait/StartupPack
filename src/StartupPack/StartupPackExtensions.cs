using Microsoft.Extensions.Hosting;

namespace StartupPack;

public static class StartupPackExtensions
{
    public static bool IsLocalhost(this IHostEnvironment environment)
    {
        return environment.IsEnvironment(StartupPackConstants.Localhost);
    }
}
