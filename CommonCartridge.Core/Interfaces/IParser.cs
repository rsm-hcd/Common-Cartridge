using CommonCartridge.Core.Models.Parser;

namespace CommonCartridge.Core.Interfaces
{
    public interface IParser
    {
        ParserResult<T> FromFile<T>(string path);
        ParserResult<T> FromXml<T>(string content);
        ParserResult<T> FromCCArchive<T>(string path);
        ParserResult<T> FromCCFile<T>(string path, string directory);
        ParserResult<T> FromCCXml<T>(string content, string directory);
    }
}
