
namespace SMDR.Infratructure
{
    using Base;
    using Configuration;
    using Models;
    public class IPECS_UCP_SMDR_PARSER : SMDRParserBase<IPECS_UCP_CallLog>
    {
        public IPECS_UCP_SMDR_PARSER() : base(new IPECS_UCP_Four_Digit_SMDR_Settings())
        {
            
        }
        public IPECS_UCP_SMDR_PARSER(IParserSettings settings) : base(settings)
        {

        }
    }

}
