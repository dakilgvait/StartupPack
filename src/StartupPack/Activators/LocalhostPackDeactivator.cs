
using Microsoft.Extensions.Hosting;

namespace StartupPack;

public class LocalhostPackDeactivator : IPackActivator
{
    private readonly string[] _keys;
    private readonly IHostEnvironment _environment;

    public LocalhostPackDeactivator(IHostEnvironment environment)
    {
        _keys = GetKeys();
        _environment = environment;
    }

    protected virtual string[] GetKeys()
    {
        return new string[] { };
    }

    public bool IsActive(string? key)
    {
        return !_environment.IsLocalhost() || Array.IndexOf(_keys, key) < 0;
    }
}
