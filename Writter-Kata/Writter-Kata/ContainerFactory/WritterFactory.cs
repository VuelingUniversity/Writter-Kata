using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;
using Writter_Kata.Formats;
using Writter_Kata.Interfaces;

namespace Writter_Kata.ContainerFactory
{
    public static class WritterFactory
    {
        private static readonly Dictionary<FormatType, IFormat> format_creators
                = new Dictionary<FormatType, IFormat> {
                { FormatType.json, new JsonFormat()},
                { FormatType.txt, new TxtFormat()},
                { FormatType.xml, new XmlFormat()},
                { FormatType.yml, new YmlFormat()}
                };
		public static IFormat CreateChecker(FormatType format)
		{
		    return format_creators[format];
		}
	}
}
