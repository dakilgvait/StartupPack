namespace StartupPack;

public class PackIndexer : IPackIndexer
{
    private readonly string[] _addOrderedKeys;
    private readonly string[] _useOrderedKeys;

    public PackIndexer()
    {
        _addOrderedKeys = GetAddOrderedKeys();
        _useOrderedKeys = GetUseOrderedKeys();
    }

    protected virtual string[] GetAddOrderedKeys()
    {
        return new string[] { };
    }

    protected virtual string[] GetUseOrderedKeys()
    {
        return new string[] { };
    }

    public int? GetIndexAdd(string? key)
    {
        var index = Array.IndexOf(_addOrderedKeys, key);
        return index < 0 ? null : index;
    }

    public int? GetIndexUse(string? key)
    {
        var index = Array.IndexOf(_useOrderedKeys, key);
        return index < 0 ? null : index;
    }
}
