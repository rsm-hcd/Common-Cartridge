using CommonCartridge.Core.Models.Parser;

namespace CommonCartridge.Core.Interfaces
{
    public interface IParser
    {
        BasicLTIParserResult FromLTIFile<T>(string path);
        BasicLTIParserResult FromLTIXml<T>(string content);
        CCParserResult FromCCArchive<T>(string path);
        CCParserResult FromCCFile<T>(string path, string directory);
        CCParserResult FromCCXml<T>(string content, string directory);
    }
}
