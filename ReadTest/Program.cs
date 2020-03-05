using System;
using System.Collections.Generic;
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
        static void Main(string[] args)
        {
            string UCP_2400_IP_ADDRESS = args[0];
            int PORT = int.Parse(args[1]);


            listener = new BasicTcpMessageListener(UCP_2400_IP_ADDRESS, PORT);

            parser = new IPECS_UCP_Four_Digit_SMDR_Parser();
            parser.Settings.TrimWhiteSpaces = false;

            listener.OnMessageRecieved += Listener_OnMessageRecieved;
            listener.Listen();

            Console.Read();

        }
        private static void Listener_OnMessageRecieved(object sender, string recievedRecord)
        {
            foreach (var callLog in parser.Parse(recievedRecord))
            {
                Console.WriteLine(callLog);
            }
        }



    }
}
