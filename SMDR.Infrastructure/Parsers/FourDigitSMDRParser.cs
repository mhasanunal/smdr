
namespace SMDR.Infratructure
{
    using Base;
    using Configuration;
    using Models;
    public class DefaultParser : SMDRParserBase<CallLog>
    {
        public DefaultParser() : base(new FourDigitSettings())
        {

        }
        public DefaultParser(IParserSettings settings) : base(settings)
        {

        }
    }
    public class FourDigitSMDRParser : DefaultParser { }

}
