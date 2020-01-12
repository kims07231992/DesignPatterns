using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.Networks
{
    public interface INetwork
    {
        bool Connect();
        bool Disconnect();
        void Send();
        void Receive();
    }
}
