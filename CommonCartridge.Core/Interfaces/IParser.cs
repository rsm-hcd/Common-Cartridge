using CommonCartridge.Core.Models.v1_2;

namespace CommonCartridge.Core.Interfaces
{
    public interface IParser
    {
        ManifestType FromFile(string absolutePath);
        ManifestType FromXml(string content);
    }
}
