using System;
using System.IO;
using System.Net;

namespace SMDR.Infratructure.Base
{
    public interface IListener
    {
        void Listen();
        event EventHandler<string> OnMessageRecieved;
    }
}
