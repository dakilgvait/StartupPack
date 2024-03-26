using Microsoft.Extensions.DependencyInjection;

namespace StartupPack;

public interface IConfigureServicesBuilder
{
    void Register(Action<IServiceCollection> action);
    void Install(Action<IStartupPackBuilder> action);
    void InstallPack<TPack>() where TPack : class, IStartupPack;
    void InstallBuilder<TBuilder>() where TBuilder : class, IStartupPackBuilder;
    IConfigureBuilder Build(IServiceCollection services);
}
