using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SMDR.DataAccessLayer;
using SMDR.Infratructure;
using SMDR.Infratructure.Auxilary;
using SMDR.Infratructure.Base;
using SMDR.Infratructure.Models;

namespace ReadTest
{
    class Program
    {

        static IListener listener;
        static IParser<IEnumerable<IPECS_UCP_CallLog>> parser;
        static CallContext context;
        static void Main(string[] args)
        {
            var conString = @"Data Source=HASANMONSTER\SQLEXPRESS;Initial Catalog=SMDR;Integrated Security=SSPI;User ID=sa;Password=Hh105650;";
            string UCP_2400_IP_ADDRESS = args[0];
            int PORT = int.Parse(args[1]);
            var options = new DbContextOptionsBuilder<CallContext>()
                .UseSqlServer(conString);
            context = new CallContext(options.Options);
            var logs = context.CallLogs;
            listener = new BasicTcpMessageListener(UCP_2400_IP_ADDRESS, PORT);

            parser = new IPECS_UCP_Four_Digit_SMDR_Parser();
            parser.Settings.TrimWhiteSpaces = false;

            listener.OnMessageRecieved += Listener_OnMessageRecieved;
            listener.Listen();

            Console.Read();

        }
        private static void Listener_OnMessageRecieved(object sender, string recievedRecord)
        {
            Console.WriteLine(recievedRecord);
            foreach (var callLog in parser.Parse(recievedRecord))
            {
                context.CallLogs.Add(new SMDR.DataAccessLayer.Models.CallLog {
                NO=callLog.NO,
                STA=callLog.STA,
                CO=callLog.CO,
                TIME=callLog.TIME,
                START=callLog.START,
                DIALED_NUMBER=callLog.DIALED_NUMBER,
                COST=callLog.COST,
                ACCOUNT_CODE=callLog.ACCOUNT_CODE,
                CLI_NUMBER=callLog.CLI_NUMBER,
                Disconnect_Cause=callLog.Disconnect_Cause,
                Raw=callLog.Raw
                
                });
            }
            context.SaveChangesAsync();
        }



    }
}
