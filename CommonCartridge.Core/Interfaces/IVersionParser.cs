namespace CommonCartridge.Core.Interfaces
{
    public interface IVersionParser
    {
        string GetSchemaVersionFromFile(string path);
        string GetSchemaVersion(string content);
    }
}
