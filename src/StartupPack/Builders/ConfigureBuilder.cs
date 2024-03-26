using Microsoft.AspNetCore.Builder;

namespace StartupPack;

public class ConfigureBuilder : IConfigureBuilder
{
    private readonly IEnumerable<IStartupPack> _packs;

    public ConfigureBuilder(IEnumerable<IStartupPack> packs)
    {
        _packs = packs;
    }

    public void Build(IApplicationBuilder application)
    {
        var activeStartups = _packs.Select(x => new
        {
            index = x.GetUseIndex(),
            pack = x
        }).OrderByDescending(x => x.index.HasValue)
            .OrderBy(x => x.index)
            .Select(x => x.pack)
            .ToList();

        activeStartups.ForEach(x => x.Configure(application));
    }
}
