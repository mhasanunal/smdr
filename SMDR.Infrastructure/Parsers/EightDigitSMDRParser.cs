using SMDR.Infratructure.Configuration;
using SMDR.Infratructure.Models;

namespace SMDR.Infratructure
{
    public class EightDigitSMDRParser : DefaultParser
    {
        public EightDigitSMDRParser() : base(new EightDigitSettings())
        {
        }
    }
}
