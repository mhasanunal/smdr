using SMDR.Infratructure.Configuration;
using SMDR.Infratructure.Models;

namespace SMDR.Infratructure
{
    public class IPECS_UCP_Eight_Digit_SMDR_Parser : IPECS_UCP_SMDR_PARSER
    {
        public IPECS_UCP_Eight_Digit_SMDR_Parser() : base(new IPECS_UCP_Eight_Digit_SMDR_Settings())
        {
        }
    }
}
