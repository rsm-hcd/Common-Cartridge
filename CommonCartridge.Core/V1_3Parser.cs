using CommonCartridge.Core.Interfaces.v1_3;
using CommonCartridge.Core.Models.Parser.v1_3;
using CommonCartridge.Core.Models.v1_3;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CommonCartridge.Core
{
    public class V1_3Parser : IV1_3Parser
    {
        public CCParserResult FromCCArchive(string path)
        {
            var result = new CCParserResult();

            if (!File.Exists(path))
            {
                result.Errors.Add(new FileNotFoundException());
                result.HasErrors = true;
                return result;
            }

            var directory = string.Empty;

            try
            {
                var file = new FileInfo(path);
                if (file.Extension.Equals(".imscc", StringComparison.OrdinalIgnoreCase) || file.Extension.Equals(".zip", StringComparison.OrdinalIgnoreCase))
                {
                    // If file is compressed, create temp directory and decompress
                    directory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                    Directory.CreateDirectory(directory);
                    ZipFile.ExtractToDirectory(file.FullName, directory);
                    var fileLookup = Directory.GetFiles(directory, "imsmanifest.xml").FirstOrDefault();
                    if (fileLookup == null)
                    {
                        result.Errors.Add(new FileNotFoundException("IMS Manifest File (imsmanifest.xml) not found in cartridge content"));
                        result.HasErrors = true;
                    }
                    file = new FileInfo(fileLookup);
                }

                // Open file
                result = FromCCFile(file.FullName, directory);

            }
            catch (Exception ex)
            {
                result.Errors.Add(ex);
                result.HasErrors = true;
            }

            return result;
        }

        public CCParserResult FromCCFile(string path, string directory)
        {
            var result = new CCParserResult();

            if (!File.Exists(path))
            {
                result.Errors.Add(new FileNotFoundException());
                result.HasErrors = true;

                return result;
            }

            try
            {
                // Open file using StreamReader
                result = FromCCXml(File.ReadAllText(path), directory);

            }
            catch (Exception ex)
            {
                result.Errors.Add(ex);
                result.HasErrors = true;
            }

            return result;
        }

        public CCParserResult FromCCXml(string content, string directory)
        {
            var result = new CCParserResult();

            if (content == null || string.IsNullOrWhiteSpace(content))
            {
                return null;
            }

            try
            {
                // Load XML into XDocument
                var doc = XDocument.Parse(content);

                // Read XML and determine version.
                var serializer = new XmlSerializer(typeof(ManifestType));
                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                {
                    result.Manifest = serializer.Deserialize(stream) as ManifestType;
                }

                if (result.Manifest != null && result.Manifest.Resources != null && result.Manifest.Resources.Resource.Count > 0)
                {
                    foreach (var r in result.Manifest.Resources.Resource.Where(r => r.Type != "webcontent"))
                    {
                        foreach (var f in r.File.Where(f => !string.IsNullOrWhiteSpace(f.Href)))
                        {
                            try
                            {
                                if (!f.Href.Contains("http"))
                                {
                                    f.Data = XDocument.Load(Path.Combine(directory, f.Href));
                                }
                                else
                                {
                                    f.Data = XDocument.Load(f.Href);
                                }
                            }
                            catch (Exception ex)
                            {
                                result.Errors.Add(ex);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex);
                result.HasErrors = true;
            }

            return result;
        }
    }
}
