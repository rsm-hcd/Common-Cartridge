using CommonCartridge.Core.Models.Parser.v1_1;

namespace CommonCartridge.Core.Interfaces.v1_1
{
    public interface IV1_1Parser
    {
        CCParserResult FromCCArchive(string path);
        CCParserResult FromCCFile(string path, string directory);
        CCParserResult FromCCXml(string content, string directory);
    }
}
