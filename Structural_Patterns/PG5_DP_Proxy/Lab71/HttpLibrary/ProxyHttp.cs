using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HttpLibrary
{
    public class ProxyHttp : IHttpRequestable
    {
        private readonly Lazy<SocketHttp> _socketHttp = new Lazy<SocketHttp>();
        private readonly Lazy<Dictionary<string, string>> _cacheDictionary // Key: httpRawData, Value: Http result
            = new Lazy<Dictionary<string, string>>();
        private readonly Lazy<List<string>> _prohibitedHosts = new Lazy<List<string>>(() => new List<string>()
        {
            "youtube",
            "naver"
        });

        public ProxyHttp()
        {

        }

        public string SendHttpRequest(int port, string hostName, string httpRawData)
        {
            string result = null;

            if (IsProhibitedHost(hostName))
            {
                throw new ArgumentException($"Prohibited Host: {hostName}");
            }

            if (!this._cacheDictionary.Value.ContainsKey(httpRawData))
            {
                result = this._socketHttp.Value.SendHttpRequest(port, hostName, httpRawData);
                this._cacheDictionary.Value.Add(httpRawData, result);
            }

            result = this._cacheDictionary.Value[httpRawData];

            return result;
        }

        private bool IsProhibitedHost(string hostName)
        {
            foreach (var host in this._prohibitedHosts.Value)
            {
                var regex = new Regex(host);
                var match = regex.Match(hostName);
                if (match.Success)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
