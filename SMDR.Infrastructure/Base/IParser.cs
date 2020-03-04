namespace SMDR.Infratructure.Base
{
    public interface IParser<TParseResult>
    {
        IParserSettings Settings { get; set; }
        TParseResult Parse(string context);
    }
}
