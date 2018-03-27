namespace CommonCartridge.Core.Interfaces
{
    public interface IVersionParser
    {
        string GetSchemaVersionFromFile(string path, string prefix = "");
        string GetSchemaVersion(string content, string prefix = "");
    }
}
