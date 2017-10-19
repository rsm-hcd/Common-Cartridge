using CommonCartridge.Core.Models.Parser.v1_3;

namespace CommonCartridge.Core.Interfaces.v1_3
{
    public interface IV1_3Parser
    {
        CCParserResult FromCCArchive(string path);
        CCParserResult FromCCFile(string path, string directory);
        CCParserResult FromCCXml(string content, string directory);
    }
}
