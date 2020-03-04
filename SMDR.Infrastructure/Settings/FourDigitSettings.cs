using SMDR.Infratructure.Base;
using SMDR.Infratructure.Configuration;
using System.Collections.Generic;

namespace SMDR.Infratructure.Configuration
{
    public class FourDigitSettings : DefaultSettings
    {
        public FourDigitSettings() : base()
        {
            var columns = new List<Column>();
            columns.Add(new Column("NO", 0, 4));
            columns.Add(new Column("STA", 5, 5));
            columns.Add(new Column("CO", 11, 3));
            columns.Add(new Column("TIME", 15, 8));
            columns.Add(new Column("START", 24, 14));
            columns.Add(new Column("DIALED_NUMBER", 39, 21));
            columns.Add(new Column("COST", 61, 10));
            columns.Add(new Column("ACCOUNT_CODE", 73, 12));
            columns.Add(new Column("CLI_NUMBER", 85, 20));// SINCE ACCOUNT CODE IS NOT IN USE, JUST ASSUME IT DOESNT SENDS EMPTY SPACE
            columns.Add(new Column("Disconnect_Cause", 106, 2));
            Columns = columns;
        }
    }
}
