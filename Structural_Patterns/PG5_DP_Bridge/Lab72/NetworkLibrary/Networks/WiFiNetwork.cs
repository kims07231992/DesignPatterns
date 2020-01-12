using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.Networks
{
    public class WiFiNetwork : INetwork
    {
        public WiFiNetwork()
        {

        }

        public bool Connect()
        {
            Console.WriteLine($"{nameof(WiFiNetwork)} has been connected.");
            return true;
        }

        public bool Disconnect()
        {
            Console.WriteLine($"{nameof(WiFiNetwork)} has been disconnected.");
            return true;
        }

        public void Receive()
        {
            Console.WriteLine($"{nameof(WiFiNetwork)} received successfully.");
        }

        public void Send()
        {
            Console.WriteLine($"{nameof(WiFiNetwork)} sent successfully.");
        }
    }
}
