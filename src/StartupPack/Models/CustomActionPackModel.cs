using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace StartupPack;

public class CustomActionPackModel
{
    public string? Name { get; set; }
    public Action<IServiceCollection>? ActionAdd { get; set; }
    public Action<IApplicationBuilder>? ActionUse { get; set; }
    public Func<bool>? FunctionIsActive { get; set; }
}
