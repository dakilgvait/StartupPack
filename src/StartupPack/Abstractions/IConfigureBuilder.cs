using Microsoft.AspNetCore.Builder;

namespace StartupPack;

public interface IConfigureBuilder
{
    void Build(IApplicationBuilder application);
}
