using Microsoft.Extensions.DependencyInjection;

namespace StartupPack;

public class ConfigureServicesBuilder : IConfigureServicesBuilder
{
    private readonly IServiceCollection _services;

    public ConfigureServicesBuilder()
    {
        _services = new ServiceCollection();
    }

    public IConfigureBuilder Build(IServiceCollection services)
    {
        throw new NotImplementedException();
    }

    public void Install(Action<IStartupPackBuilder> action)
    {
        var builder = new CustomActionPackBuilder();
        action.Invoke(builder);
        _services.AddSingleton<IStartupPackBuilder>(builder);
    }

    public void Register(Action<IServiceCollection> action)
    {
        action.Invoke(_services);
    }

    public void InstallBuilder<TBuilder>() where TBuilder : class, IStartupPackBuilder
    {
        _services.AddSingleton<IStartupPackBuilder, TBuilder>();
    }

    public void InstallPack<TPack>() where TPack : class, IStartupPack
    {
        _services.AddSingleton<IStartupPack, TPack>();
    }
}
