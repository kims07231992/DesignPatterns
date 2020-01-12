using NetworkLibrary.NetworkModules;
using NetworkLibrary.Networks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            try
            {
                var network = PickNetwork();
                using (var coreNetworkModule = new CoreNetworkModule(network))
                {
                    coreNetworkModule.Connect();
                    coreNetworkModule.Send();
                    coreNetworkModule.Receive();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static INetwork PickNetwork()
        {
            if (IsBluetoothNetworkAvailable())
            {
                return new BluetoothNetwork();
            }
            else if (IsWiFiNetworkAvailable())
            {
                return new WiFiNetwork();
            }
            else
            {
                return new _3GNetwork();
            }
        }

        private static bool IsBluetoothNetworkAvailable()
        {
            // Only avaliable on Monday
            return DateTime.Now.DayOfWeek == DayOfWeek.Monday;
        }

        private static bool IsWiFiNetworkAvailable()
        {
            // Only avaliable on Friday
            return DateTime.Now.DayOfWeek == DayOfWeek.Friday;
        }

        private static bool Is3GNetworkAvailable()
        {
            // Only avaliable on Sunday
            return DateTime.Now.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
