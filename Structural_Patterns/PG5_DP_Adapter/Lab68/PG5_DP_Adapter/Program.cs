using AdapterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            string currentSystemCode = "A123";
            ILegacyGettable legacyGettable = new LegacyAdapter();

            int legacyCode = legacyGettable.GetCode(currentSystemCode);

            Console.WriteLine($"Current System Code: {currentSystemCode} => Result Code: {legacyCode}");
        }
    }
}
