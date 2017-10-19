using CommonCartridge.Core.Models.Parser.v1_2;

namespace CommonCartridge.Core.Interfaces.v1_2
{
    public interface IV1_2Parser
    {
        CCParserResult FromCCArchive(string path);
        CCParserResult FromCCFile(string path, string directory);
        CCParserResult FromCCXml(string content, string directory);
    }
}
