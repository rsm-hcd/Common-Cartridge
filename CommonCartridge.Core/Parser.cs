using CommonCartridge.Core.Interfaces;
using CommonCartridge.Core.Models.Parser;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CommonCartridge.Core
{
    public class Parser : IParser
    {
        public BasicLTIParserResult FromLTIFile<T>(string path)
        {
            var result = new BasicLTIParserResult();

            if (!File.Exists(path))
            {
                result.Errors.Add(new FileNotFoundException());
                result.HasErrors = true;

                return result;
            }

            try
            {
                // Open file using StreamReader
                result = FromLTIXml<T>(File.ReadAllText(path));

            }
            catch (Exception ex)
            {
                result.Errors.Add(ex);
                result.HasErrors = true;
            }

            return result;
        }

        public BasicLTIParserResult FromLTIXml<T>(string content)
        {
            var result = new BasicLTIParserResult();

            if (content == null || string.IsNullOrWhiteSpace(content))
            {
                return null;
            }

            try
            {
                // Load XML into XDocument
                var doc = XDocument.Parse(content);

                // Read XML and determine version.
                var serializer = new XmlSerializer(typeof(T));
                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                {
                    result.BasicLTI = serializer.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex);
                result.HasErrors = true;
            }

            return result;
        }

        public CCParserResult FromCCArchive<T>(string path)
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
                result = FromCCFile<T>(file.FullName, directory);

            }
            catch (Exception ex)
            {
                result.Errors.Add(ex);
                result.HasErrors = true;
            }

            return result;
        }

        public CCParserResult FromCCFile<T>(string path, string directory)
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
                result = FromCCXml<T>(File.ReadAllText(path), directory);

            }
            catch (Exception ex)
            {
                result.Errors.Add(ex);
                result.HasErrors = true;
            }

            return result;
        }

        public CCParserResult FromCCXml<T>(string content, string directory)
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
                var serializer = new XmlSerializer(typeof(T));
                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                {
                    result.Manifest = serializer.Deserialize(stream);
                }

                result = BuildManifest<T>(result, directory);
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex);
                result.HasErrors = true;
            }

            return result;
        }

        #region Private Methods

        private CCParserResult BuildManifest<T>(CCParserResult result, string directory)
        {
            if (typeof(T).Equals(typeof(Models.v1_0.ManifestType)))
            {
                if (result.Manifest is Models.v1_0.ManifestType v0Manifest && v0Manifest.Resources != null && v0Manifest.Resources.Resource.Count > 0)
                {
                    foreach (var r in v0Manifest.Resources.Resource.Where(r => r.Type != "webcontent"))
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
            } else if (typeof(T).Equals(typeof(Models.v1_1.ManifestType)))
            {
                if (result.Manifest is Models.v1_1.ManifestType v1Manifest && v1Manifest.Resources != null && v1Manifest.Resources.Resource.Count > 0)
                {
                    foreach (var r in v1Manifest.Resources.Resource.Where(r => r.Type != Models.v1_1.ResourceTypeType.webcontent))
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
            } else if (typeof(T).Equals(typeof(Models.v1_2.ManifestType)))
            {
                if (result.Manifest is Models.v1_2.ManifestType v2Manifest && v2Manifest.Resources != null && v2Manifest.Resources.Resource.Count > 0)
                {
                    foreach (var r in v2Manifest.Resources.Resource.Where(r => r.Type != Models.v1_2.ResourceTypeType.webcontent))
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
            } else if (typeof(T).Equals(typeof(Models.v1_3.ManifestType)))
            {
                if (result.Manifest is Models.v1_3.ManifestType v3Manifest && v3Manifest.Resources != null && v3Manifest.Resources.Resource.Count > 0)
                {
                    foreach (var r in v3Manifest.Resources.Resource.Where(r => r.Type != "webcontent"))
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

            return result;
        }

        #endregion
    }
}
