using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace StartupPack;

public interface IStartupPackBuilder
{
    void SetupKey(string key);
    void SetupAddAction(Action<IServiceCollection> action);
    void SetupUseAction(Action<IApplicationBuilder> action);
    void SetupIsActiveFunction(Func<bool> func);
    IStartupPack Build(IServiceProvider provider);
}
