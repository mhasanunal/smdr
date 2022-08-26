using SMDR.Infratructure.Base;
using SMDR.Infratructure.Configuration;
using System.Collections.Generic;

namespace SMDR.Infratructure.Configuration
{
    public class IPECS_UCP_Four_Digit_SMDR_Settings : ParserSettings
    {
        public IPECS_UCP_Four_Digit_SMDR_Settings() : base()
        {
            var columns = new List<Column>();
            //columns.Add(new Column("NO", 0, 4));
            columns.Add(new Column("STA", 0, 5));
            columns.Add(new Column("CO", 6, 3));
            columns.Add(new Column("TIME", 10, 8));
            columns.Add(new Column("START", 19, 14));
            columns.Add(new Column("DIALED_NUMBER", 34, 21));
            columns.Add(new Column("COST", 56, 10));
            columns.Add(new Column("ACCOUNT_CODE", 68, 12));
            // SINCE ACCOUNT CODE IS NOT IN USE, JUST ASSUME IT DOESNT SENDS EMPTY SPACE
            columns.Add(new Column("CLI_NUMBER", 80, 20));
            columns.Add(new Column("Disconnect_Cause", 101, 2));
            Columns = columns;
        }
    }
}
