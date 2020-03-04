using System;
using System.Net.Sockets;

namespace SMDR.Infratructure
{
    using Base;
    using Auxilary;

    public class BasicTcpMessageListener : IListener, IDisposable
    {

        #region Contructors
        public BasicTcpMessageListener(
        String listen_ip,
        Int32 port)
        {
            this.Listener = new TcpClient(listen_ip, port);
            Stream = Listener.GetStream();
            Encoding = System.Text.Encoding.ASCII;
        }

        public BasicTcpMessageListener(
            String listen_ip,
            Int32 port,
            System.Text.Encoding encoding) : this(listen_ip, port)
        {
            this.Encoding = encoding;
        }
        #endregion

        #region PRIVATE_PROPERTIES

        private int tempBufferCurrentSize = 0;
        private byte[] _tempBuffer = new byte[Globals.DEFAULT_BUFFER_SIZE];
        private byte[] _readBuffer = new byte[Globals.DEFAULT_BUFFER_SIZE];
        #endregion

        #region PROTECTED_INTERNAL

        protected internal NetworkStream Stream { get; set; }
        protected internal TcpClient Listener { get; }
        protected internal virtual void ReadHandler(IAsyncResult result)
        {
            int dataLength = Stream.EndRead(result);

            int currentStart = 0;
            int currentEnd = -1;

            for (int i = 0; i < dataLength; i++)
            {
                if (_readBuffer[i].IsCarrgiageReturn()
                    && i < (_readBuffer.Length - 1)
                    && _readBuffer[i + 1].IsLineFeed())
                {

                    currentEnd = i - 1;
                    byte[] joinedData = new byte[tempBufferCurrentSize + (currentEnd - currentStart + 1)];
                    Array.Copy(_tempBuffer, 0, joinedData, 0, tempBufferCurrentSize);
                    Array.Copy(_readBuffer, currentStart, joinedData, tempBufferCurrentSize, (currentEnd - currentStart + 1));
                    tempBufferCurrentSize = 0;
                    currentStart = i + 2;
                    var messageResolved = Encoding.GetString(joinedData);
                    OnMessageRecieved?.Invoke(this, messageResolved);
                }
            }

            if (currentStart < dataLength)
            {
                Array.Copy(_readBuffer, currentStart, _tempBuffer, 0, dataLength - currentStart);
                tempBufferCurrentSize = dataLength - currentStart;
            }

            Listen();
        }
        #endregion

        #region PUBLIC
        public void Listen()
        {
            Stream.BeginRead(_readBuffer, 0, Globals.DEFAULT_BUFFER_SIZE, new AsyncCallback(ReadHandler), Listener);
        }
        public void Dispose()
        {
            this.Listener.Close();
            this.Listener.Dispose();
            _readBuffer = null;
            _tempBuffer = null;
            tempBufferCurrentSize = 0;
        }

        public event EventHandler<string> OnMessageRecieved;
        public System.Text.Encoding Encoding { get; set; }
        #endregion
    }
}
