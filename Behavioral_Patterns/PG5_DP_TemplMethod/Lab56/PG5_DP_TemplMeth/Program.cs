using PG5_DP_TemplMeth.Ecommerce.EcommerceHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_TemplMeth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            const int productQuantity = 100;

            var handlers = new List<EcommerceHandler>()
            {
                new AsiaHandler(), new EuropeHandler(), new USHandler()
            };

            foreach (var handler in handlers)
            {
                handler.ProductQuantity = productQuantity;
                handler.MakeOrder("Fruit", "Json Kim", "Republic Korea", 0, 10);
            }
        }
    }
}
