using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HttpLibrary
{
    internal class SocketHttp : IHttpRequestable
    {
        public SocketHttp()
        {

        }

        public string SendHttpRequest(int port, string hostName, string httpRawData)
        {
            string result = null;

            using (var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
                IPAddress ip = hostEntry.AddressList[0];

                var httpEndPoint = new IPEndPoint(ip, port);
                sock.Connect(httpEndPoint);

                // Send
                var sendBuff = Encoding.ASCII.GetBytes(httpRawData);
                sock.Send(sendBuff, SocketFlags.None);

                // Receive
                byte[] recvBuff = new byte[sock.ReceiveBufferSize];
                int nCount = sock.Receive(recvBuff);
                result = Encoding.ASCII.GetString(recvBuff, 0, nCount);
            }

            return result;
        }
    }
}
