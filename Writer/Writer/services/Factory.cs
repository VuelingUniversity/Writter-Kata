using System;
using System.Collections.Generic;
using System.Text;
using WriterKata.models;

namespace WriterKata.models
{
    class Factory
    {
        private readonly Dictionary<string, Format> _formatList;

        public Factory(Dictionary<string, Format> formatList)
        {
            _formatList = formatList;
        }
        
        public Writer createWriter(string format)
        {
            return new Writer(_formatList[format]);
        }
    }
}
