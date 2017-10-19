using System;
using System.Collections.Generic;

namespace CommonCartridge.Core.Models.Parser
{
    public class ParserResult
    {
        public List<Exception>   Errors         { get; set; }
        public bool              HasErrors      { get; set; }

        public ParserResult()
        {
            Errors = new List<Exception>();
        }
    }
}
