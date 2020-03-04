using System.Collections.Generic;

namespace SMDR.Infratructure.Base
{
    public interface IParserSettings
    {
        bool TrimWhiteSpaces { get; set; }
        IEnumerable<Column> Columns { get; set; }
        string Delimiter { get; set; }
        char LineFeed { get; set; }
        char Blank { get; set; }
        char FormFeed { get; set; }
        char CarriageReturn { get; set; }
    }

}
