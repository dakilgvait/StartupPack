namespace StartupPack;

public interface IPackIndexer
{
    int? GetIndexAdd(string? key);
    int? GetIndexUse(string? key);
}
