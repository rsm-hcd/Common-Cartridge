using CommonCartridge.Core.Interfaces;
using CommonCartridge.Core.Models.v1_2;
using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CommonCartridge.Core
{
    public class Parser : IParser
    {
        public ManifestType FromFile(string absolutePath)
        {
            if (!File.Exists(absolutePath))
            {
                throw new FileNotFoundException();
            }

            try
            {
                // Open file using StreamReader
                return FromXml(File.ReadAllText(absolutePath));
            } catch (Exception ex)
            {
                // Exception encountered. Once logging implented, capture here and pass exception up.
                throw ex;
            }
        }

        public ManifestType FromXml(string content)
        {
            if (content == null || string.IsNullOrWhiteSpace(content))
            {
                return null;
            }

            try
            {
                var serializer = new XmlSerializer(typeof(ManifestType));
                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                {
                    return (ManifestType)serializer.Deserialize(stream);
                }
            } catch (Exception ex)
            {
                // Exception encountered. Once logging implented, capture here and pass exception up.
                throw ex;
            }
        }
    }
}
