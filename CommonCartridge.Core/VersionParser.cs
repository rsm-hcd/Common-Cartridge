using CommonCartridge.Core.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CommonCartridge.Core
{
    public class VersionParser : IVersionParser
    {
        public string GetSchemaVersionFromFile(string path, string prefix = "imscc")
        {
            string result = null;

            if (!File.Exists(path))
            {
                return result;
            }

            // Open file using StreamReader
            result = GetSchemaVersion(File.ReadAllText(path), prefix);

            return result;
        }

        public string GetSchemaVersion(string content, string prefix = "imscc")
        {
            string result = null;

            if (content == null || string.IsNullOrWhiteSpace(content))
            {
                return result;
            }

            // Load XML into XDocument
            var document = XDocument.Parse(content);

            // Read XML and determine version.
            if (document.Descendants(document.Root.Name.Namespace + "schemaversion").Any())
            {
                result = document.Descendants(document.Root.Name.Namespace + "schemaversion").FirstOrDefault().Value;
            } else
            {
                if (!prefix.StartsWith("ims", StringComparison.OrdinalIgnoreCase))
                {
                    prefix = $"ims{prefix}";
                }
                var docNamespace = document.Root.Name.NamespaceName;
                var pattern = $@"\/xsd\/{prefix}\w*v(\d)p(\d)+";
                var matches = Regex.Match(docNamespace, pattern);

                if (matches.Success && matches.Groups.Count > 2)
                {
                    result = $"{matches.Groups[1].Value}.{matches.Groups[2].Value}.";
                    if (matches.Groups.Count > 3)
                    {
                        result += matches.Groups[3].Value;
                    } else
                    {
                        result += "0";
                    }
                }
            }

            return result;
        }
    }
}
