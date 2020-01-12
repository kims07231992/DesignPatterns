using NetworkLibrary.Networks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.NetworkModules
{
    public abstract class BaseNetworkModule : IDisposable
    {
        public abstract void Connect();

        protected bool _isConnected;

        public BaseNetworkModule(INetwork network)
        {
            this.Network = network;
            this._isConnected = false;
        }

        public INetwork Network { get; set; }

        public virtual void Disconnect()
        {
            CheckNetworkStatus();
        }

        public virtual void Send()
        {
            CheckNetworkStatus();
        }

        public virtual void Receive()
        {
            CheckNetworkStatus();
        }

        private void CheckNetworkStatus()
        {
            if (!this._isConnected)
            {
                throw new InvalidOperationException("Network is not connected exception.");
            }
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (this.Network != null && this._isConnected)
                    {
                        this.Network.Disconnect(); 
                    }
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
