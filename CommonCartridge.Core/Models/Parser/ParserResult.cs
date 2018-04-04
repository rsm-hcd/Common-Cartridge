using System;
using System.Collections.Generic;

namespace CommonCartridge.Core.Models.Parser
{
    public class ParserResult<T>
    {
        public List<Exception>   Errors         { get; set; }
        public bool              HasErrors      { get; set; }
        public T                 ResultObject   { get; set; }

        public ParserResult()
        {
            Errors = new List<Exception>();
        }
    }
}
