using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Singleton  
{
    public sealed class Configuration
    {
        private static readonly Lazy<Configuration> _instance = new Lazy<Configuration>(() => new Configuration());
        private Dictionary<string, object> _configDictionary = new Dictionary<string, object>();

        private Configuration()
        {
            SetConfigByJSON();
        }

        public static Configuration Instance { get { return _instance.Value; } }
        public Dictionary<string, object> ConfigDictionary
        {
            get { return this._configDictionary; }
        }

        private void SetConfigByJSON()
        {
            string startPath = AppDomain.CurrentDomain.BaseDirectory;
            string configPath = Path.Combine("Resources", "Config.json");
            string filePath = Path.Combine(startPath, configPath); // full path
            string jsonString = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonString); // parse jsonString

            foreach (var node in jsonObject)
            {
                this.ConfigDictionary.Add(node.Key, node.Value);
            }
        }
    }
}
