using SMDR.Infratructure.Base;
using System.Collections.Generic;

namespace SMDR.Infratructure.Configuration
{
    public class IPECS_UCP_Eight_Digit_SMDR_Settings : ParserSettings
    {
        public IPECS_UCP_Eight_Digit_SMDR_Settings() : base()
        {
            var columns = new List<Column>();
            columns.Add(new Column("NO", 0, 4));
            columns.Add(new Column("STA", 5, 9));
            columns.Add(new Column("CO", 15, 3));
            columns.Add(new Column("TIME", 19, 8));
            columns.Add(new Column("START", 28, 14));
            columns.Add(new Column("DIALED_NUMBER", 43, 21));
            columns.Add(new Column("COST", 65, 10));
            columns.Add(new Column("ACCOUNT_CODE", 77, 12));
            // SINCE ACCOUNT CODE IS NOT IN USE, JUST ASSUME IT DOESNT SENDS EMPTY SPACE
            columns.Add(new Column("CLI_NUMBER", 89, 20));
            columns.Add(new Column("Disconnect_Cause", 110, 2));
            Columns = columns;
        }
    }
}
