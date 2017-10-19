using CommonCartridge.Core.Models.Parser.v1_0;

namespace CommonCartridge.Core.Interfaces.v1_0
{
    public interface IV1_0Parser
    {
        BasicLTIParserResult FromLTIFile(string path);
        BasicLTIParserResult FromLTIXml(string content);
        CCParserResult FromCCArchive(string path);
        CCParserResult FromCCFile(string path, string directory);
        CCParserResult FromCCXml(string content, string directory);
    }
}
