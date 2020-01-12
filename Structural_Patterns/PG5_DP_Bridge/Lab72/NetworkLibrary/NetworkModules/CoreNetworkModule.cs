using NetworkLibrary.Networks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.NetworkModules
{
    public class CoreNetworkModule : BaseNetworkModule
    {
        public CoreNetworkModule(INetwork network) : base(network)
        {
      
        }

        public override void Connect()
        {
            this._isConnected = this.Network.Connect();
        }

        public override void Disconnect()
        {
            base.Disconnect();
            this._isConnected =  !this.Network.Disconnect();
        }

        public override void Receive()
        {
            base.Receive();
            this.Network.Receive();
        }

        public override void Send()
        {
            base.Send();
            this.Network.Send();
        }
    }
}
