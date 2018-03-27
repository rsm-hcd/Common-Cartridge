namespace CommonCartridge.Core.Interfaces
{
    public interface IVersionParser
    {
        string GetSchemaVersionFromFile(string path, string prefix = "imscc");
        string GetSchemaVersion(string content, string prefix = "imscc");
    }
}
