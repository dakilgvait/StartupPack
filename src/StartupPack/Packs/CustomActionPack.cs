using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace StartupPack;

public class CustomActionPack : IStartupPack
{
    private readonly CustomActionPackModel _packModel;

    public CustomActionPack(CustomActionPackModel model)
    {
        _packModel = model;
    }

    public bool GetIsActive()
    {
        return _packModel.FunctionIsActive?.Invoke() ?? true;
    }

    public void Configure(IApplicationBuilder application)
    {
        _packModel.ActionUse?.Invoke(application);
    }

    public void ConfigureServices(IServiceCollection services)
    {
        _packModel.ActionAdd?.Invoke(services);
    }

    public int? GetAddIndex()
    {
        return null;
    }

    public int? GetUseIndex()
    {
        return null;
    }
}
