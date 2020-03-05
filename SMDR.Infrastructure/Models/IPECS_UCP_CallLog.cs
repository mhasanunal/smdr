using System;
using System.Dynamic;

namespace SMDR.Infratructure.Models
{
    public class IPECS_UCP_CallLog :ICallLog
    {
        public string NO { get; set; }
        public string STA { get; set; }
        public string CO { get; set; }
        public string TIME { get; set; }
        public string START { get; set; }
        public string DIALED_NUMBER { get; set; }
        public string COST { get; set; }
        public string ACCOUNT_CODE { get; set; }
        public string CLI_NUMBER { get; set; }
        public string Disconnect_Cause { get; set; }
        public string Raw { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}{10}{8} {9}"
                , NO
                , STA
                , CO
                , TIME
                , START
                , DIALED_NUMBER
                , COST
                , ACCOUNT_CODE
                , CLI_NUMBER
                , Disconnect_Cause
                ,string.IsNullOrWhiteSpace(ACCOUNT_CODE)?" ": "");
        }
        public virtual void Enhance()
        {

        }
    }
   

}
