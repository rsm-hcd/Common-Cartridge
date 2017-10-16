using System;
using System.Collections.Generic;

namespace CommonCartridge.Core.Models
{
    public class ParserResult
    {
        public v1_0.ManifestType v1_0_Manifest{ get; set; }
        public v1_1.ManifestType v1_1_Manifest  { get; set; }
        public v1_2.ManifestType v1_2_Manifest  { get; set; }
        public v1_3.ManifestType v1_3_Manifest  { get; set; }
        public List<Exception>   Errors         { get; set; }
        public bool              HasErrors      { get; set; }

        public ParserResult()
        {
            Errors = new List<Exception>();
        }
    }
}
