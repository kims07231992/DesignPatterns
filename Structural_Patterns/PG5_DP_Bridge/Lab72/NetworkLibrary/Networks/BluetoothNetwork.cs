using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.Networks
{
    public class BluetoothNetwork : INetwork
    {
        public BluetoothNetwork()
        {

        }

        public bool Connect()
        {
            Console.WriteLine($"{nameof(BluetoothNetwork)} has been connected.");
            return true;
        }

        public bool Disconnect()
        {
            Console.WriteLine($"{nameof(BluetoothNetwork)} has been disconnected.");
            return true;
        }

        public void Receive()
        {
            Console.WriteLine($"{nameof(BluetoothNetwork)} received successfully.");
        }

        public void Send()
        {
            Console.WriteLine($"{nameof(BluetoothNetwork)} sent successfully.");
        }
    }
}
