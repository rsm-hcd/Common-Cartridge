using CommonCartridge.Core.Models;

namespace CommonCartridge.Core.Interfaces
{
    public interface IParser
    {
        ParserResult FromArchive(string path);
        ParserResult FromFile(string path, string directory);
        ParserResult FromXml(string content, string directory);
    }
}
