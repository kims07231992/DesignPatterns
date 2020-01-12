using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.Networks
{
    public class _3GNetwork : INetwork
    {
        public _3GNetwork()
        {

        }

        public bool Connect()
        {
            Console.WriteLine($"{nameof(_3GNetwork)} has been connected.");
            return true;
        }

        public bool Disconnect()
        {
            Console.WriteLine($"{nameof(_3GNetwork)} has been disconnected.");
            return true;
        }

        public void Receive()
        {
            Console.WriteLine($"{nameof(_3GNetwork)} received successfully.");
        }

        public void Send()
        {
            Console.WriteLine($"{nameof(_3GNetwork)} sent successfully.");
        }
    }
}
