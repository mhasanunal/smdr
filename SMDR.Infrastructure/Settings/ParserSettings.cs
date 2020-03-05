using System.Collections.Generic;

namespace SMDR.Infratructure.Configuration
{
using Auxilary;
using Base;
    public abstract class ParserSettings : IParserSettings
    {
        public IEnumerable<Column> Columns { get; set; }
        public string Delimiter { get; set; } = ((char)0x20).ToString();
        public char LineFeed { get; set; } = (char)Globals.ASCII_LINE_FEED;
        public char Blank { get; set; } = (char)0x20;
        public char FormFeed { get; set; } = (char)0x0C;
        public char CarriageReturn { get; set; } = (char)Globals.ASCII_CARRIAGE_RETURN;
        public bool TrimWhiteSpaces { get; set; } = true;
    }
}
