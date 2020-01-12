using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            Configuration configuration = Configuration.Instance;

            foreach (var node in configuration.ConfigDictionary)
            {
                Console.WriteLine("Key = {0}    Value = {1}", node.Key, node.Value);
            }
        }
    }
}
