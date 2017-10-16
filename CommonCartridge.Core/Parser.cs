using CommonCartridge.Core.Interfaces;
using CommonCartridge.Core.Models;
using System;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CommonCartridge.Core
{
    public class Parser : IParser
    {
        public static Hashtable ManifestVersions => new Hashtable()
        {
            { "1.0.0", typeof(Models.v1_0.ManifestType) },
            { "1.1.0", typeof(Models.v1_1.ManifestType) },
            { "1.2.0", typeof(Models.v1_2.ManifestType) },
            { "1.3.0", typeof(Models.v1_3.ManifestType) }
        };

        public ParserResult FromArchive(string path)
        {
            var result = new ParserResult();

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
                result = FromFile(file.FullName, directory);

            } catch (Exception ex)
            {
                result.Errors.Add(ex);
                result.HasErrors = true;
            }

            return result;
        }

        public ParserResult FromFile(string path, string directory)
        {
            var result = new ParserResult();

            if (!File.Exists(path))
            {
                result.Errors.Add(new FileNotFoundException());
                result.HasErrors = true;

                return result;
            }

            try
            {
                // Open file using StreamReader
                result = FromXml(File.ReadAllText(path), directory);

            }
            catch (Exception ex)
            {
                result.Errors.Add(ex);
                result.HasErrors = true;
            }

            return result;
        }

        public ParserResult FromXml(string content, string directory)
        {
            var result = new ParserResult();

            if (content == null || string.IsNullOrWhiteSpace(content))
            {
                return null;
            }

            try
            {
                // Load XML into XDocument
                var doc = XDocument.Parse(content);

                // Read XML and determine version.
                var type = GetManifestVersion(doc);
                var serializer = new XmlSerializer(type);
                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                {
                    SetManifestResult(serializer.Deserialize(stream), doc, directory, ref result);
                }
            } catch (Exception ex)
            {
                result.Errors.Add(ex);
                result.HasErrors = true;
            }

            return result;
        }


        #region Private Methods

        private XElement GetSchemaVersionNode(XDocument document)
        {
            return document.Descendants(document.Root.Name.Namespace + "schemaversion").FirstOrDefault();
        }

        private Type GetManifestVersion(XDocument document)
        {
            var node = GetSchemaVersionNode(document);
            var type = typeof(Models.v1_3.ManifestType);
            if (node != null)
            {
                type = ManifestVersions[node.Value] as Type;
            }
            if (type != null)
            {
                return type;
            }
            return typeof(Models.v1_3.ManifestType);
        }

        private void SetManifestResult(object content, XDocument document, string directory, ref ParserResult result)
        {
            var node = GetSchemaVersionNode(document);

            if (node != null)
            {
                switch (node.Value)
                {
                    case "1.0.0":
                        var manifest0 = content as Models.v1_0.ManifestType;
                        if (manifest0 != null)
                        {
                            if (manifest0.Resources != null && manifest0.Resources.Resource.Count > 0)
                            {
                                foreach (var r in manifest0.Resources.Resource.Where(r => r.Type != "webcontent"))
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
                            result.v1_0_Manifest = manifest0;
                        }
                        break;
                    case "1.1.0":
                        var manifest1 = content as Models.v1_1.ManifestType;
                        if (manifest1 != null)
                        {
                            if (manifest1.Resources != null && manifest1.Resources.Resource.Count > 0)
                            {
                                foreach (var r in manifest1.Resources.Resource.Where(r => r.Type != Models.v1_1.ResourceTypeType.webcontent))
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
                            result.v1_1_Manifest = manifest1;
                        }
                        break;
                    case "1.2.0":
                        var manifest2 = content as Models.v1_2.ManifestType;
                        if (manifest2 != null)
                        {
                            if (manifest2.Resources != null && manifest2.Resources.Resource.Count > 0)
                            {
                                foreach (var r in manifest2.Resources.Resource.Where(r => r.Type != Models.v1_2.ResourceTypeType.webcontent))
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
                            result.v1_2_Manifest = manifest2;
                        }
                        break;
                    case "1.3.0":
                        var manifest3 = content as Models.v1_3.ManifestType;
                        if (manifest3 != null)
                        {
                            if (manifest3.Resources != null && manifest3.Resources.Resource.Count > 0)
                            {
                                foreach (var r in manifest3.Resources.Resource.Where(r => r.Type != "webcontent"))
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
                            result.v1_3_Manifest = manifest3;
                        }
                        break;
                }
            }
        }

        #endregion
    }
}
